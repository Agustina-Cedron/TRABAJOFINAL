using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tablaArbitro.Datos;
using tablaArbitro.Modelos;

namespace tablaArbitro.Vistas
{
    public partial class frm_Arbitros : Form
    {
        public frm_Arbitros()
        {
            InitializeComponent();
        }
        //region "Mis metodos"
        //private void cargarDatagridArbitro;

        private void button1_Click(object sender, EventArgs e)
        {
            DatosArbitro datos = new DatosArbitro();
            dgvArbitro.DataSource = datos.listarArbitros();
        }

       

        private void frmArbitro_Load(object sender, EventArgs e)
        {
            //this.dgvArbitro();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int _id = (int)dgvArbitro.CurrentRow.Cells[0].Value;
            DialogResult respuesta = MessageBox.Show("¿Quiere eliminar al arbitro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.Yes)
            {
                DatosArbitro datos = new DatosArbitro();
                if (datos.eliminarArbitro(_id))
                {
                    MessageBox.Show("Borrado con exito!!", "Borrado", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el arbitro", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

       private void txtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.Text = dgvArbitro.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvArbitro.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = dgvArbitro.CurrentRow.Cells[3].Value.ToString();
            txtDomicilio.Text = dgvArbitro.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvArbitro.CurrentRow.Cells[5].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = false;
            txtDni.ReadOnly = false;
            txtDomicilio.ReadOnly = false;
            txtNombre.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNewArbitro nuevo = new FormNewArbitro ();
            //nuevo.txtDni.Focus();
            nuevo.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
           
                Arbitro arbitro = new Arbitro();
                DatosArbitro datos = new DatosArbitro();
                arbitro.dni = txtDni.Text;
                arbitro.apellido = txtApellido.Text;
                arbitro.nombre = txtNombre.Text;
                arbitro.telefono = txtTelefono.Text;
                arbitro.domicilio = txtDomicilio.Text;
                arbitro.activo = true;
                if (datos.agregarArbitro(arbitro) == "OK")
                {
                    MessageBox.Show("Arbitro agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Arbitro no agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void dgvArbitro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}