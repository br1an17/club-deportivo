namespace Proyecto
{
    partial class frmPrincipal
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
            lblIngreso = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            btnCobrar = new Button();
            btnListar = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(33, 11);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 16);
            lblIngreso.TabIndex = 0;
            lblIngreso.Click += lblIngreso_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DeepSkyBlue;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(637, 11);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 34);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.AliceBlue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Navy;
            btnRegistrar.Location = new Point(101, 97);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(230, 95);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar Usuario";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.AliceBlue;
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = Color.Navy;
            btnCobrar.Location = new Point(419, 97);
            btnCobrar.Margin = new Padding(3, 4, 3, 4);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(230, 95);
            btnCobrar.TabIndex = 3;
            btnCobrar.Text = "Cobrar Cuota";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Navy;
            btnListar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListar.ForeColor = SystemColors.ButtonHighlight;
            btnListar.Location = new Point(265, 250);
            btnListar.Margin = new Padding(3, 4, 3, 4);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(230, 95);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar Socios c/Cuota vencida";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += button2_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 570);
            Controls.Add(btnListar);
            Controls.Add(btnCobrar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnRegistrar;
        private Button btnCobrar;
        private Button btnListar;
    }
}