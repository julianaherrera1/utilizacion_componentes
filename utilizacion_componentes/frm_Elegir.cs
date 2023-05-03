using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilizacion_componentes
{
    public partial class frm_Elegir : Form
    {
        public frm_Elegir()
        {
            InitializeComponent();
        }

        bool mov = false;

        // Minimizar formulario
        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }
        // Cerrar formulario
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // cuando el mouse es presionado la variable es verdadera
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
        }
        // si es verdadero, nos permite mover el formulario
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                this.Location = Cursor.Position;
            }
        }
        // cuando no se presiona el mouse, el formulario se dejara de mover 
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void btn_AbrirReproductor_Click(object sender, EventArgs e)
        {
            frm_Reproductor frm = new frm_Reproductor();
            frm.Show();
        }

        private void btn_AbrirPdf_Click(object sender, EventArgs e)
        {
            frm_LectorPdf frm = new frm_LectorPdf();
            frm.Show();
        }

        private void btn_AbrirNavegador_Click(object sender, EventArgs e)
        {
            frm_NavegadorWeb frm = new frm_NavegadorWeb();
            frm.Show();
        }

        private void frm_Elegir_Load(object sender, EventArgs e)
        {

        }
    }
}
