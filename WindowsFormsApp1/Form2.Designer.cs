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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dndDataSet1 = new WindowsFormsApp1.dndDataSet1();
            this.selectButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.campaignsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campaignsTableAdapter = new WindowsFormsApp1.dndDataSet1TableAdapters.campaignsTableAdapter();
            this.campaignsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dndDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campaignsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dndDataSet1
            // 
            this.dndDataSet1.DataSetName = "dndDataSet1";
            this.dndDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(22, 335);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(194, 335);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Your Campiagn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(103, 334);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 5;
            this.newButton.Text = "Add New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(162, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 84);
            this.textBox1.TabIndex = 6;
            // 
            // campaignsBindingSource
            // 
            this.campaignsBindingSource.DataMember = "campaigns";
            this.campaignsBindingSource.DataSource = this.dndDataSet1;
            // 
            // campaignsTableAdapter
            // 
            this.campaignsTableAdapter.ClearBeforeFill = true;
            // 
            // campaignsBindingSource1
            // 
            this.campaignsBindingSource1.DataMember = "campaigns";
            this.campaignsBindingSource1.DataSource = this.dndDataSet1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(275, 335);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // CamSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 372);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.listBox1);
            this.Name = "CamSelect";
            this.Text = "CampaignSelect";
            this.Load += new System.EventHandler(this.CamSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dndDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.TextBox textBox1;
        private dndDataSet1 dndDataSet1;
        private System.Windows.Forms.BindingSource campaignsBindingSource;
        private dndDataSet1TableAdapters.campaignsTableAdapter campaignsTableAdapter;
        private System.Windows.Forms.BindingSource campaignsBindingSource1;
        private System.Windows.Forms.Button updateButton;
    }
}