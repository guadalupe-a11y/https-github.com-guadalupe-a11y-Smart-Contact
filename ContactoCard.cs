using System;
using System.Windows.Forms;

namespace SmartContact
{
    public partial class ContactoCard : UserControl
    {
        // Declaraciones de los controles que faltaban
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblFavorito;

        public ContactoCard()
        {
            InitializeComponent();
        }

        // Propiedades para llenar fácilmente la tarjeta
        public string Nombre
        {
            get => lblNombre?.Text ?? "";
            set { if (lblNombre != null) lblNombre.Text = value; }
        }

        public string Telefono
        {
            get => lblTelefono?.Text ?? "";
            set { if (lblTelefono != null) lblTelefono.Text = value; }
        }

        public string Email
        {
            get => lblEmail?.Text ?? "";
            set { if (lblEmail != null) lblEmail.Text = value; }
        }

        public bool EsFavorito
        {
            get => lblFavorito?.Visible ?? false;
            set { if (lblFavorito != null) lblFavorito.Visible = value; }
        }

        private void ContactoCard_Load(object sender, EventArgs e)
        {

        }
    }
}