
namespace BankApplication
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.list_Acc = new System.Windows.Forms.ListBox();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_select = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_Deposit = new System.Windows.Forms.Label();
            this.lbl_withdraw = new System.Windows.Forms.Label();
            this.tb_Deposit = new System.Windows.Forms.TextBox();
            this.tb_wd = new System.Windows.Forms.TextBox();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Trans = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_selectedaccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // list_Acc
            // 
            this.list_Acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Acc.FormattingEnabled = true;
            this.list_Acc.ItemHeight = 18;
            this.list_Acc.Location = new System.Drawing.Point(289, 114);
            this.list_Acc.Name = "list_Acc";
            this.list_Acc.Size = new System.Drawing.Size(218, 76);
            this.list_Acc.TabIndex = 0;
            this.list_Acc.SelectedIndexChanged += new System.EventHandler(this.list_Acc_SelectedIndexChanged);
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account.Location = new System.Drawing.Point(183, 114);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(91, 16);
            this.lbl_Account.TabIndex = 1;
            this.lbl_Account.Text = "Account List";
            this.lbl_Account.Click += new System.EventHandler(this.lbl_Account_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Silver;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.Black;
            this.btn_create.Location = new System.Drawing.Point(321, 44);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(151, 32);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create Account";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.Location = new System.Drawing.Point(45, 214);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(129, 16);
            this.lbl_select.TabIndex = 3;
            this.lbl_select.Text = "Selected Account";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(451, 214);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(160, 16);
            this.lbl_balance.TabIndex = 4;
            this.lbl_balance.Text = "Your Account Balance";
            // 
            // lbl_Deposit
            // 
            this.lbl_Deposit.AutoSize = true;
            this.lbl_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deposit.Location = new System.Drawing.Point(63, 281);
            this.lbl_Deposit.Name = "lbl_Deposit";
            this.lbl_Deposit.Size = new System.Drawing.Size(62, 16);
            this.lbl_Deposit.TabIndex = 5;
            this.lbl_Deposit.Text = "Deposit";
            // 
            // lbl_withdraw
            // 
            this.lbl_withdraw.AutoSize = true;
            this.lbl_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_withdraw.Location = new System.Drawing.Point(489, 281);
            this.lbl_withdraw.Name = "lbl_withdraw";
            this.lbl_withdraw.Size = new System.Drawing.Size(71, 16);
            this.lbl_withdraw.TabIndex = 6;
            this.lbl_withdraw.Text = "Withdraw";
            // 
            // tb_Deposit
            // 
            this.tb_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Deposit.Location = new System.Drawing.Point(142, 280);
            this.tb_Deposit.Name = "tb_Deposit";
            this.tb_Deposit.Size = new System.Drawing.Size(118, 22);
            this.tb_Deposit.TabIndex = 9;
            this.tb_Deposit.TextChanged += new System.EventHandler(this.tb_Deposit_TextChanged);
            // 
            // tb_wd
            // 
            this.tb_wd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_wd.Location = new System.Drawing.Point(582, 277);
            this.tb_wd.Name = "tb_wd";
            this.tb_wd.Size = new System.Drawing.Size(118, 22);
            this.tb_wd.TabIndex = 10;
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deposit.Location = new System.Drawing.Point(142, 332);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(118, 23);
            this.btn_Deposit.TabIndex = 11;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = false;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Withdraw.Location = new System.Drawing.Point(582, 332);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(118, 23);
            this.btn_Withdraw.TabIndex = 12;
            this.btn_Withdraw.Text = "WithDraw";
            this.btn_Withdraw.UseVisualStyleBackColor = false;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_Trans
            // 
            this.btn_Trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Trans.Location = new System.Drawing.Point(321, 393);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(151, 32);
            this.btn_Trans.TabIndex = 15;
            this.btn_Trans.Text = "Make Transaction";
            this.btn_Trans.UseVisualStyleBackColor = true;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(711, 402);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(67, 23);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_selectedaccount
            // 
            this.lbl_selectedaccount.AutoSize = true;
            this.lbl_selectedaccount.Location = new System.Drawing.Point(219, 214);
            this.lbl_selectedaccount.Name = "lbl_selectedaccount";
            this.lbl_selectedaccount.Size = new System.Drawing.Size(0, 13);
            this.lbl_selectedaccount.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.Location = new System.Drawing.Point(631, 214);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(0, 13);
            this.lbl_bal.TabIndex = 19;
            // 
            // lbl_warn
            // 
            this.lbl_warn.AutoSize = true;
            this.lbl_warn.Location = new System.Drawing.Point(407, 332);
            this.lbl_warn.Name = "lbl_warn";
            this.lbl_warn.Size = new System.Drawing.Size(0, 13);
            this.lbl_warn.TabIndex = 20;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(BankApplication.Session);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_warn);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_selectedaccount);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Trans);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.tb_wd);
            this.Controls.Add(this.tb_Deposit);
            this.Controls.Add(this.lbl_withdraw);
            this.Controls.Add(this.lbl_Deposit);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.list_Acc);
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_Acc;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_Deposit;
        private System.Windows.Forms.Label lbl_withdraw;
        private System.Windows.Forms.TextBox tb_Deposit;
        private System.Windows.Forms.TextBox tb_wd;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Trans;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_selectedaccount;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_bal;
        private System.Windows.Forms.Label lbl_warn;
    }
}