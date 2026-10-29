

namespace SistemaRestaurante.Forms
{
    partial class FrmMesas
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
			dataGridView1 = new DataGridView();
			numericUpDown1 = new NumericUpDown();
			numericUpDown2 = new NumericUpDown();
			EstadoMesa = new ComboBox();
			textBox1 = new TextBox();
			GuardarBtn = new Button();
			CambiarEstadoBtn = new Button();
			LimpiarCamposBtn = new Button();
			CapacidadLb = new Label();
			MesaLb = new Label();
			groupBox1 = new GroupBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.BackgroundColor = Color.FromArgb(244, 246, 249);
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 36);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(784, 371);
			dataGridView1.TabIndex = 0;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Anchor = AnchorStyles.Bottom;
			numericUpDown1.Location = new Point(135, 62);
			numericUpDown1.Margin = new Padding(3, 2, 3, 2);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(132, 23);
			numericUpDown1.TabIndex = 1;
			// 
			// numericUpDown2
			// 
			numericUpDown2.Anchor = AnchorStyles.Bottom;
			numericUpDown2.Location = new Point(378, 62);
			numericUpDown2.Margin = new Padding(3, 2, 3, 2);
			numericUpDown2.Name = "numericUpDown2";
			numericUpDown2.Size = new Size(132, 23);
			numericUpDown2.TabIndex = 2;
			// 
			// EstadoMesa
			// 
			EstadoMesa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			EstadoMesa.FormattingEnabled = true;
			EstadoMesa.Location = new Point(589, 62);
			EstadoMesa.Margin = new Padding(3, 2, 3, 2);
			EstadoMesa.Name = "EstadoMesa";
			EstadoMesa.Size = new Size(105, 23);
			EstadoMesa.TabIndex = 3;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(12, 9);
			textBox1.Margin = new Padding(3, 2, 3, 2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(784, 23);
			textBox1.TabIndex = 4;
			textBox1.Text = "Buscar mesa...";
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// GuardarBtn
			// 
			GuardarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			GuardarBtn.BackColor = Color.Lime;
			GuardarBtn.FlatAppearance.BorderSize = 0;
			GuardarBtn.FlatStyle = FlatStyle.Flat;
			GuardarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			GuardarBtn.Location = new Point(99, 566);
			GuardarBtn.Margin = new Padding(3, 2, 3, 2);
			GuardarBtn.Name = "GuardarBtn";
			GuardarBtn.Size = new Size(195, 33);
			GuardarBtn.TabIndex = 5;
			GuardarBtn.Text = "Guardar";
			GuardarBtn.UseVisualStyleBackColor = false;
			// 
			// CambiarEstadoBtn
			// 
			CambiarEstadoBtn.Anchor = AnchorStyles.Bottom;
			CambiarEstadoBtn.BackColor = Color.LightGray;
			CambiarEstadoBtn.FlatAppearance.BorderSize = 0;
			CambiarEstadoBtn.FlatStyle = FlatStyle.Flat;
			CambiarEstadoBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			CambiarEstadoBtn.Location = new Point(300, 566);
			CambiarEstadoBtn.Margin = new Padding(3, 2, 3, 2);
			CambiarEstadoBtn.Name = "CambiarEstadoBtn";
			CambiarEstadoBtn.Size = new Size(195, 33);
			CambiarEstadoBtn.TabIndex = 6;
			CambiarEstadoBtn.Text = "Cambiar estado de la mesa";
			CambiarEstadoBtn.UseVisualStyleBackColor = false;
			// 
			// LimpiarCamposBtn
			// 
			LimpiarCamposBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			LimpiarCamposBtn.BackColor = Color.Firebrick;
			LimpiarCamposBtn.FlatAppearance.BorderSize = 0;
			LimpiarCamposBtn.FlatStyle = FlatStyle.Flat;
			LimpiarCamposBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			LimpiarCamposBtn.Location = new Point(501, 566);
			LimpiarCamposBtn.Margin = new Padding(3, 2, 3, 2);
			LimpiarCamposBtn.Name = "LimpiarCamposBtn";
			LimpiarCamposBtn.Size = new Size(195, 33);
			LimpiarCamposBtn.TabIndex = 7;
			LimpiarCamposBtn.Text = "Limpiar campos";
			LimpiarCamposBtn.UseVisualStyleBackColor = false;
			// 
			// CapacidadLb
			// 
			CapacidadLb.Anchor = AnchorStyles.Bottom;
			CapacidadLb.AutoSize = true;
			CapacidadLb.ForeColor = Color.FromArgb(34, 34, 34);
			CapacidadLb.Location = new Point(310, 65);
			CapacidadLb.Name = "CapacidadLb";
			CapacidadLb.Size = new Size(62, 15);
			CapacidadLb.TabIndex = 8;
			CapacidadLb.Text = "Capacidad";
			// 
			// MesaLb
			// 
			MesaLb.Anchor = AnchorStyles.Bottom;
			MesaLb.AutoSize = true;
			MesaLb.ForeColor = Color.FromArgb(34, 34, 34);
			MesaLb.Location = new Point(27, 65);
			MesaLb.Name = "MesaLb";
			MesaLb.Size = new Size(102, 15);
			MesaLb.TabIndex = 9;
			MesaLb.Text = "Numero de Mesa";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(CapacidadLb);
			groupBox1.Controls.Add(MesaLb);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(EstadoMesa);
			groupBox1.Controls.Add(numericUpDown2);
			groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(12, 418);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(784, 143);
			groupBox1.TabIndex = 10;
			groupBox1.TabStop = false;
			groupBox1.Text = "Gestión de Mesa";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(34, 34, 34);
			label1.Location = new Point(540, 65);
			label1.Name = "label1";
			label1.Size = new Size(43, 15);
			label1.TabIndex = 10;
			label1.Text = "Estado";
			// 
			// FrmMesas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(808, 668);
			Controls.Add(CambiarEstadoBtn);
			Controls.Add(textBox1);
			Controls.Add(LimpiarCamposBtn);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox1);
			Controls.Add(GuardarBtn);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FrmMesas";
			Text = "Registro de Mesas";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private ComboBox EstadoMesa;
        private TextBox textBox1;
        private Button GuardarBtn;
        private Button CambiarEstadoBtn;
        private Button LimpiarCamposBtn;
        private Label CapacidadLb;
        private Label MesaLb;
		private GroupBox groupBox1;
		private Label label1;
	}
}