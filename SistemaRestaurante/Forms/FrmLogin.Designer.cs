namespace SistemaRestaurante.Forms
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(185, 161);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(185, 221);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña :";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(305, 161);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(305, 221);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(150, 31);
            txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Lime;
            btnIngresar.BackgroundImageLayout = ImageLayout.None;
            btnIngresar.Location = new Point(183, 342);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Aceptar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Location = new Point(427, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnCancelar;
    }
}