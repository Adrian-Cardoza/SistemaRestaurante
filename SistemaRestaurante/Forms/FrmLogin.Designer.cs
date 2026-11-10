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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			label1 = new Label();
			label2 = new Label();
			txtUsuario = new TextBox();
			txtContraseña = new TextBox();
			btnIngresar = new Button();
			btnCancelar = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(34, 34, 34);
			label1.Location = new Point(152, 176);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 0;
			label1.Text = "Usuario :";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.FromArgb(34, 34, 34);
			label2.Location = new Point(132, 207);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(75, 15);
			label2.TabIndex = 1;
			label2.Text = "Contraseña :";
			// 
			// txtUsuario
			// 
			txtUsuario.ForeColor = Color.FromArgb(34, 34, 34);
			txtUsuario.Location = new Point(218, 173);
			txtUsuario.Margin = new Padding(2);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(106, 23);
			txtUsuario.TabIndex = 2;
			// 
			// txtContraseña
			// 
			txtContraseña.ForeColor = Color.FromArgb(34, 34, 34);
			txtContraseña.Location = new Point(218, 204);
			txtContraseña.Margin = new Padding(2);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.PasswordChar = '*';
			txtContraseña.Size = new Size(106, 23);
			txtContraseña.TabIndex = 3;
			// 
			// btnIngresar
			// 
			btnIngresar.BackColor = Color.Lime;
			btnIngresar.BackgroundImageLayout = ImageLayout.None;
			btnIngresar.FlatAppearance.BorderSize = 0;
			btnIngresar.FlatStyle = FlatStyle.Flat;
			btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnIngresar.ForeColor = Color.FromArgb(34, 34, 34);
			btnIngresar.Location = new Point(140, 258);
			btnIngresar.Margin = new Padding(2);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new Size(78, 26);
			btnIngresar.TabIndex = 4;
			btnIngresar.Text = "Aceptar";
			btnIngresar.UseVisualStyleBackColor = false;
			btnIngresar.Click += btnIngresar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.Firebrick;
			btnCancelar.FlatAppearance.BorderSize = 0;
			btnCancelar.FlatStyle = FlatStyle.Flat;
			btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			btnCancelar.ForeColor = Color.FromArgb(34, 34, 34);
			btnCancelar.Location = new Point(234, 258);
			btnCancelar.Margin = new Padding(2);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(78, 26);
			btnCancelar.TabIndex = 5;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(158, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(144, 144);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// FrmLogin
			// 
			AcceptButton = btnIngresar;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(484, 311);
			Controls.Add(pictureBox1);
			Controls.Add(btnCancelar);
			Controls.Add(btnIngresar);
			Controls.Add(txtContraseña);
			Controls.Add(txtUsuario);
			Controls.Add(label2);
			Controls.Add(label1);
			ForeColor = Color.FromArgb(34, 34, 34);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(2);
			MaximizeBox = false;
			Name = "FrmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Inicio de Sesion";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
		private PictureBox pictureBox1;
	}
}