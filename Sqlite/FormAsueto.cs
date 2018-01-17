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
    public partial class FormAsueto : Form
    {
        public FormAsueto()
        {
            InitializeComponent();
        }

        private void FormAsueto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet4.personaNombreCompleto' Puede moverla o quitarla según sea necesario.
            this.personaNombreCompletoTableAdapter.Fill(this.pruebaDataSet4.personaNombreCompleto);
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet3.Persona' Puede moverla o quitarla según sea necesario.
            this.personaTableAdapter.Fill(this.pruebaDataSet3.Persona);

        }
    }
}
