using AdsADONET.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsADONET
{
    public partial class FormRegisterAccount : Form
    {
        public FormRegisterAccount()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            string regMessage = repo.CreateAccount(textBoxRegUsername.Text, textBoxRegPassword.Text, textBoxRegFullname.Text, textBoxRegEmail.Text);
   
            MessageBox.Show(regMessage);
            this.Close();
        }
    }
}
