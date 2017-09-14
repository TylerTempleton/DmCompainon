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
    public partial class NewCampaign : Form
    {
        public NewCampaign()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog camImage = new OpenFileDialog();
            camImage.Filter= "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                previewPicture.Image = Image.FromFile(camImage.FileName);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
