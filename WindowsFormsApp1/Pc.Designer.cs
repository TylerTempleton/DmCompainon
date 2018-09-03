namespace WindowsFormsApp1
{
    partial class Pc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pc));
            this.cWMNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cWMNameLabel
            // 
            this.cWMNameLabel.AutoSize = true;
            this.cWMNameLabel.Location = new System.Drawing.Point(239, 9);
            this.cWMNameLabel.Name = "cWMNameLabel";
            this.cWMNameLabel.Size = new System.Drawing.Size(341, 13);
            this.cWMNameLabel.TabIndex = 4;
            this.cWMNameLabel.Text = "Placeholder(user should not see this text but rather the campign name )";
            // 
            // Pc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.cWMNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pc";
            this.Text = "Pc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cWMNameLabel;
    }
}