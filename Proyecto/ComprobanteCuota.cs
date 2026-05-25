using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class ComprobanteCuota : Form
    {
        public ComprobanteCuota()
        {
            InitializeComponent();
        }
        //variables para traer los datos del formulario
        //donde se ejecuta la lógica
        public int numero_c;
        public string cliente_c = "";
        public string tipo_c = "";
        public float monto_c;
        public DateTime fecha_c;
        public string forma_c = "";
        public int cuotas_c;
        public float valorCuota_c;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //mostrar datos en labels, asigna los valores de los datos q muestra cada etiqueta del diseño del comprobante
        private void ComprobanteCuota_Load(object sender, EventArgs e)
        {
            lblNumero.Text = numero_c.ToString();

            lblCliente.Text = cliente_c;

            lblTipo.Text = tipo_c;

            lblMonto.Text = monto_c.ToString();

            lblFecha.Text = DateTime.UtcNow.ToShortDateString(); //se obtiene la fecha actual

            lblForma.Text = forma_c;

            lblCuotas.Text = cuotas_c.ToString();

            lblValorCuota.Text = valorCuota_c.ToString();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {//ocultamos los botones q no pertenecen al diseño pero si para la funcionalidad
            btnImprimir.Visible = false; //propiedad visible, posibles valores True o False

            //creamos los objetos para la impresion
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            btnImprimir.Visible = true; //visualizamos nuevamente el objeto

            //Regreso al formulario principal después de dar el aviso
            MessageBox.Show("Operación Exitosa", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        //Conjunto de sentencias necesarias para el objeto Print
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
