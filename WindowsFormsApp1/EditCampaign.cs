using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        {//connection string

            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            {
                conn_string.Server = "localhost";
                conn_string.UserID = "tnt";
                conn_string.Password = "tnt";
                conn_string.Database = "dnd";
            }
            {
                MySqlConnection conn = new MySqlConnection(conn_string.ToString());
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO dnd.campaigns (campaignsName, campaignsDesc, campaignsImg) Values (@name, @desc, @img)";

                cmd.Parameters.AddWithValue("@name", nameBox.Text);
                cmd.Parameters.AddWithValue("@desc", descBox.Text);
                
                Image image = previewPicture.Image;
                if (image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, ImageFormat.Png);
                    byte[] imageBt = memoryStream.ToArray();
                    cmd.Parameters.AddWithValue("@img", imageBt);
                }
                else {
                    cmd.Parameters.AddWithValue("@img", null);
                }
                
                
                
                
                conn.Open();
               // cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }

                conn.Close();
            }
        }
                    
      

        private void backButton_Click(object sender, EventArgs e)
        {
        CamSelect f2 = new CamSelect();
        this.Hide();
        f2.Show();
    }
    }
}
