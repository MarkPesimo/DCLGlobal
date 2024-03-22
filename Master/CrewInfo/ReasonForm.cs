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

namespace DCLGlobal.Master.CrewInfo
{
    public partial class ReasonForm : Form
    {
        string _fromwhat = "";
        bool _forwatchlist = false;
        bool _watchlist = false;
        bool _active = false;
        string _crewname;
        string _applicantid;

        public ReasonForm()
        {
            InitializeComponent();
        }

        public ReasonForm(string Fromwhat, bool Forwatchlist, bool Watchlist, bool Active, string Crewname, string Applicantid)
        {
            InitializeComponent();

            _fromwhat = Fromwhat;
            _forwatchlist = Forwatchlist;
            _watchlist = Watchlist;
            _active = Active;
            _crewname = Crewname;
            _applicantid = Applicantid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtReason.Text == "")
            {
                MessageBox.Show("Kindly enter a reason.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtReason.Focus();
                return;
            }

            int _mode = 0;
            try 
            {
                iCrew _icrew = new CMSFilesRepository.rCrew();

                if (_fromwhat == "")
                {

                    if (_forwatchlist)                                                                  //watchlist mode
                    {
                        if (_watchlist)
                        {
                            if (MessageBox.Show("Tagged this crew " + _crewname + " as watchlisted, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                            _mode = 6;
                        }
                        else
                        {
                            if (MessageBox.Show("Remove this crew " + _crewname + " from watchlist, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                            _mode = 7;
                        }

                        _icrew.UpdateCrewStatus(_mode, _applicantid, txtReason.Text);
                        ToolsControl.CallShowNotification(this, 4, "Crew Watchlist satus successfully updated");
                        this.Close();
                    }
                    else                                                                               //active/inactive mode
                    {
                        if (_active)
                        {
                            if (MessageBox.Show("Tagged this crew " + _crewname + " as active, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                            _mode = 0;
                        }
                        else
                        {
                            if (MessageBox.Show("Tagged this crew " + _crewname + " as Inactive, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                            _mode = 1;
                        }

                        _icrew.UpdateCrewStatus(_mode, _applicantid, txtReason.Text);
                        ToolsControl.CallShowNotification(this, 4, "Crew satus successfully updated");
                        this.Close();
                    }
                }
                else                                                                                    //from irecruit qualification
                { 
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReasonForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (_fromwhat == "") { this.Text = "Input Reason"; }
                else { this.Text = "Enter Qualification"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
