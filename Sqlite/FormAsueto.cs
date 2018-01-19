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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            // Eliminamos el handler del evento RowEnter para evitar que se dispare al
            // realizar la búsqueda

            dgvDatos.RowEnter -= dataGrid_RowEnter;

            // Instanciamos el contexto y cargamos un listado de usuarios
            var context = new PruebaEntities();
            var users =
                from user in context.Asueto
                orderby user.id descending
                select user;

            // Cargamos el grid con los datos
            dgvDatos.DataSource = users.ToList();

            // Restauramos el handler del evento
            dgvDatos.RowEnter += dataGrid_RowEnter;
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperamos ID, nombre y apellido de la fila
            int id = int.Parse( dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString());
            String fechaInicio = (String)dgvDatos.Rows[e.RowIndex].Cells[1].Value;
            String fechaFin = (String)dgvDatos.Rows[e.RowIndex].Cells[2].Value;
            String tipo = (String)dgvDatos.Rows[e.RowIndex].Cells[3].Value;
            int persona = int.Parse(dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString());

            // Asignamos los valores a las cajas de texto
            txtId.Text = id.ToString();
            dpFechaInicio.Value =  DateTime.Parse(fechaInicio);
            dpFechaFin.Value = DateTime.Parse(fechaFin);
            cbTipo.Text = tipo;
            cbPersona.SelectedValue = persona;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            var context = new PruebaEntities();
            Persona persona = context.Persona.Find(cbPersona.SelectedValue);

            // Si la caja de texto está vacía, se tratará de una inserción
            if (String.IsNullOrEmpty(txtId.Text))
            {
                try
                {
                    // Creamos un nuevo usuario y lo añadimos, guardando a continuación los cambios
                    Asueto asueto = new Asueto
                    {
                        id = 0,
                        fechaInicio = dpFechaInicio.Value.ToShortDateString(),
                        fechaFin = dpFechaFin.Value.ToShortDateString(),
                        tipo = cbTipo.Text,
                        Persona=persona
                    };
                    context.Asueto.Add(asueto);
                    context.SaveChanges();
                    cargar();
                    MessageBox.Show("REGISTRO NUEVO EXITOSO!");

                }
                catch (Exception)
                {

                    throw;
                }

            }

            // En caso contrario, se tratará de una modificación
            else
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    // Recuperamos el usuario cuyo identificador coincida con el de la caja de texto
                    Asueto u = context.Asueto.Where(asueto => asueto.id == id).First();

                    // Modificamos el contenido
                    u.fechaInicio = dpFechaInicio.Value.ToShortDateString();
                    u.fechaFin = dpFechaFin.Value.ToShortDateString();
                    u.tipo = cbTipo.Text;
                    u.Persona = persona;

                    // Guardamos los cambios
                    context.SaveChanges();
                    cargar();
                    MessageBox.Show("ACTUALIZACION EXITOSA!");
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            var context = new PruebaEntities();

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                // Recuperamos el usuario cuyo identificador coincida con el de la caja de texto
                int id = int.Parse(txtId.Text);
                Asueto u = context.Asueto.Where(asueto => asueto.id == id).First();

                // Lo eliminamos y salvamos los cambios
                context.Asueto.Remove(u);
                context.SaveChanges();
                cargar();
            }
        }
    }
}
