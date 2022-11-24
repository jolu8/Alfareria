namespace Alfareria
{
    partial class FormPedidoBuscar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.cbProductoID = new System.Windows.Forms.ComboBox();
            this.cbClienteID = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPedidoID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PEDIDO:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(532, 311);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(234, 20);
            this.txtPedido.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtFechaEntrega);
            this.groupBox1.Controls.Add(this.dtFechaPedido);
            this.groupBox1.Controls.Add(this.cbProductoID);
            this.groupBox1.Controls.Add(this.cbClienteID);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtPedidoID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 396);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PEDIDO";
            // 
            // dtFechaEntrega
            // 
            this.dtFechaEntrega.Location = new System.Drawing.Point(235, 300);
            this.dtFechaEntrega.Name = "dtFechaEntrega";
            this.dtFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.dtFechaEntrega.TabIndex = 15;
            // 
            // dtFechaPedido
            // 
            this.dtFechaPedido.Location = new System.Drawing.Point(235, 261);
            this.dtFechaPedido.Name = "dtFechaPedido";
            this.dtFechaPedido.Size = new System.Drawing.Size(200, 22);
            this.dtFechaPedido.TabIndex = 14;
            // 
            // cbProductoID
            // 
            this.cbProductoID.FormattingEnabled = true;
            this.cbProductoID.Location = new System.Drawing.Point(235, 110);
            this.cbProductoID.Name = "cbProductoID";
            this.cbProductoID.Size = new System.Drawing.Size(197, 24);
            this.cbProductoID.TabIndex = 13;
            // 
            // cbClienteID
            // 
            this.cbClienteID.FormattingEnabled = true;
            this.cbClienteID.Location = new System.Drawing.Point(235, 73);
            this.cbClienteID.Name = "cbClienteID";
            this.cbClienteID.Size = new System.Drawing.Size(197, 24);
            this.cbClienteID.TabIndex = 12;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(235, 224);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(197, 22);
            this.txtObservaciones.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(235, 185);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(197, 22);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(235, 147);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(197, 22);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtPedidoID
            // 
            this.txtPedidoID.Location = new System.Drawing.Point(235, 37);
            this.txtPedidoID.Name = "txtPedidoID";
            this.txtPedidoID.Size = new System.Drawing.Size(197, 22);
            this.txtPedidoID.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "FECHA DE ENTREGA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "FECHA DEL PEDIDO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "OBSERVACIONES:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "PRECIO DEL PEDIDO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "CANTIDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID DEL PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "CLIENTE ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID PEDIDO:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(561, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alfareria.Properties.Resources.Alfareria;
            this.pictureBox1.Location = new System.Drawing.Point(532, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormPedidoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPedidoBuscar";
            this.Text = "FormPedidoBuscar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbProductoID;
        private System.Windows.Forms.ComboBox cbClienteID;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPedidoID;
        private System.Windows.Forms.DateTimePicker dtFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtFechaPedido;
    }
}