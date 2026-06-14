namespace Proyecto
{
    partial class frmAsignar
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
            dtgvActividades = new DataGridView();
            idEdicion = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            Dia = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            txtDni = new TextBox();
            lblCliente = new Label();
            btnVolver = new Button();
            btnBuscar = new Button();
            btnAsignar = new Button();
            lblGrilla = new Label();
            lblTipoCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).BeginInit();
            SuspendLayout();
            // 
            // dtgvActividades
            // 
            dtgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividades.Columns.AddRange(new DataGridViewColumn[] { idEdicion, Actividad, Dia, Horario, Profesor, Precio });
            dtgvActividades.Location = new Point(41, 175);
            dtgvActividades.Name = "dtgvActividades";
            dtgvActividades.Size = new Size(602, 281);
            dtgvActividades.TabIndex = 0;
            dtgvActividades.CellClick += dtgvActividades_CellClick;
            dtgvActividades.CellContentClick += dtgvActividades_CellContentClick;
            // 
            // idEdicion
            // 
            idEdicion.HeaderText = "IDEdicion";
            idEdicion.Name = "idEdicion";
            idEdicion.Visible = false;
            // 
            // Actividad
            // 
            Actividad.HeaderText = "ACTIVIDAD";
            Actividad.Name = "Actividad";
            // 
            // Dia
            // 
            Dia.HeaderText = "DIA";
            Dia.Name = "Dia";
            // 
            // Horario
            // 
            Horario.HeaderText = "HORARIO";
            Horario.Name = "Horario";
            // 
            // Profesor
            // 
            Profesor.HeaderText = "PROFESOR";
            Profesor.Name = "Profesor";
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO";
            Precio.Name = "Precio";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(41, 40);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(224, 23);
            txtDni.TabIndex = 1;
            txtDni.Text = "Ingrese numero de DNI";
            txtDni.Enter += txtDni_Enter;
            txtDni.Leave += txtDni_Leave;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(64, 89);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(62, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Resultado:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SteelBlue;
            btnVolver.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(562, 118);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 44);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(341, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 56);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.DodgerBlue;
            btnAsignar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAsignar.Location = new Point(528, 12);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(115, 74);
            btnAsignar.TabIndex = 5;
            btnAsignar.Text = "Asignar Actividad";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lblGrilla
            // 
            lblGrilla.AutoSize = true;
            lblGrilla.Location = new Point(41, 147);
            lblGrilla.Name = "lblGrilla";
            lblGrilla.Size = new Size(126, 15);
            lblGrilla.TabIndex = 6;
            lblGrilla.Text = "Seleccione la actividad";
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(139, 118);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(28, 15);
            lblTipoCliente.TabIndex = 7;
            lblTipoCliente.Text = "tipo";
            lblTipoCliente.Click += lblTipoCliente_Click;
            // 
            // frmAsignar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblGrilla);
            Controls.Add(btnAsignar);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(lblCliente);
            Controls.Add(txtDni);
            Controls.Add(dtgvActividades);
            Name = "frmAsignar";
            Text = "frmAsignar";
            Load += frmAsignar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvActividades;
        private TextBox txtDni;
        private Label lblCliente;
        private Button btnVolver;
        private Button btnBuscar;
        private Button btnAsignar;
        private Label lblGrilla;
        private DataGridViewTextBoxColumn idEdicion;
        private DataGridViewTextBoxColumn Actividad;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Precio;
        private Label lblTipoCliente;
    }
}