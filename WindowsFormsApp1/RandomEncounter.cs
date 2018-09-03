using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RandomEncounter : Form
    {// connection string to MySql database
        private string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

        public RandomEncounter()
        {
            InitializeComponent();
        }

        public void cNameLabelFill(Label cNameLabel)
        {//pass campign name
            cWMNameLabel.Text = cNameLabel.Text;
        }

        // encounter generation button
        private void encounterButton_Click(object sender, EventArgs e)
        {// intilize exp, partysize and party level
            double exp = 0;
            //Convert party size/lvl from NumUpDown Boxes
            int partylvl = Convert.ToInt32(partyLevel.Value);
            int partysize = Convert.ToInt32(numberOfPlayers.Value);
            int playersizeMulti = Convert.ToInt32(numberOfPlayers.Value);
            int numMonsters = Convert.ToInt32(numOfMons.Value);
            double perMonsterExp = 0;
            double baseExp = 0;
            double partySizeMulti = 0;
            double monsterMulti = 0;
            int challenge_rateing = 0;
            // get difficulty from box
            string difficulty = difficultyBox.Visible.ToString();

            // calculate XP by level

            if (partylvl == 1)
            {
                //difficulty exp
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 25;
                        break;

                    case "Medium":
                        exp = 50;
                        break;

                    case "Hard":
                        exp = 75;
                        break;

                    case "Deadly":
                        exp = 100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 2)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 50;
                        break;

                    case "Medium":
                        exp = 100;
                        break;

                    case "Hard":
                        exp = 150;
                        break;

                    case "Deadly":
                        exp = 200;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 3)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 75;
                        break;

                    case "Medium":
                        exp = 150;
                        break;

                    case "Hard":
                        exp = 225;
                        break;

                    case "Deadly":
                        exp = 400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 4)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 125;
                        break;

                    case "Medium":
                        exp = 250;
                        break;

                    case "Hard":
                        exp = 375;
                        break;

                    case "Deadly":
                        exp = 500;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 5)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 250;
                        break;

                    case "Medium":
                        exp = 500;
                        break;

                    case "Hard":
                        exp = 750;
                        break;

                    case "Deadly":
                        exp = 1100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 6)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 300;
                        break;

                    case "Medium":
                        exp = 600;
                        break;

                    case "Hard":
                        exp = 900;
                        break;

                    case "Deadly":
                        exp = 1400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 7)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 350;
                        break;

                    case "Medium":
                        exp = 750;
                        break;

                    case "Hard":
                        exp = 1100;
                        break;

                    case "Deadly":
                        exp = 1700;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 8)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 450;
                        break;

                    case "Medium":
                        exp = 900;
                        break;

                    case "Hard":
                        exp = 1400;
                        break;

                    case "Deadly":
                        exp = 2100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 9)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 600;
                        break;

                    case "Medium":
                        exp = 1200;
                        break;

                    case "Hard":
                        exp = 1600;
                        break;

                    case "Deadly":
                        exp = 2400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 10)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 600;
                        break;

                    case "Medium":
                        exp = 1200;
                        break;

                    case "Hard":
                        exp = 1900;
                        break;

                    case "Deadly":
                        exp = 2800;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 11)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 800;
                        break;

                    case "Medium":
                        exp = 1600;
                        break;

                    case "Hard":
                        exp = 2400;
                        break;

                    case "Deadly":
                        exp = 3600;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 12)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 1000;
                        break;

                    case "Medium":
                        exp = 2000;
                        break;

                    case "Hard":
                        exp = 3000;
                        break;

                    case "Deadly":
                        exp = 4500;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 13)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 1100;
                        break;

                    case "Medium":
                        exp = 2200;
                        break;

                    case "Hard":
                        exp = 3400;
                        break;

                    case "Deadly":
                        exp = 5100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 14)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 1250;
                        break;

                    case "Medium":
                        exp = 2500;
                        break;

                    case "Hard":
                        exp = 3800;
                        break;

                    case "Deadly":
                        exp = 5700;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 15)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 1400;
                        break;

                    case "Medium":
                        exp = 2800;
                        break;

                    case "Hard":
                        exp = 4300;
                        break;

                    case "Deadly":
                        exp = 6400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 16)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 1600;
                        break;

                    case "Medium":
                        exp = 3200;
                        break;

                    case "Hard":
                        exp = 4800;
                        break;

                    case "Deadly":
                        exp = 7200;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 17)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 2000;
                        break;

                    case "Medium":
                        exp = 3900;
                        break;

                    case "Hard":
                        exp = 5900;
                        break;

                    case "Deadly":
                        exp = 8800;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 18)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 2100;
                        break;

                    case "Medium":
                        exp = 4200;
                        break;

                    case "Hard":
                        exp = 6300;
                        break;

                    case "Deadly":
                        exp = 9500;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else if (partylvl == 19)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 2400;
                        break;

                    case "Medium":
                        exp = 4900;
                        break;

                    case "Hard":
                        exp = 7300;
                        break;

                    case "Deadly":
                        exp = 10900;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            else
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        exp = 2800;
                        break;

                    case "Medium":
                        exp = 5700;
                        break;

                    case "Hard":
                        exp = 8500;
                        break;

                    case "Deadly":
                        exp = 12700;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        break;
                }
            }
            //assign base exp to exp before multipliers
            baseExp = exp;
            //Encounter Multipliers

            if (numMonsters == 2)
            {
                exp = Math.Round(exp * 1.5, 0);
                monsterMulti = 1.5;
            }
            if (numMonsters >= 3 && numMonsters < 7)
            {
                exp = Math.Round(exp * 2, 0);
                monsterMulti = 2;
            }
            if (numMonsters >= 7 && numMonsters < 11)
            {
                exp = Math.Round(exp * 2.5, 0);
                monsterMulti = 2.5;
            }
            if (numMonsters >= 11 && numMonsters < 15)
            {
                exp = Math.Round(exp * 3, 0);
                monsterMulti = 3;
            }
            if (numMonsters >= 15)
            {
                if (partysize > 5)
                {
                    exp = Math.Round(exp * 5, 0);
                    monsterMulti = 5;
                }
                else
                    exp = Math.Round(exp * 4, 0);
                monsterMulti = 4;
            }

            // Partysize Modifiers
            exp = exp * partysize;
            if (partysize < 3)
            {
                exp = exp * 1.5;
                partySizeMulti = 1.5;
            }
            if (partysize > 5)
            {
                exp = exp * 0.5;
                partySizeMulti = 0.5;
            }
            //set Exp value and show Exp to user
            expValue.Text = exp.ToString();
            besxpValue.Text = baseExp.ToString();
            monsterMultiValue.Text = monsterMulti.ToString();
            partyMultiValue.Text = partySizeMulti.ToString();
            playerMultiValue.Text = playersizeMulti.ToString();
            perMonsterExp = exp / numMonsters;
            if (perMonsterExp >= 10 ) {
                challenge_rateing = 0;
            }
            if (perMonsterExp >= 25) {
                challenge_rateing = 1/8;
            }
            if (perMonsterExp >=50)
            {
                challenge_rateing =1/4 ;
            }
            if (perMonsterExp >= 100)
            {
                challenge_rateing = 1/2;
            }
            if (perMonsterExp >=200)
            {
                challenge_rateing = 1;
            }
            //console check values
            Console.WriteLine("base exp " + baseExp.ToString());
            Console.WriteLine("monster multi " + monsterMulti.ToString());
            Console.WriteLine("playersize multi " + playersizeMulti.ToString());
            Console.WriteLine("partysize multi " + partySizeMulti.ToString());
            Console.WriteLine("exp Value " + exp.ToString());
            Console.WriteLine("permonster Value " + perMonsterExp.ToString());
            Console.WriteLine("Challenge rating " + challenge_rateing.ToString());

            bexpLabel.Visible = true;
            besxpValue.Visible = true;
            playerMultiLabel.Visible = true;
            playerMultiValue.Visible = true;
            monMultiLabel.Visible = true;
            monsterMultiValue.Visible = true;
            partyMultiLabel.Visible = true;
            partyMultiValue.Visible = true;
            expLabel.Visible = true;
            expValue.Visible = true;
            lineBar.Visible = true;
            // generate an encounter with monster table
            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {//open DB connection
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    //select all monsters, find monsters closest by challenge rating and randomly select one
                    cmd.CommandText = "SELECT name, challenge_rating, hit_points, armor_class   FROM monsters   ORDER BY ABS(@challengeRateing - challenge_rating), RANDOM() LIMIT 1 ";

                    cmd.Parameters.AddWithValue("@challengeRateing", challenge_rateing.ToString());
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = new BindingSource(table,null);
                        conn.Close();
                    }
                }
            }
        }
    }
}