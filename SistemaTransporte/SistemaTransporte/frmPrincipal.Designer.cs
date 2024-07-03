namespace SistemaTransporte
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionDeTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasPorUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasDelDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSistemaDeSCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulosToolStripMenuItem,
            this.impresiónToolStripMenuItem,
            this.salirToolStripMenuItem1,
            this.salirToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1898, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadesToolStripMenuItem,
            this.cuotasToolStripMenuItem,
            this.impresionDeTicketsToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(158, 49);
            this.modulosToolStripMenuItem.Text = "Modulos";
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(407, 50);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // cuotasToolStripMenuItem
            // 
            this.cuotasToolStripMenuItem.Name = "cuotasToolStripMenuItem";
            this.cuotasToolStripMenuItem.Size = new System.Drawing.Size(407, 50);
            this.cuotasToolStripMenuItem.Text = "Cuotas";
            this.cuotasToolStripMenuItem.Click += new System.EventHandler(this.cuotasToolStripMenuItem_Click);
            // 
            // impresionDeTicketsToolStripMenuItem
            // 
            this.impresionDeTicketsToolStripMenuItem.Name = "impresionDeTicketsToolStripMenuItem";
            this.impresionDeTicketsToolStripMenuItem.Size = new System.Drawing.Size(407, 50);
            this.impresionDeTicketsToolStripMenuItem.Text = "Impresion de Tickets";
            this.impresionDeTicketsToolStripMenuItem.Visible = false;
            this.impresionDeTicketsToolStripMenuItem.Click += new System.EventHandler(this.impresionDeTicketsToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(407, 50);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // impresiónToolStripMenuItem
            // 
            this.impresiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuotasPorUnidadToolStripMenuItem,
            this.cuotasDelDíaToolStripMenuItem,
            this.consultarPorFechasToolStripMenuItem});
            this.impresiónToolStripMenuItem.Name = "impresiónToolStripMenuItem";
            this.impresiónToolStripMenuItem.Size = new System.Drawing.Size(170, 49);
            this.impresiónToolStripMenuItem.Text = "Consultas";
            // 
            // cuotasPorUnidadToolStripMenuItem
            // 
            this.cuotasPorUnidadToolStripMenuItem.Name = "cuotasPorUnidadToolStripMenuItem";
            this.cuotasPorUnidadToolStripMenuItem.Size = new System.Drawing.Size(410, 50);
            this.cuotasPorUnidadToolStripMenuItem.Text = "Cuotas por unidad";
            this.cuotasPorUnidadToolStripMenuItem.Click += new System.EventHandler(this.cuotasPorUnidadToolStripMenuItem_Click);
            // 
            // cuotasDelDíaToolStripMenuItem
            // 
            this.cuotasDelDíaToolStripMenuItem.Name = "cuotasDelDíaToolStripMenuItem";
            this.cuotasDelDíaToolStripMenuItem.Size = new System.Drawing.Size(410, 50);
            this.cuotasDelDíaToolStripMenuItem.Text = "Cuotas del día";
            this.cuotasDelDíaToolStripMenuItem.Click += new System.EventHandler(this.cuotasDelDíaToolStripMenuItem_Click);
            // 
            // consultarPorFechasToolStripMenuItem
            // 
            this.consultarPorFechasToolStripMenuItem.Name = "consultarPorFechasToolStripMenuItem";
            this.consultarPorFechasToolStripMenuItem.Size = new System.Drawing.Size(410, 50);
            this.consultarPorFechasToolStripMenuItem.Text = "Consultar por Fechas";
            this.consultarPorFechasToolStripMenuItem.Click += new System.EventHandler(this.consultarPorFechasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenidoToolStripMenuItem,
            this.acercaDeSistemaDeSCCToolStripMenuItem});
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(120, 49);
            this.salirToolStripMenuItem1.Text = "Ayuda";
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(482, 50);
            this.contenidoToolStripMenuItem.Text = "Contenido";
            this.contenidoToolStripMenuItem.Click += new System.EventHandler(this.contenidoToolStripMenuItem_Click);
            // 
            // acercaDeSistemaDeSCCToolStripMenuItem
            // 
            this.acercaDeSistemaDeSCCToolStripMenuItem.Name = "acercaDeSistemaDeSCCToolStripMenuItem";
            this.acercaDeSistemaDeSCCToolStripMenuItem.Size = new System.Drawing.Size(482, 50);
            this.acercaDeSistemaDeSCCToolStripMenuItem.Text = "Acerca de Sistema de SCC";
            this.acercaDeSistemaDeSCCToolStripMenuItem.Click += new System.EventHandler(this.acercaDeSistemaDeSCCToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem2
            // 
            this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            this.salirToolStripMenuItem2.Size = new System.Drawing.Size(92, 49);
            this.salirToolStripMenuItem2.Text = "Salir";
            this.salirToolStripMenuItem2.Click += new System.EventHandler(this.salirToolStripMenuItem2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Cooperativa de transportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionDeTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSistemaDeSCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cuotasPorUnidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasDelDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorFechasToolStripMenuItem;
    }
}