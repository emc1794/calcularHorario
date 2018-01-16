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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar()
        {
            
            var context = new PruebaEntities();
            Categoria categoria = context.Categoria.Find(cbCategoria.SelectedValue);
            int codigo = int.Parse(txtCodigo.Text);
            int activo = 0;
            if (cbActivo.Checked)
            {
                activo = 1;
            }

            // Si la caja de texto está vacía, se tratará de una inserción
            if (String.IsNullOrEmpty(txtId.Text))
            {
                try
                {
                    // Creamos un nuevo usuario y lo añadimos, guardando a continuación los cambios
                    Persona persona = new Persona
                    {
                        id = 0,
                        nombre = txtNombre.Text,
                        paterno = txtPaterno.Text,
                        materno = txtMaterno.Text,
                        codigo = codigo,
                        activo = activo,
                        Categoria=categoria
                    };
                    context.Persona.Add(persona);
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
                    Persona u = context.Persona.Where(persona => persona.id == id).First();

                    // Modificamos el contenido
                    u.codigo = codigo;
                    u.nombre = txtNombre.Text;
                    u.paterno = txtPaterno.Text;
                    u.materno = txtMaterno.Text;
                    u.activo = activo;
                    u.Categoria = categoria;

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
        private void cargar()
        {
            // Eliminamos el handler del evento RowEnter para evitar que se dispare al
            // realizar la búsqueda

            dataGridView1.RowEnter -= dataGrid_RowEnter;

            // Instanciamos el contexto y cargamos un listado de usuarios
            var context = new PruebaEntities();
            var users = 
                from user in context.Persona
                orderby user.id descending
                        select user;

            // Cargamos el grid con los datos
            dataGridView1.DataSource = users.ToList();

            // Restauramos el handler del evento
            dataGridView1.RowEnter += dataGrid_RowEnter;
        }
        private void eliminar()
        {
            var context = new PruebaEntities();

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                // Recuperamos el usuario cuyo identificador coincida con el de la caja de texto
                int id = int.Parse(txtId.Text);
                Persona u = context.Persona.Where(persona => persona.id == id).First();

                // Lo eliminamos y salvamos los cambios
                context.Persona.Remove(u);
                context.SaveChanges();
                cargar();
            }
        }
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperamos ID, nombre y apellido de la fila
            int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            int codigo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            String nombre = (String)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            String paterno = (String)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            String materno = (String)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            int activo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            int categoria = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

            // Asignamos los valores a las cajas de texto
            txtId.Text = id.ToString();
            txtCodigo.Text = codigo.ToString();
            txtNombre.Text = nombre;
            txtPaterno.Text = paterno;
            txtMaterno.Text = materno;
            cbActivo.Checked = Convert.ToBoolean(activo);
            cbCategoria.SelectedValue = categoria;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet2.Persona' Puede moverla o quitarla según sea necesario.
            this.personaTableAdapter.Fill(this.pruebaDataSet2.Persona);
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.pruebaDataSet.Categoria);

        }



    }
}
