namespace utilizacion_componentes
{
    partial class frm_Reproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reproductor));
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Reproducir = new System.Windows.Forms.Button();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.btn_Pausar = new System.Windows.Forms.Button();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cargar.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Cargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cargar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargar.Location = new System.Drawing.Point(14, 361);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(93, 26);
            this.btn_Cargar.TabIndex = 1;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = false;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // btn_Reproducir
            // 
            this.btn_Reproducir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reproducir.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Reproducir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_Reproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reproducir.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reproducir.Location = new System.Drawing.Point(113, 361);
            this.btn_Reproducir.Name = "btn_Reproducir";
            this.btn_Reproducir.Size = new System.Drawing.Size(93, 26);
            this.btn_Reproducir.TabIndex = 2;
            this.btn_Reproducir.Text = "Reproducir";
            this.btn_Reproducir.UseVisualStyleBackColor = false;
            this.btn_Reproducir.Click += new System.EventHandler(this.btn_Reproducir_Click);
            // 
            // btn_Parar
            // 
            this.btn_Parar.Location = new System.Drawing.Point(229, 310);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar.TabIndex = 3;
            this.btn_Parar.Text = "Parar";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // btn_Pausar
            // 
            this.btn_Pausar.Location = new System.Drawing.Point(326, 310);
            this.btn_Pausar.Name = "btn_Pausar";
            this.btn_Pausar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pausar.TabIndex = 4;
            this.btn_Pausar.Text = "Pausar";
            this.btn_Pausar.UseVisualStyleBackColor = true;
            this.btn_Pausar.Click += new System.EventHandler(this.btn_Pausar_Click);
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.AutoSize = true;
            this.lbl_Ruta.Location = new System.Drawing.Point(4, 310);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(35, 13);
            this.lbl_Ruta.TabIndex = 5;
            this.lbl_Ruta.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 40);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(690, 317);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.img_maximizar);
            this.panel1.Controls.Add(this.btn_Minimizar);
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 44);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // img_maximizar
            // 
            this.img_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_maximizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.img_maximizar.Image = global::utilizacion_componentes.Properties.Resources.maximize_filled_icon_202081;
            this.img_maximizar.Location = new System.Drawing.Point(617, 12);
            this.img_maximizar.Name = "img_maximizar";
            this.img_maximizar.Size = new System.Drawing.Size(30, 22);
            this.img_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_maximizar.TabIndex = 3;
            this.img_maximizar.TabStop = false;
            this.img_maximizar.Click += new System.EventHandler(this.img_maximizar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.Location = new System.Drawing.Point(580, 12);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(31, 21);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.Text = "--";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(653, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 21);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.Text = "x";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // frm_Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(690, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lbl_Ruta);
            this.Controls.Add(this.btn_Pausar);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.btn_Reproducir);
            this.Controls.Add(this.btn_Cargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Reproducir;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Button btn_Pausar;
        private System.Windows.Forms.Label lbl_Ruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.PictureBox img_maximizar;
    }
}

