using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class Transaction : Form
    {
        public static BankDbtier.DbBank bank = from_lgn.bank;
        public static List<Session> sessions = from_lgn.sessions;
        public static Session session = from_lgn.session;
        public static AccountClass account = Account.account;
        public static TransactionClass transaction = null;
        public Transaction()
        {
            InitializeComponent();
            tb_sender.Text = account.accid.ToString();
            tb_sender.Enabled = false;
            list_Transaction.DataSource = account.transactions.Select(s=> s.TransactionId).ToList();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_reciever.Text = "";
            tb_Amount.Text = "";
            tb_search.Text = "";


        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //Transaction sending method, validation and verification is done and then data stores into session
            //Validation of the fields
            if (tb_sender.Text == "")
            {
                tb_sender.Text = null;
            }
            if (tb_reciever.Text == "")
            {
                tb_reciever.Text = null;
            }
            if(tb_Amount.Text == "")
            {
                tb_Amount.Text = null;
            }
            if (tb_sender.Text == null && tb_Amount.Text == null && tb_reciever.Text == null)
            {
                lbl_warn.Text = "unable to do transaction because of missing fields";
            }
            else
            {
                //validation of amount and verification of reciever account
                uint reciever = Convert.ToUInt32(tb_reciever.Text);
                uint sendacc = Convert.ToUInt32(tb_sender.Text);
                uint wd = Convert.ToUInt32(tb_Amount.Text);
                foreach (var user in bank.GetUsers())
                {
                    foreach(var acc in bank.GetAccountIDsByUser(user))
                    {
                        if(acc == reciever)
                        {
                            if (wd <= account.balance)
                            {
                                bank.SelectAccount(sendacc);
                              
                                transaction = new TransactionClass();
                                transaction.TransactionId = bank.CreateTransaction();
                                bank.SelectTransaction(transaction.TransactionId);
                                bank.SetSender(sendacc, transaction.TransactionId);
                                bank.SetReciever(reciever, transaction.TransactionId);
                                bank.SetAmount(wd, transaction.TransactionId);
                                bank.processAlltransactions();
                                transaction.Amount= wd;
                                transaction.recieveracc = reciever;
                                transaction.senderacc = sendacc;
                                account.transactions.Add(transaction);
                                account.balance -= wd;
                                list_Transaction.DataSource = account.transactions.Select(s => s.TransactionId).ToList();
                            }
                            else
                            {
                                lbl_warn.Text = "withdrawl amount is greater than current balance";
                            }
                            
                        }
                    }
                }

                
                
                tb_Amount.Text = "";
                tb_reciever.Text = "";
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //logging out and storing the data to the database and to the list of the session
            foreach(var acc in session.Accounts)
            {
                if(acc.accid == account.accid)
                {
                    session.Accounts.Remove(account);
                }
            }
            session.Accounts.Add(account);
            foreach (var sess in sessions)
            {
                if (sess.User.UserId == session.User.UserId)
                {
                    sessions.Remove(session);
                }
            }
            sessions.Add(session);
            bank.processAlltransactions();
            bank.savetoDisk();
            this.Hide();
            from_lgn lgn = new from_lgn();
            lgn.Show();
        }



        private void btn_Account_Click(object sender, EventArgs e)
        {
            //navigating user to account form
            this.Hide();
            Account accc = new Account();
            accc.Show();
        }

        private void list_Transaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecting the transaction from the given list
            transaction = new TransactionClass();

            transaction.TransactionId = Convert.ToUInt32(list_Transaction.SelectedItem.ToString());
            bank.SelectTransaction(transaction.TransactionId);
            transaction.recieveracc = bank.GetRecvrAcct(transaction.TransactionId);
            tb_reciever.Text = transaction.recieveracc.ToString();
            transaction.senderacc = bank.GetSendrAcct(transaction.TransactionId);
            tb_sender.Text = transaction.senderacc.ToString();
            transaction.Amount = bank.GetAmount(transaction.TransactionId);
            tb_Amount.Text = transaction.Amount.ToString();

            tb_reciever.Enabled = false;
            tb_sender.Enabled = false;
            tb_Amount.Enabled = false;
            btn_Send.Enabled = false;
        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            //asynchronously search for the record
            if(tb_search.Text == "")
            {
                tb_search.Text = null;
            }
            if(tb_search.Text == null)
            {
                lbl_warn.Text = "cannot search an empty search field";
            }
            else
            {
                uint transid = Convert.ToUInt32(tb_search.Text);
                transaction = account.transactions.Find(s => s.TransactionId == transid);
                tb_reciever.Text = transaction.recieveracc.ToString();
                tb_sender.Text = transaction.senderacc.ToString();
                tb_Amount.Text = transaction.Amount.ToString();

                tb_reciever.Enabled = false;
                tb_sender.Enabled = false;
                tb_Amount.Enabled = false;
                btn_Send.Enabled = false;
            }
            
        }

        private void lbl_Reciever_Click(object sender, EventArgs e)
        {

        }

        private void tb_reciever_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
