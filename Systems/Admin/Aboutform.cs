using CAL.Global;
using CAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using ZMGCAL.MODEL;
//using ZMGCAL.MASTER.INTERFACE;
//using ZMGCAL.MASTER.REPOSITORY;


namespace DCLGlobal.Systems.Admin
{
    public partial class Aboutform : Form
    {
        public Aboutform()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Aboutform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void Aboutform_Load(object sender, EventArgs e)
        {
            DisplayAbouts();
        }

        void DisplayAbouts()
        {
            GlobalToolsControl.Global _i = new GlobalToolsControl.Global();
            lsvList.Items.Clear();  

            try
            {
                List<sys_about> _abouts = _i.GetAbouts();
                foreach (sys_about _x in _abouts)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.full_name);
                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label21_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    
    }
}
