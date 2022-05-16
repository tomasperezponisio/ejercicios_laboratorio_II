using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarTextBox(this.txtKilometros.Text, this.txtLitros.Text);
                int km = int.Parse(this.txtKilometros.Text);
                int lt = int.Parse(this.txtLitros.Text);
                int resultado = Calculador.Calcular(km, lt);
                rtbResultado.Text = resultado.ToString();

            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarTextBox(string st1, string st2)
        {            
            if (string.IsNullOrWhiteSpace(st1) || string.IsNullOrWhiteSpace(st2))
            {
                throw new ParametrosVaciosException("Los textbox no pueden estar vacios");
            }
            return true;
        }
    }
}
