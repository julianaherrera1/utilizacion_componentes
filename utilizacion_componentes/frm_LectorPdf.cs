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
    public partial class frm_LectorPdf : Form
    {
        public frm_LectorPdf()
        {
            InitializeComponent();
        }

        bool mov = false;

        //minimizar formulario
        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // maximizar formulario
        private void img_maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        // Cerrar formulario
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // mover formulario con mouse
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                this.Location = Cursor.Position;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void btn_CargarPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = fd.FileName;
            }
            else
            {
                MessageBox.Show(" Seleccione el archivo ");
            }
        }
       
    }
}
