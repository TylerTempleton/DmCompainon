namespace WindowsFormsApp1
{
    partial class CamSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamSelect));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.campaignImgBox = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.campaignsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campaignsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.campaignImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 407);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(167, 61);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(420, 407);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(185, 61);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Campiagn";
            // 
            // campaignImgBox
            // 
            this.campaignImgBox.Location = new System.Drawing.Point(334, 65);
            this.campaignImgBox.Name = "campaignImgBox";
            this.campaignImgBox.Size = new System.Drawing.Size(435, 203);
            this.campaignImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.campaignImgBox.TabIndex = 4;
            this.campaignImgBox.TabStop = false;
            this.campaignImgBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(206, 407);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(181, 61);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "Add New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(334, 295);
            this.textBox1.MaxLength = 200;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(435, 92);
            this.textBox1.TabIndex = 6;
            // 
            // campaignsBindingSource
            // 
            this.campaignsBindingSource.DataMember = "campaigns";
            // 
            // campaignsBindingSource1
            // 
            this.campaignsBindingSource1.DataMember = "campaigns";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(645, 407);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(177, 61);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(331, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Click at add a Image";
            // 
            // CamSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.paper_background;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.campaignImgBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CamSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampaignSelect";
            this.Load += new System.EventHandler(this.CamSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campaignImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox campaignImgBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox textBox1;
        
        private System.Windows.Forms.BindingSource campaignsBindingSource;
      
        private System.Windows.Forms.BindingSource campaignsBindingSource1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
    }
}