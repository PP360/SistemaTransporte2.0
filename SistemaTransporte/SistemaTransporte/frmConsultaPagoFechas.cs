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
    public partial class frmConsultaPagoFechas : Form
    {
        AccesoDatos ad = new AccesoDatos();
        public frmConsultaPagoFechas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaInicio = txtFechaInicio.Value.Year + "-" +
               txtFechaInicio.Value.Month + "-" + txtFechaInicio.Value.Day;
                string fechaFin = txtFechaFin.Value.Year + "-" +
                    txtFechaFin.Value.Month + "-" + txtFechaFin.Value.Day;
                //string sql = "SELECT date_format(fecha,'%d/%m/%Y') as fecha," +
                //    "date_format(fechaExpedicion,'%d/%m/%Y')as fecha_Del_Pago," +
                //    "No_Unidad,cuota_administrativa  as cuota,seguro_chofer," +
                //    "seguro_posturero,seguro_socio,finiquito,ahorro, otros,Total" +
                //    " from cuotas WHERE fecha>='" + fechaInicio + "' AND fecha<='" +
                //    fechaFin + "' ORDER BY(Fecha) DESC";
                string sql = "SELECT date_format(c.fecha,'%d/%m/%Y') as fecha,"+
                    "date_format(c.fechaExpedicion,'%d/%m/%Y')as fecha_Del_Pago,c.No_Unidad,"+
                    "c.cuota_administrativa as cuota,c.seguro_chofer,c.seguro_posturero,"+
                    "c.seguro_socio,c.finiquito,c.ahorro,c.otros,c.Total,u.socio from cuotas as c,"+
                    "unidades as u WHERE fecha>='"+fechaInicio+"' AND fecha<='"+
                    fechaFin+"' and u.numero=c.No_unidad ORDER BY(c.Fecha)";

                
                DataSet ds = new DataSet();
                ds = ad.consultarDatos(sql);
                dgvResultados.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                Trace.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
           

            

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
