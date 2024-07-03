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
    public partial class frmUnidades : Form
    {
        AccesoDatos ad = new AccesoDatos();
        public frmUnidades()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            string sql = "Select * From unidades";
            dgvUnidades.DataSource = ad.consultarDatos(sql).Tables[0];

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtChofer.Text = "";
            txtNumero.Text = "";
            txtPlaca.Text = "";
            txtSocio.Text = "";
            CbEstado.Text="Seleccione";
            txtModelo.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           string sql= "INSERT INTO unidades(NUMERO,Placa,Socio,Chofer,Modelo,Estatus) VALUES("+txtNumero.Text+",'"+
                txtPlaca.Text+"','"+txtSocio.Text+"','"+txtChofer.Text+"','"+txtModelo.Text+"','"+CbEstado.Text+"')";
            int insertado = 0;
            insertado = ad.Ejecutar(sql);
            if (insertado > 0)
            {
                MessageBox.Show("Los datos de la unidad se han agregado con éxito");
                btnNuevo_Click(null, null);
                btnListado_Click(null, null);
            }
            else
            {
                MessageBox.Show("Los datos de la unidad no se han podido Agregar ");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE UNIDADES SET Placa='" + txtPlaca.Text + "',Socio='" + txtSocio.Text +
                "',Chofer='" + txtChofer.Text + "',Modelo='" + txtModelo.Text + "',Estatus='" +
                CbEstado.Text + "' WHERE Numero=" + txtNumero.Text;
            int actualizado = 0;
            actualizado = ad.Ejecutar(sql);
            if (actualizado > 0)
            {
                MessageBox.Show("Los datos de la unidad se han actualizado con éxito");
                btnListado_Click(null, null);
                btnNuevo_Click(null, null);
            }
            else
            {
                MessageBox.Show("Los datos de la unidad no se han podido actualizar");
            }

        }

        private void frmUnidades_Load(object sender, EventArgs e)
        {
            string sql = "Select * From unidades";
            try
            {
                dgvUnidades.AutoResizeColumns();
                dgvUnidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvUnidades.DataSource = ad.consultarDatos(sql).Tables[0];
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                MessageBox.Show("No se pudieron cargar los datos");
            }
        }

        private void dgvUnidades_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvUnidades.CurrentRow.Index;
                txtNumero.Text = dgvUnidades.Rows[fila].Cells[0].Value.ToString();
                txtPlaca.Text = dgvUnidades.Rows[fila].Cells[1].Value.ToString();
                txtSocio.Text = dgvUnidades.Rows[fila].Cells[2].Value.ToString();
                txtChofer.Text = dgvUnidades.Rows[fila].Cells[3].Value.ToString();
                txtModelo.Text = dgvUnidades.Rows[fila].Cells[4].Value.ToString();
                CbEstado.Text = dgvUnidades.Rows[fila].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
    }
}
