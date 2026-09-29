

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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(740, 180);
            dataGridView1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(22, 280);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(244, 280);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 2;
            // 
            // EstadoMesa
            // 
            EstadoMesa.FormattingEnabled = true;
            EstadoMesa.Items.AddRange(new object[] { "Libre", "Ocupada", "Reservada" });
            EstadoMesa.Location = new Point(23, 327);
            EstadoMesa.Name = "EstadoMesa";
            EstadoMesa.Size = new Size(740, 28);
            EstadoMesa.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Buscar mesa...";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(22, 377);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(223, 44);
            GuardarBtn.TabIndex = 5;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // CambiarEstadoBtn
            // 
            CambiarEstadoBtn.Location = new Point(277, 377);
            CambiarEstadoBtn.Name = "CambiarEstadoBtn";
            CambiarEstadoBtn.Size = new Size(223, 44);
            CambiarEstadoBtn.TabIndex = 6;
            CambiarEstadoBtn.Text = "Cambiar estado de la mesa";
            CambiarEstadoBtn.UseVisualStyleBackColor = true;
            // 
            // LimpiarCamposBtn
            // 
            LimpiarCamposBtn.Location = new Point(540, 377);
            LimpiarCamposBtn.Name = "LimpiarCamposBtn";
            LimpiarCamposBtn.Size = new Size(223, 44);
            LimpiarCamposBtn.TabIndex = 7;
            LimpiarCamposBtn.Text = "Limpiar campos";
            LimpiarCamposBtn.UseVisualStyleBackColor = true;
            // 
            // CapacidadLb
            // 
            CapacidadLb.AutoSize = true;
            CapacidadLb.Location = new Point(244, 257);
            CapacidadLb.Name = "CapacidadLb";
            CapacidadLb.Size = new Size(80, 20);
            CapacidadLb.TabIndex = 8;
            CapacidadLb.Text = "Capacidad";
            // 
            // MesaLb
            // 
            MesaLb.AutoSize = true;
            MesaLb.Location = new Point(24, 253);
            MesaLb.Name = "MesaLb";
            MesaLb.Size = new Size(44, 20);
            MesaLb.TabIndex = 9;
            MesaLb.Text = "Mesa";
            // 
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MesaLb);
            Controls.Add(CapacidadLb);
            Controls.Add(LimpiarCamposBtn);
            Controls.Add(CambiarEstadoBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(textBox1);
            Controls.Add(EstadoMesa);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Name = "FrmMesas";
            Text = "FrmMesas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
    }
}