using SysAcadCore.ar.com.sysacad.entities;
using SysAcadCore.ar.com.sysacad.service;
using SysAcadCore.ar.com.sysacad.service.impl;
using SysAcadView.ar.com.sysacad.dto;
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
        private LoginService _logService;
        public LoginPanelView(){
            InitializeComponent();
            _logService = new LoginServiceImpl();
        }

        private void LoginPanelView_Load(object sender, EventArgs e){

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

        //LoginBtn
        private void button1_Click(object sender, EventArgs e) {
            User user = null;
            if (userNameTxt.Text.Length>0 && passwordTxt.Text.Length>0) {
                user = _logService.CheckCredential(userNameTxt.Text, passwordTxt.Text);
                if (user == null){
                    wrongCredential();
                }
                else {
                    correctCredential();
                }
            }else{
                wrongCredential();
            }

        }
        private void wrongCredential() {
            MessageBox.Show("The user name or password are incorrect");
            userNameTxt.Clear();
            passwordTxt.Clear();
            userNameTxt.Focus();
        }

        private void correctCredential() {
            new SysAcadAppView().Show();
            this.Hide();
        }
    }
}
