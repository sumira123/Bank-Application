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
    public partial class UserMgt : Form
    {
        public static BankDbtier.DbBank bank = from_lgn.bank;
        public static List<Session> sessions = from_lgn.sessions;
        public static Session session = from_lgn.session;


        //display random USerID
        public UserMgt()
        {
            InitializeComponent();
            lbl_userid.Text = String.Format("Your userid is "+  session.User.UserId + ", Please remember for future login");

        }

        
        public UserMgt(string fname,string lname)
        {
            InitializeComponent();
            tb_fname.Text = fname;
            tb_lname.Text = lname;
            session.User.fname = fname;
            session.User.lname = lname;
            bank.SetUserName(fname, lname, session.User.UserId);
            
            lbl_userid.Text = String.Format("Your userid is " + session.User.UserId + ", Please remember for future login");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Saving user Daata
            string fname =tb_fname.Text;
            string lname =tb_lname.Text;


            if (fname == null && lname == null)
            {
                lbl_warn.Text = "Please insert the first and last name";
            }
            else
            {
                bank.SetUserName(fname, lname,session.User.UserId);
                bank.savetoDisk();
                session.User.fname = fname;
                session.User.lname = lname;
                tb_fname.Text = fname;
                tb_lname.Text = lname;

                MessageBox.Show("Account is created !", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Account acc = new Account();
                acc.Show();
            }

        }


        private void btn_Account_Click(object sender, EventArgs e)
        {
            // going to the next window
            this.Hide();
            Account acc = new Account();
            acc.Show();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            //logging out and saving all the information collected to the session
            foreach(var sess in sessions)
            {
                if(sess.User.UserId == session.User.UserId)
                {
                    sessions.Remove(sess);
                    break;
                }
            }
            sessions.Add(session);
            bank.processAlltransactions();
            bank.savetoDisk();
            this.Hide();
            from_lgn lgn = new from_lgn();
            lgn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // navigate back
            this.Hide();
            from_lgn login = new from_lgn();
            login.Show();
        }

        private void UserMgt_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
