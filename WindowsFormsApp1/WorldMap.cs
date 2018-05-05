using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WorldMap : Form
    {
        string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

        public WorldMap()
        {
            InitializeComponent();
          
        }
        public void cNameLabelFill(Label cNameLabel)
        {
           cWMNameLabel.Text  = cNameLabel.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog camImage = new OpenFileDialog();
            camImage.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                worldMapBox.Image = Image.FromFile(camImage.FileName);
            }
          
            {
               SQLiteConnection conn = new SQLiteConnection(conn_string.ToString());
               SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE campaigns SET campaignWorldMap = @img  WHERE campaignsName = @name";

                cmd.Parameters.AddWithValue("@name", cWMNameLabel.Text);
                

                Image image = worldMapBox.Image;
                if (image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
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
        }
        
            


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorldMap_Load(object sender, EventArgs e)
        {
          SQLiteConnection conn = new SQLiteConnection(conn_string.ToString());
           SQLiteCommand cmd = conn.CreateCommand();
            SQLiteDataReader reader;
            try
            {//open DB connection
                conn.Open();
                //select all campaigns
                cmd.CommandText = "SELECT * FROM campaigns WHERE  campaignsName = @name";
                cmd.Parameters.AddWithValue("@name", cWMNameLabel.Text);

                //get the data and show it 

                reader = cmd.ExecuteReader();
                while (reader.Read())
                { // reader filters the campaign names from the result

                    Boolean logthing = reader.IsDBNull(3);
                    Debug.WriteLine(logthing);
                    if (!reader.IsDBNull(3))
                    {
                        byte[] byteBLOBData = (byte[])reader["campaignWorldMap"];
                        MemoryStream ms = new MemoryStream(byteBLOBData);
                        worldMapBox.Image = Image.FromStream(ms);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
