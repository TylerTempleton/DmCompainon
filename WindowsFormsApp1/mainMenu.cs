using System;
using System.Windows.Forms;

namespace DMCompainion
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public delegate void cNamePass(Label label);

        private void backButton_Click(object sender, EventArgs e)
        {
            CamSelect f2 = new CamSelect();
            Hide();
            f2.Show();
        }

        public void cNameLabelFill(ListBox listBox1)
        {
            cNameLabel.Text = listBox1.SelectedItem.ToString();
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            {
                Notes f4 = new Notes();
                cNamePass cname = new cNamePass(f4.cNameLabelFill);
                cname(this.cNameLabel);
                f4.Show();
            }
        }

        private void npcButton_Click(object sender, EventArgs e)
        {
            Npc f10 = new Npc();
            cNamePass cname = new cNamePass(f10.cNameLabelFill);
            cname(this.cNameLabel);
            f10.Show();
        }

        private void pcButton_Click(object sender, EventArgs e)
        {
            Pc f11 = new Pc();
            cNamePass cname = new cNamePass(f11.cNameLabelFill);
            cname(this.cNameLabel);
            f11.Show();
        }

        private void wmButton_Click(object sender, EventArgs e)
        {
            WorldMap f5 = new WorldMap();
            cNamePass cname = new cNamePass(f5.cNameLabelFill);
            cname(this.cNameLabel);
            f5.Show();
        }

        private void reButton_Click(object sender, EventArgs e)
        {
            RandomEncounter f6 = new RandomEncounter();
            cNamePass cname = new cNamePass(f6.cNameLabelFill);
            cname(this.cNameLabel);
            f6.Show();
        }

        private void townButton_Click(object sender, EventArgs e)
        {
            Town f7 = new Town();
            cNamePass cname = new cNamePass(f7.cNameLabelFill);
            cname(this.cNameLabel);
            f7.Show();
        }

        private void dunButton_Click(object sender, EventArgs e)
        {
            Dungeon f8 = new Dungeon();
            cNamePass cname = new cNamePass(f8.cNameLabelFill);
            cname(this.cNameLabel);
            f8.Show();
        }

        private void lootButton_Click(object sender, EventArgs e)
        {
            Loot f9 = new Loot();
            //cNamePass cname = new cNamePass(f9.cNameLabelFill);
           // cname(this.cNameLabel);
            f9.Show();
        }
    }
}