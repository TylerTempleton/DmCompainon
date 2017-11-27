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
    public partial class Notes : Form
    {
        MySql.Data.MySqlClient.MySqlConnectionStringBuilder conn_string = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "tnt",
            Password = "tnt",
            Database = "dnd"
        };
        public void cNameLabelFill(Label cNameLabel)
        {
            cNoteNameLabel.Text = cNameLabel.Text;
        }
        public Notes()
        {
            InitializeComponent();
          
        }
       
      

        //exits form without saving notes
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //saves new notes to database
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection(conn_string.ToString());
            MySqlCommand cmd = conn.CreateCommand();

            //open DB connection
            conn.Open();
            cmd.CommandText = "UPDATE dnd.campaigns SET  campaignNotes = @note  WHERE campaignsName = @name ";
            cmd.Parameters.AddWithValue("@name", cNoteNameLabel.Text);
            cmd.Parameters.AddWithValue("@note", noteBox.Text);
            cmd.ExecuteNonQuery();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Updated");
            }

            conn.Close();
        }
        //Load old notes method
        private void Notes_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(conn_string.ToString());
            MySql.Data.MySqlClient.MySqlCommand cmd = conn.CreateCommand();
            MySql.Data.MySqlClient.MySqlDataReader reader;

            //open DB connection
            conn.Open();
            //select notes
            cmd.CommandText = "SELECT campaignNotes FROM dnd.campaigns WHERE campaignsName = @name";
            cmd.Parameters.AddWithValue("@name", cNoteNameLabel.Text);


            //get the data and show it 
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string stuff = reader["campaignNotes"].ToString();
                noteBox.Text = reader.GetString("campaignNotes");
               
            }
            else
            {
                noteBox.Text = "";
            }
            conn.Close();

        }
    }
}
