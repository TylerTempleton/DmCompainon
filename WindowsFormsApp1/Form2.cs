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
    public partial class CamSelect : Form
    {// connection string to MySql database
        MySql.Data.MySqlClient.MySqlConnectionStringBuilder conn_string = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "tnt",
            Password = "tnt",
            Database = "dnd"
        };
        public CamSelect()
        {//start up form
            InitializeComponent();
            //populate listbox
            GetList();



        }

        private void selectButton_Click(object sender, EventArgs e)
        { // instance of Main Menu form window
            MainMenu f3 = new MainMenu();
            // hide old form
            Hide();
            // show new form
            f3.Show();
        }

        private void newButton_Click(object sender, EventArgs e)
        { // instance of new campaign form window
            NewCampaign f2 = new NewCampaign();
            // hide old form
            Hide();
            // show new form
            f2.Show();
        }

        private void delButton_Click(object sender, EventArgs e)
        {// store name of list item selected
            string i = listBox1.SelectedItem.ToString();
            //set up connection to DB
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_string.ToString());
            MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
           

           
            //open DB connection
                conn.Open();
            //MySQL statment to delete based on campaign name that is paramiterized to prevent sql injection
                cmd.CommandText =( "DELETE FROM dnd.campaigns where campaignsName = @name");
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

        void CamSelect_Load(object sender, EventArgs e)
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
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_string.ToString());
                MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
                MySql.Data.MySqlClient.MySqlDataReader reader;
                //do sql stuff
                //open DB connection
                conn.Open();

                cmd.CommandText = "SELECT * FROM dnd.campaigns where campaignsName = @name";
                cmd.Parameters.AddWithValue("@name", selectedText);

                //get the data and show it in any controls like gridview or whatever you want to do with data
               
                 reader = cmd.ExecuteReader();
                while (reader.Read())
                { // reader filters the campaign names from the result
                    string descStuff = reader.GetString("campaignsDesc");
                    Boolean logthing = reader.IsDBNull(3);
                    Debug.WriteLine(logthing);
                    if (!reader.IsDBNull(3))
                    {
                        byte[] byteBLOBData = (byte[])reader["campaignsImg"];
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
        void GetList()
        {// clear listbox for reloading the list
            listBox1.Items.Clear();
            //connect to database and initilize reader
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_string.ToString());
            MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
            MySql.Data.MySqlClient.MySqlDataReader reader;

            try
            {//open DB connection
                conn.Open();
                //select all campaigns
                cmd.CommandText = "SELECT * FROM dnd.campaigns";
                //reader loads in results
                reader = cmd.ExecuteReader();
                while (reader.Read())
                { // reader filters the campaign names from the result
                    string sName = reader.GetString("campaignsName");
                    // add the names to the listbox
                    listBox1.Items.Add(sName);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
      

    }
}
    

