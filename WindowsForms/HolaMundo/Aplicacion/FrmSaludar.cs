using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FrmSaludar : Form
    {
        public FrmSaludar()
        {
            InitializeComponent();
        }


        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                frmSaludo frmSaludar = new frmSaludo("Hola Windows Form", $"Soy {this.txtNombre.Text}, {this.txtApellido.Text} y mi materia favorita es {this.cmbMateriaFavorita.SelectedItem}");
                frmSaludar.ShowDialog();
            }
            else 
            {
                MessageBox.Show($"Se debe completar los siguientes campos\n{this.txtNombre.Name}\n{this.txtApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSaludar_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFavorita.Items.Add("Programacion II");
            this.cmbMateriaFavorita.Items.Add("Laboratorio II");
            this.cmbMateriaFavorita.SelectedIndex = 0;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras");
            }
        }
    }
}
