namespace WindowsFormsApp1
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
            this.worldMapBox.Size = new System.Drawing.Size(1091, 547);
            this.worldMapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.worldMapBox.TabIndex = 0;
            this.worldMapBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload New Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(686, 590);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(148, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cWMNameLabel
            // 
            this.cWMNameLabel.AutoSize = true;
            this.cWMNameLabel.Location = new System.Drawing.Point(334, 13);
            this.cWMNameLabel.Name = "cWMNameLabel";
            this.cWMNameLabel.Size = new System.Drawing.Size(341, 13);
            this.cWMNameLabel.TabIndex = 3;
            this.cWMNameLabel.Text = "Placeholder(user should not see this text but rather the campign name )";
            // 
            // WorldMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 617);
            this.Controls.Add(this.cWMNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.worldMapBox);
            this.Name = "WorldMap";
            this.Text = "WorldMap";
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