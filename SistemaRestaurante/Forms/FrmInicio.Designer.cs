namespace SistemaRestaurante.Forms
{
    partial class FrmInicio
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
            panel1 = new Panel();
            lblMesasOcupadas = new Label();
            lblMesas = new Label();
            panel2 = new Panel();
            lblPedidosActivos = new Label();
            lblpedidos = new Label();
            panel3 = new Panel();
            lblTotalProductos = new Label();
            lblTotal = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(244, 246, 249);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblMesasOcupadas);
            panel1.Controls.Add(lblMesas);
            panel1.Location = new Point(39, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 267);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // lblMesasOcupadas
            // 
            lblMesasOcupadas.AutoSize = true;
            lblMesasOcupadas.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesasOcupadas.ForeColor = Color.DarkBlue;
            lblMesasOcupadas.Location = new Point(87, 120);
            lblMesasOcupadas.Name = "lblMesasOcupadas";
            lblMesasOcupadas.Size = new Size(276, 60);
            lblMesasOcupadas.TabIndex = 1;
            lblMesasOcupadas.Text = "Cargando...";
            // 
            // lblMesas
            // 
            lblMesas.AutoSize = true;
            lblMesas.ForeColor = Color.FromArgb(34, 34, 34);
            lblMesas.Location = new Point(4, 4);
            lblMesas.Name = "lblMesas";
            lblMesas.Size = new Size(147, 25);
            lblMesas.TabIndex = 0;
            lblMesas.Text = "Mesas Ocupadas";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(244, 246, 249);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblPedidosActivos);
            panel2.Controls.Add(lblpedidos);
            panel2.Location = new Point(709, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 267);
            panel2.TabIndex = 1;
            
            // 
            // lblPedidosActivos
            // 
            lblPedidosActivos.AutoSize = true;
            lblPedidosActivos.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosActivos.ForeColor = Color.Gold;
            lblPedidosActivos.Location = new Point(115, 120);
            lblPedidosActivos.Name = "lblPedidosActivos";
            lblPedidosActivos.Size = new Size(276, 60);
            lblPedidosActivos.TabIndex = 1;
            lblPedidosActivos.Text = "Cargando...";
            // 
            // lblpedidos
            // 
            lblpedidos.AutoSize = true;
            lblpedidos.ForeColor = Color.FromArgb(34, 34, 34);
            lblpedidos.Location = new Point(3, 4);
            lblpedidos.Name = "lblpedidos";
            lblpedidos.Size = new Size(157, 25);
            lblpedidos.TabIndex = 0;
            lblpedidos.Text = "Pedidos en Cocina";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(244, 246, 249);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTotalProductos);
            panel3.Controls.Add(lblTotal);
            panel3.Location = new Point(1373, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(565, 267);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductos.ForeColor = Color.Green;
            lblTotalProductos.Location = new Point(155, 125);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(276, 60);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "Cargando...";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(34, 34, 34);
            lblTotal.Location = new Point(5, 5);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(135, 25);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Productos";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(34, 34, 34);
            textBox1.Location = new Point(12, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1946, 50);
            textBox1.TabIndex = 3;
            textBox1.Text = "Bienvenidos al Sistema RestoSys";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1970, 1019);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(0, 0, 0, 34);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInicio";
            Text = "FrmInicio";
            Load += FrmInicio_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblMesasOcupadas;
        private Label lblMesas;
        private Panel panel2;
        private Panel panel3;
        private Label lblPedidosActivos;
        private Label lblpedidos;
        private Label lblTotalProductos;
        private Label lblTotal;
        private TextBox textBox1;
    }
}