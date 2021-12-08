
namespace BankApplication
{
    partial class from_lgn
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_userId = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.Label();
            this.l_warn = new System.Windows.Forms.Label();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(315, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(327, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_userId
            // 
            this.tb_userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userId.Location = new System.Drawing.Point(315, 182);
            this.tb_userId.Name = "tb_userId";
            this.tb_userId.Size = new System.Drawing.Size(156, 24);
            this.tb_userId.TabIndex = 2;
            this.tb_userId.TextChanged += new System.EventHandler(this.tb_userId_TextChanged);
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.Location = new System.Drawing.Point(225, 182);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(66, 20);
            this.UserId.TabIndex = 3;
            this.UserId.Text = "UserID";
            this.UserId.Click += new System.EventHandler(this.UserId_Click);
            // 
            // l_warn
            // 
            this.l_warn.AutoSize = true;
            this.l_warn.Location = new System.Drawing.Point(402, 97);
            this.l_warn.Name = "l_warn";
            this.l_warn.Size = new System.Drawing.Size(0, 13);
            this.l_warn.TabIndex = 4;
            // 
            // lbl_warn
            // 
            this.lbl_warn.AutoSize = true;
            this.lbl_warn.Location = new System.Drawing.Point(389, 110);
            this.lbl_warn.Name = "lbl_warn";
            this.lbl_warn.Size = new System.Drawing.Size(0, 13);
            this.lbl_warn.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to BankApplication";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(312, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dont have an account? ";
            // 
            // from_lgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_warn);
            this.Controls.Add(this.l_warn);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.tb_userId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "from_lgn";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.from_lgn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_userId;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label l_warn;
        private System.Windows.Forms.Label lbl_warn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

