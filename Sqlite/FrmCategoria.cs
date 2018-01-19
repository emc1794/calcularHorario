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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
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

            dataGridView1.RowEnter -= dataGrid_RowEnter;

            // Instanciamos el contexto y cargamos un listado de usuarios
            var context = new PruebaEntities();
            var users =
                from user in context.Categoria
                orderby user.id descending
                select user;

            // Cargamos el grid con los datos
            dataGridView1.DataSource = users.ToList();

            // Restauramos el handler del evento
            dataGridView1.RowEnter += dataGrid_RowEnter;
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperamos ID, nombre y apellido de la fila
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String nombre = (String)dataGridView1.Rows[e.RowIndex].Cells[1].Value;

            // Asignamos los valores a las cajas de texto
            txtId.Text = id.ToString();
            txtNombre.Text = nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            var context = new PruebaEntities();
            // Si la caja de texto está vacía, se tratará de una inserción
            if (String.IsNullOrEmpty(txtId.Text))
            {
                try
                {
                    // Creamos un nuevo usuario y lo añadimos, guardando a continuación los cambios
                    Categoria categoria = new Categoria
                    {
                        id = 0,
                        nombre = txtNombre.Text,
                      
                    };
                    context.Categoria.Add(categoria);
                    context.SaveChanges();
                    cargar();
                    MessageBox.Show("REGISTRO EXITOSO!");

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
                    Categoria u = context.Categoria.Where(categoria => categoria.id == id).First();

                    // Modificamos el contenido
                    u.nombre = txtNombre.Text;

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

        private void eliminar()
        {
            var context = new PruebaEntities();

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                // Recuperamos el usuario cuyo identificador coincida con el de la caja de texto
                int id = int.Parse(txtId.Text);
                Categoria u = context.Categoria.Where(categoria => categoria.id == id).First();

                // Lo eliminamos y salvamos los cambios
                context.Categoria.Remove(u);
                context.SaveChanges();
                cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
