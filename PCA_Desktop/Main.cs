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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //show the homeScreen Form.
            HomeScreen newMDIChild = new HomeScreen();
            newMDIChild.MdiParent = this;
            //show the form
            newMDIChild.Show();

        }
    }
}
