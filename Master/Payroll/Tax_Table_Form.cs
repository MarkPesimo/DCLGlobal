using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;

namespace DCLGlobal.Master.Payroll
{
    public partial class Tax_Table_Form : Form
    {
        int _id = 0;

        public Tax_Table_Form()
        {
            InitializeComponent();
        }

        private void Tax_Table_Form_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        void EnableForm(bool _cond)
        {
            lsvH.Enabled = _cond;
            lsvA.Enabled = _cond;
            lsvB.Enabled = _cond;
        }
        void DisplayRecord()
        {
            iTax _itax = new IHOPSFilesRepository.rTax();
            List<Tax_table> _tax = new List<Tax_table>();

            _tax.Add(_itax.GetTaxTable(1));
            _tax.Add(_itax.GetTaxTable(2));
            DisplayTaxTable(_tax, lsvH);

            _tax = new List<Tax_table>();
            _tax.Add(_itax.GetTaxTable(3));
            _tax.Add(_itax.GetTaxTable(4));
            DisplayTaxTable(_tax, lsvA);

            _tax = new List<Tax_table>();
            _tax = _itax.GetTaxTables();
            DisplayTaxTable(_tax, lsvB);
        }
        void DisplayTaxTable(List<Tax_table> _tax, ListView _lsv)
        {     
            try
            {
                _lsv.Items.Clear();
                if (_tax != null)
                {
                    foreach (Tax_table _x in _tax)
                    {
                        ListViewItem _item = new ListViewItem(_x.TaxExemption);
                        _item.SubItems.Add(_x.Col_Zero.ToString());
                        _item.SubItems.Add(_x.Col_One.ToString());
                        _item.SubItems.Add(_x.Col_Two.ToString());
                        _item.SubItems.Add(_x.Col_Three.ToString());
                        _item.SubItems.Add(_x.Col_Four.ToString());
                        _item.SubItems.Add(_x.Col_Five.ToString());
                        _item.SubItems.Add(_x.Col_Six.ToString());
                        _item.SubItems.Add(_x.Col_Seven.ToString());
                        _item.SubItems.Add(_x.Col_Eight.ToString());
                        _item.SubItems.Add(_x.id.ToString());

                        _lsv.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayInfo()
        {
            iTax _itax = new IHOPSFilesRepository.rTax();
            Tax_table _tax = _itax.GetTaxTable(_id);

            try
            {
                if(_tax != null)
                {
                    _id = _tax.id;
                    txtDescription.Text = _tax.TaxExemption;
                    txtField0.Text = _tax.Col_Zero.ToString();
                    txtField1.Text = _tax.Col_One.ToString();
                    txtField2.Text = _tax.Col_Two.ToString();
                    txtField3.Text = _tax.Col_Three.ToString();
                    txtField4.Text = _tax.Col_Four.ToString();
                    txtField5.Text = _tax.Col_Five.ToString();
                    txtField6.Text = _tax.Col_Six.ToString();
                    txtField7.Text = _tax.Col_Seven.ToString();
                    txtField8.Text = _tax.Col_Eight.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvH_DoubleClick(object sender, EventArgs e)
        {
            EnableForm(false);

            if (lsvH.SelectedItems.Count == 0) { return; }
            try
            {
                panDetails.Visible = true;
                panDetails.BringToFront();

                _id = int.Parse(lsvH.SelectedItems[0].SubItems[10].Text);

                DisplayInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        private void lsvA_DoubleClick(object sender, EventArgs e)
        {
            EnableForm(false);
            if (lsvA.SelectedItems.Count == 0) { return; }
            try
            {
                panDetails.Visible = true;
                panDetails.BringToFront();

                _id = int.Parse(lsvA.SelectedItems[0].SubItems[10].Text);

                DisplayInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void lsvB_DoubleClick(object sender, EventArgs e)
        {
            EnableForm(false);
            if (lsvB.SelectedItems.Count == 0) { return; }
            try
            {
                panDetails.Visible = true;
                panDetails.BringToFront();

                _id = int.Parse(lsvB.SelectedItems[0].SubItems[10].Text);

                DisplayInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update Tax table?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManageTaxTable();

            DisplayRecord();
            ToolsControl.CallShowNotification(this, 1, "Record successfully save.");
            EnableForm(true);
            panDetails.Visible = false;
            panDetails.SendToBack();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            panDetails.Visible = false;
            panDetails.SendToBack();
        }
        void ManageTaxTable()
        {
            iTax _itax = new IHOPSFilesRepository.rTax();
            Tax_table _tax = new Tax_table();

            try
            {
                _tax.id = _id;
                _tax.TaxExemption = txtDescription.Text;
                _tax.Col_Zero = decimal.Parse(txtField0.Text);
                _tax.Col_One = decimal.Parse(txtField1.Text);
                _tax.Col_Two = decimal.Parse(txtField2.Text);
                _tax.Col_Three = decimal.Parse(txtField3.Text);
                _tax.Col_Four = decimal.Parse(txtField4.Text);
                _tax.Col_Five = decimal.Parse(txtField5.Text);
                _tax.Col_Six = decimal.Parse(txtField6.Text);
                _tax.Col_Seven = decimal.Parse(txtField7.Text);
                _tax.Col_Eight = decimal.Parse(txtField8.Text);

                _itax.ManageTaxTable(_tax);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
