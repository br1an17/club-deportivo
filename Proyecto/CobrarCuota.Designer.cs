namespace Proyecto
{
    partial class CobrarCuota
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
            txtID = new TextBox();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            btnCobrar = new Button();
            btnComprobante = new Button();
            cmbCuotas = new ComboBox();
            lblCuotas = new Label();
            lblIngrese = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(36, 62);
            txtID.Name = "txtID";
            txtID.Size = new Size(126, 23);
            txtID.TabIndex = 0;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(233, 46);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 1;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(233, 81);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(60, 19);
            optTarjeta.TabIndex = 2;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(36, 107);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(126, 34);
            btnCobrar.TabIndex = 3;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(39, 161);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(123, 34);
            btnComprobante.TabIndex = 4;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // cmbCuotas
            // 
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Items.AddRange(new object[] { "3", "6" });
            cmbCuotas.Location = new Point(233, 124);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(76, 23);
            cmbCuotas.TabIndex = 5;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(233, 107);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Location = new Point(39, 44);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(121, 15);
            lblIngrese.TabIndex = 7;
            lblIngrese.Text = "Ingrese N°  de Cliente";
            // 
            // CobrarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 296);
            Controls.Add(lblIngrese);
            Controls.Add(lblCuotas);
            Controls.Add(cmbCuotas);
            Controls.Add(btnComprobante);
            Controls.Add(btnCobrar);
            Controls.Add(optTarjeta);
            Controls.Add(optEfectivo);
            Controls.Add(txtID);
            Name = "CobrarCuota";
            Text = "CobrarCuota";
            Load += CobrarCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private Button btnCobrar;
        private Button btnComprobante;
        private ComboBox cmbCuotas;
        private Label lblCuotas;
        private Label lblIngrese;
    }
}