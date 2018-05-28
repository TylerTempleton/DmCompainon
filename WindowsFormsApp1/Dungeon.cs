using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dungeons : Form
    {// connection string to MySql database
        MySql.Data.MySqlClient.MySqlConnectionStringBuilder conn_string = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "tnt",
            Password = "tnt",
            Database = "dnd"
        };
        public Dungeons()
        {//start up form
            InitializeComponent();
            //populate listbox
            getList();
        }
        public delegate void delPassData(Label label);



        public delegate void cNamePass(ListBox listbox);
        public void cNameLabelFill(Label cNameLabel)
        {
            cDungeonLabel.Text = cNameLabel.Text;
        }

        void getList()
        {// clear listbox for reloading the list
            dungeonList.Items.Clear();
            //connect to database and initilize reader
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_string.ToString());
            MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
            MySql.Data.MySqlClient.MySqlDataReader reader;

            try
            {//open DB connection
                conn.Open();
                //select all campaigns
                cmd.CommandText = "SELECT * FROM dnd.dungeons WHERE campaignName = @name";
                cmd.Parameters.AddWithValue("@name", cDungeonLabel.Text);
                //reader loads in results
                reader = cmd.ExecuteReader();
                while (reader.Read())
                { // reader filters the campaign names from the result
                    string sName = reader.GetString("dungeonsName");
                    // add the names to the listbox
                    dungeonList.Items.Add(sName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The variable that will keep the index of the selected item
            int index;
            // Get the index of the selected item
            index = dungeonList.SelectedIndex;

            //get the selected text
            string selectedText = string.Empty;
            if (index >= 0)
            {
                selectedText = dungeonList.GetItemText(dungeonList.Items[index]).ToString();


                //write your sql and pass the text as one parameter
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_string.ToString());
                MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
                MySql.Data.MySqlClient.MySqlDataReader reader;
                //do sql stuff
                //open DB connection
                conn.Open();

                cmd.CommandText = "SELECT * FROM dnd.dungeons where dungeonsName = @name";
                cmd.Parameters.AddWithValue("@name", selectedText);

                //get the data and show it in any controls like gridview or whatever you want to do with data

                reader = cmd.ExecuteReader();
                while (reader.Read())
                { // reader filters the campaign names from the result
                    string descStuff = reader.GetString("dungeonsDesc");
                    Boolean logthing = reader.IsDBNull(3);
                    Debug.WriteLine(logthing);
                    if (!reader.IsDBNull(3))
                    {
                        byte[] byteBLOBData = (byte[])reader["dungeonsMap"];
                        MemoryStream ms = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    else
                    {



                        pictureBox1.Image = null;
                    }


                    // add the names to the description textbox
                    textBox1.Clear();
                    textBox1.Text = descStuff;


                }

            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }

        private void newDungeonButton_Click(object sender, EventArgs e)
        {//pass dungeon name
            NewDungeon f1 = new NewDungeon();
            delPassData del = new delPassData(f1.getLabel);
            del(this.cDungeonLabel);
            Hide();
            f1.Show();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dungeons_Load(object sender, EventArgs e)
        {
            getList();
        }
    }
}
