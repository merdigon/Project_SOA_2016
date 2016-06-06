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
            this.lbNick.Location = new System.Drawing.Point(58, 85);
            this.lbNick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNick.Name = "lbNick";
            this.lbNick.Size = new System.Drawing.Size(32, 13);
            this.lbNick.TabIndex = 2;
            this.lbNick.Text = "Nick:";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(94, 83);
            this.tbNick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(251, 20);
            this.tbNick.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(94, 106);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(251, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(32, 108);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(94, 151);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(251, 20);
            this.tbEmail.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 128);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 20);
            this.tbName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(94, 174);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(251, 20);
            this.tbCity.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "City:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbUserName.Location = new System.Drawing.Point(124, 21);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(86, 31);
            this.lbUserName.TabIndex = 22;
            this.lbUserName.Text = "label4";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 245);
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
            this.MaximumSize = new System.Drawing.Size(383, 287);
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