﻿using System;
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
    /// <summary>
    /// Codigo formulario de reproductor de video
    /// </summary>
    public partial class frm_Reproductor : Form
    {
        private string ruta = "";
        bool mov = false;
        public frm_Reproductor()
        {
            InitializeComponent();
        }

        // minimizar formulario
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

        // cerrar formulario
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // eventos para mover el formulario 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                this.Location = Cursor.Position;
            }
        }
        // buscar video 
        private void btn_Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = openFileDialog1.FileName;
                    lbl_Ruta.Text = ruta;
                }
            }
            catch
            {
                MessageBox.Show(" ERROR : No ha escogido nigun archivo ");
            }
             
        }
        // reproducir el video
        private void btn_Reproducir_Click(object sender, EventArgs e)
        {
            // ruta es donde se guarda el video
            if (ruta == "")
            {
                errorProvider1.SetError(btn_Reproducir, " Debe cargar un archivo ");
                btn_Reproducir.Focus();
                return;
            }
            errorProvider1.SetError(btn_Reproducir, "");
            try
            {
                axWindowsMediaPlayer1.URL = ruta; //Indicar donde esta el video 
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch
            {
                MessageBox.Show("ERROR : Tipo de archivo no valido ");
            }
            
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btn_Pausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        
    }
}
