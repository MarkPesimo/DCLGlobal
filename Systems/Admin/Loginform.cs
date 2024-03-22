using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Classes;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DevComponents.DotNetBar;
using Balloon;
using System.Threading;
using CAL.Global;

namespace DCLGlobal.Systems.Admin
{
    public partial class Loginform : Form
    {
        private AlertCustom m_AlertOnLoad = null;        
        string _appmodule = "";
        int _appmoduleid = 0;
        bool _formclosed = false;

        public bool LoginFormClosed
        {
            get { return _formclosed; }
        }

        public Loginform()
        {
            InitializeComponent();
        }

        public Loginform(string _AppModule, int _AppModuleId)
        {
            InitializeComponent();
            _appmodule = _AppModule;
            _appmoduleid = _AppModuleId;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Login();
            }
        }

        void Login()
        {
            if (UsernameTextBox.Text.Length == 0)
            {
                btxMsg.ShowBalloon(UsernameTextBox);
                UsernameTextBox.Focus();
                return;
            }

            if (PasswordTextBox.Text.Length == 0)
            {
                btxMsg.ShowBalloon(PasswordTextBox);
                PasswordTextBox.Focus();
                return;
            }

            string _message = "";
            try
            {
                _message = SecurityControl.Login(UsernameTextBox.Text, PasswordTextBox.Text, _appmodule, _appmoduleid);
                if (_message != "")
                {
                    ToolsControl.CallPopMessage(this, "Autorization", _message);
                    return;
                }

                ToolsControl.CallPopMessage(this, "Autorization Complete", "Welcome to ZMG - " + _appmodule + " system");
                Thread.Sleep(1000);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelX3_Click(object sender, EventArgs e)
        {

            m_AlertOnLoad = new AlertCustom("test header", "test body");
            Rectangle r = Screen.GetWorkingArea(this);
            m_AlertOnLoad.Location = new Point(r.Right - m_AlertOnLoad.Width, r.Bottom - m_AlertOnLoad.Height);
            m_AlertOnLoad.AutoClose = true;
            m_AlertOnLoad.AutoCloseTimeOut = 5;
            m_AlertOnLoad.AlertAnimation = eAlertAnimation.BottomToTop;
            m_AlertOnLoad.AlertAnimationDuration = 300;
            m_AlertOnLoad.Show(false);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            string _notes = "";

            if (_appmodule == appmodule.CMS) { _notes = _appmodule + " ® 2010"; }
            else if (_appmodule == appmodule.IRECRUIT) { _notes = _appmodule + " ® 2011"; }
            else if (_appmodule == appmodule.IHOPS) { _notes = _appmodule + " ® 2012"; }
            else if (_appmodule == appmodule.HURIS) { _notes = _appmodule + " ® 2016"; }
            else if (_appmodule == appmodule.TAMS) { _notes = _appmodule + " ® 2011"; }
            else if (_appmodule == appmodule.DCLAPS) { _notes = _appmodule + " ® 2009"; }
            else if (_appmodule == appmodule.AIMS) { _notes = _appmodule + " ® 2016"; }


            lbTitle.Text = "Log on to ZMG System - " + _appmodule;
            lblnotes.Text = _notes + lblnotes.Text;
        }

        private void Loginform_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginUser.userid == 0)
            {
                if (_appmodule == appmodule.TAMS)
                {
                    _formclosed = true;
                }
            }
        }

    }
}
