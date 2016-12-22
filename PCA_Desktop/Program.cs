using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCA_Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  START Login Routine
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Login login_form = new Login();

            //variable to store dialog result
            DialogResult loginResult = login_form.ShowDialog();
            //Show login form as a dialog
    
            switch (loginResult)
            {
                case DialogResult.OK:
                    {
                        Application.Run(new Main());
                       break;
                    }
                case DialogResult.Cancel:
                    {
                        Application.Exit();
                        break;
                    }
            }
           
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  END Login Routine
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
