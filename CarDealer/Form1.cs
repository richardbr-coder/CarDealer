using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vehicleListCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (DeloreanCheckBox.Checked == true)
            {
                DeloreanForm dF = new DeloreanForm();
                dF.ShowDialog();
                DeloreanCheckBox.CheckState = CheckState.Unchecked;
            }

        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void FuturaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (FuturaCheckBox.Checked == true)
            {
                BatmanForm bM = new BatmanForm();
                bM.ShowDialog();
                FuturaCheckBox.CheckState = CheckState.Unchecked;
            }
            
        }

        private void D85CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (D85CheckBox.Checked == true)
            {
                Form4 f = new Form4();
                f.ShowDialog();
                D85CheckBox.CheckState = CheckState.Unchecked;
            }
        }
    }
}
