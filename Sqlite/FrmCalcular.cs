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
    public partial class FrmCalcular : Form
    {
        public FrmCalcular()
        {
            InitializeComponent();
        }

        private void FrmCalcular_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet8.calculo' Puede moverla o quitarla según sea necesario.
            this.calculoTableAdapter.Fill(this.pruebaDataSet8.calculo);

        }
    }
}
