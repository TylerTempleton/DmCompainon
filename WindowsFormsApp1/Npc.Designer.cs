namespace DMCompainion
{
    partial class Npc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Npc));
            this.cWMNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cWMNameLabel
            // 
            this.cWMNameLabel.AutoSize = true;
            this.cWMNameLabel.Location = new System.Drawing.Point(216, 9);
            this.cWMNameLabel.Name = "cWMNameLabel";
            this.cWMNameLabel.Size = new System.Drawing.Size(341, 13);
            this.cWMNameLabel.TabIndex = 4;
            this.cWMNameLabel.Text = "Placeholder(user should not see this text but rather the campign name )";
            // 
            // Npc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DMCompainion.Properties.Resources.paper_background;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.cWMNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Npc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Npc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cWMNameLabel;
    }
}