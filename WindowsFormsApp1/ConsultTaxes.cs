using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConsultTaxes : Form
    {
        Taxes persona = new Taxes();
        Report nextStep;
        public ConsultTaxes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Registro guardado");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SaveData();
            Report frmReport = new Report();
            frmReport.Show();
            Hide();
            frmReport.lblNombre.Text = persona.Nombre;
            frmReport.lblCedula.Text = persona.Cedula;
            frmReport.lblTipoVehiculo.Text = persona.TipoDeVehicullo;
            frmReport.lblPlaca.Text = persona.Placa;
            frmReport.lblModelo.Text = persona.Modelo;
            frmReport.lblMarca.Text = persona.Marca;
            frmReport.lblAvaluo.Text = persona.Avaluo.ToString("N");
            frmReport.lblResultado.Text = persona.CalculoAvaluo(persona.Avaluo).ToString("N");

        }

        private void SaveData()
        {
            persona.Placa = txtPlaca.Text;
            persona.Modelo = txtModelo.Text;
            persona.Marca = cmbMarca.Text;
            persona.TipoDeVehicullo = cmbTipoVehiculo.Text;
            persona.Avaluo = Int32.Parse(txtAvaluo.Text);
            persona.Nombre = txtNombre.Text;
            persona.Cedula = txtCedula.Text;
        }
    }
}
