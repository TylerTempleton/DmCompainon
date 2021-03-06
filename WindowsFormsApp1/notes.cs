﻿using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Notes : Form
    {
        private string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

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
            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {  //open DB connection
                conn.Open();
                string stm = "UPDATE campaigns SET  campaignNotes = @note  WHERE campaignsName = @name ";
                using (SQLiteCommand cmd = new SQLiteCommand(stm, conn))
                {
                    cmd.Parameters.AddWithValue("@name", cNoteNameLabel.Text);
                    cmd.Parameters.AddWithValue("@note", noteBox.Text);
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Updated");
                    }

                    conn.Close();
                }
            }
        }

        //Load old notes method
        private void Notes_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {//open DB connection
                conn.Open();
                string stm = "SELECT campaignNotes FROM campaigns WHERE campaignsName = @name";
                using (SQLiteCommand cmd = new SQLiteCommand(stm, conn))
                { //select notes
                    cmd.Parameters.AddWithValue("@name", cNoteNameLabel.Text);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //get the data and show it
                            // boolean to see if notes are null
                            Boolean logthing = reader.IsDBNull(5);
                            Debug.WriteLine(logthing);

                            if (reader.IsDBNull(5))
                            {
                                string stuff = reader["campaignNotes"].ToString();

                                noteBox.Text = reader.GetString(reader.GetOrdinal("campaignNotes"));
                            }
                            else
                            {
                                noteBox.Text = "";
                            }
                        }
                        conn.Close();
                    }
                }
            }
        }
    }
}