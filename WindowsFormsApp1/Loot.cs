//This Window's purpose it to allow the user to generate rewards usuallly referenced as loot.
//The user enters the Level of the party/ encounter's challenge rateing to generate an appropiate amount of money, gems, art, and magic items
//The rewards are based on the Dungeon Masters Guide Treasure Tables found on Page 136 - 139
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DMCompainion
{
    public partial class Loot : Form
    {// initalize variables
        private string lootType;
        private string treasure, challengeRating;
        private int randomNumber, dice;
        private Random random = new Random();

        //connection string to Database
        private string conn_string = "data source = C:\\Users\\TNT\\Source\\Repos\\DmCompainon\\dndDatabase.db";

        private string lootName, lootDesc, lootValue, lootWeight, lootRarity, lootCat, lootProp, lootReq;

        public Loot()
        {
            InitializeComponent();
        }

        //passing of the Campign Name to the loot generator window (nostly here incase we add a saving to indiviual campign profile)
        //  public void cNameLabelFill(Label cNameLabel)
        //   {
        //      cWMNameLabel.Text = cNameLabel.Text;
        //  }

        //method of when generate loot button is pressed
        private void LootGenButton_Click(object sender, EventArgs e)
        {  //clear box of previous text
            treasureBox.Clear();
            treasure = null;
            // get values from dropdown boxes
            lootType = (treasureTypeBox.Text);
            challengeRating = (crValueBox.Text);

            //Console.Write(lootType);

            //check what the user has selected from the drop down
            if (lootType == "Individual Treasure" && challengeRating != "-Select CR-")
            {
                GenerateBasicTreasure(challengeRating);
            }
            else if (lootType == "Treasure Hoard" && challengeRating != "-Select CR-")
            {
                GenerateTreasureHoard(challengeRating);
            }
            else if (lootType == "One Loot Table to Rule Them All")
            {
                GenerateOLTtRTA();
            }
            //if the user doesnt get the correct inputs tell them to do so
            else
            {
                MessageBox.Show("Please Ensure All Required Options Have Been Selected");
            }
            //apply treasure text to the text box via TreasureLabelfill method and give scroll bars to text box
            treasureBox.ScrollBars = ScrollBars.Vertical;
            TreasureLabelFill(treasure);
        }

        private void treasureBox_TextChanged(object sender, EventArgs e)
        {
        }

        //method to get basic small amount of money loot based on level/challenge rateing
        private string GenerateBasicTreasure(object selectedValue)
        {//roll a d100 to determine tier of loot
            randomNumber = DiceRoll(100);
            //Result Checker
            Console.WriteLine(randomNumber);
            //low level CR loot
            if (challengeRating == "0-4")
            {
                if (randomNumber <= 30)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6));
                    treasure = dice.ToString() + " Copper Pieces";
                    return treasure;
                }
                if (randomNumber <= 60)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6));
                    treasure = dice.ToString() + " Silver Pieces";
                    return treasure;
                }

                if (randomNumber <= 70)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6));
                    treasure = dice.ToString() + " Electrum Pieces";
                    return treasure;
                }
                if (randomNumber <= 95)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6));
                    treasure = dice.ToString() + " Gold Pieces";
                    return treasure;
                }
                if (randomNumber <= 100)
                {
                    dice = DiceRoll(6);
                    treasure = dice.ToString() + " Platium Pieces";
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 " +
                        "";
                }
            }
            //low-moderate  loot
            if (challengeRating == "5-10")
            {
                if (randomNumber <= 30)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 100);
                    treasure = dice.ToString() + " Copper Pieces, ";
                    dice = (DiceRoll(6) * 10);
                    treasure = treasure + dice.ToString() + " Electrum pieces";
                    return treasure;
                }
                if (randomNumber <= 60)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) + DiceRoll(6) * 10);
                    treasure = dice.ToString() + " Silver Pieces";
                    dice = ((DiceRoll(6) + DiceRoll(6)) * 10);
                    treasure = treasure + dice.ToString() + " Gold pieces";
                    return treasure;
                }

                if (randomNumber <= 70)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) + DiceRoll(6) * 10);
                    treasure = dice.ToString() + " Silver Pieces";
                    dice = ((DiceRoll(6) + DiceRoll(6)) * 10);
                    treasure = treasure + dice.ToString() + " Gold pieces";
                    return treasure;
                }
                if (randomNumber <= 95)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 10);
                    treasure = dice.ToString() + " Gold Pieces";
                    return treasure;
                }
                if (randomNumber <= 100)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6)) * 10);
                    treasure = dice.ToString() + " Gold Pieces";
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice.ToString() + " Platinum pieces";
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                }
            }
            //moderate-high loot
            if (challengeRating == "11-16")
            {
                if (randomNumber <= 20)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) * 100);
                    treasure = dice.ToString() + " Silver Pieces, ";
                    dice = (DiceRoll(6) * 10);
                    treasure = treasure + dice.ToString() + " Electrum Pieces ";
                    return treasure;
                }
                if (randomNumber <= 35)
                {
                    dice = (DiceRoll(6) * 100);
                    treasure = dice.ToString() + " Electrum Pieces, ";
                    dice = (DiceRoll(6) * 100);
                    treasure = treasure + dice.ToString() + " Gold Pieces ";
                    return treasure;
                }

                if (randomNumber <= 75)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) * 100);
                    treasure = dice.ToString() + " Gold Pieces, ";
                    dice = (DiceRoll(6) * 10);
                    treasure = treasure + dice.ToString() + " Platinum Pieces ";
                    return treasure;
                }

                if (randomNumber <= 100)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) * 100);
                    treasure = dice.ToString() + " Gold Pieces, ";
                    dice = (DiceRoll(6) + DiceRoll(6) * 10);
                    treasure = treasure + dice.ToString() + " Platinum Pieces ";
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                }
            }
            // high - epic loot
            if (challengeRating == "17+")
            {
                if (randomNumber <= 15)
                {
                    dice = (DiceRoll(6) + DiceRoll(6) * 1000);
                    treasure = dice.ToString() + " Electrum Pieces, ";
                    dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) * 100);
                    treasure = treasure + dice.ToString() + " Gold Pieces ";
                    return treasure;
                }
                if (randomNumber <= 55)
                {
                    dice = (DiceRoll(6) * 1000);
                    treasure = dice.ToString() + " Gold Pieces, ";
                    dice = (DiceRoll(6) + DiceRoll(6) * 10);
                    treasure = treasure + dice.ToString() + " Platinum Pieces ";
                    return treasure;
                }

                if (randomNumber <= 100)
                {
                    dice = (DiceRoll(6) * 1000);
                    treasure = dice.ToString() + " Gold Pieces, ";
                    dice = (DiceRoll(6) + DiceRoll(6) * 100);
                    treasure = treasure + dice.ToString() + " Platinum Pieces ";
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                }
            }
            //catch all if somehow the value isn't between 1-100
            else
            {
                return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
            }
        }

        //Method generates large chunk of treasure in the form of money, gems, art and magic items
        private string GenerateTreasureHoard(object selectedValue)
        {
            randomNumber = DiceRoll(100);
            Console.WriteLine(randomNumber);
            if (challengeRating == "0-4")
            {//generates baseline amount of money for the 0-4 tier
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 100);
                treasure = dice.ToString() + " Copper Pieces, ";
                dice = (DiceRoll(6) + DiceRoll(6) + DiceRoll(6) * 100);
                treasure = treasure + dice.ToString() + " Silver pieces,  ";
                dice = (DiceRoll(6) + DiceRoll(6) * 10);
                treasure = treasure + dice.ToString() + " Gold pieces  ";
                treasure = treasure + System.Environment.NewLine + "And" + System.Environment.NewLine;

                if (randomNumber <= 6)
                {
                    treasure = treasure + " Nothing Else ";

                    return treasure;
                }
                if (randomNumber <= 16)
                {
                    dice = DiceRoll(6) + DiceRoll(6);
                    treasure = treasure + dice + " 10 GP Gems ";
                    return treasure;
                }
                if (randomNumber <= 26)
                {
                    dice = DiceRoll(4) + DiceRoll(4);
                    treasure = treasure + dice + " 25 GP Works of Art ";

                    return treasure;
                }
                if (randomNumber <= 36)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  50 GP Gems";
                    return treasure;
                }
                if (randomNumber <= 44)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  10 GP Gems";
                    dice = DiceRoll(6);
                    MagicTableA(dice);

                    return treasure;
                }
                if (randomNumber <= 52)
                {
                    dice = (DiceRoll(4) + DiceRoll(4));
                    treasure = treasure + dice + "  25 GP Art Objects";
                    dice = DiceRoll(6);
                    MagicTableA(dice);
                    return treasure;
                }
                if (randomNumber <= 60)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  50 GP Gems";
                    dice = DiceRoll(6);
                    MagicTableA(dice);
                    return treasure;
                }
                if (randomNumber <= 65)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  10 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableB(dice);
                    return treasure;
                }
                if (randomNumber <= 70)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  25 GP Art";
                    dice = DiceRoll(4);
                    MagicTableB(dice);
                    return treasure;
                }
                if (randomNumber <= 75)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  50 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableB(dice);
                    return treasure;
                }
                if (randomNumber <= 78)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  10 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                if (randomNumber <= 80)
                {
                    dice = (DiceRoll(4) + DiceRoll(4));
                    treasure = treasure + dice + "  25 GP Art";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                if (randomNumber <= 85)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  50 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableC(dice);

                    return treasure;
                }
                if (randomNumber <= 92)
                {
                    dice = (DiceRoll(4) + DiceRoll(4));
                    treasure = treasure + dice + "  25 GP Art";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                if (randomNumber <= 97)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  50 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                if (randomNumber <= 99)
                {
                    dice = (DiceRoll(4) + DiceRoll(4));
                    treasure = treasure + dice + "  25 GP Art";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                if (randomNumber == 100)
                {
                    dice = (DiceRoll(6) + DiceRoll(6));
                    treasure = treasure + dice + "  50 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                }
            }
            if (challengeRating == "5-10")
            {//generates baseline amount of money for the 5-10 tier
                dice = ((DiceRoll(6) + DiceRoll(6)) * 100);
                treasure = dice.ToString() + " Copper Pieces, ";
                dice = ((DiceRoll(6) + DiceRoll(6)) * 100);
                treasure = treasure + dice.ToString() + " Silver pieces,  ";
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 100);
                treasure = treasure + dice.ToString() + " Gold pieces  ";
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 10);
                treasure = treasure + dice.ToString() + " Platinum pieces,  ";
                treasure = treasure + System.Environment.NewLine + "And" + System.Environment.NewLine;
                if (randomNumber <= 4)
                {
                    treasure = treasure + "Nothing Else";
                    return treasure;
                }
                if (randomNumber <= 28)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)));
                    treasure = treasure + dice.ToString() + "  100 GP Gems";
                    return treasure;
                }

                if (randomNumber <= 44)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)));
                    treasure = treasure + dice.ToString() + "  250 GP Art";
                    dice = DiceRoll(4);
                    MagicTableA(dice);
                    return treasure;
                }
                if (randomNumber <= 63)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 2);
                    treasure = treasure + dice.ToString() + "  100 GP Gems";
                    dice = DiceRoll(4);
                    MagicTableB(dice);
                    return treasure;
                }
                if (randomNumber <= 100)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)));
                    treasure = treasure + dice.ToString() + "  250 GP Art";
                    dice = DiceRoll(4);
                    MagicTableC(dice);
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                }
            }
            if (challengeRating == "11-16")
            {//generates baseline amount of money for the 11-16 tier
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) + DiceRoll(6) * 1000);
                treasure = treasure + dice.ToString() + " Gold pieces,  ";
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) + DiceRoll(6) + DiceRoll(6) * 100);
                treasure = treasure + dice.ToString() + " Platinum pieces ";
                treasure = treasure + System.Environment.NewLine + "And" + System.Environment.NewLine;
                if (randomNumber <= 3)
                {
                    treasure = treasure + " Nothing Else";
                    return treasure;
                }

                if (randomNumber <= 15)
                {
                    dice = (DiceRoll(4) + DiceRoll(4) + DiceRoll(4));
                    treasure = treasure + dice.ToString() + " 500 GP Gems";
                    return treasure;
                }
                if (randomNumber <= 29)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 1000);
                    treasure = treasure + dice.ToString() + " Gold pieces,  ";
                    treasure = treasure + (MagicTableA(DiceRoll(4))) + (MagicTableB(DiceRoll(6)));
                    return treasure;
                }
                if (randomNumber <= 50)
                {
                    dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 750);
                    treasure = treasure + dice.ToString() + " Gold Pieces,   ";
                    treasure = treasure + MagicTableC(DiceRoll(6));

                    return treasure;
                }
                if (randomNumber <= 66)
                {
                    return treasure;
                }
                if (randomNumber <= 74)
                {
                    return treasure;
                }
                if (randomNumber <= 82)
                {
                    return treasure;
                }
                if (randomNumber <= 92)
                {
                    return treasure;
                }
                if (randomNumber <= 100)
                {
                    return treasure;
                }
                else
                {
                    return treasure + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                }
            }
            if (challengeRating == "17")
            {//generates baseline amount of money for the 17+ tier
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) * 1000);
                treasure = treasure + dice.ToString() + " Gold pieces,  ";
                dice = ((DiceRoll(6) + DiceRoll(6) + DiceRoll(6)) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) + DiceRoll(6) * 100);
                treasure = treasure + dice.ToString() + " Platinum pieces ";
                treasure = treasure + System.Environment.NewLine + "And" + System.Environment.NewLine;

                if (randomNumber <= 2)
                {
                    treasure = treasure + "Nothing Else ";
                    return treasure;
                }
                if (randomNumber >= 60)
                {
                    return treasure;
                }

                if (randomNumber >= 70)
                {
                    return treasure;
                }
                if (randomNumber >= 95)
                {
                    return treasure;
                }
                if (randomNumber >= 100)
                {
                    return treasure;
                }
                else
                {
                    treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR DICEROLL VALUE NOT BETWEEN 1 - 100 ";
                    return treasure;
                }
            }
            // Catch all for values outside of 1-100
            else
            {
                treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR RANDOMNUMBER VALUE NOT BETWEEN 1 - 100 ";
                return treasure;
            }
        }
        //Generates  magic loot times the number of times rolled on dice
        private string MagicTableE(int dice)

        {
            Console.WriteLine("dice value: " + dice);
            //repeat method equal to number rolled on the dice
            for (int i = 0; i < dice; i++)

            {
                
                int tableroll = DiceRoll(100);

                if (tableroll <= 30)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll(8th LVL) ";
                    
                }
                else if (tableroll <= 55)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Storm Giant's Strength ";
                    
                }
                else if (tableroll <= 70)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Supreme Healing ";
                    
                }
                else if (tableroll <= 85)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (9th LVL) ";
                    
                }
                else if (tableroll <= 93)
                {
                    treasure = treasure + System.Environment.NewLine + "  Universal Solvent ";
                    
                }
                else if (tableroll <= 98)
                {
                    treasure = treasure + System.Environment.NewLine + "  Arrow of Slaying ";
                    
                }
               else  if (tableroll <= 100)
                {
                    treasure = treasure + System.Environment.NewLine + "  Sovereign Glue ";
                    
                }
                else
                {
                    treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR TABLEROLL VALUE NOT BETWEEN 1 - 100 ";
                    return treasure;
                }
            }
            //return treasures generated to treasureBox
            return treasure;
        }
        //Generates  magic loot times the number of times rolled on dice
        private string MagicTableD(int dice)
        {//repeat method equal to number rolled on the dice
            Console.WriteLine("dice value: " + dice);
            for (int i = 0; i < dice; i++)

            {
               
                int tableroll = DiceRoll(100);
                if (tableroll <= 98)
                {
                    treasure = treasure + System.Environment.NewLine + "  Nolzuf's Marvelous Pigments ";
                    
                }
                else if (tableroll <= 95)
                {
                    treasure = treasure + System.Environment.NewLine + "  Horseshoes of a Zephyr ";
                    
                }
                else if (tableroll <= 92)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (8th LVL) ";
                    
                }

                else if (tableroll <= 87)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Vitality ";
                    
                }
                else if (tableroll <= 82)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Longevity ";
                    
                }
                else if (tableroll <= 77)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Cloud Giant's Strength  ";
                    
                }

                else if (tableroll <= 72)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Flying ";
                    
                }
                else if (tableroll <= 67)
                {
                    treasure = treasure + System.Environment.NewLine + "  Oil of Sharpness ";
                    
                }
                else if (tableroll <= 62)
                {
                    treasure = treasure + System.Environment.NewLine + "  Ammunition +3 ";
                    
                }
                else if (tableroll <= 57)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (7th LVL) ";
                    
                }
                else if (tableroll <= 50)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (6th LVL) ";
                    
                }
                else if (tableroll <= 40)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Speed ";
                    
                }
                else if (tableroll <= 30)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Invisibility ";
                    
                }
                else if (tableroll <= 20)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Supreme Healing ";
                    
                }
                else if (tableroll == 99)
                {
                    treasure = treasure + System.Environment.NewLine + "  Bag of Devouring ";
                    return treasure;
                }
                else if (tableroll == 100)
                {
                    treasure = treasure + System.Environment.NewLine + "  Portable Hole ";
                    return treasure;
                }
                else
                {
                    treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR TABLEROLL VALUE NOT BETWEEN 1 - 100 ";
                    return treasure;
                }
            }
            //return treasures generated to treasureBox
            return treasure;
        }

        //Generates  magic loot times the number of times rolled on dice
        private string MagicTableC(int dice)
        {//repeat method equal to number rolled on the dice
            Console.WriteLine("dice value: " + dice);
            for (int i = 0; i < dice; i++)
            {

                int tableroll = DiceRoll(100);

                
                if (tableroll <= 22)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll(lvl 4)";
                    
                }
                else if (tableroll <= 27)
                {
                    treasure = treasure + System.Environment.NewLine + "  Ammunition +2";
                    
                }
                else if (tableroll <= 32)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Clairvoyance";
                    
                }
                else if (tableroll <= 37)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Diminution ";
                    
                }
                else if (tableroll <= 42)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Gaseous Form";
                    
                }
                else if (tableroll <= 47)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Frost Giant Strength";
                    
                }
                else if (tableroll <= 52)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Stone Giant Strength";
                    
                }
                else if (tableroll <= 57)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Heroism";
                    
                }
                else if (tableroll <= 62)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Invulnerability";
                    
                }
                else if (tableroll <= 67)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Mind Reading ";
                    
                }
                else if (tableroll <= 72)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (5th Lvl) ";
                    
                }
                else if (tableroll <= 75)
                {
                    treasure = treasure + System.Environment.NewLine + "  Elixir of Health ";
                    
                }
                else if (tableroll <= 78)
                {
                    treasure = treasure + System.Environment.NewLine + "  Oil of Etherealness ";
                    
                }
                else if (tableroll <= 81)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Fire Giant Strength ";
                    
                }
                else if (tableroll <= 84)
                {
                    treasure = treasure + System.Environment.NewLine + "  Quaal's Feather Token ";
                    
                }
                else if (tableroll <= 87)
                {
                    treasure = treasure + System.Environment.NewLine + " Scroll of Protection  ";
                    
                }
                else if (tableroll <= 89)
                {
                    treasure = treasure + System.Environment.NewLine + "  Bag of Beans ";
                    
                }
                else if (tableroll <= 91)
                {
                    treasure = treasure + System.Environment.NewLine + "  Bead of Force ";
                    
                }
                else if (tableroll <= 15)
                {
                   
                    treasure = treasure + System.Environment.NewLine + "  Potion of Superior Healing";
                    
                }
                else if (tableroll == 92)
                {
                    treasure = treasure + System.Environment.NewLine + "  Chime of Opening ";
                    
                }
                else if (tableroll == 93)
                {
                    treasure = treasure + System.Environment.NewLine + "  Decanter of Endless Water ";
                    
                }
                else if (tableroll == 94)
                {
                    treasure = treasure + System.Environment.NewLine + "  Eyes of Minute Seeing ";
                    
                }
                else if (tableroll == 95)
                {
                    treasure = treasure + System.Environment.NewLine + "  Folding Ship ";
                    
                }
                else if (tableroll == 96)
                {
                    treasure = treasure + System.Environment.NewLine + "  Heward's Handy Havershack ";
                    
                }
                else if (tableroll == 97)
                {
                    treasure = treasure + System.Environment.NewLine + " Horseshoes of Speed ";
                    
                }
                else if (tableroll == 98)
                {
                    treasure = treasure + System.Environment.NewLine + " Necklace of Fireballs ";
                    
                }
                else if (tableroll == 99)
                {
                    treasure = treasure + System.Environment.NewLine + " Periapt of Health ";
                    
                }
                else if (tableroll == 100)
                {
                    treasure = treasure + System.Environment.NewLine + " Sending Stones ";
                    
                }
                else
                {
                    treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR TABLEROLL VALUE NOT BETWEEN 1 - 100 ";
                    
                }
            }
            //return treasures generated to treasureBox
            return treasure;
        }

        //Generate magic  loot times the number of times rolled on dice
        private string MagicTableB(int dice)
        {
            Console.WriteLine("dice value: " + dice);
            for (int i = 0; i < dice; i++)
            {
                
                int tableroll = DiceRoll(100);

                if (tableroll <= 15)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Greater Healing";
                    
                }
                else if (tableroll <= 22)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Fire Breathing)";
                   
                }
                else if (tableroll <= 29)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Resistance";
                   
                }
                else if (tableroll <= 34)
                {
                    treasure = treasure + System.Environment.NewLine + "  Ammunition +1";
                   
                }
                else if (tableroll <= 39)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Animal Friendship";
                   
                }
                else if (tableroll <= 44)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Hill Giant's Strength";
                   
                }
                else if (tableroll <= 49)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Growth";
                   
                }
               else if (tableroll <= 54)
                {
                    treasure = treasure + System.Environment.NewLine + " Potion of WaterBreathing";
                   
                }
                else if (tableroll <= 59)
                {
                    treasure = treasure + System.Environment.NewLine + " Spell Scroll (lvl2)";
                   
                }
                else if (tableroll <= 64)
                {
                    treasure = treasure + System.Environment.NewLine + " Spell Scroll (lvl3)";
                   
                }

                else if (tableroll <= 67)
                {
                    treasure = treasure + System.Environment.NewLine + " Bag of Holding";
                   
                }
                else if (tableroll <= 70)
                {
                    treasure = treasure + System.Environment.NewLine + " Keoghtom's Ointment";
                   
                }
               else  if (tableroll <= 73)
                {
                    treasure = treasure + System.Environment.NewLine + " Oil of Slipperiness";
                   
                }
               else if (tableroll <= 75)
                {
                    treasure = treasure + System.Environment.NewLine + " Dust of Disapperence";
                   
                }
                else if (tableroll <= 77)
                {
                    treasure = treasure + System.Environment.NewLine + " Dust of Dryness";
                   
                }
                else if (tableroll <= 79)
                {
                    treasure = treasure + System.Environment.NewLine + " Dust of Sneezing and choking";
                   
                }
               else if (tableroll <= 81)
                {
                    treasure = treasure + System.Environment.NewLine + " Elemental Gem";
                   
                }
               else if (tableroll <= 83)
                {
                    treasure = treasure + System.Environment.NewLine + " Philter of Love";
                   
                }
                else if (tableroll == 84)
                {
                    treasure = treasure + System.Environment.NewLine + " Alchemy Jug";
                   
                }
                else if (tableroll == 85)
                {
                    treasure = treasure + System.Environment.NewLine + " Cap of Water Breathing";
                   
                }
                else if (tableroll == 86)
                {
                    treasure = treasure + System.Environment.NewLine + " Cloak of the Manta Ray";
                   
                }
                else if (tableroll == 87)
                {
                    treasure = treasure + System.Environment.NewLine + " Driftglobe";
                   
                }
                else if (tableroll == 88)
                {
                    treasure = treasure + System.Environment.NewLine + " Goggles of Night";
                   
                }
                else if (tableroll == 89)
                {
                    treasure = treasure + System.Environment.NewLine + " Helm of Comprehending Languages";
                   
                }
                else if (tableroll == 90)
                {
                    treasure = treasure + System.Environment.NewLine + " Immovable Rod";
                   
                }
                else if (tableroll == 91)
                {
                    treasure = treasure + System.Environment.NewLine + " Lantern of Revealing";
                   
                }
               else  if (tableroll == 92)
                {
                    treasure = treasure + System.Environment.NewLine + " Mariner's Armor";
                   
                }
                else if (tableroll == 93)
                {
                    treasure = treasure + System.Environment.NewLine + " Mithral Armour";
                   
                }
                else if (tableroll == 94)
                {
                    treasure = treasure + System.Environment.NewLine + " Potion of Poison";
                   
                }
                else if (tableroll == 95)
                {
                    treasure = treasure + System.Environment.NewLine + " Ring of Swimming";
                   
                }
               else if (tableroll == 96)
                {
                    treasure = treasure + System.Environment.NewLine + " Robe of Useful Items";
                   
                }
                else if (tableroll == 97)
                {
                    treasure = treasure + System.Environment.NewLine + " Rope of Climbing";
                   
                }
                else if (tableroll == 98)
                {
                    treasure = treasure + System.Environment.NewLine + " Saddle of the Cavalier";
                   
                }
                else if (tableroll == 99)
                {
                    treasure = treasure + System.Environment.NewLine + " Wand of Magic Detection";
                   
                }
                else if (tableroll == 100)
                {
                    treasure = treasure + System.Environment.NewLine + " Wand of Secrets";
                   
                }
                else
                {
                    treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR TABLEROLL VALUE NOT BETWEEN 1 - 100";
                   
                }
            }

            return treasure;
        }

        //Generates low magic item loot times the number of times rolled on dice
        private string MagicTableA(int dice)
        {
            Console.WriteLine("dice value: " + dice);
            for (int i = 0; i < dice; i++)
            {
                int tableroll = DiceRoll(100);
                if (tableroll <= 50)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Healing";
                    
                }
                 else if (tableroll <= 60)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (Cantrip)";
                    
                }
               else if (tableroll <= 70)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Climbing";
                    
                }
                else if (tableroll <= 90)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (lvl 1)";
                    
                }
                else if (tableroll <= 94)
                {
                    treasure = treasure + System.Environment.NewLine + "  Spell Scroll (lvl 2)";
                    
                }
                else if (tableroll <= 98)
                {
                    treasure = treasure + System.Environment.NewLine + "  Potion of Greater healing";
                    
                }
                else if (tableroll == 99)
                {
                    treasure = treasure + System.Environment.NewLine + "  Bag of Holding";
                    
                }
               else if (tableroll == 100)
                {
                    treasure = treasure + System.Environment.NewLine + " DriftGlobe ";
                    
                }
                else
                {
                    treasure = treasure + System.Environment.NewLine + "ERROR: OUT OF BOUNDS ERROR TABLEROLL VALUE NOT BETWEEN 1 - 100";
                    
                }
            }
            return treasure;
        }

        //Method Accesses database's Loot table to get 1 random magic item
        private string GenerateOLTtRTA()
        {
            using (SQLiteConnection conn = new SQLiteConnection(conn_string.ToString()))
            {//open DB connection
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    //select all magic items and randomly select one
                    cmd.CommandText = "SELECT * FROM loot ORDER BY RANDOM() LIMIT 1;";

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        //Check the reader has data:
                        if (reader.Read())
                        {
                            //assign result to
                            lootName = SafeGetString(reader, reader.GetOrdinal("Name"));
                            lootDesc = SafeGetString(reader, reader.GetOrdinal("Description"));
                            lootValue = SafeGetString(reader, reader.GetOrdinal("Value"));
                            lootRarity = SafeGetString(reader, reader.GetOrdinal("Rarity"));
                            lootWeight = SafeGetString(reader, reader.GetOrdinal("Weight"));
                            lootCat = SafeGetString(reader, reader.GetOrdinal("Category"));
                            lootProp = SafeGetString(reader, reader.GetOrdinal("Properties"));
                            lootReq = SafeGetString(reader, reader.GetOrdinal("Requirements"));
                            treasure = treasure + System.Environment.NewLine + lootName + "  " + lootCat + System.Environment.NewLine + lootDesc + System.Environment.NewLine + lootValue + "  " + lootRarity + "  " + lootWeight + System.Environment.NewLine + lootProp + System.Environment.NewLine + lootReq + System.Environment.NewLine;
                        }
                    }
                }
                conn.Close();
            }
            return treasure;
        }

        //Method used to check if string values in datareader ar not null if null return an empty string
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

        //Method attaches treasure string value to treasureBox's Text for the user to see the results
        private void TreasureLabelFill(string treasure)
        {
            treasureBox.Text = treasure;
        }

        //This Method takes a number and "rolls" like a dice to randomly generate a number between 1 and the number entered
        private int DiceRoll(int x)
        {
            return random.Next(1, x + 1);
        }
    }
}