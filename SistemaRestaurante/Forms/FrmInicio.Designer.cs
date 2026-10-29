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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			lblMesasOcupadas = new Label();
			lblMesas = new Label();
			label1 = new Label();
			panel3 = new Panel();
			pictureBox3 = new PictureBox();
			lblTotalProductos = new Label();
			lblTotal = new Label();
			panel2 = new Panel();
			pictureBox2 = new PictureBox();
			lblPedidosActivos = new Label();
			lblpedidos = new Label();
			panel4 = new Panel();
			dgvPedidos = new DataGridView();
			label2 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(244, 246, 249);
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(lblMesasOcupadas);
			panel1.Controls.Add(lblMesas);
			panel1.Location = new Point(11, 73);
			panel1.Margin = new Padding(2);
			panel1.Name = "panel1";
			panel1.Size = new Size(260, 140);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint_1;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(138, 44);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(64, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// lblMesasOcupadas
			// 
			lblMesasOcupadas.AutoSize = true;
			lblMesasOcupadas.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
			lblMesasOcupadas.ForeColor = Color.DarkBlue;
			lblMesasOcupadas.Location = new Point(34, 53);
			lblMesasOcupadas.Margin = new Padding(2, 0, 2, 0);
			lblMesasOcupadas.Name = "lblMesasOcupadas";
			lblMesasOcupadas.Size = new Size(47, 45);
			lblMesasOcupadas.TabIndex = 1;
			lblMesasOcupadas.Text = "...";
			// 
			// lblMesas
			// 
			lblMesas.AutoSize = true;
			lblMesas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblMesas.ForeColor = Color.FromArgb(34, 34, 34);
			lblMesas.Location = new Point(3, 2);
			lblMesas.Margin = new Padding(2, 0, 2, 0);
			lblMesas.Name = "lblMesas";
			lblMesas.Size = new Size(136, 21);
			lblMesas.TabIndex = 0;
			lblMesas.Text = "Mesas Ocupadas";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(460, 40);
			label1.TabIndex = 4;
			label1.Text = "Bienvenidos al Sistema RestoSys";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			panel3.BackColor = Color.FromArgb(244, 246, 249);
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(pictureBox3);
			panel3.Controls.Add(lblTotalProductos);
			panel3.Controls.Add(lblTotal);
			panel3.Location = new Point(736, 73);
			panel3.Margin = new Padding(2);
			panel3.Name = "panel3";
			panel3.Size = new Size(260, 140);
			panel3.TabIndex = 2;
			panel3.Paint += panel3_Paint;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(137, 44);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(64, 64);
			pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox3.TabIndex = 6;
			pictureBox3.TabStop = false;
			// 
			// lblTotalProductos
			// 
			lblTotalProductos.AutoSize = true;
			lblTotalProductos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
			lblTotalProductos.ForeColor = Color.Green;
			lblTotalProductos.Location = new Point(39, 53);
			lblTotalProductos.Margin = new Padding(2, 0, 2, 0);
			lblTotalProductos.Name = "lblTotalProductos";
			lblTotalProductos.Size = new Size(47, 45);
			lblTotalProductos.TabIndex = 1;
			lblTotalProductos.Text = "...";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblTotal.ForeColor = Color.FromArgb(34, 34, 34);
			lblTotal.Location = new Point(4, 3);
			lblTotal.Margin = new Padding(2, 0, 2, 0);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(129, 21);
			lblTotal.TabIndex = 0;
			lblTotal.Text = "Total Productos";
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Top;
			panel2.BackColor = Color.FromArgb(244, 246, 249);
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(pictureBox2);
			panel2.Controls.Add(lblPedidosActivos);
			panel2.Controls.Add(lblpedidos);
			panel2.Location = new Point(370, 73);
			panel2.Margin = new Padding(2);
			panel2.Name = "panel2";
			panel2.Size = new Size(260, 140);
			panel2.TabIndex = 1;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(143, 44);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(64, 64);
			pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox2.TabIndex = 3;
			pictureBox2.TabStop = false;
			// 
			// lblPedidosActivos
			// 
			lblPedidosActivos.AutoSize = true;
			lblPedidosActivos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
			lblPedidosActivos.ForeColor = Color.Gold;
			lblPedidosActivos.Location = new Point(39, 53);
			lblPedidosActivos.Margin = new Padding(2, 0, 2, 0);
			lblPedidosActivos.Name = "lblPedidosActivos";
			lblPedidosActivos.Size = new Size(47, 45);
			lblPedidosActivos.TabIndex = 1;
			lblPedidosActivos.Text = "...";
			// 
			// lblpedidos
			// 
			lblpedidos.AutoSize = true;
			lblpedidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblpedidos.ForeColor = Color.FromArgb(34, 34, 34);
			lblpedidos.Location = new Point(2, 2);
			lblpedidos.Margin = new Padding(2, 0, 2, 0);
			lblpedidos.Name = "lblpedidos";
			lblpedidos.Size = new Size(150, 21);
			lblpedidos.TabIndex = 0;
			lblpedidos.Text = "Pedidos en Cocina";
			// 
			// panel4
			// 
			panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel4.Controls.Add(dgvPedidos);
			panel4.Controls.Add(label2);
			panel4.Location = new Point(11, 218);
			panel4.Name = "panel4";
			panel4.Size = new Size(985, 412);
			panel4.TabIndex = 5;
			// 
			// dgvPedidos
			// 
			dgvPedidos.AllowUserToAddRows = false;
			dgvPedidos.AllowUserToDeleteRows = false;
			dgvPedidos.AllowUserToResizeColumns = false;
			dgvPedidos.AllowUserToResizeRows = false;
			dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvPedidos.BackgroundColor = Color.FromArgb(244, 246, 249);
			dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPedidos.Location = new Point(4, 27);
			dgvPedidos.Name = "dgvPedidos";
			dgvPedidos.ReadOnly = true;
			dgvPedidos.RowHeadersVisible = false;
			dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvPedidos.Size = new Size(978, 382);
			dgvPedidos.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(34, 34, 34);
			label2.Location = new Point(4, 3);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(135, 21);
			label2.TabIndex = 3;
			label2.Text = "Ultimos Pedidos";
			// 
			// FrmInicio
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(1008, 729);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(label1);
			ForeColor = Color.FromArgb(0, 0, 0, 34);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(2);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FrmInicio";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Inicio";
			Load += FrmInicio_Load_1;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
        private Label lblMesasOcupadas;
        private Label lblMesas;
		private Label label1;
		private Panel panel3;
		private Label lblTotalProductos;
		private Label lblTotal;
		private Panel panel2;
		private Label lblPedidosActivos;
		private Label lblpedidos;
		private Panel panel4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Label label2;
		private DataGridView dgvPedidos;
	}
}