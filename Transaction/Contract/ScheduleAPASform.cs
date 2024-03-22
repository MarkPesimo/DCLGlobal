using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using DCLGlobal.Classes;

namespace DCLGlobal.Transaction.Contract
{
    public partial class ScheduleAPASform : Form
    {
        
        int _crewstatusid = 0;
        string _applicantid = "";
        DateTime _apasdate = DateTime.Now;
        string _fromwhat = "";

        public ScheduleAPASform(DateTime Apasdate, int Crewstatusid, string Applicantid, string Fromwhat)
        {
            _apasdate = Apasdate;
            _crewstatusid = Crewstatusid;
            _applicantid = Applicantid;
            _fromwhat = Fromwhat;
            InitializeComponent();
        }

        private void ScheduleAPASform_Load(object sender, EventArgs e)
        {
            try
            {
                if (_apasdate == null) { cmdUnschedule.Enabled = false; }
                else
                {
                    cmdUnschedule.Enabled = true;
                    mcAPAS.SetDate(_apasdate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUnschedule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Un-scheduled this crew to APAS, Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            
            ScheduleApas(false, 1);
        }

        void ScheduleApas(bool _attend, int _mode)
        {
            try 
            {
                _apasdate = mcAPAS.SelectionRange.Start;

                iAPAS _iapas = new CMSTransactionRepository.rAPAS();
                _iapas.ScheduleApas(_crewstatusid, _applicantid, _apasdate, DateTime.Now, DateTime.Now, _mode, _attend, "");

                if (_mode == 0) { ToolsControl.CallShowNotification(this,  5, "Crew successfully Scheduled to attend APAS."); }
                else { ToolsControl.CallShowNotification(this, 5, "Crew successfully UnScheduled to attend APAS."); }

                if (_fromwhat != "")
                { }
                else { this.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void cmdSchedule_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to scheduled this crew to APAS, Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            
            ScheduleApas(false, 0);
        }
    }
}
