using MySql.Data.MySqlClient;
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
using tablaArbitro.Vistas;

namespace tablaArbitro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baseDatos = new MySqlConnection();
            baseDatos = (new Conexion()).crearConexion();
            baseDatos.Open();
            MessageBox.Show(baseDatos.State.ToString());
            baseDatos.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funciones.Logs("Prueba", "esta es una prueba de logs");
        }

      

        private void arbitroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Arbitros ventana = new frm_Arbitros();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelVetical.Width==250)
            {
                panelVetical.Width = 70;
            }
            else
            {
                panelVetical.Width =250;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
                Application.Exit();
            
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock= DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

     
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new frm_Arbitros());
                frm_Arbitros ventana = new frm_Arbitros();
                ventana.MdiParent = this;
                ventana.Show();
           
            
        }

       
        private void FormEquipoPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }
        private void button4_Click(object sender, EventArgs e)
        {
            FormEquipoPanel(new frm_Equipo());
            frm_Equipo ventana = new frm_Equipo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
