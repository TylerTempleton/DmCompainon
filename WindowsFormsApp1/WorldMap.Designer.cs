namespace DMCompainion
{
    partial class WorldMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldMap));
            this.worldMapBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.cWMNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldMapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // worldMapBox
            // 
            this.worldMapBox.Location = new System.Drawing.Point(12, 37);
            this.worldMapBox.Name = "worldMapBox";
            this.worldMapBox.Size = new System.Drawing.Size(810, 329);
            this.worldMapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.worldMapBox.TabIndex = 0;
            this.worldMapBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(424, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload New Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(442, 372);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(380, 96);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cWMNameLabel
            // 
            this.cWMNameLabel.AutoSize = true;
            this.cWMNameLabel.Location = new System.Drawing.Point(279, 9);
            this.cWMNameLabel.Name = "cWMNameLabel";
            this.cWMNameLabel.Size = new System.Drawing.Size(341, 13);
            this.cWMNameLabel.TabIndex = 3;
            this.cWMNameLabel.Text = "Placeholder(user should not see this text but rather the campign name )";
            // 
            // WorldMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.cWMNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.worldMapBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WorldMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldMap";
            this.Load += new System.EventHandler(this.WorldMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worldMapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox worldMapBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label cWMNameLabel;
    }
}