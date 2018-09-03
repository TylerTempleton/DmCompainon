namespace WindowsFormsApp1
{
    partial class RandomEncounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomEncounter));
            this.cWMNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partyLevelLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.numberOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.partyLevel = new System.Windows.Forms.NumericUpDown();
            this.difficultyBox = new System.Windows.Forms.ComboBox();
            this.encounterButton = new System.Windows.Forms.Button();
            this.expLabel = new System.Windows.Forms.Label();
            this.expValue = new System.Windows.Forms.Label();
            this.numOfMons = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bexpLabel = new System.Windows.Forms.Label();
            this.besxpValue = new System.Windows.Forms.Label();
            this.partyMultiLabel = new System.Windows.Forms.Label();
            this.monMultiLabel = new System.Windows.Forms.Label();
            this.partyMultiValue = new System.Windows.Forms.Label();
            this.monsterMultiValue = new System.Windows.Forms.Label();
            this.playerMultiLabel = new System.Windows.Forms.Label();
            this.playerMultiValue = new System.Windows.Forms.Label();
            this.lineBar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfMons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cWMNameLabel
            // 
            this.cWMNameLabel.AutoSize = true;
            this.cWMNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.cWMNameLabel.Location = new System.Drawing.Point(243, 9);
            this.cWMNameLabel.Name = "cWMNameLabel";
            this.cWMNameLabel.Size = new System.Drawing.Size(341, 13);
            this.cWMNameLabel.TabIndex = 4;
            this.cWMNameLabel.Text = "Placeholder(user should not see this text but rather the campign name )";
            this.cWMNameLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "# Of Players";
            // 
            // partyLevelLabel
            // 
            this.partyLevelLabel.AutoSize = true;
            this.partyLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.partyLevelLabel.Location = new System.Drawing.Point(133, 50);
            this.partyLevelLabel.Name = "partyLevelLabel";
            this.partyLevelLabel.Size = new System.Drawing.Size(67, 13);
            this.partyLevelLabel.TabIndex = 7;
            this.partyLevelLabel.Text = "Party\'s Level";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.difficultyLabel.Location = new System.Drawing.Point(250, 50);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.difficultyLabel.TabIndex = 9;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // numberOfPlayers
            // 
            this.numberOfPlayers.Location = new System.Drawing.Point(83, 48);
            this.numberOfPlayers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPlayers.Name = "numberOfPlayers";
            this.numberOfPlayers.Size = new System.Drawing.Size(33, 20);
            this.numberOfPlayers.TabIndex = 10;
            this.numberOfPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // partyLevel
            // 
            this.partyLevel.Location = new System.Drawing.Point(211, 48);
            this.partyLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.partyLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyLevel.Name = "partyLevel";
            this.partyLevel.Size = new System.Drawing.Size(33, 20);
            this.partyLevel.TabIndex = 11;
            this.partyLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // difficultyBox
            // 
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Deadly"});
            this.difficultyBox.Location = new System.Drawing.Point(312, 48);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(121, 21);
            this.difficultyBox.TabIndex = 12;
            this.difficultyBox.Text = "Easy";
            // 
            // encounterButton
            // 
            this.encounterButton.Location = new System.Drawing.Point(630, 46);
            this.encounterButton.Name = "encounterButton";
            this.encounterButton.Size = new System.Drawing.Size(147, 22);
            this.encounterButton.TabIndex = 13;
            this.encounterButton.Text = "Generate Encounter!";
            this.encounterButton.UseVisualStyleBackColor = true;
            this.encounterButton.Click += new System.EventHandler(this.encounterButton_Click);
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.BackColor = System.Drawing.Color.Transparent;
            this.expLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLabel.Location = new System.Drawing.Point(12, 247);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(72, 13);
            this.expLabel.TabIndex = 14;
            this.expLabel.Text = "Exp Budget";
            this.expLabel.Visible = false;
            // 
            // expValue
            // 
            this.expValue.AutoSize = true;
            this.expValue.BackColor = System.Drawing.Color.Transparent;
            this.expValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expValue.Location = new System.Drawing.Point(103, 247);
            this.expValue.Name = "expValue";
            this.expValue.Size = new System.Drawing.Size(14, 13);
            this.expValue.TabIndex = 15;
            this.expValue.Text = "0";
            this.expValue.Visible = false;
            // 
            // numOfMons
            // 
            this.numOfMons.Location = new System.Drawing.Point(573, 48);
            this.numOfMons.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numOfMons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfMons.Name = "numOfMons";
            this.numOfMons.Size = new System.Drawing.Size(36, 20);
            this.numOfMons.TabIndex = 16;
            this.numOfMons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(452, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Number of Monsters";
            // 
            // bexpLabel
            // 
            this.bexpLabel.AutoSize = true;
            this.bexpLabel.BackColor = System.Drawing.Color.Transparent;
            this.bexpLabel.Location = new System.Drawing.Point(12, 100);
            this.bexpLabel.Name = "bexpLabel";
            this.bexpLabel.Size = new System.Drawing.Size(55, 13);
            this.bexpLabel.TabIndex = 18;
            this.bexpLabel.Text = "Base EXP";
            this.bexpLabel.Visible = false;
            // 
            // besxpValue
            // 
            this.besxpValue.AutoSize = true;
            this.besxpValue.BackColor = System.Drawing.Color.Transparent;
            this.besxpValue.Location = new System.Drawing.Point(103, 100);
            this.besxpValue.Name = "besxpValue";
            this.besxpValue.Size = new System.Drawing.Size(13, 13);
            this.besxpValue.TabIndex = 19;
            this.besxpValue.Text = "0";
            this.besxpValue.Visible = false;
            // 
            // partyMultiLabel
            // 
            this.partyMultiLabel.AutoSize = true;
            this.partyMultiLabel.BackColor = System.Drawing.Color.Transparent;
            this.partyMultiLabel.Location = new System.Drawing.Point(12, 163);
            this.partyMultiLabel.Name = "partyMultiLabel";
            this.partyMultiLabel.Size = new System.Drawing.Size(76, 13);
            this.partyMultiLabel.TabIndex = 20;
            this.partyMultiLabel.Text = "PartySize Multi";
            this.partyMultiLabel.Visible = false;
            // 
            // monMultiLabel
            // 
            this.monMultiLabel.AutoSize = true;
            this.monMultiLabel.BackColor = System.Drawing.Color.Transparent;
            this.monMultiLabel.Location = new System.Drawing.Point(12, 194);
            this.monMultiLabel.Name = "monMultiLabel";
            this.monMultiLabel.Size = new System.Drawing.Size(70, 13);
            this.monMultiLabel.TabIndex = 21;
            this.monMultiLabel.Text = "Monster Multi";
            this.monMultiLabel.Visible = false;
            // 
            // partyMultiValue
            // 
            this.partyMultiValue.AutoSize = true;
            this.partyMultiValue.BackColor = System.Drawing.Color.Transparent;
            this.partyMultiValue.Location = new System.Drawing.Point(103, 163);
            this.partyMultiValue.Name = "partyMultiValue";
            this.partyMultiValue.Size = new System.Drawing.Size(13, 13);
            this.partyMultiValue.TabIndex = 22;
            this.partyMultiValue.Text = "0";
            this.partyMultiValue.Visible = false;
            // 
            // monsterMultiValue
            // 
            this.monsterMultiValue.AutoSize = true;
            this.monsterMultiValue.BackColor = System.Drawing.Color.Transparent;
            this.monsterMultiValue.Location = new System.Drawing.Point(103, 194);
            this.monsterMultiValue.Name = "monsterMultiValue";
            this.monsterMultiValue.Size = new System.Drawing.Size(13, 13);
            this.monsterMultiValue.TabIndex = 23;
            this.monsterMultiValue.Text = "0";
            this.monsterMultiValue.Visible = false;
            // 
            // playerMultiLabel
            // 
            this.playerMultiLabel.AutoSize = true;
            this.playerMultiLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerMultiLabel.Location = new System.Drawing.Point(12, 131);
            this.playerMultiLabel.Name = "playerMultiLabel";
            this.playerMultiLabel.Size = new System.Drawing.Size(58, 13);
            this.playerMultiLabel.TabIndex = 24;
            this.playerMultiLabel.Text = "PlayerMulti";
            this.playerMultiLabel.Visible = false;
            // 
            // playerMultiValue
            // 
            this.playerMultiValue.AutoSize = true;
            this.playerMultiValue.BackColor = System.Drawing.Color.Transparent;
            this.playerMultiValue.Location = new System.Drawing.Point(103, 131);
            this.playerMultiValue.Name = "playerMultiValue";
            this.playerMultiValue.Size = new System.Drawing.Size(13, 13);
            this.playerMultiValue.TabIndex = 25;
            this.playerMultiValue.Text = "0";
            this.playerMultiValue.Visible = false;
            // 
            // lineBar
            // 
            this.lineBar.AutoSize = true;
            this.lineBar.BackColor = System.Drawing.Color.Transparent;
            this.lineBar.Location = new System.Drawing.Point(1, 207);
            this.lineBar.Name = "lineBar";
            this.lineBar.Size = new System.Drawing.Size(163, 13);
            this.lineBar.TabIndex = 26;
            this.lineBar.Text = "__________________________";
            this.lineBar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 107);
            this.dataGridView1.TabIndex = 27;
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.paper_background;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Location = new System.Drawing.Point(211, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(566, 255);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // RandomEncounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.paper_background;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lineBar);
            this.Controls.Add(this.playerMultiValue);
            this.Controls.Add(this.playerMultiLabel);
            this.Controls.Add(this.monsterMultiValue);
            this.Controls.Add(this.partyMultiValue);
            this.Controls.Add(this.monMultiLabel);
            this.Controls.Add(this.partyMultiLabel);
            this.Controls.Add(this.besxpValue);
            this.Controls.Add(this.bexpLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOfMons);
            this.Controls.Add(this.expValue);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.encounterButton);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.partyLevel);
            this.Controls.Add(this.numberOfPlayers);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.partyLevelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cWMNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RandomEncounter";
            this.Text = "RandomEncounter";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfMons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cWMNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partyLevelLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.NumericUpDown numberOfPlayers;
        private System.Windows.Forms.NumericUpDown partyLevel;
        private System.Windows.Forms.ComboBox difficultyBox;
        private System.Windows.Forms.Button encounterButton;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label expValue;
        private System.Windows.Forms.NumericUpDown numOfMons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bexpLabel;
        private System.Windows.Forms.Label besxpValue;
        private System.Windows.Forms.Label partyMultiLabel;
        private System.Windows.Forms.Label monMultiLabel;
        private System.Windows.Forms.Label partyMultiValue;
        private System.Windows.Forms.Label monsterMultiValue;
        private System.Windows.Forms.Label playerMultiLabel;
        private System.Windows.Forms.Label playerMultiValue;
        private System.Windows.Forms.Label lineBar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
    }
}