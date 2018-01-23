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
            btnEliminar.Enabled = false;
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

            string fechaInicio = dpFechaInicio.Value.ToShortDateString();
            string fechaFin = dpFechaFin.Value.ToShortDateString();

            // Instanciamos el contexto y cargamos un listado de usuarios
            var context = new PruebaEntities();
            var users =
                from user in context.Fecha
                orderby user.fecha descending
                select user;

            // Cargamos el grid con los datos
            dgv.DataSource = users.ToList();

            // Restauramos el handler del evento
            dgv.RowEnter += dataGrid_RowEnter;
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
            string fechaParametro = inicio.ToShortDateString();
            var context = new PruebaEntities();
            var u = context.Fecha.Where(fecha => fecha.fecha == fechaParametro).Count();
            if (u < 1)
            {
                Fecha fecha = new Fecha
                {
                    id = 0,
                    fecha = fechaParametro,
                    tipo = tipo
                };
                context.Fecha.Add(fecha);
                context.SaveChanges();
                cargar();
                MessageBox.Show("REGISTRO EXITOSO!"+fechaParametro);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fechaParametro = dpFecha.Value.ToShortDateString();
            string mensajes = "";
            if(String.IsNullOrEmpty(txtId.Text))
            {
                mensajes = "Esta seguro de Guardar Nuevo Registro";
            }
            else
            {
                mensajes = "Esta seguro de Editar el Registro con ID "+txtId.Text;
            }
            DialogResult dialogo = MessageBox.Show(mensajes, "Comfirmar", MessageBoxButtons.OKCancel);

            if(dialogo==DialogResult.OK)
            {
                var context = new PruebaEntities();
                var u = context.Fecha.Where(fecha => fecha.fecha == fechaParametro).Count();
                if(u<1)
                {
                    guardar();
                }
                else
                {
                    MessageBox.Show("ERROR ! Ya existe un registro con al misma fecha");
                }
                
            }
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
                    Fecha fecha = new Fecha
                    {
                        id = 0,
                        fecha=dpFecha.Value.ToShortDateString(),
                        tipo="M"
                    };
                    context.Fecha.Add(fecha);
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
                    Fecha u = context.Fecha.Where(fecha => fecha.id == id).First();

                    // Modificamos el contenido
                    u.fecha = dpFecha.Value.ToShortDateString();

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
        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Recuperamos ID, nombre y apellido de la fila
            int id = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            String fechaInicio = (String)dgv.Rows[e.RowIndex].Cells[1].Value;

            // Asignamos los valores a las cajas de texto
            txtId.Text = id.ToString();
            dpFecha.Value = DateTime.Parse(fechaInicio);

            btnEliminar.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            var context = new PruebaEntities();
            string fecha1= dpFecha.Value.ToShortDateString();

            var result = context.Fecha.Where(fecha => fecha.id>1);

            foreach(var r in result){
                DateTime fecha = Convert.ToDateTime( r.fecha);
                if (fecha>=dpFechaInicio.Value && fecha<=dpFechaFin.Value)
                {
                    MessageBox.Show("sdkfnh");
                }
            }
        }

    }
}
