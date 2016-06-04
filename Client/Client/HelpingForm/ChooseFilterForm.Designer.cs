namespace Client.HelpingForm
{
    partial class ChooseFilterForm
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(13, 13);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(246, 22);
            this.tbValue.TabIndex = 0;
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(13, 42);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(205, 24);
            this.cbFilters.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Client.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(224, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.tbValue);
            this.Name = "ChooseFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wybierz filtr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button button1;
    }
}