namespace utilizacion_componentes
{
    partial class frm_Elegir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AbrirReproductor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_AbrirPdf = new System.Windows.Forms.Button();
            this.btn_AbrirNavegador = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AbrirReproductor
            // 
            this.btn_AbrirReproductor.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_AbrirReproductor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AbrirReproductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AbrirReproductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_AbrirReproductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirReproductor.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirReproductor.Location = new System.Drawing.Point(72, 78);
            this.btn_AbrirReproductor.Name = "btn_AbrirReproductor";
            this.btn_AbrirReproductor.Size = new System.Drawing.Size(185, 60);
            this.btn_AbrirReproductor.TabIndex = 0;
            this.btn_AbrirReproductor.Text = "Reproductor de video";
            this.btn_AbrirReproductor.UseVisualStyleBackColor = false;
            this.btn_AbrirReproductor.Click += new System.EventHandler(this.btn_AbrirReproductor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_Minimizar);
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 34);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.Location = new System.Drawing.Point(271, 5);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(27, 19);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.Text = "--";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(304, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 21);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.Text = "x";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_AbrirPdf
            // 
            this.btn_AbrirPdf.BackColor = System.Drawing.Color.Bisque;
            this.btn_AbrirPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_AbrirPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirPdf.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirPdf.Location = new System.Drawing.Point(72, 135);
            this.btn_AbrirPdf.Name = "btn_AbrirPdf";
            this.btn_AbrirPdf.Size = new System.Drawing.Size(185, 48);
            this.btn_AbrirPdf.TabIndex = 1;
            this.btn_AbrirPdf.Text = "Lector PDF";
            this.btn_AbrirPdf.UseVisualStyleBackColor = false;
            this.btn_AbrirPdf.Click += new System.EventHandler(this.btn_AbrirPdf_Click);
            // 
            // btn_AbrirNavegador
            // 
            this.btn_AbrirNavegador.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_AbrirNavegador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_AbrirNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirNavegador.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirNavegador.ImageKey = "(ninguno)";
            this.btn_AbrirNavegador.Location = new System.Drawing.Point(72, 181);
            this.btn_AbrirNavegador.Name = "btn_AbrirNavegador";
            this.btn_AbrirNavegador.Size = new System.Drawing.Size(185, 48);
            this.btn_AbrirNavegador.TabIndex = 3;
            this.btn_AbrirNavegador.Text = "Navegador Web";
            this.btn_AbrirNavegador.UseVisualStyleBackColor = false;
            this.btn_AbrirNavegador.Click += new System.EventHandler(this.btn_AbrirNavegador_Click);
            // 
            // frm_Elegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(337, 265);
            this.Controls.Add(this.btn_AbrirNavegador);
            this.Controls.Add(this.btn_AbrirPdf);
            this.Controls.Add(this.btn_AbrirReproductor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Elegir";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Elegir";
            this.Load += new System.EventHandler(this.frm_Elegir_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AbrirReproductor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.Button btn_AbrirPdf;
        private System.Windows.Forms.Button btn_AbrirNavegador;
    }
}