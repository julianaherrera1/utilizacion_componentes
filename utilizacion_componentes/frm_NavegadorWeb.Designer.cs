namespace utilizacion_componentes
{
    partial class frm_NavegadorWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NavegadorWeb));
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Retroceder = new System.Windows.Forms.ToolStripButton();
            this.btn_Siguiente = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.btn_Detener = new System.Windows.Forms.ToolStripButton();
            this.txt_Url = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Ir = new System.Windows.Forms.ToolStripButton();
            this.btn_Home = new System.Windows.Forms.ToolStripButton();
            this.WebBrowser1 = new AxSHDocVw.AxWebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowser1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.img_maximizar);
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Controls.Add(this.btn_Minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 37);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // img_maximizar
            // 
            this.img_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_maximizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.img_maximizar.Image = global::utilizacion_componentes.Properties.Resources.maximize_filled_icon_202081;
            this.img_maximizar.Location = new System.Drawing.Point(701, 3);
            this.img_maximizar.Name = "img_maximizar";
            this.img_maximizar.Size = new System.Drawing.Size(29, 22);
            this.img_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_maximizar.TabIndex = 3;
            this.img_maximizar.TabStop = false;
            this.img_maximizar.Click += new System.EventHandler(this.img_maximizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(736, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 21);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.Text = "x";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.Location = new System.Drawing.Point(664, 4);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(31, 21);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.Text = "--";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Retroceder,
            this.btn_Siguiente,
            this.btn_Recargar,
            this.btn_Detener,
            this.txt_Url,
            this.btn_Ir,
            this.btn_Home});
            this.toolStrip1.Location = new System.Drawing.Point(0, 37);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Retroceder
            // 
            this.btn_Retroceder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Retroceder.Image = ((System.Drawing.Image)(resources.GetObject("btn_Retroceder.Image")));
            this.btn_Retroceder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Retroceder.Name = "btn_Retroceder";
            this.btn_Retroceder.Size = new System.Drawing.Size(23, 22);
            this.btn_Retroceder.Text = "toolStripButton1";
            this.btn_Retroceder.Click += new System.EventHandler(this.btn_Retroceder_Click);
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_Siguiente.Image")));
            this.btn_Siguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(23, 22);
            this.btn_Siguiente.Text = "toolStripButton2";
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // btn_Recargar
            // 
            this.btn_Recargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Recargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Recargar.Image")));
            this.btn_Recargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Recargar.Name = "btn_Recargar";
            this.btn_Recargar.Size = new System.Drawing.Size(23, 22);
            this.btn_Recargar.Text = "toolStripButton3";
            this.btn_Recargar.Click += new System.EventHandler(this.btn_Recargar_Click);
            // 
            // btn_Detener
            // 
            this.btn_Detener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Detener.Image = ((System.Drawing.Image)(resources.GetObject("btn_Detener.Image")));
            this.btn_Detener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Detener.Name = "btn_Detener";
            this.btn_Detener.Size = new System.Drawing.Size(23, 22);
            this.btn_Detener.Text = "toolStripButton4";
            this.btn_Detener.Click += new System.EventHandler(this.btn_Detener_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(500, 25);
            this.txt_Url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Url_KeyPress);
            // 
            // btn_Ir
            // 
            this.btn_Ir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Ir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ir.Image")));
            this.btn_Ir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Ir.Name = "btn_Ir";
            this.btn_Ir.Size = new System.Drawing.Size(23, 22);
            this.btn_Ir.Text = "toolStripButton5";
            this.btn_Ir.Click += new System.EventHandler(this.btn_Ir_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(23, 22);
            this.btn_Home.Text = "toolStripButton6";
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser1.Enabled = true;
            this.WebBrowser1.Location = new System.Drawing.Point(0, 65);
            this.WebBrowser1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WebBrowser1.OcxState")));
            this.WebBrowser1.Size = new System.Drawing.Size(781, 388);
            this.WebBrowser1.TabIndex = 5;
            // 
            // frm_NavegadorWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NavegadorWeb";
            this.Text = "frm_NavegadorWeb";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_maximizar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebBrowser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Minimizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Retroceder;
        private System.Windows.Forms.ToolStripButton btn_Siguiente;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripButton btn_Detener;
        private System.Windows.Forms.ToolStripTextBox txt_Url;
        private System.Windows.Forms.ToolStripButton btn_Ir;
        private System.Windows.Forms.ToolStripButton btn_Home;
        private AxSHDocVw.AxWebBrowser WebBrowser1;
        private System.Windows.Forms.PictureBox img_maximizar;
    }
}