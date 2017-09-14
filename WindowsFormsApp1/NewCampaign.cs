using MySql.Data.MySqlClient;
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
            {//connection string
                string connection = "datasource = localhost; user id = tnt; password=tnt; database = dnd; persistsecurityinfo = True";

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
               previewPicture.Image.Save(ms, previewPicture.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySql.Data.MySqlClient.MySqlConnection Myconn = new MySql.Data.MySqlClient.MySqlConnection(connection);

                String insertQuery = "INSERT INTO dnd.campaigns( campaignsName, campaignsDesc, campaignImg) VALUES( @name, @desc, @img)";
                MySql.Data.MySqlClient.MySqlCommand MyCommand2 = new MySql.Data.MySqlClient.MySqlCommand(insertQuery, Myconn);



                MyCommand2.Parameters.AddWithValue("@name", nameBox.Text);
                MyCommand2.Parameters.AddWithValue("@desc", descBox.Text);
                MyCommand2.Parameters.Add("@img", MySqlDbType.Blob);


                MyCommand2.Parameters["@name"].Value = nameBox.Text;
                MyCommand2.Parameters["@desc"].Value = descBox.Text;
                MyCommand2.Parameters["@img"].Value = previewPicture.Image;

                if (MyCommand2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }

               Myconn.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
