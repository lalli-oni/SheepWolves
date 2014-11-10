using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SheepWolves
{

    public partial class Form1 : Form
    {
        private int playerNumber = 0;
        List<int> playerNameList = new List<int>(); 

        int xmlFileNumber = 10001;
        string currentDirectory = Directory.GetCurrentDirectory();

        Battle playerCreation = new Battle();
        XDocument currentSession = new XDocument(
                new XElement("root",
                    new XElement("battle",
                        new XElement("playerList")))
                );


        public Form1()
        {
            InitializeComponent();

        }

        public void saveXML()
        {
            int currPlayerNumber = Convert.ToInt32(playerNumber);
            bool fileExists = File.Exists(currentDirectory + currPlayerNumber + "SAV" + xmlFileNumber + ".xml");

            for (int i = 0; i < 20000; i++)
            {
                if (fileExists)
                {
                    xmlFileNumber++;
                }
                else
                {
                    xmlFileNumber++;
                    currentSession.Save(currPlayerNumber + "SAV" + xmlFileNumber + ".xml");
                    break;
                }
            }
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (playerNumberInputTextBox.Text.GetType() != typeof(int))
            {
                MessageBox.Show("You need to write a number between 5 to 10 in the player number box.","Error",MessageBoxButtons.OK);
            }
            else
            {
                playerNumberInputTextBox.Visible = false;
                playerNumberLabelDynamic.Visible = true;
                playerNumber = Convert.ToInt16(playerNumberInputTextBox.Text);
                playerNumberLabelDynamic.Text = playerNumber.ToString();
                CharacterCreation charPrompt = new CharacterCreation(playerNumber);
            }
        }

    }
}
