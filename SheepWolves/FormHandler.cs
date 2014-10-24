using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepWolves
{
    class FormHandler : Form
    {
        public void splashForm(bool showForm1)
        {
            if (showForm1)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                Close();
            }
        }

        public void charGenForm(bool showCharacterCreation, int playerNumber)
        {
            if (showCharacterCreation)
            {
                CharacterCreation characterCreation = new CharacterCreation(playerNumber);
                characterCreation.ShowDialog();
            }
            else
            {
                Close();
            }
        }
    }
}
