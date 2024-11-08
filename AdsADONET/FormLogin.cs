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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserRepo repo = new UserRepo();
            repo.ValidateUser(textBoxUsername.Text, textBoxPassword.Text);
            MessageBox.Show("Logged in succefully");
        }
    }
}
