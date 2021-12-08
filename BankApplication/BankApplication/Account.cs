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
    public partial class Account : Form
    {
        public static BankDbtier.DbBank bank = from_lgn.bank;
        public static List<Session> sessions = from_lgn.sessions;
        public static Session session = from_lgn.session;
        public static AccountClass account = null;
        public Account()
        {
            InitializeComponent();
            btn_Deposit.Enabled = false;
            btn_Withdraw.Enabled = false;
            list_Acc.DataSource = session.Accounts.Select(s => s.accid).ToList();
        }

        

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            //navigate to the transactions page
            this.Hide();
            Transaction trans = new Transaction();
            trans.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //logging out and saving all the information collected to the session
            foreach (var sess in sessions)
            {
                if(sess.User.UserId == session.User.UserId)
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

        private void btn_create_Click(object sender, EventArgs e)
        {
            //creation of account and adding it to session

            btn_Deposit.Enabled = true;
            btn_Withdraw.Enabled = true;
             account = new AccountClass();
             account.accid = bank.createAccount(session.User.UserId);
            bank.SelectAccount(account.accid);
            lbl_selectedaccount.Text = account.accid.ToString();
            account.balance = bank.GetBalance(account.accid);
            lbl_bal.Text = bank.GetBalance(account.accid).ToString();
            //Check for the similar accounts to maintain list
            if (account != null)
            {
                foreach (var acc in session.Accounts)
                {
                    if (acc.accid == account.accid)
                    {
                        session.Accounts.Remove(account);
                        break;
                    }

                }
                session.Accounts.Add(account);
            }
            list_Acc.DataSource = session.Accounts.Select(s => s.accid).ToList();

        }

        private void list_Acc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Deposit.Enabled = true;
            btn_Withdraw.Enabled = true;


            //new account creating inlist
            account = new AccountClass();

            account.accid = Convert.ToUInt32(list_Acc.SelectedItem.ToString());
            bank.SelectAccount(account.accid);
            lbl_selectedaccount.Text = account.accid.ToString();
            account.balance = bank.GetBalance(account.accid);
            lbl_bal.Text =  bank.GetBalance(account.accid).ToString();
            }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            //manual deposition of amount
            if(lbl_selectedaccount.Text == "")
            {
                lbl_selectedaccount.Text = null; 
            }
            if(lbl_selectedaccount.Text == null && (tb_Deposit.Text == "" || tb_Deposit.Text == null) )
            {
                lbl_warn.Text = "select account first or please insert deposit amount";
            }
            else
            {
                uint deposit = Convert.ToUInt32(tb_Deposit.Text);
                bank.Deposit(deposit, account.accid);
                account.balance += deposit;
                lbl_bal.Text = account.balance.ToString();
                
            }
            tb_Deposit.Text = "0";
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            //manual withdrawl of amount
            if (lbl_selectedaccount.Text == "")
            {
                lbl_selectedaccount.Text = null;
            }
            if (lbl_selectedaccount.Text == null && (tb_wd.Text == "" || tb_wd.Text == null))
            {

            }
            else
            {
                uint wd = Convert.ToUInt32(tb_wd.Text);
                if (wd <= account.balance)
                {
                    bank.Withdraw(wd, account.accid);
                    account.balance -= wd;
                    lbl_bal.Text = account.balance.ToString();
                }
                else
                {
                    MessageBox.Show("Balance is not enough.. !", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                tb_wd.Text = "0";
            }
        }

        private void lbl_Account_Click(object sender, EventArgs e)
        {

        }

        private void tb_Deposit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
