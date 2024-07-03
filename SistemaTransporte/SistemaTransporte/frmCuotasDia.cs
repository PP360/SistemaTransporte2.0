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
    public partial class frmCuotasDia : Form
    {
        AccesoDatos ad = new AccesoDatos();
        public frmCuotasDia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipoFecha.Text == "Fecha de la Cuota")
                {
                    string fechaBusqueda = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day;
                    string sql =
                    "SELECT date_format(fecha,'%d/%m/%Y') as fechaCuota,date_format(fechaExpedicion,'%d/%m/%Y')" +
                    " as fechaPago,No_unidad,cuota_administrativa," +
                    "seguro_chofer,seguro_posturero,seguro_socio, finiquito, ahorro, otros," +
                    " Total from cuotas Where fecha='" + fechaBusqueda + "' Order by (No_unidad)";
                    if (dtpFecha.Text != "")
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
                else if (cbTipoFecha.Text == "Fecha En que se pagó la cuota")
                {
                    string fechaBusqueda = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day;
                    string sql =
                    "SELECT date_format(fecha,'%d/%m/%Y') as fechaCuota,date_format(fechaExpedicion,'%d/%m/%Y')" +
                    " as fechaPago,No_unidad,cuota_administrativa," +
                    "seguro_chofer,seguro_posturero,seguro_socio, finiquito, ahorro, otros," +
                    " Total from cuotas Where fechaExpedicion='" + fechaBusqueda + "' Order by (No_unidad)";
                    if (dtpFecha.Text != "")
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
    }
}
