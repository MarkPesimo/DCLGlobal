using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;

using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.Global;

using DevComponents.DotNetBar;
using Balloon;

namespace DCLGlobal.Classes
{
    public class ToolsControl
    {
        //iFiles _ifles = new FilesRepository(DCLSystemConfiguration.Connection);
        iFiles _ifles = new FilesRepository();
        
        public bool CheckFormAleadyOpen(string _form)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == _form)
                {
                    form.Activate();
                    form.Focus();
                    return true;
                }
            }
            return false;
        }

        public bool CheckFormAleadyOpen(string _form, string _transactionType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == _form)
                {
                    if (form.Tag.ToString() == _transactionType)
                    {
                        form.Activate();
                        form.Focus();
                        return true;
                    }                    
                }
            }
            return false;
        }

        public string Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age.ToString();
        }

        public void ShowNotification(System.Windows.Forms.Control _form, int _mode , string _message)
        {
            
            if (_mode == 3) 
            {
                ToastNotification.Show(_form, "Record succesfully Deleted", DCLGlobal.Properties.Resources.Cancel.ToBitmap(), 3000);
            }
            else if (_mode == 1 || _mode == 2 || _mode == 0)
            {
                ToastNotification.Show(_form, "Record succesfully Saved", DCLGlobal.Properties.Resources.Save.ToBitmap(), 3000);
            }
            else
            {
                ToastNotification.Show(_form, _message, DCLGlobal.Properties.Resources.Information.ToBitmap(), 3000);
            }                     
        }

        public void ShowNotification(System.Windows.Forms.Control _form, int _mode, string _message, eToastGlowColor _color, eToastPosition _position)
        {

            if (_mode == 3)
            {
                ToastNotification.Show(_form, "Record succesfully Deleted", DCLGlobal.Properties.Resources.Cancel.ToBitmap(), 3000, _color, _position);
            }
            else if (_mode == 1 || _mode == 2 || _mode == 0)
            {
                ToastNotification.Show(_form, "Record succesfully Saved", DCLGlobal.Properties.Resources.Save.ToBitmap(), 3000, _color, _position);
            }
            else
            {
                ToastNotification.Show(_form, _message, DCLGlobal.Properties.Resources.Information.ToBitmap(), 3000, _color, _position);
            }
        }

        public static void CallShowNotification(System.Windows.Forms.Control _form, int _mode, string _message, eToastGlowColor _color, eToastPosition _position)
        {
            try
            {
                ToolsControl _control = new ToolsControl();
                _control.ShowNotification(_form, _mode, _message, _color, _position);
            }
            catch (Exception ex)
            {

            }
        }

        public static void CallShowNotification(System.Windows.Forms.Control _form, int _mode, string _message)
        {
            try
            {
                ToolsControl _control = new ToolsControl();
                _control.ShowNotification(_form, _mode, _message);                 
            }
            catch (Exception ex)
            {
                
            }
        }

        public static void CallPopMessage(System.Windows.Forms.Control _form, string _header, string _body)
        {
            try
            {
                ToolsControl _control = new ToolsControl();
                _control.PopMessage(_form, _header, _body);
            }
            catch (Exception ex)
            {

            }
        
        }
        private AlertCustom m_AlertOnLoad = null;
        public void PopMessage(System.Windows.Forms.Control _form, string _header, string _body)
        {
            m_AlertOnLoad = new AlertCustom(_header, _body);
            Rectangle r = Screen.GetWorkingArea(_form);
            m_AlertOnLoad.Location = new Point(r.Right - m_AlertOnLoad.Width, r.Bottom - m_AlertOnLoad.Height);
            m_AlertOnLoad.AutoClose = true;
            m_AlertOnLoad.AutoCloseTimeOut = 5;
            m_AlertOnLoad.AlertAnimation = eAlertAnimation.BottomToTop;
            m_AlertOnLoad.AlertAnimationDuration = 300;
            m_AlertOnLoad.Show(false);
        }

        public static bool ModuleAccess(System.Windows.Forms.Control _form, string _modulename, int _moduletype)
        {
            if (LoginUser.userid == 0)
            {
                CallPopMessage(_form, "Access Denied", "Kindly login first.");
                return false;
            }

            if (!SecurityControl.ModuleAccess(_modulename, _moduletype))
            {
                CallPopMessage(_form, "Access Denied", "You dont have Rights to access this Module " + _modulename + ", Kindly contact your system administrator");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool FunctionAccess(System.Windows.Forms.Control _form, string _modulename, string _action, int _moduletype)
        {
            if (!SecurityControl.FunctionAccess(_modulename, _action, _moduletype))
            {
                CallPopMessage(_form, "Access Denied","You dont have Rights to access this Feature, Kindly contact your system administrator");
                return false;
            }
            else { return true; }
        }
    }
}
