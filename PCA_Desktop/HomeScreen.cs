using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCA_Desktop
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            //Recover the user to set the label.
            string usuario = GlobalVar.Usuario;
            lblUser.Text = usuario;

            //start the clock
            TimeClock.Enabled = true;


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///// Start of the Traffic Light Retrieval
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            AQUIVOY
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///// End of the Traffic Light Retrieval
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void TimeClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }
    }
}
