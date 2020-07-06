using ListaGenerica.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaGenerica
{
    public partial class frmLista : Form
    {
        private List<Datos> lista = new List<Datos>();
        public frmLista()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtMatricula.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el número de matrícula...");
                this.txtMatricula.Focus();//ubica el cursor en el control
            }
            if (this.txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar la edad...");
                this.txtEdad.Focus();//ubica el cursor en el control
            }
            //convertir a entero
            if(!(int.TryParse(this.txtMatricula.Text, out int matricula)))
            {
                MessageBox.Show("Matricula no valida...");
                this.txtMatricula.Focus();
            }
            if (!(int.TryParse(this.txtEdad.Text, out int edad)))
            {
                MessageBox.Show("Valor invalido...");
                this.txtEdad.Focus();
            }
            Datos estudiante = new Datos();
            estudiante.matricula = this.txtMatricula.Text;
            estudiante.apellido = this.txtApellidos.Text;
            estudiante.nombre = this.txtNombres.Text;
            estudiante.edad = edad;
            estudiante.sexo = this.cmbSexo.Text;

            //asignar los datos en la lista de estudiantes
            lista.Add(estudiante);

            //cargar la lista en el datagridview
            this.gridEstudiantes.DataSource = null;
            this.gridEstudiantes.DataSource = lista;

            //guardar lista en el listview
            lstvEstudiante.Items.Add(new ListViewItem(this.txtMatricula.Text));
            lstvEstudiante.Items.Add(new ListViewItem(this.txtApellidos.Text));
            lstvEstudiante.Items.Add(new ListViewItem(this.txtNombres.Text));
            lstvEstudiante.Items.Add(new ListViewItem(this.txtEdad.Text));
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrarmat_Click(object sender, EventArgs e)
        {
            // Filtrar datos por matricula
            this.gridEstudiantes.DataSource = null;
            this.gridEstudiantes.DataSource = lista.Where(data => data.matricula == this.txtMatricula.Text).ToList();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //encontrar mayor y menor edad
            this.txtMayoredad.Text = lista.Max(data => data.edad).ToString();
            this.txtMenoredad.Text = lista.Min(data => data.edad).ToString();
        }
    }
}
