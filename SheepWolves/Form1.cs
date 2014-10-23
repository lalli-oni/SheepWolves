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

        private void startGameButton_Click(object sender, EventArgs e)
        {

            foreach (var detail in currentSession.Descendants("battle"))
            {
                detail.SetAttributeValue("playerNumer", playerNumberNumeric.Value);
            }
            
            saveXML();

            //Form.Close();
        }


        public void saveXML()
        {
            int currPlayerNumber = Convert.ToInt32(playerNumberNumeric.Value);
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

    }
}
