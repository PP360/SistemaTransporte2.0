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
    public partial class frmConsultaUnidad : Form
    {
        AccesoDatos ad = new AccesoDatos();
        public frmConsultaUnidad()
        {
            InitializeComponent();
        }

        private void frmConsultaUnidad_Load(object sender, EventArgs e)
        {
            string sql = "Select Numero from Unidades where Estatus='ACTIVA'";
            DataSet ds = ad.consultarDatos(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbUnidad.Items.Add(ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString());

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql =
                "SELECT date_format(fecha,'%d/%m/%Y') as fechaCuota,date_format(fechaExpedicion,'%d/%m/%Y')"+
                " as fechaPago,cuota_administrativa," +
                "seguro_chofer,seguro_posturero,seguro_socio, finiquito, ahorro, otros," +
                " Total from cuotas Where No_unidad=" + cbUnidad.Text+" Order by (fecha)";
                if (cbUnidad.Text != "")
                {
                    dgvPagosUnidad.AutoResizeColumns();
                    dgvPagosUnidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvPagosUnidad.DataSource = ad.consultarDatos(sql).Tables[0];
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un No. de Unidad");
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
               throw;
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
