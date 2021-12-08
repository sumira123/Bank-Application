using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDB;

namespace BankDbtier
{
    //an interface for the application
    public class DbBank : MarshalByRefObject
    {
        //bankDb object
        public static BankDB.BankDB dbtier = new BankDB.BankDB();
        public UserAccessInterface User;
        public AccountAccessInterface Account;
        public TransactionAccessInterface Transaction;
        public DbBank()
        {
            User = dbtier.GetUserAccess();
            Account = dbtier.GetAccountInterface();
            Transaction = dbtier.GetTransactionInterface();
        }

        public void savetoDisk()
        {
            dbtier.SaveToDisk();
        }

        public void processAlltransactions()
        {
            dbtier.ProcessAllTransactions();
        }

        public uint createAccount(uint userId)
        {
            return Account.CreateAccount(userId);
        }

        public List<uint> GetAccountIDsByUser(uint userID)
        {
            return Account.GetAccountIDsByUser(userID);
        }

        public void Deposit(uint amount,uint account)
        {
            Account.SelectAccount(account);
            Account.Deposit(amount);
        }

        public void SelectAccount(uint accId)
        {
            Account.SelectAccount(accId);
        }

        public void Withdraw(uint amount,uint account)
        {
            Account.SelectAccount(account);
            Account.Withdraw(amount);
        }

        public uint GetBalance(uint account) 
        {
            Account.SelectAccount(account);
            return Account.GetBalance();
        }

        public uint GetOwner(uint account)
        {
            Account.SelectAccount(account);
            return Account.GetOwner();
        }

        public void SelectUser(uint userID)
        {
            User.SelectUser(userID);
        }

        public List<uint> GetUsers()
        {
            return User.GetUsers();
        }

        public uint CreateUser()
        {
            return User.CreateUser();
        }

        public void GetUserName(out string fname, out string lname,uint userID)
        {
            User.SelectUser(userID);
            User.GetUserName(out fname, out lname);
        }

        public void SetUserName(string fname, string lname,uint userid)
        {
            User.SelectUser(userid);
            User.SetUserName(fname, lname);
        }

        public void SelectTransaction(uint TransactionID)
        {
            Transaction.SelectTransaction(TransactionID);
        }
        public List<uint> GetTransactions()
        {
            return Transaction.GetTransactions();
        }
        public uint CreateTransaction()
        {
            return Transaction.CreateTransaction();
        }
        public uint GetAmount(uint TransId)
        {
            Transaction.SelectTransaction(TransId);
            
            return Transaction.GetAmount();
        }
        public uint GetSendrAcct(uint TransId)
        {
            Transaction.SelectTransaction(TransId);

            return Transaction.GetSendrAcct();
        }
        public uint GetRecvrAcct(uint TransId)
        {
            Transaction.SelectTransaction(TransId);

            return Transaction.GetRecvrAcct();
        }
        public void SetAmount(uint amount, uint TransId)
        {
            Transaction.SelectTransaction(TransId);

            Transaction.SetAmount(amount);
        }

        public void SetSender(uint acc, uint TransId)
        {
            Transaction.SelectTransaction(TransId);

            Transaction.SetSendr(acc);
        }

        public void SetReciever(uint acc, uint TransId)
        {
            Transaction.SelectTransaction(TransId);

            Transaction.SetRecvr(acc);
        }

    }
}
