using System;
using System.Globalization;
using System.Windows.Forms;

namespace Interpolacion
{
    public partial class FormIngresar : Form
    {
        private Ingresador ingresador { get; set; }

        private CalculadorPolinomio calculadorPolinomio { get; set; }

        public FormIngresar()
        {
            InitializeComponent();
            ingresador = new Ingresador();
            calculadorPolinomio = new CalculadorPolinomio();
            dgvPares.DataSource = ingresador.tablaParesOrdenados;
            txtX.Focus();
            updateViewFromIngresador();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                updateIngresadorFromView();
                ingresador.agregarPar();
                updateViewFromIngresador();
                txtX.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateIngresadorFromView()
        {
            try
            {
                ingresador.parIngresado.X = float.Parse(txtX.Text, CultureInfo.CurrentUICulture);
                ingresador.parIngresado.Y = float.Parse(txtY.Text, CultureInfo.CurrentUICulture);                
            }
            catch (Exception)
            {
                throw new Exception("Error en los valores ingresados.");
            }
        }

        private void updateViewFromIngresador()
        {
            txtX.Text = ingresador.parIngresado.X.ToString(CultureInfo.CurrentCulture);
            txtY.Text = ingresador.parIngresado.Y.ToString(CultureInfo.CurrentCulture);
            dgvPares.Refresh();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
        }
    }
}
