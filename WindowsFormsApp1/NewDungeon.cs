using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewDungeon : Form
    {
        public NewDungeon()
        {
            InitializeComponent();

        }
        MySql.Data.MySqlClient.MySqlConnectionStringBuilder conn_string = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "tnt",
            Password = "tnt",
            Database = "dnd"
        };
        public void getLabel(Label label)
        {
            cNewDungeonLabel.Text = label.Text;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {


            OpenFileDialog camImage = new OpenFileDialog();
            camImage.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                previewPicture.Image = Image.FromFile(camImage.FileName);
            }


            MySqlConnection conn = new MySqlConnection(conn_string.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE dnd.dungeons SET dungeonsMap = @img  WHERE dungeonsName = @name";

            cmd.Parameters.AddWithValue("@name", cNewDungeonLabel.Text);


            Image image = previewPicture.Image;
            if (image != null)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                image.Save(memoryStream, ImageFormat.Jpeg);
                byte[] imageBt = memoryStream.ToArray();
                cmd.Parameters.AddWithValue("@img", imageBt);
            }
            else
            {
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



        private void submitButton_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(conn_string.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO dnd.dungeons (campaignName, dungeonsName, dungeonsDesc, dungeonsMap) Values (@campname, @name, @desc, @img)";

            cmd.Parameters.AddWithValue("@name", nameBox.Text);
            cmd.Parameters.AddWithValue("@desc", descBox.Text);
            cmd.Parameters.AddWithValue("@campname", cNewDungeonLabel.Text);
            Image image = previewPicture.Image;
            if (image != null)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                image.Save(memoryStream, ImageFormat.Png);
                byte[] imageBt = memoryStream.ToArray();
                cmd.Parameters.AddWithValue("@img", imageBt);
            }
            else
            {
                cmd.Parameters.AddWithValue("@img", null);
            }




            conn.Open();
            try
            {
                // cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
            }
            catch(MySqlException)
            {
                MessageBox.Show("Please try a Different Name");
            }
            

            conn.Close();

        }
       
        private void backButton_Click(object sender, EventArgs e)
        {
            Dungeons f6 = new Dungeons();
            this.Close();
            f6.Show();
        }

        private void previewPicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog camImage = new OpenFileDialog();
            camImage.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                previewPicture.Image = Image.FromFile(camImage.FileName);
            }

        }
    }
}
