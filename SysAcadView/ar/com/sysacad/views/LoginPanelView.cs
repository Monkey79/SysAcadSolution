using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAcadView.ar.com.sysacad.views
{
    public partial class LoginPanelView : Form
    {
        public LoginPanelView()
        {
            InitializeComponent();
        }

        private void LoginPanelView_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userNameTxt.Clear();
            passwordTxt.Clear();
            userNameTxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userNameTxt.Text == "pepe" && passwordTxt.Text == "pepe")
            {
                new SysAcadAppView().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password are incorrect");
                userNameTxt.Clear();
                passwordTxt.Clear();
                userNameTxt.Focus();
            }

        }
    }
}
