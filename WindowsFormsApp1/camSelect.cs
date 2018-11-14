using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DMCompainion
{
    public partial class CamSelect : Form
    {// connection string to MySql database
        private string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

        public CamSelect()
        {//start up form
            InitializeComponent();
            //populate listbox
            GetList();
        }

        public delegate void cNamePass(ListBox listbox);

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Campaign To Continue");
            }
            else
            {
                // instance of Main Menu form window
                MainMenu f3 = new MainMenu();

                //pass campaign data
                cNamePass cname = new cNamePass(f3.cNameLabelFill);
                cname(this.listBox1);

                // show new form
                f3.Show();
                this.Close();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        { // instance of new campaign form window
            NewCampaign f2 = new NewCampaign();
            // show new form
            f2.Show();
            // hide old form
            this.Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {// store name of list item selected
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Campaign To Continue");
            }
            else
            {
                string i = listBox1.SelectedItem.ToString();
                //set up connection to DB

                using (SQLiteConnection conn = new SQLiteConnection(conn_string))
                {//open DB connection
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM campaigns where campaignsName = @name", conn))
                    {
                        //MySQL statment to delete based on campaign name that is paramiterized to prevent sql injection

                        cmd.Parameters.AddWithValue("@name", i);
                        // execute command
                        cmd.ExecuteNonQuery();
                        {//popup for user to know it has been deleted
                            MessageBox.Show("Data deleted");
                        }
                        // close connection
                        conn.Close();
                        GetList();
                    }
                }
            }
        }

        private void CamSelect_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The variable that will keep the index of the selected item
            int index;
            // Get the index of the selected item
            index = listBox1.SelectedIndex;

            //get the selected text
            string selectedText = string.Empty;
            if (index >= 0)
            {
                selectedText = listBox1.GetItemText(listBox1.Items[index]).ToString();

                //write your sql and pass the text as one parameter
                using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
                {//open DB connection
                    conn.Open();
                    string stm = "SELECT * FROM campaigns where campaignsName = @name";
                    using (SQLiteCommand cmd = new SQLiteCommand(stm, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", selectedText);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            //get the data and show it in any controls like gridview or whatever you want to do with data

                            while (reader.Read())
                            { // reader filters the campaign names from the result
                                string descStuff = reader.GetString(reader.GetOrdinal("campaignsDesc"));
                                Boolean logthing = reader.IsDBNull(3);
                                Debug.WriteLine(logthing);
                                if (!reader.IsDBNull(3))
                                {
                                    byte[] byteBLOBData = (byte[])reader["campaignsImg"];
                                    MemoryStream ms = new MemoryStream(byteBLOBData);
                                    campaignImgBox.Image = Image.FromStream(ms);
                                }
                                else
                                {
                                    campaignImgBox.Image = null;
                                }

                                // add the names to the description textbox
                                textBox1.Clear();
                                textBox1.Text = descStuff;
                            }
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void GetList()
        {// clear listbox for reloading the list
            listBox1.Items.Clear();
            //connect to database and initilize reader
            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {//open DB connection
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    //select all campaigns
                    cmd.CommandText = "SELECT * FROM campaigns";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        //reader loads in results

                        while (reader.Read())
                        { // reader filters the campaign names from the result
                            string sName = reader.GetString(reader.GetOrdinal("campaignsName"));
                            // add the names to the listbox
                            listBox1.Items.Add(sName);
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Campaign To Continue");
            }
            else
            {
                int index;
                // Get the index of the selected item
                index = listBox1.SelectedIndex;

                //get the selected text
                string selectedText = string.Empty;
                using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE campaigns SET  campaignsDesc = @desc, campaignsImg = @img WHERE campaignsName = @name ";

                        cmd.Parameters.AddWithValue("@name", listBox1.GetItemText(listBox1.Items[index]).ToString());
                        cmd.Parameters.AddWithValue("@desc", textBox1.Text);

                        Image image = campaignImgBox.Image;
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

                        conn.Open();
                        //cmd.ExecuteNonQuery();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data Updated");
                        }

                        conn.Close();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog camImage = new OpenFileDialog();
            camImage.Filter = "Choose Image(*.jpg); *.png; *.gif)|*.jpg;*.png; *.gif";
            if (camImage.ShowDialog() == DialogResult.OK)
            {
                campaignImgBox.Image = Image.FromFile(camImage.FileName);
            }
        }
    }
}