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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //replace with actual login variables retrieved from database, this info is now for testing purposes.
            if (txtUsr.Text=="Anta" && txtPwd.Text=="1234")
            {
                //Save the username into global variables.
                GlobalVar.Usuario = txtUsr.Text;
                //login succesful
                this.DialogResult = DialogResult.OK;
                //close the login form
                this.Close();
            } else
            {
                //Add cases for access control, it should notify the error wherever it's found, both user or password.
                MessageBox.Show("Acceso no exitoso");
                txtUsr.Text = "";
                txtPwd.Text = "";
                txtUsr.Focus();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            //Send the message to program.cs to quit the app.
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
