using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using System.Diagnostics;
using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using DevComponents.DotNetBar;

namespace DCLGlobal.Systems.Admin
{
    public partial class WhatsNewform : Form
    {
        int _appmoduleid = 0;
        int _id = 0;

        public WhatsNewform(int Appmoduleid)
        {
            InitializeComponent();
            _appmoduleid = Appmoduleid;
        }

        private void NewModuleform_Load(object sender, EventArgs e)
        {
            iApplication _iapplication = new GlobalFilesRepository.rApplication();
            CAL.Model.Sys_App_Module _appmodule = _iapplication.GetApplication(_appmoduleid);
            try 
            {
                lblModuleName.Text = _appmodule.Module_Name;

                Thread _thread = new Thread(new ThreadStart(DisplayRecords));
                _thread.IsBackground = true;
                _thread.Start();
                //DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region    Delegates

        private delegate void SetProgressBarMaxDelegate(int _value);
        public void SetProgressBarMax(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetProgressBarMaxDelegate(this.SetProgressBarMax), new object[] { _value });
            }
            else
            {
                this.pbar.Maximum = _value;
            }
        }

        private delegate void UpdateProgressBarDelegate(int _value);
        public void UpdateProgressBar(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new UpdateProgressBarDelegate(this.UpdateProgressBar), new object[] { _value });
            }
            else
            {
                this.pbar.Value = _value;
            }
        }

        private delegate void SetDGVRowcountDelegate(int _value);
        public void SetDGVRowcount(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetDGVRowcountDelegate(this.SetDGVRowcount), new object[] { _value });
            }
            else
            {
                this.DataGridView1.RowCount = _value;
            }
        }

        private delegate void AddRowDelegate();
        public void AddRow()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new AddRowDelegate(this.AddRow));
            }
            else
            {
                DataGridView1.Rows.Add();
            }
        }       
        #endregion


        private void DisplayRecords()
        {
            //iNewModule _inewmodule = new GlobalFilesRepository.rNewModule(); 
            //List<NEW_MODULE> _newmodules = new List<NEW_MODULE>();
            //int n = 0;
            //try
            //{
            //    //DataGridView1.RowCount = 0;
            //    SetDGVRowcount(0);
            //    UpdateProgressBar(0);

            //    _newmodules = _inewmodule.GetNewModules(_appmoduleid);
            //    SetProgressBarMax(_newmodules.Count);
            //    foreach (NEW_MODULE _list in _newmodules)
            //    {
            //        //DataGridView1.Rows.Add();
            //        AddRow();
            //        UpdateProgressBar(pbar.Value + 1);

            //        DataGridView1.Rows[n].Cells[0].Value = _list.id.ToString();
            //        DataGridView1.Rows[n].Cells[1].Value = _list.AppModule.Module_Name;
            //        DataGridView1.Rows[n].Cells[2].Value = _list.Module_Name;
            //        if (_list.Date_update.Date != null)
            //        { DataGridView1.Rows[n].Cells[3].Value = _list.Date_update.Date; }
            //        if (_list.Link_path != null) { DataGridView1.Rows[n].Cells[4].Value = "Open"; }
            //        else { DataGridView1.Rows[n].Cells[4].Value = ""; }

            //        DataGridView1.Rows[n].Cells[5].Value = _list.Version.ToString(); ;

            //        n++;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void NewModuleform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SuperTooltipInfo _supertooltip1 = new SuperTooltipInfo();
            //iNewModule _inewmodule = new GlobalFilesRepository.rNewModule();
            //NEW_MODULE _newmodule = new NEW_MODULE();
            ////Point _point = new Point(400, 0);   
            //System.Drawing.Size _point = new System.Drawing.Size(400, 0);
            //string _body = "";

            //try
            //{
                
            //    _id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    _newmodule = _inewmodule.GetNewModule(_id);

            //    if (e.ColumnIndex == 2)
            //    {
            //        _supertooltip1.HeaderText = "New Module Description";
            //        _supertooltip1.CustomSize = _point;

            //        if (_newmodule != null)
            //        {
            //            _body = _newmodule.Additional_information;                    
            //        }
            //        _supertooltip1.BodyText = _body;
            //        superTooltip1.SetSuperTooltip(picLogin, _supertooltip1);
            //        superTooltip1.ShowTooltip(picLogin);
            //    }
            //    else if (e.ColumnIndex == 4)
            //    {
            //        if (DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            //        {
            //            string _path = _newmodule.Link_path;
            //            Process.Start(_path);
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
