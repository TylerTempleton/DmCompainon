//This Window of the program is to Generate Monsters for a Random Enounter.
//The user enters the number of party members, the level of the party and difficulty and number of monster you want them to face.
//based on the entered information using the encounter calculations from the dungeon master's guide generate the EXP budget.
//Based on the exp budget and number of monsters it generated the appopriate Challenge Rating per monster and randomly selects one of that Challenge Rating
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DMCompainion
{
    public partial class RandomEncounter : Form
    {// connection string to MySql database
        private string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";
        //initalize variables
        private string monName, monSize, hitpoints, armorClass, speed, alignment, type, subtype, strength, dexterity, constitution, intelligence, wisdom, charisma, conSave, intSave, wisSave, dmgVul, dmgres, dmgImu,
         condition, senses, lang, lineString, special1, special2, special3, action1, action2, action3, action4, action5;

        private int partylvl, partysize, playersizeMulti, numMonsters, challenge_rateing;
        private double exp, perMonsterExp, baseExp, partySizeMulti, monsterMulti;

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
            exp = 0;
            //Convert party size/lvl from NumUpDown Boxes
            partylvl = Convert.ToInt32(partyLevel.Value);
            partysize = Convert.ToInt32(numberOfPlayers.Value);
            playersizeMulti = Convert.ToInt32(numberOfPlayers.Value);
            numMonsters = Convert.ToInt32(numOfMons.Value);
            perMonsterExp = 0;
            baseExp = 0;
            partySizeMulti = 0;
            monsterMulti = 0;
            challenge_rateing = 0;
            // get difficulty from box
            string difficulty = difficultyBox.Visible.ToString();

            // calculate XP by level

            ExpCalc(partylvl);

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
            //set Exp value to labels
            expValue.Text = exp.ToString();
            besxpValue.Text = baseExp.ToString();
            monsterMultiValue.Text = monsterMulti.ToString();
            partyMultiValue.Text = partySizeMulti.ToString();
            playerMultiValue.Text = playersizeMulti.ToString();
            perMonsterExp = exp / numMonsters;
            ChallegeRatingFinder(perMonsterExp);

            //console check values
            //Console.WriteLine("base exp " + baseExp.ToString());
            //Console.WriteLine("monster multi " + monsterMulti.ToString());
            //Console.WriteLine("playersize multi " + playersizeMulti.ToString());
            //Console.WriteLine("partysize multi " + partySizeMulti.ToString());
            //Console.WriteLine("exp Value " + exp.ToString());
            //Console.WriteLine("permonster Value " + perMonsterExp.ToString());
            //Console.WriteLine("Challenge rating " + challenge_rateing.ToString());
            
            
            //show EXP budget labels  for user
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
                    //cmd.CommandText = 'SELECT name, size, hit_points, armor_class, speed, alignment, type, subtype, strength, dexterity, constitution, intelligence, wisdom, charisma, constitution_save, intelligence_save, wisdom_save, damage_vulnerabilities, damage_resistances, damage_immunities, "special_abilities/0/name", "special_abilities/0/desc", "special_abilities/0/attack_bonus","special_abilities/1/name", "special_abilities/1/desc", "special_abilities/1/attack_bonus", senses, languages, "actions/0/name", "actions/0/desc","actions/0/attack_bonus","actions/1/name", "actions/1/desc","actions/1/attack_bonus","actions/2/name", "actions/2/desc","actions/2/attack_bonus", "actions/3/name", "actions/3/desc","actions/3/attack_bonus","actions/4/name", "actions/4/desc","actions/4/attack_bonus" FROM monsters   ORDER BY ABS(@challengeRateing - challenge_rating), RANDOM() LIMIT 1 ';
                    cmd.CommandText = "SELECT * FROM monsters ORDER BY ABS(@challengeRateing - challenge_rating), RANDOM() LIMIT 1";
                    cmd.Parameters.AddWithValue("@challengeRateing", challenge_rateing.ToString());
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        //Check the reader has data:
                        if (reader.Read())
                        {//add values appropiate variables
                            monName = reader.GetString(reader.GetOrdinal("name"));
                            hitpoints = reader.GetString(reader.GetOrdinal("hit_points"));
                            armorClass = reader.GetString(reader.GetOrdinal("armor_class"));
                            speed = reader.GetString(reader.GetOrdinal("speed"));
                            monSize = reader.GetString(reader.GetOrdinal("size"));
                            type = reader.GetString(reader.GetOrdinal("type"));
                            subtype = SafeGetString(reader, reader.GetOrdinal("subtype"));
                            alignment = reader.GetString(reader.GetOrdinal("alignment"));
                            strength = reader.GetString(reader.GetOrdinal("strength"));
                            dexterity = reader.GetString(reader.GetOrdinal("dexterity"));
                            constitution = reader.GetString(reader.GetOrdinal("constitution"));
                            intelligence = reader.GetString(reader.GetOrdinal("intelligence"));
                            wisdom = reader.GetString(reader.GetOrdinal("wisdom"));
                            charisma = reader.GetString(reader.GetOrdinal("charisma"));
                            conSave = "CON Save: " + SafeGetString(reader, reader.GetOrdinal("constitution_save"));
                            intSave = "INT Save: " + SafeGetString(reader, reader.GetOrdinal("intelligence_save"));
                            wisSave = "WIS Save: " + SafeGetString(reader, reader.GetOrdinal("wisdom_save"));

                            dmgVul = "Damage Vulnerabilities: " + SafeGetString(reader, reader.GetOrdinal("damage_vulnerabilities")).ToString();
                            dmgres = "Damage Resistances: " + SafeGetString(reader, reader.GetOrdinal("damage_resistence")).ToString();
                            dmgImu = "Damage Immunities " + SafeGetString(reader, reader.GetOrdinal("damage_immunities")).ToString();
                            condition = "Condition Immunities " + SafeGetString(reader, reader.GetOrdinal("condition_immunities")).ToString();
                            senses = "Senses: " + SafeGetString(reader, reader.GetOrdinal("senses")).ToString();
                            lang = "Languages:  " + SafeGetString(reader, reader.GetOrdinal("languages")).ToString();
                            special1 = SafeGetString(reader, reader.GetOrdinal("special_abilities/0/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("special_abilities/0/desc")).ToString() + SafeGetString(reader, reader.GetOrdinal("special_abilities/0/attack_bonus")).ToString();
                            special2 = SafeGetString(reader, reader.GetOrdinal("special_abilities/1/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("special_abilities/1/desc")).ToString() + SafeGetString(reader, reader.GetOrdinal("special_abilities/1/attack_bonus")).ToString();
                            special3 = SafeGetString(reader, reader.GetOrdinal("special_abilities/2/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("special_abilities/2/desc")).ToString() + SafeGetString(reader, reader.GetOrdinal("special_abilities/2/attack_bonus")).ToString();

                            action1 = SafeGetString(reader, reader.GetOrdinal("actions/0/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("actions/0/desc")).ToString();
                            action2 = SafeGetString(reader, reader.GetOrdinal("actions/1/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("actions/1/desc")).ToString();
                            action3 = SafeGetString(reader, reader.GetOrdinal("actions/2/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("actions/2/desc")).ToString();
                            action4 = SafeGetString(reader, reader.GetOrdinal("actions/3/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("actions/3/desc")).ToString();
                            action5 = SafeGetString(reader, reader.GetOrdinal("actions/4/name")).ToString() + ": " + SafeGetString(reader, reader.GetOrdinal("actions/4/desc")).ToString();
                            //call safegetstring if columnn can be null
                            //string  = reader.GetString(reader.GetOrdinal(""));

                            //add nice divider line 
                            lineString = "________________________________________________________________________________";

                           //add scrollbars to ensure users and real whole monster
                            monsterBox.ScrollBars = ScrollBars.Vertical;
                            //fill monsterbox with values from variables
                            monsterBox.Text = monName + "      " + " CR:" + challenge_rateing.ToString() + System.Environment.NewLine +
                                             monSize + "      " + type + "      " + subtype + "      " + alignment + System.Environment.NewLine +
                                             lineString + System.Environment.NewLine +
                                             " HP: " + hitpoints + "   AC:  " + armorClass + "  Speed:   " + speed + System.Environment.NewLine +
                                             lineString + System.Environment.NewLine +
                                             "STR: " + strength + "   DEX: " + dexterity + "   CON: " + constitution + "   INT: " + intelligence + "   WIS: " + wisdom + "   CHA: " + charisma + System.Environment.NewLine +
                                             lineString + System.Environment.NewLine +
                                             dmgVul + System.Environment.NewLine +
                                             dmgres + System.Environment.NewLine +
                                             dmgImu + System.Environment.NewLine +
                                             condition + System.Environment.NewLine +
                                             senses + System.Environment.NewLine +
                                             lang + System.Environment.NewLine +
                                             lineString + System.Environment.NewLine +
                                             special1 + System.Environment.NewLine +
                                             special2 + System.Environment.NewLine +
                                             special3 + System.Environment.NewLine +
                                             action1 + System.Environment.NewLine +
                                             action2 + System.Environment.NewLine +
                                             action3 + System.Environment.NewLine +
                                             action4 + System.Environment.NewLine +
                                             action5 + System.Environment.NewLine;

                            ;
                            // .Text = monName.ToString();
                        }
                    }

                    //using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    //{
                    //    DataTable table = new DataTable();
                    //    adapter.Fill(table);
                    //    dataGridView1.DataSource = new BindingSource(table, null);
                    //    conn.Close();
                    //}
                }
                conn.Close();
            }
        }
        //This Method calcualtes the EXP based on the calcualtions found in the DMG page 82
        private double ExpCalc(int partyLevel)
        {
            if (partylvl == 1)
            {
                //difficulty exp
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 25;
                        break;

                    case "Medium":
                        return exp = 50;
                        break;

                    case "Hard":
                        return exp = 75;
                        break;

                    case "Deadly":
                        return exp = 100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 2)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 50;
                        break;

                    case "Medium":
                        return exp = 100;
                        break;

                    case "Hard":
                        return exp = 150;
                        break;

                    case "Deadly":
                        return exp = 200;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 3)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 75;
                        break;

                    case "Medium":
                        return exp = 150;
                        break;

                    case "Hard":
                        return exp = 225;
                        break;

                    case "Deadly":
                        return exp = 400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 4)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 125;
                        break;

                    case "Medium":
                        return exp = 250;
                        break;

                    case "Hard":
                        return exp = 375;
                        break;

                    case "Deadly":
                        return exp = 500;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 5)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 250;
                        break;

                    case "Medium":
                        return exp = 500;
                        break;

                    case "Hard":
                        return exp = 750;
                        break;

                    case "Deadly":
                        return exp = 1100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 6)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 300;
                        break;

                    case "Medium":
                        return exp = 600;
                        break;

                    case "Hard":
                        return exp = 900;
                        break;

                    case "Deadly":
                        return exp = 1400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 7)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 350;
                        break;

                    case "Medium":
                        return exp = 750;
                        break;

                    case "Hard":
                        return exp = 1100;
                        break;

                    case "Deadly":
                        return exp = 1700;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 8)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 450;
                        break;

                    case "Medium":
                        return exp = 900;
                        break;

                    case "Hard":
                        return exp = 1400;
                        break;

                    case "Deadly":
                        return exp = 2100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 9)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 600;
                        break;

                    case "Medium":
                        return exp = 1200;
                        break;

                    case "Hard":
                        return exp = 1600;
                        break;

                    case "Deadly":
                        return exp = 2400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 10)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 600;
                        break;

                    case "Medium":
                        return exp = 1200;
                        break;

                    case "Hard":
                        return exp = 1900;
                        break;

                    case "Deadly":
                        return exp = 2800;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 11)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 800;
                        break;

                    case "Medium":
                        return exp = 1600;
                        break;

                    case "Hard":
                        return exp = 2400;
                        break;

                    case "Deadly":
                        return exp = 3600;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 12)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 1000;
                        break;

                    case "Medium":
                        return exp = 2000;
                        break;

                    case "Hard":
                        return exp = 3000;
                        break;

                    case "Deadly":
                        return exp = 4500;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 13)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 1100;
                        break;

                    case "Medium":
                        return exp = 2200;
                        break;

                    case "Hard":
                        return exp = 3400;
                        break;

                    case "Deadly":
                        return exp = 5100;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 14)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 1250;
                        break;

                    case "Medium":
                        return exp = 2500;
                        break;

                    case "Hard":
                        return exp = 3800;
                        break;

                    case "Deadly":
                        return exp = 5700;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 15)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 1400;
                        break;

                    case "Medium":
                        return exp = 2800;
                        break;

                    case "Hard":
                        return exp = 4300;
                        break;

                    case "Deadly":
                        return exp = 6400;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 16)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 1600;
                        break;

                    case "Medium":
                        return exp = 3200;
                        break;

                    case "Hard":
                        return exp = 4800;
                        break;

                    case "Deadly":
                        return exp = 7200;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 17)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 2000;
                        break;

                    case "Medium":
                        return exp = 3900;
                        break;

                    case "Hard":
                        return exp = 5900;
                        break;

                    case "Deadly":
                        return exp = 8800;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 18)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 2100;
                        break;

                    case "Medium":
                        return exp = 4200;
                        break;

                    case "Hard":
                        return exp = 6300;
                        break;

                    case "Deadly":
                        return exp = 9500;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0;
                        break;
                }
            }
            else if (partylvl == 19)
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 2400;
                        break;

                    case "Medium":
                        return exp = 4900;
                        break;

                    case "Hard":
                        return exp = 7300;
                        break;

                    case "Deadly":
                        return exp = 10900;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection."); return exp = 0; ;
                        break;
                }
            }
            else
            {
                switch (difficultyBox.Text)

                {
                    case "Easy":
                        return exp = 2800;
                        break;

                    case "Medium":
                        return exp = 5700;
                        break;

                    case "Hard":
                        return exp = 8500;
                        break;

                    case "Deadly":
                        return exp = 12700;
                        break;

                    default:
                        Console.WriteLine("Bugger, something went wrong in the difficulty selection.");
                        return exp = 0;
                        break;
                }
            }
        }
        //This Method converts EXP budget value in to Challenge rating 
        private int ChallegeRatingFinder(double perMonsterExp)
        {
            if (perMonsterExp >= 155000)
            {
                return challenge_rateing = 30;
            }
            if (perMonsterExp >= 1350000)
            {
                return challenge_rateing = 29;
            }
            if (perMonsterExp >= 120000)
            {
                return challenge_rateing = 28;
            }
            if (perMonsterExp >= 105000)
            {
                return challenge_rateing = 27;
            }
            if (perMonsterExp >= 90000)
            {
                return challenge_rateing = 26;
            }
            if (perMonsterExp >= 75000)
            {
                return challenge_rateing = 25;
            }
            if (perMonsterExp >= 62000)
            {
                return challenge_rateing = 24;
            }
            if (perMonsterExp >= 50000)
            {
                return challenge_rateing = 23;
            }
            if (perMonsterExp >= 41000)
            {
                return challenge_rateing = 22;
            }
            if (perMonsterExp >= 33000)
            {
                return challenge_rateing = 21;
            }
            if (perMonsterExp >= 25000)
            {
                return challenge_rateing = 20;
            }
            if (perMonsterExp >= 22000)
            {
                return challenge_rateing = 19;
            }
            if (perMonsterExp >= 20000)
            {
                return challenge_rateing = 18;
            }
            if (perMonsterExp >= 18000)
            {
                return challenge_rateing = 17;
            }
            if (perMonsterExp >= 15000)
            {
                return challenge_rateing = 16;
            }
            if (perMonsterExp >= 13000)
            {
                return challenge_rateing = 15;
            }
            if (perMonsterExp >= 11500)
            {
                return challenge_rateing = 14;
            }
            if (perMonsterExp >= 10000)
            {
                return challenge_rateing = 13;
            }

            if (perMonsterExp >= 8400)
            {
                return challenge_rateing = 12;
            }
            if (perMonsterExp >= 7200)
            {
                return challenge_rateing = 11;
            }
            if (perMonsterExp >= 5900)
            {
                return challenge_rateing = 10;
            }
            if (perMonsterExp >= 5000)
            {
                return challenge_rateing = 9;
            }
            if (perMonsterExp >= 3900)
            {
                return challenge_rateing = 8;
            }
            if (perMonsterExp >= 2900)
            {
                return challenge_rateing = 7;
            }
            if (perMonsterExp >= 2300)
            {
                return challenge_rateing = 6;
            }
            if (perMonsterExp >= 1800)
            {
                return challenge_rateing = 5;
            }
            if (perMonsterExp >= 1100)
            {
                return challenge_rateing = 4;
            }
            if (perMonsterExp >= 700)
            {
                return challenge_rateing = 3;
            }
            if (perMonsterExp >= 450)
            {
                return challenge_rateing = 2;
            }
            if (perMonsterExp >= 200)
            {
                return challenge_rateing = 1;
            }
            if (perMonsterExp >= 100)
            {
                return challenge_rateing = 1 / 2;
            }
            if (perMonsterExp >= 50)
            {
                return challenge_rateing = 1 / 4;
            }
            if (perMonsterExp >= 25)
            {
                return challenge_rateing = 1 / 8;
            }
            if (perMonsterExp >= 10)
            {
                return challenge_rateing = 0;
            }
            else
            {
                MessageBox.Show("something went wrong");
                return challenge_rateing = 30;
            }
        }
        //Checks value for a value if its null then returns a empty string to prevent issues in sql return values
        public string SafeGetString(SQLiteDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetString(colIndex);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}