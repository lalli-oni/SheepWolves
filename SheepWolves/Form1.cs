using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using SheepWolves.Enum;
using SheepWolves.Properties;


namespace SheepWolves
{
    public partial class Form1 : Form
    {
        private Player tempPlayer;
        private int playerNumber = 0;
        List<Player> playerList = new List<Player>();
        List<Animal> statesList = new List<Animal>();
        private GameStates gameStates = GameStates.Intro;
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
            playerNumberInputTextBox.Select();

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
                gameStates = GameStates.Naming;
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
                prepareStatesList(playerNumber);
            }
            else
            {
                MessageBox.Show("You need to write a number between 5 to 10 in the player number box.", "Error", MessageBoxButtons.OK);
            }
        }

        void prepareStatesList(int playerNumberPara)
        {
            #region switchCase
            switch (playerNumberPara)
            {
                case 5:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 6:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 7:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 8:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 9:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 10:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 11:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 12:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 13:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 14:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                case 15:
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Wolf);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    statesList.Add(Animal.Sheep);
                    break;
                default:
                    MessageBox.Show("omg, prepareStateList switch out of index.");
                    break;
#endregion
            }
            if (statesList.Count < playerNumber)
            {
                MessageBox.Show("Nope!");
            }
        }

        void battleMode(int playerVoting)
        {
            voteStartButton.Visible = false;
            statusLabel.Visible = true;
                MessageBox.Show("Next player to vote is: " + playerList[playerVoting].Name);
                if(playerList[playerVoting].Sheep == Animal.Sheep)
                {
                    statusLabel.Text = playerList[playerVoting].Name + ", You are a sheep, please select a someone to accuse!";
                    
            switch (playerVoting)
            {
                #region longswitch... DONT OPEN!
                case 0:
                    playerPicture1.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 1:
                    playerPicture2.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(0, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 2:
                    playerPicture3.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 3:
                    playerPicture4.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 4:
                    playerPicture5.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 5:
                    playerPicture6.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 6:
                    playerPicture7.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 7:
                    playerPicture8.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 8:
                    playerPicture9.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture10.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
                case 9:
                    playerPicture10.Image =
                        Image.FromFile("../Resources/icon-quantumsheepBW.png");
                    playerPicture2.MouseClick += new MouseEventHandler((o, a) => registerVote(1, playerVoting));
                    playerPicture3.MouseClick += new MouseEventHandler((o, a) => registerVote(2, playerVoting));
                    playerPicture4.MouseClick += new MouseEventHandler((o, a) => registerVote(3, playerVoting));
                    playerPicture5.MouseClick += new MouseEventHandler((o, a) => registerVote(4, playerVoting));
                    playerPicture6.MouseClick += new MouseEventHandler((o, a) => registerVote(5, playerVoting));
                    playerPicture7.MouseClick += new MouseEventHandler((o, a) => registerVote(6, playerVoting));
                    playerPicture8.MouseClick += new MouseEventHandler((o, a) => registerVote(7, playerVoting));
                    playerPicture9.MouseClick += new MouseEventHandler((o, a) => registerVote(8, playerVoting));
                    playerPicture1.MouseClick += new MouseEventHandler((o, a) => registerVote(9, playerVoting));
                    break;
#endregion
            }
                }
                else
                {
                    statusLabel.Text = playerList[playerVoting].Name + ", You are a wolf, please select a sheep to kill!";
                }
        }

        private void registerVote(int vote, int currentPlayer)
        {
            MessageBox.Show(playerList[currentPlayer].Name + ", voted for" + playerList[vote].Name);
        }

        private void registerPlayerButton_Click(object sender, EventArgs e)
        {
            if (inputTextbox.Text != null)
            {
                if (currentPlayerNaming <= playerNumber)
                {
                    Player p = new Player();
                    p.Name = inputTextbox.Text;
                    p.State = State.Alive;
                    Random rng = new Random();
                    int randomNumber = rng.Next(statesList.Count);
                    p.Sheep = statesList[randomNumber];
                    statesList.RemoveAt(randomNumber);
                    playerList.Add(p);

                    switch (currentPlayerNaming)
                    {
                        #region cases 1-10
                        case 1:
                            label1.Text = p.Name;
                            label1.Visible = true;
                            playerPicture1.Visible = true;
                            break;
                        case 2:
                            label2.Text = p.Name;
                            label2.Visible = true;
                            playerPicture2.Visible = true;
                            break;
                        case 3:
                            label3.Text = p.Name;
                            label3.Visible = true;
                            playerPicture3.Visible = true;
                            break;
                        case 4:
                            label4.Text = p.Name;
                            label4.Visible = true;
                            playerPicture4.Visible = true;
                            break;
                        case 5:
                            label5.Text = p.Name;
                            label5.Visible = true;
                            playerPicture5.Visible = true;
                            break;
                        case 6:
                            label6.Text = p.Name;
                            label6.Visible = true;
                            playerPicture6.Visible = true;
                            break;
                        case 7:
                            label7.Text = p.Name;
                            label7.Visible = true;
                            playerPicture7.Visible = true;
                            break;
                        case 8:
                            label8.Text = p.Name;
                            label8.Visible = true;
                            playerPicture8.Visible = true;
                            break;
                        case 9:
                            label9.Text = p.Name;
                            label9.Visible = true;
                            playerPicture9.Visible = true;
                            break;
                        case 10:
                            label10.Text = p.Name;
                            label10.Visible = true;
                            playerPicture10.Visible = true;
                            break;
                        #endregion
                    }
                    playerAliveNumberLabelDynamic.Text = playerList.Count.ToString();
                    currentPlayerNaming++;
                    statusLabel.Text = "Input Player " + currentPlayerNaming + " Name:";
                    inputTextbox.Enabled = true;
                    MessageBox.Show("Welcome " + p.Name + ", you are a " + p.Sheep + ".");
                    inputTextbox.Text = "";
                    if (currentPlayerNaming > playerNumber)
                    {
                        inputTextbox.Visible = false;
                        statusLabel.Text = "All players Registered";
                        registerPlayerButton.Text = "Start Voting!";
                        registerPlayerButton.Enabled = false;
                        gameStates = GameStates.Accusing;
                        statusLabel.Visible = false;
                        registerPlayerButton.Visible = false;
                        voteStartButton.Visible = true;
                        voteStartButton.Select();
                    }
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

        private void playerNumberInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                newGameButton_Click(null, null);
            }
        }

        private void voteStartButton_Click(object sender, EventArgs e)
        {
            currentPlayerNaming = 0;
            battleMode(currentPlayerNaming);
        }

    }
}
