namespace WindowsFormsApp1
{
    partial class Dungeons
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
            this.dungeonList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.newDungeonButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cDungeonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonList
            // 
            this.dungeonList.FormattingEnabled = true;
            this.dungeonList.Location = new System.Drawing.Point(13, 13);
            this.dungeonList.Name = "dungeonList";
            this.dungeonList.Size = new System.Drawing.Size(120, 368);
            this.dungeonList.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(177, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 225);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(13, 432);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // newDungeonButton
            // 
            this.newDungeonButton.Location = new System.Drawing.Point(140, 432);
            this.newDungeonButton.Name = "newDungeonButton";
            this.newDungeonButton.Size = new System.Drawing.Size(91, 23);
            this.newDungeonButton.TabIndex = 3;
            this.newDungeonButton.Text = "New Dungeon";
            this.newDungeonButton.UseVisualStyleBackColor = true;
            this.newDungeonButton.Click += new System.EventHandler(this.newDungeonButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(281, 432);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete Dungeon";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(431, 432);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Back";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(177, 269);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 112);
            this.textBox1.TabIndex = 6;
            // 
            // cDungeonLabel
            // 
            this.cDungeonLabel.AutoSize = true;
            this.cDungeonLabel.Location = new System.Drawing.Point(174, 5);
            this.cDungeonLabel.Name = "cDungeonLabel";
            this.cDungeonLabel.Size = new System.Drawing.Size(62, 13);
            this.cDungeonLabel.TabIndex = 7;
            this.cDungeonLabel.Text = "placeholder";
            // 
            // Dungeons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 477);
            this.Controls.Add(this.cDungeonLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newDungeonButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dungeonList);
            this.Name = "Dungeons";
            this.Text = "Dungeons";
            this.Load += new System.EventHandler(this.Dungeons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dungeonList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button newDungeonButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label cDungeonLabel;
    }
}