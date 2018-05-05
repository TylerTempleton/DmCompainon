using System.Data.SQLite;
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
       string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";
       
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
            
            SQLiteConnection conn = new SQLiteConnection(conn_string.ToString());
            SQLiteCommand cmd = conn.CreateCommand();

            //open DB connection
            conn.Open();
            cmd.CommandText = "UPDATE campaigns SET  campaignNotes = @note  WHERE campaignsName = @name ";
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
           SQLiteConnection conn = new SQLiteConnection(conn_string.ToString());
           SQLiteCommand cmd = conn.CreateCommand();
            SQLiteDataReader reader;

            //open DB connection
            conn.Open();
            //select notes
            cmd.CommandText = "SELECT campaignNotes FROM campaigns WHERE campaignsName = @name";
            cmd.Parameters.AddWithValue("@name", cNoteNameLabel.Text);


            //get the data and show it 
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string stuff = reader["campaignNotes"].ToString();
                noteBox.Text = reader.GetString(reader.GetOrdinal("campaignNotes"));
               
            }
            else
            {
                noteBox.Text = "";
            }
            conn.Close();

        }
    }
}
