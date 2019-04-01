namespace DMCompainion
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainlabel = new System.Windows.Forms.Label();
            this.wmButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.pcButton = new System.Windows.Forms.Button();
            this.npcButton = new System.Windows.Forms.Button();
            this.townButton = new System.Windows.Forms.Button();
            this.dunButton = new System.Windows.Forms.Button();
            this.lootButton = new System.Windows.Forms.Button();
            this.reButton = new System.Windows.Forms.Button();
            this.campaignImg = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.cNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.campaignImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.BackColor = System.Drawing.Color.Transparent;
            this.mainlabel.Font = new System.Drawing.Font("Gabriola", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(293, -17);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(220, 88);
            this.mainlabel.TabIndex = 0;
            this.mainlabel.Text = "Main Menu";
            // 
            // wmButton
            // 
            this.wmButton.Location = new System.Drawing.Point(351, 356);
            this.wmButton.Name = "wmButton";
            this.wmButton.Size = new System.Drawing.Size(127, 23);
            this.wmButton.TabIndex = 1;
            this.wmButton.Text = "WorldMap";
            this.wmButton.UseVisualStyleBackColor = true;
            this.wmButton.Click += new System.EventHandler(this.wmButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.Location = new System.Drawing.Point(208, 327);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(127, 23);
            this.notesButton.TabIndex = 2;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = true;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // pcButton
            // 
            this.pcButton.Enabled = false;
            this.pcButton.Location = new System.Drawing.Point(351, 326);
            this.pcButton.Name = "pcButton";
            this.pcButton.Size = new System.Drawing.Size(128, 24);
            this.pcButton.TabIndex = 3;
            this.pcButton.Text = "Player Charaters";
            this.pcButton.UseVisualStyleBackColor = true;
            this.pcButton.Click += new System.EventHandler(this.pcButton_Click);
            // 
            // npcButton
            // 
            this.npcButton.Enabled = false;
            this.npcButton.Location = new System.Drawing.Point(208, 356);
            this.npcButton.Name = "npcButton";
            this.npcButton.Size = new System.Drawing.Size(127, 24);
            this.npcButton.TabIndex = 4;
            this.npcButton.Text = "NPC";
            this.npcButton.UseVisualStyleBackColor = true;
            this.npcButton.Click += new System.EventHandler(this.npcButton_Click);
            // 
            // townButton
            // 
            this.townButton.Enabled = false;
            this.townButton.Location = new System.Drawing.Point(494, 326);
            this.townButton.Name = "townButton";
            this.townButton.Size = new System.Drawing.Size(127, 24);
            this.townButton.TabIndex = 5;
            this.townButton.Text = "Towns";
            this.townButton.UseVisualStyleBackColor = true;
            this.townButton.Click += new System.EventHandler(this.townButton_Click);
            // 
            // dunButton
            // 
            this.dunButton.Enabled = false;
            this.dunButton.Location = new System.Drawing.Point(493, 357);
            this.dunButton.Name = "dunButton";
            this.dunButton.Size = new System.Drawing.Size(128, 23);
            this.dunButton.TabIndex = 6;
            this.dunButton.Text = "Dungeons";
            this.dunButton.UseVisualStyleBackColor = true;
            this.dunButton.Click += new System.EventHandler(this.dunButton_Click);
            // 
            // lootButton
            // 
            this.lootButton.Location = new System.Drawing.Point(493, 386);
            this.lootButton.Name = "lootButton";
            this.lootButton.Size = new System.Drawing.Size(127, 24);
            this.lootButton.TabIndex = 7;
            this.lootButton.Text = "Random Loot";
            this.lootButton.UseVisualStyleBackColor = true;
            this.lootButton.Click += new System.EventHandler(this.lootButton_Click);
            // 
            // reButton
            // 
            this.reButton.Location = new System.Drawing.Point(351, 385);
            this.reButton.Name = "reButton";
            this.reButton.Size = new System.Drawing.Size(128, 24);
            this.reButton.TabIndex = 8;
            this.reButton.Text = "Random Encounter";
            this.reButton.UseVisualStyleBackColor = true;
            this.reButton.Click += new System.EventHandler(this.reButton_Click);
            // 
            // campaignImg
            // 
            this.campaignImg.BackColor = System.Drawing.Color.Transparent;
            this.campaignImg.Location = new System.Drawing.Point(208, 125);
            this.campaignImg.Name = "campaignImg";
            this.campaignImg.Size = new System.Drawing.Size(413, 182);
            this.campaignImg.TabIndex = 9;
            this.campaignImg.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(208, 386);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(127, 24);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cNameLabel
            // 
            this.cNameLabel.AutoSize = true;
            this.cNameLabel.Location = new System.Drawing.Point(411, 71);
            this.cNameLabel.Name = "cNameLabel";
            this.cNameLabel.Size = new System.Drawing.Size(0, 13);
            this.cNameLabel.TabIndex = 11;
            this.cNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cNameLabel.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DMCompainion.Properties.Resources.paper_background;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.cNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.campaignImg);
            this.Controls.Add(this.reButton);
            this.Controls.Add(this.lootButton);
            this.Controls.Add(this.dunButton);
            this.Controls.Add(this.townButton);
            this.Controls.Add(this.npcButton);
            this.Controls.Add(this.pcButton);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.wmButton);
            this.Controls.Add(this.mainlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.campaignImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.Button wmButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button pcButton;
        private System.Windows.Forms.Button npcButton;
        private System.Windows.Forms.Button townButton;
        private System.Windows.Forms.Button dunButton;
        private System.Windows.Forms.Button lootButton;
        private System.Windows.Forms.Button reButton;
        private System.Windows.Forms.PictureBox campaignImg;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label cNameLabel;
    }
}