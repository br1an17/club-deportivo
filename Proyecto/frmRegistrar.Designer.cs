namespace Proyecto
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblDocumento = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            cboTipo = new ComboBox();
            rbSocio = new RadioButton();
            rbNoSocio = new RadioButton();
            chkCarnet = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 16);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(423, 16);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(167, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro del Cliente";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(400, 357);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(91, 47);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(526, 357);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 47);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(643, 357);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(91, 47);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(404, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(404, 110);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 18);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(404, 153);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(41, 18);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(610, 153);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(95, 18);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "Documento";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(404, 196);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 18);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(404, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 18);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(539, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(392, 24);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(539, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(392, 24);
            txtApellido.TabIndex = 12;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(713, 150);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(218, 24);
            txtDocumento.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(539, 196);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 24);
            txtTelefono.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(539, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 24);
            txtEmail.TabIndex = 15;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(474, 148);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 26);
            cboTipo.TabIndex = 16;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Location = new Point(456, 290);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(70, 22);
            rbSocio.TabIndex = 17;
            rbSocio.TabStop = true;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Location = new Point(643, 290);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(97, 22);
            rbNoSocio.TabIndex = 18;
            rbNoSocio.TabStop = true;
            rbNoSocio.Text = "No Socio";
            rbNoSocio.UseVisualStyleBackColor = true;
            // 
            // chkCarnet
            // 
            chkCarnet.AutoSize = true;
            chkCarnet.Location = new Point(513, 325);
            chkCarnet.Name = "chkCarnet";
            chkCarnet.Size = new Size(77, 22);
            chkCarnet.TabIndex = 19;
            chkCarnet.Text = "Carnet";
            chkCarnet.UseVisualStyleBackColor = true;
            // 
            // frmRegistrar
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 660);
            Controls.Add(chkCarnet);
            Controls.Add(rbNoSocio);
            Controls.Add(rbSocio);
            Controls.Add(cboTipo);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDocumento);
            Controls.Add(lblTipo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistrar";
            Text = "frmRegistrar";
            Load += frmRegistrar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblDocumento;
        private Label lblTelefono;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private ComboBox cboTipo;
        private RadioButton rbSocio;
        private RadioButton rbNoSocio;
        private CheckBox chkCarnet;
    }
}