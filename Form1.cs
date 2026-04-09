using GUI;
using System;
using System.Drawing;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar contacto...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.White;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar contacto...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        public void CargarContactos()
        {
            flowContactos.Controls.Clear();

            // Ejemplo de contactos (después los sacarás de tu BLL)
            var contactos = new[]
            {
        new { Nombre = "Ana López", Telefono = "+503 7777-1234", Email = "ana@email.com", Favorito = true },
        new { Nombre = "Carlos Rivera", Telefono = "+503 8888-5678", Email = "carlos@email.com", Favorito = false },
        new { Nombre = "María González", Telefono = "+503 6666-9876", Email = "maria@email.com", Favorito = true }
    };

            foreach (var c in contactos)
            {
                ContactoCard card = new ContactoCard();
                card.Nombre = c.Nombre;
                card.Telefono = c.Telefono;
                card.Email = c.Email;
                // card.Favorito = c.Favorito;

                flowContactos.Controls.Add(card);
            }
        }
    }

}