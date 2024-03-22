using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Reports;

namespace DCLGlobal.Transaction.Contract
{
    public partial class rpsAmmendmentform : Form
    {
        private int _crewid = 0;
        private string _reporttype;

        public rpsAmmendmentform(int _Crewid, string _Reporttype)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _reporttype = _Reporttype;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string _x1 = "";
            string _x2 = "";
            string _x3 = "";
            string _x4 = "";
            string _x5 = "";
            string _x6 = "";
            string _x7 = "";
            string _x8 = "";
            string _x9 = "";
            string _x10 = "";
            string _x11 = "";
            string _x12 = "";


            if (chk1.Checked) { _x1 = "1"; }
            if (chk2.Checked) { _x2 = "1"; }
            if (chk3.Checked) { _x3 = "1"; }
            if (chk4.Checked) { _x4 = "1"; }
            if (chk5.Checked) { _x5 = "1"; }
            if (chk6.Checked) { _x6 = "1"; }
            if (chk7.Checked) { _x7 = "1"; }
            if (chk8.Checked) { _x8 = "1"; }
            if (chk9.Checked) { _x9 = "1"; }
            if (chk10.Checked) { _x10 = "1"; }
            if (chk11.Checked) { _x11 = "1"; }
            if (chk12.Checked) { _x12 = "1"; }

            GlobalReportViewerform _viewer = new GlobalReportViewerform(_reporttype);
            _viewer._crewid = _crewid;
            _viewer._x1 = _x1;
            _viewer._x2 = _x2;
            _viewer._x3 = _x3;
            _viewer._x4 = _x4;
            _viewer._x5 = _x5;
            _viewer._x6 = _x6;
            _viewer._x7 = _x7;
            _viewer._x8 = _x8;
            _viewer._x9 = _x9;
            _viewer._x10 = _x10;
            _viewer._x11 = _x11;
            _viewer._x12 = _x12;

            _viewer.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
