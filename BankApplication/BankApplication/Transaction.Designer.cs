
namespace BankApplication
{
    partial class Transaction
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.tb_reciever = new System.Windows.Forms.TextBox();
            this.tb_sender = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_Reciever = new System.Windows.Forms.Label();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.lbl_Transaction = new System.Windows.Forms.Label();
            this.list_Transaction = new System.Windows.Forms.ListBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.btn_Account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(297, 327);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(85, 32);
            this.btn_Clear.TabIndex = 29;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(501, 165);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 32);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(353, 173);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(120, 24);
            this.tb_search.TabIndex = 26;
            // 
            // tb_Amount
            // 
            this.tb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount.Location = new System.Drawing.Point(591, 270);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(100, 22);
            this.tb_Amount.TabIndex = 25;
            // 
            // tb_reciever
            // 
            this.tb_reciever.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_reciever.Location = new System.Drawing.Point(363, 270);
            this.tb_reciever.Name = "tb_reciever";
            this.tb_reciever.Size = new System.Drawing.Size(100, 22);
            this.tb_reciever.TabIndex = 24;
            this.tb_reciever.TextChanged += new System.EventHandler(this.tb_reciever_TextChanged);
            // 
            // tb_sender
            // 
            this.tb_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sender.Location = new System.Drawing.Point(87, 270);
            this.tb_sender.Name = "tb_sender";
            this.tb_sender.Size = new System.Drawing.Size(100, 22);
            this.tb_sender.TabIndex = 23;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(181, 176);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(143, 16);
            this.lbl_Search.TabIndex = 22;
            this.lbl_Search.Text = "Search Transaction";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(613, 251);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(59, 16);
            this.lbl_Amount.TabIndex = 21;
            this.lbl_Amount.Text = "Amount";
            // 
            // lbl_Reciever
            // 
            this.lbl_Reciever.AutoSize = true;
            this.lbl_Reciever.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reciever.Location = new System.Drawing.Point(331, 251);
            this.lbl_Reciever.Name = "lbl_Reciever";
            this.lbl_Reciever.Size = new System.Drawing.Size(184, 16);
            this.lbl_Reciever.TabIndex = 20;
            this.lbl_Reciever.Text = "Reciever account number";
            this.lbl_Reciever.Click += new System.EventHandler(this.lbl_Reciever_Click);
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sender.Location = new System.Drawing.Point(58, 251);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(171, 16);
            this.lbl_sender.TabIndex = 19;
            this.lbl_sender.Text = "Sender account number";
            // 
            // lbl_Transaction
            // 
            this.lbl_Transaction.AutoSize = true;
            this.lbl_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Transaction.Location = new System.Drawing.Point(205, 66);
            this.lbl_Transaction.Name = "lbl_Transaction";
            this.lbl_Transaction.Size = new System.Drawing.Size(118, 16);
            this.lbl_Transaction.TabIndex = 17;
            this.lbl_Transaction.Text = "Transaction List";
            // 
            // list_Transaction
            // 
            this.list_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Transaction.FormattingEnabled = true;
            this.list_Transaction.ItemHeight = 18;
            this.list_Transaction.Location = new System.Drawing.Point(334, 66);
            this.list_Transaction.Name = "list_Transaction";
            this.list_Transaction.Size = new System.Drawing.Size(186, 58);
            this.list_Transaction.TabIndex = 16;
            this.list_Transaction.SelectedIndexChanged += new System.EventHandler(this.list_Transaction_SelectedIndexChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(430, 327);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(85, 32);
            this.btn_Send.TabIndex = 27;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(723, 415);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(65, 23);
            this.btn_logout.TabIndex = 32;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_warn
            // 
            this.lbl_warn.AutoSize = true;
            this.lbl_warn.Location = new System.Drawing.Point(368, 306);
            this.lbl_warn.Name = "lbl_warn";
            this.lbl_warn.Size = new System.Drawing.Size(0, 13);
            this.lbl_warn.TabIndex = 33;
            // 
            // btn_Account
            // 
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.Location = new System.Drawing.Point(12, 415);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(75, 23);
            this.btn_Account.TabIndex = 31;
            this.btn_Account.Text = "Go back";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_warn);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Account);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.tb_Amount);
            this.Controls.Add(this.tb_reciever);
            this.Controls.Add(this.tb_sender);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_Reciever);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.lbl_Transaction);
            this.Controls.Add(this.list_Transaction);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.TextBox tb_reciever;
        private System.Windows.Forms.TextBox tb_sender;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_Reciever;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Label lbl_Transaction;
        private System.Windows.Forms.ListBox list_Transaction;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_warn;
        private System.Windows.Forms.Button btn_Account;
    }
}