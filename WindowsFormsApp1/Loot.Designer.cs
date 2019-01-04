namespace DMCompainion
{
    partial class Loot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loot));
            this.crLabel = new System.Windows.Forms.Label();
            this.crValueBox = new System.Windows.Forms.ComboBox();
            this.typelabel = new System.Windows.Forms.Label();
            this.treasureTypeBox = new System.Windows.Forms.ComboBox();
            this.lootGenButton = new System.Windows.Forms.Button();
            this.treasureLabel = new System.Windows.Forms.Label();
            this.treasureBox = new ZBobb.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // crLabel
            // 
            this.crLabel.AutoSize = true;
            this.crLabel.BackColor = System.Drawing.Color.Transparent;
            this.crLabel.Location = new System.Drawing.Point(24, 41);
            this.crLabel.Name = "crLabel";
            this.crLabel.Size = new System.Drawing.Size(91, 13);
            this.crLabel.TabIndex = 5;
            this.crLabel.Text = "Challenge Rating:";
            // 
            // crValueBox
            // 
            this.crValueBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crValueBox.FormattingEnabled = true;
            this.crValueBox.Items.AddRange(new object[] {
            "0-4",
            "5-10",
            "11-16",
            "17+"});
            this.crValueBox.Location = new System.Drawing.Point(118, 36);
            this.crValueBox.Name = "crValueBox";
            this.crValueBox.Size = new System.Drawing.Size(121, 21);
            this.crValueBox.TabIndex = 6;
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.BackColor = System.Drawing.Color.Transparent;
            this.typelabel.Location = new System.Drawing.Point(266, 41);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(31, 13);
            this.typelabel.TabIndex = 7;
            this.typelabel.Text = "Type";
            // 
            // treasureTypeBox
            // 
            this.treasureTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treasureTypeBox.FormattingEnabled = true;
            this.treasureTypeBox.Items.AddRange(new object[] {
            "Individual Treasure",
            "Treasure Hoard",
            "One Loot Table to Rule Them All"});
            this.treasureTypeBox.Location = new System.Drawing.Point(328, 36);
            this.treasureTypeBox.Name = "treasureTypeBox";
            this.treasureTypeBox.Size = new System.Drawing.Size(138, 21);
            this.treasureTypeBox.TabIndex = 8;
            // 
            // lootGenButton
            // 
            this.lootGenButton.Location = new System.Drawing.Point(531, 38);
            this.lootGenButton.Name = "lootGenButton";
            this.lootGenButton.Size = new System.Drawing.Size(153, 23);
            this.lootGenButton.TabIndex = 9;
            this.lootGenButton.Text = "Generate Loot";
            this.lootGenButton.UseVisualStyleBackColor = true;
            this.lootGenButton.Click += new System.EventHandler(this.LootGenButton_Click);
            // 
            // treasureLabel
            // 
            this.treasureLabel.AutoSize = true;
            this.treasureLabel.BackColor = System.Drawing.Color.Transparent;
            this.treasureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureLabel.Location = new System.Drawing.Point(21, 84);
            this.treasureLabel.Name = "treasureLabel";
            this.treasureLabel.Size = new System.Drawing.Size(91, 25);
            this.treasureLabel.TabIndex = 10;
            this.treasureLabel.Text = "Treasure";
            // 
            // treasureBox
            // 
            this.treasureBox.BackAlpha = 0;
            this.treasureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.treasureBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treasureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureBox.Location = new System.Drawing.Point(27, 112);
            this.treasureBox.Multiline = true;
            this.treasureBox.Name = "treasureBox";
            this.treasureBox.Size = new System.Drawing.Size(578, 354);
            this.treasureBox.TabIndex = 11;
            this.treasureBox.TextChanged += new System.EventHandler(this.treasureBox_TextChanged);
            // 
            // Loot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.treasureBox);
            this.Controls.Add(this.treasureLabel);
            this.Controls.Add(this.lootGenButton);
            this.Controls.Add(this.treasureTypeBox);
            this.Controls.Add(this.typelabel);
            this.Controls.Add(this.crValueBox);
            this.Controls.Add(this.crLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loot";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Loot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label crLabel;
        private System.Windows.Forms.ComboBox crValueBox;
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.ComboBox treasureTypeBox;
        private System.Windows.Forms.Button lootGenButton;
        private System.Windows.Forms.Label treasureLabel;
        private ZBobb.AlphaBlendTextBox treasureBox;
    }
}