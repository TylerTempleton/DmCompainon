//
//This class is used to create a new campign in the New Campaign Window
//This will allow the user to input a new campaign name, map/image, and description/overview of the campign
//Made by Tyler Templeton
//
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DMCompainion
{
    public partial class NewCampaign : Form
    {
        public NewCampaign()
        {
            InitializeComponent();
        }

        //button to upload a new Campaign map image
        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog camImage = new OpenFileDialog();
            camImage.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                previewPicture.Image = Image.FromFile(camImage.FileName);
            }
        }

        //button to submit campaign data
        private void submitButton_Click(object sender, EventArgs e)
        {//connection string
            string conn_string = "Data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {  //open DB connection
                conn.Open();

                string stm = "SELECT* FROM campaigns WHERE campaignsName = @name";
                using (SQLiteCommand cmd = new SQLiteCommand(stm, conn))
                {//get name parameter to query
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);

                    cmd.ExecuteNonQuery();
                    //initialize reader
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    //if there is a match
                    if (reader.HasRows)
                    {
                        MessageBox.Show("That name is already taken, Try another!");
                    }
                    //otherwise insert data to sqlite database
                    else
                    {
                        reader.Close();
                        cmd.CommandText = "INSERT INTO campaigns (campaignsName, campaignsDesc, campaignsImg) Values (@name, @desc, @img)";
                        cmd.Parameters.AddWithValue("@name", nameBox.Text);
                        cmd.Parameters.AddWithValue("@desc", descBox.Text);
                        Image image = previewPicture.Image;
                        // if there is a value in image
                        if (image != null)
                        {
                            MemoryStream memoryStream = new MemoryStream();
                            image.Save(memoryStream, ImageFormat.Png);
                            byte[] imageBt = memoryStream.ToArray();
                            cmd.Parameters.AddWithValue("@img", imageBt);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@img", null);
                        }

                        // cmd.ExecuteNonQuery();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data Inserted");
                        }
                        conn.Close();
                    }
                }
            }
        }

        // button to go back to main menu
        private void backButton_Click(object sender, EventArgs e)
        {
            CamSelect f2 = new CamSelect();

            f2.Show();
            this.Close();
        }
    }
}