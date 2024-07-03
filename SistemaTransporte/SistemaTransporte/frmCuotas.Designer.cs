namespace SistemaTransporte
{
    partial class frmCuotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumeroUnidad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAhorro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiniquito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeguroSocio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeguroPosturero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeguroChofer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCargarPago = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxFechaAdeudos = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpFechaAdeudo = new System.Windows.Forms.DateTimePicker();
            this.btnAdeudosDía = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1576, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de la cuota a pagar\r\n";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(1960, 138);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(192, 44);
            this.dtpFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. De Unidad";
            // 
            // cbNumeroUnidad
            // 
            this.cbNumeroUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumeroUnidad.FormattingEnabled = true;
            this.cbNumeroUnidad.Location = new System.Drawing.Point(722, 200);
            this.cbNumeroUnidad.Name = "cbNumeroUnidad";
            this.cbNumeroUnidad.Size = new System.Drawing.Size(192, 45);
            this.cbNumeroUnidad.TabIndex = 2;
            this.cbNumeroUnidad.SelectedIndexChanged += new System.EventHandler(this.cbNumeroUnidad_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTotal);
            this.groupBox1.Controls.Add(this.txtOtros);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAhorro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFiniquito);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSeguroSocio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSeguroPosturero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSeguroChofer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCuota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1548, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 608);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargos";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(398, 488);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(179, 57);
            this.btnTotal.TabIndex = 14;
            this.btnTotal.Text = "Calcular Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtOtros
            // 
            this.txtOtros.Location = new System.Drawing.Point(441, 399);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.Size = new System.Drawing.Size(136, 44);
            this.txtOtros.TabIndex = 9;
            this.txtOtros.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 37);
            this.label10.TabIndex = 14;
            this.label10.Text = "Otros:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(194, 495);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(142, 39);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "TOTAL:";
            // 
            // txtAhorro
            // 
            this.txtAhorro.Location = new System.Drawing.Point(439, 342);
            this.txtAhorro.Name = "txtAhorro";
            this.txtAhorro.Size = new System.Drawing.Size(136, 44);
            this.txtAhorro.TabIndex = 8;
            this.txtAhorro.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ahorro:";
            // 
            // txtFiniquito
            // 
            this.txtFiniquito.Location = new System.Drawing.Point(441, 285);
            this.txtFiniquito.Name = "txtFiniquito";
            this.txtFiniquito.Size = new System.Drawing.Size(136, 44);
            this.txtFiniquito.TabIndex = 7;
            this.txtFiniquito.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Finiquito:";
            // 
            // txtSeguroSocio
            // 
            this.txtSeguroSocio.Location = new System.Drawing.Point(441, 229);
            this.txtSeguroSocio.Name = "txtSeguroSocio";
            this.txtSeguroSocio.Size = new System.Drawing.Size(136, 44);
            this.txtSeguroSocio.TabIndex = 6;
            this.txtSeguroSocio.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seguro Socio:";
            // 
            // txtSeguroPosturero
            // 
            this.txtSeguroPosturero.Location = new System.Drawing.Point(441, 168);
            this.txtSeguroPosturero.Name = "txtSeguroPosturero";
            this.txtSeguroPosturero.Size = new System.Drawing.Size(136, 44);
            this.txtSeguroPosturero.TabIndex = 5;
            this.txtSeguroPosturero.Text = "51";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Seguro Posturero:";
            // 
            // txtSeguroChofer
            // 
            this.txtSeguroChofer.Location = new System.Drawing.Point(441, 105);
            this.txtSeguroChofer.Name = "txtSeguroChofer";
            this.txtSeguroChofer.Size = new System.Drawing.Size(136, 44);
            this.txtSeguroChofer.TabIndex = 4;
            this.txtSeguroChofer.Text = "51";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seguro Chofer:";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(441, 45);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(136, 44);
            this.txtCuota.TabIndex = 3;
            this.txtCuota.Text = "115";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cuota Administrativa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2233, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 586);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(50, 473);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 63);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(50, 334);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 63);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo Ticket";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(39, 207);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(172, 63);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir Ticket";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(50, 83);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 63);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaActual.Location = new System.Drawing.Point(722, 137);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(616, 44);
            this.dtpFechaActual.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 37);
            this.label11.TabIndex = 7;
            this.label11.Text = "Fecha del pago:";
            // 
            // btnCargarPago
            // 
            this.btnCargarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPago.Location = new System.Drawing.Point(2271, 145);
            this.btnCargarPago.Name = "btnCargarPago";
            this.btnCargarPago.Size = new System.Drawing.Size(184, 63);
            this.btnCargarPago.TabIndex = 14;
            this.btnCargarPago.Text = "Cargar Pago";
            this.btnCargarPago.UseVisualStyleBackColor = true;
            this.btnCargarPago.Click += new System.EventHandler(this.btnCargarPago_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxFechaAdeudos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(451, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 542);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adeudos de la unidad";
            // 
            // lbxFechaAdeudos
            // 
            this.lbxFechaAdeudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFechaAdeudos.FormattingEnabled = true;
            this.lbxFechaAdeudos.ItemHeight = 37;
            this.lbxFechaAdeudos.Location = new System.Drawing.Point(36, 75);
            this.lbxFechaAdeudos.Name = "lbxFechaAdeudos";
            this.lbxFechaAdeudos.Size = new System.Drawing.Size(810, 448);
            this.lbxFechaAdeudos.TabIndex = 0;
            this.lbxFechaAdeudos.DoubleClick += new System.EventHandler(this.lbxFechaAdeudos_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFechaAdeudo);
            this.groupBox4.Controls.Add(this.btnAdeudosDía);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(466, 928);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(872, 192);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione una fecha para generar Adeudos";
            // 
            // dtpFechaAdeudo
            // 
            this.dtpFechaAdeudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAdeudo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAdeudo.Location = new System.Drawing.Point(44, 78);
            this.dtpFechaAdeudo.Name = "dtpFechaAdeudo";
            this.dtpFechaAdeudo.Size = new System.Drawing.Size(390, 39);
            this.dtpFechaAdeudo.TabIndex = 19;
            // 
            // btnAdeudosDía
            // 
            this.btnAdeudosDía.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdeudosDía.Location = new System.Drawing.Point(476, 58);
            this.btnAdeudosDía.Name = "btnAdeudosDía";
            this.btnAdeudosDía.Size = new System.Drawing.Size(332, 85);
            this.btnAdeudosDía.TabIndex = 18;
            this.btnAdeudosDía.Text = "Cierre de pagos del día";
            this.btnAdeudosDía.UseVisualStyleBackColor = true;
            this.btnAdeudosDía.Click += new System.EventHandler(this.btnAdeudosDía_Click_1);
            // 
            // frmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2878, 1524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCargarPago);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFechaActual);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNumeroUnidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Name = "frmCuotas";
            this.Text = "Tickets de Cuotas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCuotas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumeroUnidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAhorro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiniquito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeguroSocio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeguroPosturero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeguroChofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCargarPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxFechaAdeudos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaAdeudo;
        private System.Windows.Forms.Button btnAdeudosDía;
    }
}