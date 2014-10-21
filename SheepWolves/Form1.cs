using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Battle playerCreation = new Battle();

        public Form1()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            XDocument currentSession = new XDocument(
                new XElement("root",
                        new XElement("playerNumber", new XAttribute())
                    )
                );
            
            int xmlFileNumber = 0001;
            try
            {
            }
            catch (Exception)
            {
                xmlFileNumber++;
            }

            //Battle.PlayerNumber = Convert.ToInt32(playerNumberNumeric.Value);
            //Form.Close();
        }
    }
}
