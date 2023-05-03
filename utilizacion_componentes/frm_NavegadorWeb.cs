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
    public partial class frm_NavegadorWeb : Form
    {
        
        public frm_NavegadorWeb()
        {
            InitializeComponent();
        }
        bool mov = false;
        // minimizar el formulario
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
        // cerrar el formulario 
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // mover el formulario con mouse
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if( mov == true)
            {
                this.Location = Cursor.Position;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void btn_Retroceder_Click(object sender, EventArgs e)
        {
            // ir a la pagina anterior
            try
            {
                WebBrowser1.GoBack();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " +ex.Message);
            }
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            // ir a la pagian siguiente
            try
            {
                WebBrowser1.GoForward();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex);
            }
            
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            // recargar la pagina 
            try
            {
                WebBrowser1.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex);
            }
            
        }

        private void btn_Detener_Click(object sender, EventArgs e)
        {
            // detenemos la carga de la pagina
            try
            {
                WebBrowser1.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex);
            }
        }

        private void btn_Ir_Click(object sender, EventArgs e)
        {
            // ir al url puesto en el textbox
            try
            {
                WebBrowser1.Navigate(txt_Url.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex);
            }
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            try
            {
                WebBrowser1.GoHome();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex);
            }
        }

        // cargar web con tecla enter 
        private void txt_Url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                WebBrowser1.Navigate(txt_Url.Text);
            }
        }

       
    }
}
