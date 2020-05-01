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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ConsultTaxes frmConsult = new ConsultTaxes();
            frmConsult.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }
    }
}
