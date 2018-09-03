using System;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            camImage.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                previewPicture.Image = Image.FromFile(camImage.FileName);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {//connection string
            string conn_string = "Data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {  //open DB connection
                conn.Open();

                string stm = "SELECT* FROM campaigns WHERE campaignsName = @name";
                using (SQLiteCommand cmd = new SQLiteCommand(stm, conn))
                {
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);

                    cmd.ExecuteNonQuery();

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("That name is already taken, Try another!");
                    }
                    else
                    {
                        reader.Close();
                        cmd.CommandText = "INSERT INTO campaigns (campaignsName, campaignsDesc, campaignsImg) Values (@name, @desc, @img)";
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

        private void backButton_Click(object sender, EventArgs e)
        {
            CamSelect f2 = new CamSelect();
            this.Hide();
            f2.Show();
        }
    }
}