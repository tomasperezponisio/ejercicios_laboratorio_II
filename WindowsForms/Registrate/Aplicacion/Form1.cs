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

namespace Aplicacion
{
    public partial class Form1 : Form
    {

        private string mensaje = "Chau";
        private string[] cursos = new string[3];


        public Form1()
        {
            InitializeComponent();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (this.chkCursosCsharp.Checked)
            {
                cursos[0] = $"{this.chkCursosCsharp.Text} ";
            }
            if (this.chkCursosCplusplus.Checked)
            {
                cursos[1] = $"{this.chkCursosCplusplus.Text} ";
            }
            if (this.chkCursosJavascript.Checked)
            {
                cursos[2] = $"{this.chkCursosJavascript.Text} ";
            }

            RadioButton rb = null;
            if (this.radGeneroM.Checked == true)
            {
                rb = this.radGeneroM;
            }
            else if (this.radGeneroF.Checked == true)
            {
                rb = this.radGeneroF;
            }
            else if (this.radGeneroNoBinario.Checked == true)
            {
                rb = this.radGeneroNoBinario;
            }
            Ingresante ingresante = new Ingresante(this.txtNombre.Text, this.txtDireccion.Text, rb.Text, this.libPais.SelectedItem.ToString(), cursos, (int)this.numEdad.Value);
            mensaje = ingresante.Mostrar();
            MessageBox.Show(this.mensaje);

        }
    }
}
