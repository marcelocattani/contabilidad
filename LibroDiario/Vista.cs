using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroDiario
{
    public partial class Vista : Form
    {

       

        public Vista()
        {

            InitializeComponent();

            llenarComboBox();

        }

        private void BtnDebe_Click(object sender, EventArgs e)
        {
            lboxCuentas.Items.Add(cmbDebe.Items[cmbDebe.SelectedIndex]);
            cmbDebe.Text = "";

            lboxMontos.Items.Add(txtMontoDebe.Text);
            txtMontoDebe.Text = "";
        }

        private void BtnHaber_Click(object sender, EventArgs e)
        {
            lboxCuentas.Items.Add("\t a     " + cmbHaber.Items[cmbHaber.SelectedIndex]);
            cmbHaber.Text = "";
            
            lboxMontos.Items.Add("\t "+txtMontoHaber.Text);
            txtMontoHaber.Text = "";
        }

        private void llenarComboBox()
        {
            cmbDebe.Items.Add("Caja");
            cmbDebe.Items.Add("Proveedores");
            cmbDebe.Items.Add("Deudores Varios");

            cmbHaber.Items.Add("Banco");
            cmbHaber.Items.Add("Mercaderias");
            cmbHaber.Items.Add("Rodados");
        }
    }


}
