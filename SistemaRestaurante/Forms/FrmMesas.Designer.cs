

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
            dataGridView1.Location = new Point(28, 81);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(925, 225);
            dataGridView1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(207, 352);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(188, 31);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(675, 350);
            numericUpDown2.Margin = new Padding(4, 4, 4, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(188, 31);
            numericUpDown2.TabIndex = 2;
            // 
            // EstadoMesa
            // 
            EstadoMesa.FormattingEnabled = true;
            EstadoMesa.Items.AddRange(new object[] { "Libre", "Ocupada", "Reservada" });
            EstadoMesa.Location = new Point(29, 409);
            EstadoMesa.Margin = new Padding(4, 4, 4, 4);
            EstadoMesa.Name = "EstadoMesa";
            EstadoMesa.Size = new Size(924, 33);
            EstadoMesa.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 15);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(655, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "Buscar mesa...";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // GuardarBtn
            // 
            GuardarBtn.BackColor = Color.Lime;
            GuardarBtn.Location = new Point(28, 471);
            GuardarBtn.Margin = new Padding(4, 4, 4, 4);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(279, 55);
            GuardarBtn.TabIndex = 5;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = false;
            // 
            // CambiarEstadoBtn
            // 
            CambiarEstadoBtn.BackColor = Color.LightGray;
            CambiarEstadoBtn.Location = new Point(346, 471);
            CambiarEstadoBtn.Margin = new Padding(4, 4, 4, 4);
            CambiarEstadoBtn.Name = "CambiarEstadoBtn";
            CambiarEstadoBtn.Size = new Size(279, 55);
            CambiarEstadoBtn.TabIndex = 6;
            CambiarEstadoBtn.Text = "Cambiar estado de la mesa";
            CambiarEstadoBtn.UseVisualStyleBackColor = false;
            // 
            // LimpiarCamposBtn
            // 
            LimpiarCamposBtn.BackColor = Color.Firebrick;
            LimpiarCamposBtn.Location = new Point(675, 471);
            LimpiarCamposBtn.Margin = new Padding(4, 4, 4, 4);
            LimpiarCamposBtn.Name = "LimpiarCamposBtn";
            LimpiarCamposBtn.Size = new Size(279, 55);
            LimpiarCamposBtn.TabIndex = 7;
            LimpiarCamposBtn.Text = "Limpiar campos";
            LimpiarCamposBtn.UseVisualStyleBackColor = false;
            // 
            // CapacidadLb
            // 
            CapacidadLb.AutoSize = true;
            CapacidadLb.Location = new Point(572, 352);
            CapacidadLb.Margin = new Padding(4, 0, 4, 0);
            CapacidadLb.Name = "CapacidadLb";
            CapacidadLb.Size = new Size(95, 25);
            CapacidadLb.TabIndex = 8;
            CapacidadLb.Text = "Capacidad";
            // 
            // MesaLb
            // 
            MesaLb.AutoSize = true;
            MesaLb.Location = new Point(145, 358);
            MesaLb.Margin = new Padding(4, 0, 4, 0);
            MesaLb.Name = "MesaLb";
            MesaLb.Size = new Size(54, 25);
            MesaLb.TabIndex = 9;
            MesaLb.Text = "Mesa";
            // 
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1000, 562);
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
            Margin = new Padding(4, 4, 4, 4);
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