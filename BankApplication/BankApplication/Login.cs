using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankDbtier;

namespace BankApplication
{
    public partial class from_lgn : Form
    {
        public static BankDbtier.DbBank bank = new BankDbtier.DbBank();
        public static List<Session> sessions = new List<Session>();
        public static Session session;
        
        public from_lgn()
        {
            InitializeComponent();
        }

        private void from_lgn_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creation of account
                session = new Session();
                session.User.UserId = bank.CreateUser();
                this.Hide();
                UserMgt userMgt = new UserMgt();
                userMgt.Show();

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            // login of account
            session = new Session();
            string idx = tb_userId.Text;
            uint id = 0;
            try
            {
                id = Convert.ToUInt32(idx);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("Please Enter UserID", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var userlist = bank.GetUsers();
            //searching for USerID
            foreach (var user in userlist)
            {
                if (user == id)
                {
                    bank.SelectUser(id);
                    //session.User.UserId = id;
                    session = sessions.Where(s => s.User.UserId == id).FirstOrDefault();
                    string fname = null;
                    string lname = null;
                    bank.GetUserName(out fname,out lname, id);
                    this.Hide();
                    UserMgt userMgt = new UserMgt(fname,lname);
                    userMgt.Show();

                }
                
            }

            MessageBox.Show("User Doesn't exist", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UserId_Click(object sender, EventArgs e)
        {

        }

        private void tb_userId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
