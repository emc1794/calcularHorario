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
    public partial class FrmReportePersona : Form
    {
        public FrmReportePersona()
        {
            InitializeComponent();
        }

        private void FrmReportePersona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PruebaDataSet5.Persona' Puede moverla o quitarla según sea necesario.
            this.PersonaTableAdapter.Fill(this.PruebaDataSet5.Persona);

            this.reportViewer1.RefreshReport();
        }
    }
}
