namespace WindowsFormsApp1
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
            this.mainlabel = new System.Windows.Forms.Label();
            this.wmButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.pcButton = new System.Windows.Forms.Button();
            this.npcButton = new System.Windows.Forms.Button();
            this.townButton = new System.Windows.Forms.Button();
            this.dunButton = new System.Windows.Forms.Button();
            this.lootButton = new System.Windows.Forms.Button();
            this.reButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.cNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.Location = new System.Drawing.Point(317, 9);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(189, 40);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(208, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 182);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.cNameLabel.Location = new System.Drawing.Point(393, 79);
            this.cNameLabel.Name = "cNameLabel";
            this.cNameLabel.Size = new System.Drawing.Size(0, 13);
            this.cNameLabel.TabIndex = 11;
            this.cNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.cNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reButton);
            this.Controls.Add(this.lootButton);
            this.Controls.Add(this.dunButton);
            this.Controls.Add(this.townButton);
            this.Controls.Add(this.npcButton);
            this.Controls.Add(this.pcButton);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.wmButton);
            this.Controls.Add(this.mainlabel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label cNameLabel;
    }
}