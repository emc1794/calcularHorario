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
    public partial class FrmFechas : Form
    {
        public FrmFechas()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            // Eliminamos el handler del evento RowEnter para evitar que se dispare al
            // realizar la búsqueda

            dgv.RowEnter -= dataGrid_RowEnter;

            // Instanciamos el contexto y cargamos un listado de usuarios
            var context = new PruebaEntities();
            var users =
                from user in context.Fecha
                orderby user.id descending
                select user;

            // Cargamos el grid con los datos
            dgv.DataSource = users.ToList();

            // Restauramos el handler del evento
            dgv.RowEnter += dataGrid_RowEnter;
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperamos ID, nombre y apellido de la fila
            int id = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            String nombre = (String)dgv.Rows[e.RowIndex].Cells[1].Value;

            // Asignamos los valores a las cajas de texto
            /*txtId.Text = id.ToString();
            txtNombre.Text = nombre;*/
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generar();
        }

        private void generar()
        {
            var inicio = dpFechaInicio.Value;
            var fin = dpFechaFin.Value;

            int cantidadDias = fin.Subtract(inicio).Days + 1;
            var diasSabado = new[] { DayOfWeek.Saturday};
            var diasDomingo = new[] { DayOfWeek.Sunday};

            do
            {
                if (inicio.DayOfWeek == DayOfWeek.Saturday || inicio.DayOfWeek == DayOfWeek.Sunday) guardar(inicio,"A");

                inicio = inicio.AddDays(1);
            } while (!(inicio > fin));

            var context = new PruebaEntities();

        }

        private void guardar(DateTime inicio,string tipo)
        {
            // Creamos un nuevo usuario y lo añadimos, guardando a continuación los cambios

            var context = new PruebaEntities();
            Fecha fecha = new Fecha
            {
                id = 0,
                fecha = inicio.ToShortDateString(),
                tipo = tipo
            };
            context.Fecha.Add(fecha);
            context.SaveChanges();
            cargar();
            MessageBox.Show("REGISTRO EXITOSO!");
        }
    }
}
