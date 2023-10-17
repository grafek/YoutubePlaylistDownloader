namespace YoutubePlaylistDownloader
{
    partial class Form1
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
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.URLLAbel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(12, 42);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(590, 26);
            this.URLTextbox.TabIndex = 0;
            // 
            // URLLAbel
            // 
            this.URLLAbel.AutoSize = true;
            this.URLLAbel.Location = new System.Drawing.Point(12, 19);
            this.URLLAbel.Name = "URLLAbel";
            this.URLLAbel.Size = new System.Drawing.Size(94, 20);
            this.URLLAbel.TabIndex = 1;
            this.URLLAbel.Text = "Playlist URL";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(257, 85);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(98, 45);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(30, 143);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 20);
            this.StatusLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 183);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.URLLAbel);
            this.Controls.Add(this.URLTextbox);
            this.Name = "Form1";
            this.Text = "Youtube Playlist Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.Label URLLAbel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

