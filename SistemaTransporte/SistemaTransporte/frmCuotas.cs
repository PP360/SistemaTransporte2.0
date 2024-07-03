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
    public partial class frmCuotas : Form
    {
        AccesoDatos ad = new AccesoDatos();
       string fechaExpedicion = DateTime.Now.ToString("yyyy-MM-dd");
        public frmCuotas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtAhorro.Text = "0";
            txtCuota.Text = "115";
            txtFiniquito.Text = "10";
            txtSeguroChofer.Text="51";
            txtSeguroPosturero.Text = "51";
            txtSeguroSocio.Text = "40";
            cbNumeroUnidad.Text = "Seleccione";
            txtOtros.Text = "0";
            txtTotal.Text = "0";
            MessageBox.Show("Puede ingresar un nuevo ticket");
            //btnGuardar.Enabled = false;
           // btnImprimir.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbNumeroUnidad.Text != "")
            {
                if ((txtTotal.Text != "0")&&(cbNumeroUnidad.Text!="Seleccione"))
                {
                    string fechaBusqueda = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month +
                           "-" + dtpFecha.Value.Day;
                    string sql = "SELECT Cuota_Administrativa,Seguro_Chofer,Seguro_posturero,Seguro_socio," +
                        "Finiquito,Ahorro,Otros,Total,id_cuota FROM cuotas WHERE No_Unidad =" + cbNumeroUnidad.Text +
                        " AND fecha='" + fechaBusqueda + "'";

                    DataSet ds = new DataSet();
                    ds = ad.consultarDatos(sql);
                    int cantidadRegistros = 0;

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cantidadRegistros = ds.Tables[0].Rows.Count;
                        string fechaActual = dtpFechaActual.Value.Year + "-" + dtpFechaActual.Value.Month +
                                  "-" + dtpFechaActual.Value.Day;
                        string id_cuota = ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString();
                        MessageBox.Show("Registro almacenado previamente, se va a actualizar la información");
                        sql = "UPDATE cuotas SET Cuota_Administrativa = " + txtCuota.Text + ", Seguro_Chofer =" +
                            txtSeguroChofer.Text + " , Seguro_posturero =" + txtSeguroPosturero.Text + "" +
                            ", Seguro_socio = " + txtSeguroSocio.Text + ",Finiquito = " + txtFiniquito.Text + ", Ahorro = " +
                            txtAhorro.Text + ", Otros = " + txtOtros.Text + ", Total =" +
                            txtTotal.Text + ", FechaExpedicion = '" + fechaActual + "' WHERE id_cuota =" + id_cuota;
                        //txtOtros.Text = sql;
                        int actualizado = 0;
                        actualizado = ad.Ejecutar(sql);
                        if (actualizado > 0)
                        {
                            MessageBox.Show("Los datos de la cuota se han actualizado, ahora puede imprimir su ticket");
                            for (int i = 0; i < lbxFechaAdeudos.Items.Count; i++)
                            {
                                if (dtpFecha.Value.ToString() == lbxFechaAdeudos.Items[i].ToString())
                                {
                                    lbxFechaAdeudos.Items.RemoveAt(i);
                                    //Cambiar el campo pagado en la tabla adeudos.
                                    string fechaAdeudo = dtpFecha.Value.Year.ToString() + "-"
                         + dtpFecha.Value.Month.ToString() + "-"
                         + dtpFecha.Value.Day.ToString();
                                    string sqlCad = "UPDATE ADEUDOS SET Pagado=1 WHERE No_unidad=" +
                                        cbNumeroUnidad.Text + " AND Fecha='" + fechaAdeudo + "'";
                                   // txtOtros.Text = sqlCad;
                                    int adeudoActualizado = ad.Ejecutar(sqlCad);
                                    if (adeudoActualizado > 0)
                                    {
                                        MessageBox.Show("Adeudo del día " + dtpFecha.Value.ToString() + " Saldado.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Los datos de la cuota no se han podido Actualizar ");
                        }

                    }
                    else
                    { 
                    //Queda convertir elformato del datapicktext a yyyy-MM-dd
                    string formatoFecha = dtpFecha.Value.Year.ToString() + "-"
                        + dtpFecha.Value.Month.ToString() + "-" 
                        +dtpFecha.Value.Day.ToString();

                     sql = "INSERT INTO cuotas(Fecha,No_Unidad,Cuota_Administrativa,Seguro_Chofer,Seguro_posturero," +
                        "Seguro_socio,Finiquito,Ahorro,Otros,Total,fechaExpedicion) VALUES ('" + formatoFecha + "'," + cbNumeroUnidad.Text + "," +
                        txtCuota.Text + "," + txtSeguroChofer.Text + "," + txtSeguroPosturero.Text + "," + txtSeguroSocio.Text +","+
                        txtFiniquito.Text + "," + txtAhorro.Text + "," + txtOtros.Text + "," + txtTotal.Text + ",'"+fechaExpedicion+"')";

                    int insertado = 0;
                    
                    insertado = ad.Ejecutar(sql);
                   
                    if (insertado > 0)
                    {
                        MessageBox.Show("Los datos de la cuota se han agregado con éxito, ahora puede imprimir su ticket");
                            //btnImprimir.Enabled = true;
                            for (int i = 0; i < lbxFechaAdeudos.Items.Count; i++)
                            {
                                if (dtpFecha.Value.ToString() == lbxFechaAdeudos.Items[i].ToString())
                                {
                                    lbxFechaAdeudos.Items.RemoveAt(i);
                                    //Cambiar el campo pagado en la tabla adeudos.
                                    string fechaAdeudo = dtpFecha.Value.Year.ToString() + "-"
                         + dtpFecha.Value.Month.ToString() + "-"
                         + dtpFecha.Value.Day.ToString();
                                    string sqlCad = "UPDATE ADEUDOS SET Pagado=1 WHERE No_unidad=" +
                                        cbNumeroUnidad.Text + " AND Fecha='" + fechaAdeudo + "'";
                                    //txtOtros.Text = sqlCad;
                                    int adeudoActualizado = ad.Ejecutar(sqlCad);
                                    if (adeudoActualizado > 0)
                                    {
                                        MessageBox.Show("Adeudo del día " + dtpFecha.Value.ToString() + " Saldado.");
                                    }
                                }
                            }
                        }
                    else
                    {
                        MessageBox.Show("Los datos de la cuota no se han podido Agregar ");
                   
                    }

                    }
                }
                else
                {
                    MessageBox.Show("Presione el botón Calcular Total para Calcular, el monto total debe ser mayor que 0 y/o seleccione un No. de Unidad");

                }
            }
            else
            {
                MessageBox.Show("Debe elegir un No. de Unidad ");
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            float total, cuota, seguroChofer, seguroPosturero, seguroSocio, finiquito, ahorro, otros;
            try
            {
                cuota = float.Parse(txtCuota.Text);
                seguroChofer = float.Parse(txtSeguroChofer.Text);
                seguroPosturero = float.Parse(txtSeguroPosturero.Text);
                seguroSocio = float.Parse(txtSeguroSocio.Text);
                finiquito = float.Parse(txtFiniquito.Text);
                ahorro = float.Parse(txtAhorro.Text);
                otros = float.Parse(txtOtros.Text);
                total = cuota + seguroChofer + seguroPosturero + seguroSocio + finiquito + ahorro + otros;
                txtTotal.Text = total.ToString();
                btnGuardar.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmCuotas_Load(object sender, EventArgs e)
        {


            string sql = "Select Numero from Unidades where Estatus='ACTIVA'";
            DataSet ds = ad.consultarDatos(sql);
            cbNumeroUnidad.Items.Add("Seleccione");
            cbNumeroUnidad.Text = "Seleccione";
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                cbNumeroUnidad.Items.Add(ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString());

            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbNumeroUnidad.Text == "Seleccione")
                {
                    MessageBox.Show("Debe seleccionar un numero de unidad");
                }
                else
                {
                    
                        CrearTicket Ticket1 = new CrearTicket();
                        Ticket1.AbreCajon();  //abre el cajon
                        Ticket1.TextoCentro("");
                        Ticket1.LineasGuion(); // imprime una linea de guiones
                        Ticket1.TextoCentro("SCC"); // imprime en el centro "SCC"
                        Ticket1.LineasGuion(); // imprime una linea de guiones

                        Ticket1.TextoIzquierda("Unidad: " + cbNumeroUnidad.Text);
                        Ticket1.TextoCentro("");
                        Ticket1.TextoIzquierda("Fecha: " + fechaExpedicion);
                        Ticket1.TextoIzquierda("Operador: COMBI");
                        Ticket1.LineasGuion(); // imprime una linea de guiones
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("COBRO CUOTA DIARIA");
                        Ticket1.TextoCentro("");
                        Ticket1.LineasGuion(); // imprime una linea de guiones

                        string fechaBusqueda = dtpFechaActual.Value.Year + "-" + dtpFechaActual.Value.Month +
                            "-" + dtpFechaActual.Value.Day;
                        string sql = "SELECT date_format(fecha,'%d/%m/%Y'), Total,id_cuota FROM Cuotas WHERE No_unidad =" + cbNumeroUnidad.Text +
                        " AND FechaExpedicion = '" + fechaBusqueda + "' ORDER BY(fecha)";
                        //MessageBox.Show(sql);
                        //txtOtros.Text = sql;
                        DataSet ds = new DataSet();
                        ds = ad.consultarDatos(sql);
                       //txtAhorro.Text = sql;
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                        //string id = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();

                        //Ticket1.TextoCentro(id);
                        //Ticket1.TextoCentro("");
                        float granTotal = 0;
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                string fecha = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();

                                string total = ds.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();
                                Ticket1.TextoIzquierda("Fecha:" + fecha + "     Total:$ " + total);
                            granTotal += float.Parse(total);
                            }
                            Ticket1.LineasGuion(); // imprime una linea de guiones
                        Ticket1.TextoDerecha("Gran Total: "+granTotal);
                            Ticket1.CortaTicket(); // corta el ticket
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargarPago_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT Cuota_Administrativa,Seguro_Chofer," +
                "Seguro_posturero,Seguro_socio, Finiquito," +
                "Ahorro,Otros,Total FROM cuotas WHERE No_Unidad =" + cbNumeroUnidad.Text;
                DataSet ds = new DataSet();
                ds = ad.consultarDatos(sql);
                int cantidadRegistros = 0;
              
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cantidadRegistros = ds.Tables[0].Rows.Count;
                    MessageBox.Show("Se cargaran los datos almacenados, presione el botón calcular para generar el total.");
                    txtCuota.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(0).ToString();
                    txtSeguroChofer.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(1).ToString();
                    txtSeguroPosturero.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(2).ToString();
                    txtSeguroSocio.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(3).ToString();
                    txtFiniquito.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(4).ToString();
                    txtAhorro.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(5).ToString();
                    txtOtros.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(6).ToString();
                    // txtTotal.Text = ds.Tables[0].Rows[cantidadRegistros - 1].ItemArray.GetValue(7).ToString();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+ ", Seleccione un No. de Unidad");
            }
            
            

        }

        private void cbNumeroUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbNumeroUnidad.Text != "Seleccione")
            {
                lbxFechaAdeudos.Items.Clear();
                string sql = "Select fecha From adeudos where No_unidad=" + cbNumeroUnidad.Text+" and pagado=0";
                DateTime fechaAdeudo;
                DataSet ds = ad.consultarDatos(sql);
                int cantidadRegistros = ds.Tables[0].Rows.Count;
                if (cantidadRegistros>0)
                { 
                MessageBox.Show("La unidad " + cbNumeroUnidad.Text +
                  " tiene " + cantidadRegistros.ToString() + " días de adeudo");
                //MessageBox.Show(cantidadRegistros.ToString());
                for (int i = 0; i < cantidadRegistros; i++)
                {
                    fechaAdeudo = DateTime.Parse(ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString());
                    lbxFechaAdeudos.Items.Add(fechaAdeudo);
                }
                }
            }

        }

        private void lbxFechaAdeudos_DoubleClick(object sender, EventArgs e)
        {
            DateTime fechaAdeudo = DateTime.Parse(lbxFechaAdeudos.SelectedItem.ToString());
            string fechaPagoAdeudo = fechaAdeudo.ToShortDateString();
            dtpFecha.Text = fechaPagoAdeudo;
            MessageBox.Show("Se ha cargado la fecha de pago: "+fechaPagoAdeudo);
        }

        private void btnAdeudosDía_Click(object sender, EventArgs e)
        {
            string sql = "SELECT  Numero FROM unidades WHERE Estatus='ACTIVA'";
            DataSet ds = new DataSet();
            ds = ad.consultarDatos(sql);
            DataSet ds1 = new DataSet();
            int cantidadUnidades = ds.Tables[0].Rows.Count;
                 
            for (int i = 0; i < cantidadUnidades; i++)
            {
                string unidad = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                string fechaAdeudo1 = dtpFechaAdeudo.Value.Year.ToString() + "-"
                         + dtpFechaAdeudo.Value.Month.ToString() + "-"
                         + dtpFechaAdeudo.Value.Day.ToString();
                sql = "SELECT No_Unidad,Fecha FROM cuotas WHERE No_unidad="+ unidad
                    +" AND Fecha='"+fechaAdeudo1+"'";
                ds1 = ad.consultarDatos(sql);
                int cantidadPagos = ds1.Tables[0].Rows.Count;
                if (cantidadPagos > 0)
                {
                    string unidadPago = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    //MessageBox.Show("Unidad: " + unidad + " Unidad pagada: " + unidadPago);
                }
                else
                {

                   // MessageBox.Show("Unidad que no pagó: " + unidad);
                    //Aquí se almacena en la Tabla de adeudos.
                    string fechaAdeudo2 = dtpFechaAdeudo.Value.Year.ToString() + "-"
                         + dtpFechaAdeudo.Value.Month.ToString() + "-"
                         + dtpFechaAdeudo.Value.Day.ToString();
                    //Corroborar si ya existe el adeudo de la unidad en el día indicado para no 
                    //duplicar el registro
                    string cadenaSql = "SELECT * From adeudos WHERE Fecha='" +
                       fechaAdeudo2+ "' AND No_unidad=" +unidad;
                    
                    DataSet dsAdeudoRegistrado = new DataSet();
                    dsAdeudoRegistrado = ad.consultarDatos(cadenaSql);

                    if (dsAdeudoRegistrado.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("ya hay un adeudo registrado para la unidad " + unidad +
                            " En la fecha: " + dtpFechaAdeudo.Text);
                    }
                    else
                    {

                       // Insertar el registro en la tabla de adeudos
                    string sqlAdeudo = "INSERT INTO adeudos(No_unidad, Fecha, Pagado) VALUES('"
                             + unidad + "','" + fechaAdeudo2 + "', 0)";
                        int adeudoGuardado = ad.Ejecutar(sqlAdeudo);
                        MessageBox.Show("Se registró el adeudo de la unidad : " + unidad +
                            " en la fecha: " + dtpFechaAdeudo.Text);
                    }


                }
            }

        }

        private void btnAdeudosDía_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT  Numero FROM unidades WHERE Estatus='ACTIVA'";
            DataSet ds = new DataSet();
            ds = ad.consultarDatos(sql);
            DataSet ds1 = new DataSet();
            int cantidadUnidades = ds.Tables[0].Rows.Count;

            for (int i = 0; i < cantidadUnidades; i++)
            {
                string unidad = ds.Tables[0].Rows[i].ItemArray.GetValue(0).ToString();
                string fechaAdeudo1 = dtpFechaAdeudo.Value.Year.ToString() + "-"
                         + dtpFechaAdeudo.Value.Month.ToString() + "-"
                         + dtpFechaAdeudo.Value.Day.ToString();
                sql = "SELECT No_Unidad,Fecha FROM cuotas WHERE No_unidad=" + unidad
                    + " AND Fecha='" + fechaAdeudo1 + "'";
                ds1 = ad.consultarDatos(sql);
                int cantidadPagos = ds1.Tables[0].Rows.Count;
                if (cantidadPagos > 0)
                {
                    string unidadPago = ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    //MessageBox.Show("Unidad: " + unidad + " Unidad pagada: " + unidadPago);
                }
                else
                {

                    // MessageBox.Show("Unidad que no pagó: " + unidad);
                    //Aquí se almacena en la Tabla de adeudos.
                    string fechaAdeudo2 = dtpFechaAdeudo.Value.Year.ToString() + "-"
                         + dtpFechaAdeudo.Value.Month.ToString() + "-"
                         + dtpFechaAdeudo.Value.Day.ToString();
                    //Corroborar si ya existe el adeudo de la unidad en el día indicado para no 
                    //duplicar el registro
                    string cadenaSql = "SELECT * From adeudos WHERE Fecha='" +
                       fechaAdeudo2 + "' AND No_unidad=" + unidad;

                    DataSet dsAdeudoRegistrado = new DataSet();
                    dsAdeudoRegistrado = ad.consultarDatos(cadenaSql);

                    if (dsAdeudoRegistrado.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("ya hay un adeudo registrado para la unidad " + unidad +
                            " En la fecha: " + dtpFechaAdeudo.Text);
                    }
                    else
                    {

                        // Insertar el registro en la tabla de adeudos
                        string sqlAdeudo = "INSERT INTO adeudos(No_unidad, Fecha, Pagado) VALUES('"
                                 + unidad + "','" + fechaAdeudo2 + "', 0)";
                        int adeudoGuardado = ad.Ejecutar(sqlAdeudo);
                        MessageBox.Show("Se registró el adeudo de la unidad : " + unidad +
                            " en la fecha: " + dtpFechaAdeudo.Text);
                    }


                }
            }
        }
    }
}


