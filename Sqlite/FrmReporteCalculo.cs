using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlite
{
    public partial class FrmReporteCalculo : Form
    {
        public FrmReporteCalculo()
        {
            InitializeComponent();
        }

        private void FrmReporteCalculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PruebaDataSet6.calculo' Puede moverla o quitarla según sea necesario.
            this.calculoTableAdapter.Fill(this.PruebaDataSet6.calculo);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
