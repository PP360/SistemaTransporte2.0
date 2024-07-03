using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTransporte
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidades formUnidades = new frmUnidades();
            formUnidades.MdiParent = this;
            formUnidades.Show();
        }

        private void impresionDeTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpresionTickets imprimirTicket = new frmImpresionTickets();
            imprimirTicket.MdiParent = this;
            imprimirTicket.Show();
        }

        private void cuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuotas formCuotas = new frmCuotas();
            formCuotas.MdiParent = this;
            formCuotas.Show();
        }

       

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == respuesta)
            {
                Application.Exit();
            }
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == respuesta)
            {
                Application.Exit();
            }
        }

        private void cuotasPorUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUnidad formularioConsultaUnidad = new frmConsultaUnidad();
            formularioConsultaUnidad.MdiParent = this;
            formularioConsultaUnidad.Show();
        }

        private void cuotasDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuotasDia formularioCuotasDia = new frmCuotasDia();
            formularioCuotasDia.MdiParent = this;
            formularioCuotasDia.Show();
        }

        private void acercaDeSistemaDeSCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2022 SCC. Todos los derechos reservados.. Desarrollado por JVC", "Derechos de autor",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En el XAMPP Control Panel, presione start en el servicio de MySql para que" +
               " se puedan cargar los datos del sistema");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void consultarPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPagoFechas formularioFechas = new frmConsultaPagoFechas();
            formularioFechas.MdiParent = this;
            formularioFechas.Show();
        }
    }
}
