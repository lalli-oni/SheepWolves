using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepWolves
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initSplash();
        }

        static public void initCharacterCreation(int playerNumber)
        {
            FormHandler formHandling = new FormHandler();
            formHandling.splashForm(false);
            formHandling.charGenForm(true, playerNumber);
        }

        static public void initSplash()
        {
            FormHandler formHandling = new FormHandler();
            formHandling.splashForm(true);
        }
    }
}
