namespace WindowsFormsApp1
{
    partial class NewCampaign
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.previewPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Campaign";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Short Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 74);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upload Image";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(299, 169);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(149, 23);
            this.uploadButton.TabIndex = 5;
            this.uploadButton.Text = "Upload Image";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(54, 427);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(373, 427);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // previewPicture
            // 
            this.previewPicture.Location = new System.Drawing.Point(19, 199);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(429, 212);
            this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPicture.TabIndex = 8;
            this.previewPicture.TabStop = false;
            // 
            // NewCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 462);
            this.Controls.Add(this.previewPicture);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NewCampaign";
            this.Text = "New Campaign";
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox previewPicture;
    }
}