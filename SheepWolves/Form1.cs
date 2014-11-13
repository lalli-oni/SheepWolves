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
        List<string> playerNameList = new List<string>();
        private string gameState = "Intro";
        int currentPlayerNaming = 0;

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
            int value;
            if (int.TryParse(playerNumberInputTextBox.Text, out value) && value >= 5 && value <= 10)
            {
                currentPlayerNaming++;
                gameState = "Character Creation";
                playerNumberInputTextBox.Visible = false;
                playerNumberLabelDynamic.Visible = true;
                registerPlayerButton.Visible = true;
                statusLabel.Visible = true;
                statusLabel.Text = "Input Player 1 Name:";
                inputTextbox.Visible = true;
                playerNumber = Convert.ToInt16(playerNumberInputTextBox.Text);
                playerNumberLabelDynamic.Text = playerNumber.ToString();
                newGameButton.Enabled = false;
                inputTextbox.Select();
            }
            else
            {
                MessageBox.Show("You need to write a number between 5 to 10 in the player number box.", "Error", MessageBoxButtons.OK);
            }

        }

        private void registerPlayerButton_Click(object sender, EventArgs e)
        {
            if (inputTextbox.Text != null)
            {
                if (currentPlayerNaming <= playerNumber)
                {
                    playerNameList.Add(inputTextbox.Text);
                    switch (currentPlayerNaming)
                    {
                        #region cases 1-10
                        case 1:
                            label1.Text = inputTextbox.Text;
                            label1.Visible = true;
                            playerPicture1.Visible = true;
                            break;
                        case 2:
                            label2.Text = inputTextbox.Text;
                            label2.Visible = true;
                            playerPicture2.Visible = true;
                            break;
                        case 3:
                            label3.Text = inputTextbox.Text;
                            label3.Visible = true;
                            playerPicture3.Visible = true;
                            break;
                        case 4:
                            label4.Text = inputTextbox.Text;
                            label4.Visible = true;
                            playerPicture4.Visible = true;
                            break;
                        case 5:
                            label5.Text = inputTextbox.Text;
                            label5.Visible = true;
                            playerPicture5.Visible = true;
                            break;
                        case 6:
                            label6.Text = inputTextbox.Text;
                            label6.Visible = true;
                            playerPicture6.Visible = true;
                            break;
                        case 7:
                            label7.Text = inputTextbox.Text;
                            label7.Visible = true;
                            playerPicture7.Visible = true;
                            break;
                        case 8:
                            label8.Text = inputTextbox.Text;
                            label8.Visible = true;
                            playerPicture8.Visible = true;
                            break;
                        case 9:
                            label9.Text = inputTextbox.Text;
                            label9.Visible = true;
                            playerPicture9.Visible = true;
                            break;
                        case 10:
                            label10.Text = inputTextbox.Text;
                            label10.Visible = true;
                            playerPicture10.Visible = true;
                            break;
                        #endregion
                    }
                    playerAliveNumberLabelDynamic.Text = playerNameList.Count.ToString();
                    currentPlayerNaming++;
                    statusLabel.Text = "Input Player " + currentPlayerNaming + " Name:";
                    inputTextbox.Enabled = true;
                    if (currentPlayerNaming > playerNumber)
                    {
                        inputTextbox.Visible = false;
                        statusLabel.Text = "All players Registered";
                    }
                }
                else
                {
                    
                }
            }
        }

        private void inputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                registerPlayerButton_Click(null, null);
            }
        }

    }
}
