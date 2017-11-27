using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        }

        private void pcButton_Click(object sender, EventArgs e)
        {

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

        }

        private void townButton_Click(object sender, EventArgs e)
        {

        }

        private void dunButton_Click(object sender, EventArgs e)
        {

        }

        private void lootButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}
