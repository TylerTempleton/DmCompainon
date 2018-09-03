using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {   //
            // placeholder code for sql database checking
            //

            //code to move after authentication
            CamSelect f2 = new CamSelect();
            Hide();
            f2.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {//closes application
            System.Windows.Forms.Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }
    }
}