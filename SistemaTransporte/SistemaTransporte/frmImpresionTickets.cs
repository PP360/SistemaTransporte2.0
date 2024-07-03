using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaTransporte
{
    public partial class frmImpresionTickets : Form
    {
        AccesoDatos ad = new AccesoDatos();
        public frmImpresionTickets()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "")
            {
                CrearTicket Ticket1 = new CrearTicket();
                Ticket1.AbreCajon();  //abre el cajon
                Ticket1.TextoCentro("");
                Ticket1.LineasGuion(); // imprime una linea de guiones
                Ticket1.TextoCentro("SCC"); // imprime en el centro "SCC"
                Ticket1.LineasGuion(); // imprime una linea de guiones

                Ticket1.TextoIzquierda("Unidad: " + txtNumeroUnidad.Text);
                Ticket1.TextoCentro("");
                Ticket1.TextoIzquierda("Fecha: " + txtFechaExpedicion.Text);
                Ticket1.TextoIzquierda("Operador: COMBI");
                Ticket1.LineasGuion(); // imprime una linea de guiones
                Ticket1.TextoCentro("");
                Ticket1.TextoCentro("COBRO CUOTA DIARIA");
                Ticket1.TextoCentro("");
                Ticket1.LineasGuion(); // imprime una linea de guiones
                Ticket1.TextoIzquierda("Fecha:" +txtFecha.Text + "     Total:$ " + txtTotal.Text);
                Ticket1.LineasGuion(); // imprime una linea de guiones
                Ticket1.CortaTicket(); // corta el ticket
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Desea imprimir un ticket sin datos?", "Imprimir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == respuesta)
                {
                    CrearTicket Ticket1 = new CrearTicket();
                    Ticket1.AbreCajon();  //abre el cajon
                    Ticket1.TextoCentro("");
                    Ticket1.LineasGuion(); // imprime una linea de guiones
                    Ticket1.TextoCentro("SCC"); // imprime en el centro "SCC"
                    Ticket1.LineasGuion(); // imprime una linea de guiones

                    Ticket1.TextoIzquierda("Unidad: " + txtNumeroUnidad.Text);
                    Ticket1.TextoCentro("");
                    Ticket1.TextoIzquierda("Fecha: " + txtFecha.Text);
                    Ticket1.TextoIzquierda("Operador: COMBI");
                    Ticket1.LineasGuion(); // imprime una linea de guiones
                    Ticket1.TextoCentro("");
                    Ticket1.TextoCentro("COBRO CUOTA DIARIA");
                    Ticket1.TextoCentro("");

                    Ticket1.TextoIzquierda("Total:$ " + txtTotal.Text);
                    Ticket1.CortaTicket(); // corta el ticket

                }
            }
        }

        private void frmImpresionTickets_Load(object sender, EventArgs e)
        {
            string sql =
                  "SELECT date_format(fecha,'%d/%m/%Y') as fecha_Cuota, No_Unidad,Total,date_format(fechaExpedicion,'%d/%m/%Y')as fecha_Expedicion from cuotas ORDER BY(Fecha) DESC";
            dgvTickets.AutoResizeColumns();
            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTickets.DataSource = ad.consultarDatos(sql).Tables[0];
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvTickets.CurrentRow.Index;               
                txtFecha.Text = dgvTickets.Rows[fila].Cells[0].Value.ToString();
                txtNumeroUnidad.Text = dgvTickets.Rows[fila].Cells[1].Value.ToString();
                txtTotal.Text = dgvTickets.Rows[fila].Cells[2].Value.ToString();
                txtFechaExpedicion.Text= dgvTickets.Rows[fila].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
