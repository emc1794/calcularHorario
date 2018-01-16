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
    public partial class FrmArea : Form
    {
        private List<Area_Categoria> listaAreaCategoria = new List<Area_Categoria>();
        public FrmArea()
        {
            InitializeComponent();
        }

        private void FrmArea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter1.Fill(this.pruebaDataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.pruebaDataSet.Categoria);

        }

        private void agregarLista()
        {
            var context=new PruebaEntities();
            Area_Categoria areaCategoria=new Area_Categoria
            {
                mañana=(long)nMañana.Value,
                tarde=(long)nTarde.Value,
                noche=(long)nNoche.Value,
                categoria_id=Convert.ToInt64(cbCategoria.SelectedValue)
            };

            listaAreaCategoria.Add(areaCategoria);
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = listaAreaCategoria;
        }

        private void guardar()
        {
            var contexto = new PruebaEntities();
            try
            {
                Area area = new Area
                {
                    nombre = txtNombre.Text,
                };

                contexto.Area.Add(area);
                foreach (Area_Categoria item in listaAreaCategoria)
                {
                    item.Area = area;
                    contexto.Area_Categoria.Add(item);
                }
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarLista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

    }
}
