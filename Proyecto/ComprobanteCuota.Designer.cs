namespace Proyecto
{
    partial class ComprobanteCuota
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
            lblNumero = new Label();
            lblCliente = new Label();
            lblTipo = new Label();
            lblMonto = new Label();
            lblFecha = new Label();
            lblForma = new Label();
            lblCuotas = new Label();
            lblValorCuota = new Label();
            btnImprimir = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(47, 53);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            lblNumero.Click += label1_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(47, 87);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(47, 122);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(47, 155);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(47, 186);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(47, 220);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(87, 15);
            lblForma.TabIndex = 5;
            lblForma.Text = "Forma de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(47, 251);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            // 
            // lblValorCuota
            // 
            lblValorCuota.AutoSize = true;
            lblValorCuota.Location = new Point(47, 282);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(68, 15);
            lblValorCuota.TabIndex = 7;
            lblValorCuota.Text = "Valor Cuota";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(47, 316);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(120, 36);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // ComprobanteCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 401);
            Controls.Add(btnImprimir);
            Controls.Add(lblValorCuota);
            Controls.Add(lblCuotas);
            Controls.Add(lblForma);
            Controls.Add(lblFecha);
            Controls.Add(lblMonto);
            Controls.Add(lblTipo);
            Controls.Add(lblCliente);
            Controls.Add(lblNumero);
            Name = "ComprobanteCuota";
            Text = "ComprobanteCuota";
            Load += ComprobanteCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblCliente;
        private Label lblTipo;
        private Label lblMonto;
        private Label lblFecha;
        private Label lblForma;
        private Label lblCuotas;
        private Label lblValorCuota;
        private Button btnImprimir;
    }
}