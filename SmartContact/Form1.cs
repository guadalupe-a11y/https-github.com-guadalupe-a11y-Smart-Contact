using System;
using System.Windows.Forms;

namespace SmartContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y teclas de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Método para limpiar el formulario
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
        }
    }
}