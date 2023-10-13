using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2.Datos;
using Taller2.Modelo;

namespace Taller2
{
    public partial class Form1 : Form
    {
        DataTable Tabla;
        Usuario dato=new Usuario();
        public Form1()
        {
            InitializeComponent();
            iniciar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
            iniciar();
            limpiar();
            consultar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void iniciar ()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Codigo");
            dgvBrilla.DataSource = Tabla;
        }
        private void guardar()
        {
            Usuariomodelo modelo = new Usuariomodelo()
            {
                Nombre = txtnombre.Text,

                Codigo = int.Parse(txtcodigo.Text)

            };
            dato.guardar(modelo);
        }
        private void consultar ()
        {
            foreach (var item in dato.consultar())
            {
                DataRow fila = Tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Codigo"]= item.Codigo;
                Tabla.Rows.Add(fila);
            }
        }
        private void limpiar ()
        {
            txtnombre.Text = "";
            txtcodigo.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

