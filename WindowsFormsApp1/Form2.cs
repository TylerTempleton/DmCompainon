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
    public partial class CamSelect : Form
    {
        public CamSelect()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            MainMenu f3 = new MainMenu();
            Hide();
            f3.Show();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewCampaign f2 = new NewCampaign();
            Hide();
            f2.Show();
        }

        private void delButton_Click(object sender, EventArgs e)
        {

        }
    }
}
