namespace Client.ResourceForms
{
    partial class UserForm
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
            this.lbNick = new System.Windows.Forms.Label();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNick
            // 
            this.lbNick.AutoSize = true;
            this.lbNick.Location = new System.Drawing.Point(77, 105);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(39, 17);
            this.lbNick.TabIndex = 2;
            this.lbNick.Text = "Nick:";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(126, 102);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(333, 22);
            this.tbNick.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(126, 130);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(333, 22);
            this.tbPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(43, 133);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 17);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(126, 186);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(333, 22);
            this.tbEmail.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(126, 158);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(333, 22);
            this.tbName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(126, 214);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(333, 22);
            this.tbCity.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "City:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbUserName.Location = new System.Drawing.Point(166, 26);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(109, 39);
            this.lbUserName.TabIndex = 22;
            this.lbUserName.Text = "label4";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 301);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.lbNick);
            this.MaximumSize = new System.Drawing.Size(489, 350);
            this.Name = "UserForm";
            this.Text = "ActorForm";
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lbNick, 0);
            this.Controls.SetChildIndex(this.tbNick, 0);
            this.Controls.SetChildIndex(this.lbPassword, 0);
            this.Controls.SetChildIndex(this.tbPassword, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbEmail, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.tbCity, 0);
            this.Controls.SetChildIndex(this.lbUserName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNick;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbUserName;
    }
}