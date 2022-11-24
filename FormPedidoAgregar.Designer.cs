namespace Alfareria
{
    partial class FormPedidoAgregar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.cbxIdCliente = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR PEDIDO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaEntrega);
            this.groupBox1.Controls.Add(this.dtFechaPedido);
            this.groupBox1.Controls.Add(this.cbxIdProducto);
            this.groupBox1.Controls.Add(this.cbxIdCliente);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtIdPedido);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PEDIDO";
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.Location = new System.Drawing.Point(238, 284);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Size = new System.Drawing.Size(200, 23);
            this.dtFechaEntrega.TabIndex = 15;
            // 
            // dtFechaPedido
            // 
            this.dtFechaPedido.Location = new System.Drawing.Point(238, 247);
            this.dtFechaPedido.Name = "dtFechaPedido";
            this.dtFechaPedido.Size = new System.Drawing.Size(200, 23);
            this.dtFechaPedido.TabIndex = 14;
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(238, 106);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(132, 23);
            this.cbxIdProducto.TabIndex = 13;
            // 
            // cbxIdCliente
            // 
            this.cbxIdCliente.FormattingEnabled = true;
            this.cbxIdCliente.Location = new System.Drawing.Point(238, 72);
            this.cbxIdCliente.Name = "cbxIdCliente";
            this.cbxIdCliente.Size = new System.Drawing.Size(132, 23);
            this.cbxIdCliente.TabIndex = 12;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(238, 212);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(132, 23);
            this.txtObservaciones.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(238, 176);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 23);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(238, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 23);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(238, 36);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(132, 23);
            this.txtIdPedido.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "FECHA DE ENTREGA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "FECHA DE PEDIDO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "OBSERVACIONES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "PRECIO DEL PEDIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "CLIENTE ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID PEDIDO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(212, 453);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 43);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(444, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPedidoAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(805, 532);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPedidoAgregar";
            this.Text = "FormPedidoAgregar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtFechaPedido;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.ComboBox cbxIdCliente;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}