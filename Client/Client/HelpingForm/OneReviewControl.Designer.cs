namespace Client.HelpingForm
{
    partial class OneReviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.White;
            this.tbMessage.Location = new System.Drawing.Point(5, 29);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMessage.Size = new System.Drawing.Size(403, 44);
            this.tbMessage.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.Location = new System.Drawing.Point(9, 9);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(52, 17);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "label1";
            // 
            // lbNote
            // 
            this.lbNote.Location = new System.Drawing.Point(395, 9);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(13, 17);
            this.lbNote.TabIndex = 2;
            this.lbNote.Text = "5";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(213, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(46, 17);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note:";
            // 
            // OneReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbMessage);
            this.Name = "OneReviewControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(416, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label3;
    }
}
