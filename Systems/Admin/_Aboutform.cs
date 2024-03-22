using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZMGGlobal.Systems.Admin
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
    }
}
