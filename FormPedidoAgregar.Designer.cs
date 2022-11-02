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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPedidoID = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cbClienteID = new System.Windows.Forms.ComboBox();
            this.cbProductoID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbProductoID);
            this.groupBox1.Controls.Add(this.cbClienteID);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtPedidoID);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID PEDIDO";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID PRODUCTO";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "PRECIO DEL PEDIDO";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "FECHA DE PEDIDO";
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
            // txtPedidoID
            // 
            this.txtPedidoID.Location = new System.Drawing.Point(238, 36);
            this.txtPedidoID.Name = "txtPedidoID";
            this.txtPedidoID.Size = new System.Drawing.Size(132, 23);
            this.txtPedidoID.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(238, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 23);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(238, 176);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 23);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(238, 212);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(132, 23);
            this.txtObservaciones.TabIndex = 11;
            // 
            // cbClienteID
            // 
            this.cbClienteID.FormattingEnabled = true;
            this.cbClienteID.Location = new System.Drawing.Point(238, 72);
            this.cbClienteID.Name = "cbClienteID";
            this.cbClienteID.Size = new System.Drawing.Size(132, 23);
            this.cbClienteID.TabIndex = 12;
            // 
            // cbProductoID
            // 
            this.cbProductoID.FormattingEnabled = true;
            this.cbProductoID.Location = new System.Drawing.Point(238, 106);
            this.cbProductoID.Name = "cbProductoID";
            this.cbProductoID.Size = new System.Drawing.Size(132, 23);
            this.cbProductoID.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 284);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "GUARDAR PEDIDO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPedidoAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(805, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbProductoID;
        private System.Windows.Forms.ComboBox cbClienteID;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPedidoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}