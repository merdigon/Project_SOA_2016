namespace Client.ResourceForms
{
    partial class MovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actorGridView = new System.Windows.Forms.DataGridView();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.btnDeleteActor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.btnSetDirector = new System.Windows.Forms.Button();
            this.btnDeleteDirector = new System.Windows.Forms.Button();
            this.pbMoviePicture = new System.Windows.Forms.PictureBox();
            this.tbImageUri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefreshImage = new System.Windows.Forms.Button();
            this.tbYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.actorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tytuł:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(100, 58);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(359, 22);
            this.tbTitle.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(100, 86);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDescription.Size = new System.Drawing.Size(359, 144);
            this.tbDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rok:";
            // 
            // actorGridView
            // 
            this.actorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.actorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorGridView.Location = new System.Drawing.Point(7, 434);
            this.actorGridView.Name = "actorGridView";
            this.actorGridView.RowTemplate.Height = 24;
            this.actorGridView.Size = new System.Drawing.Size(452, 104);
            this.actorGridView.TabIndex = 8;
            // 
            // btnAddActor
            // 
            this.btnAddActor.Image = global::Client.Properties.Resources.add_icon;
            this.btnAddActor.Location = new System.Drawing.Point(306, 396);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(75, 32);
            this.btnAddActor.TabIndex = 9;
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // btnDeleteActor
            // 
            this.btnDeleteActor.Image = global::Client.Properties.Resources.Close_icon;
            this.btnDeleteActor.Location = new System.Drawing.Point(387, 396);
            this.btnDeleteActor.Name = "btnDeleteActor";
            this.btnDeleteActor.Size = new System.Drawing.Size(72, 32);
            this.btnDeleteActor.TabIndex = 10;
            this.btnDeleteActor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Aktorzy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gatunek:";
            // 
            // cbGentre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(100, 264);
            this.cbGenre.Name = "cbGentre";
            this.cbGenre.Size = new System.Drawing.Size(359, 24);
            this.cbGenre.TabIndex = 13;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(100, 294);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(359, 22);
            this.tbCountry.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kraj:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Reżyser:";
            // 
            // tbDirector
            // 
            this.tbDirector.Enabled = false;
            this.tbDirector.Location = new System.Drawing.Point(100, 324);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tbDirector.Size = new System.Drawing.Size(289, 22);
            this.tbDirector.TabIndex = 17;
            // 
            // btnSetDirector
            // 
            this.btnSetDirector.Image = global::Client.Properties.Resources.Pencil_icon;
            this.btnSetDirector.Location = new System.Drawing.Point(395, 322);
            this.btnSetDirector.Name = "btnSetDirector";
            this.btnSetDirector.Size = new System.Drawing.Size(29, 27);
            this.btnSetDirector.TabIndex = 18;
            this.btnSetDirector.UseVisualStyleBackColor = true;
            this.btnSetDirector.Click += new System.EventHandler(this.btnSetDirector_Click);
            // 
            // btnDeleteDirector
            // 
            this.btnDeleteDirector.Image = global::Client.Properties.Resources.Close_icon;
            this.btnDeleteDirector.Location = new System.Drawing.Point(430, 322);
            this.btnDeleteDirector.Name = "btnDeleteDirector";
            this.btnDeleteDirector.Size = new System.Drawing.Size(29, 27);
            this.btnDeleteDirector.TabIndex = 19;
            this.btnDeleteDirector.UseVisualStyleBackColor = true;
            this.btnDeleteDirector.Click += new System.EventHandler(this.btnDeleteDirector_Click);
            // 
            // pbMoviePicture
            // 
            this.pbMoviePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMoviePicture.Location = new System.Drawing.Point(465, 12);
            this.pbMoviePicture.Name = "pbMoviePicture";
            this.pbMoviePicture.Size = new System.Drawing.Size(214, 256);
            this.pbMoviePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoviePicture.TabIndex = 20;
            this.pbMoviePicture.TabStop = false;
            // 
            // tbImageUri
            // 
            this.tbImageUri.Location = new System.Drawing.Point(100, 355);
            this.tbImageUri.Name = "tbImageUri";
            this.tbImageUri.Size = new System.Drawing.Size(359, 22);
            this.tbImageUri.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "URI obrazka:";
            // 
            // btnRefreshImage
            // 
            this.btnRefreshImage.Image = global::Client.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btnRefreshImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshImage.Location = new System.Drawing.Point(520, 275);
            this.btnRefreshImage.Name = "btnRefreshImage";
            this.btnRefreshImage.Size = new System.Drawing.Size(158, 41);
            this.btnRefreshImage.TabIndex = 24;
            this.btnRefreshImage.Text = "Aktualizuj obrazek";
            this.btnRefreshImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshImage.UseVisualStyleBackColor = true;
            this.btnRefreshImage.Click += new System.EventHandler(this.btnRefreshImage_Click);
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(100, 236);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(359, 22);
            this.tbYear.TabIndex = 25;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 586);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.btnRefreshImage);
            this.Controls.Add(this.tbImageUri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbMoviePicture);
            this.Controls.Add(this.btnDeleteDirector);
            this.Controls.Add(this.btnSetDirector);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteActor);
            this.Controls.Add(this.btnAddActor);
            this.Controls.Add(this.actorGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbTitle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.actorGridView, 0);
            this.Controls.SetChildIndex(this.btnAddActor, 0);
            this.Controls.SetChildIndex(this.btnDeleteActor, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cbGenre, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbCountry, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.tbDirector, 0);
            this.Controls.SetChildIndex(this.btnSetDirector, 0);
            this.Controls.SetChildIndex(this.btnDeleteDirector, 0);
            this.Controls.SetChildIndex(this.pbMoviePicture, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.tbImageUri, 0);
            this.Controls.SetChildIndex(this.btnRefreshImage, 0);
            this.Controls.SetChildIndex(this.tbYear, 0);
            ((System.ComponentModel.ISupportInitialize)(this.actorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoviePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView actorGridView;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.Button btnDeleteActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.Button btnSetDirector;
        private System.Windows.Forms.Button btnDeleteDirector;
        private System.Windows.Forms.PictureBox pbMoviePicture;
        private System.Windows.Forms.TextBox tbImageUri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefreshImage;
        private System.Windows.Forms.TextBox tbYear;
    }
}