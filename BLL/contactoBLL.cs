using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class contactoBLL
    {
        private contactoDAL contactoDAL = new contactoDAL();

        public void GuardarContacto(contactoEL contacto)
        {
            // Validar los datos del contacto antes de guardarlo
            if (string.IsNullOrWhiteSpace(contacto.Nombre))
            {
                throw new ArgumentException("El nombre del contacto es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(contacto.Telefono))
            {
                throw new ArgumentException("El teléfono del contacto es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(contacto.Correo))
            {
                throw new ArgumentException("El correo del contacto es obligatorio.");
            }

            contactoDAL.AgregarContacto(contacto);
        }

        public DataTable ObtenerContactos()
        {
            return contactoDAL.ListarContactos();
        }

        public void EliminarContacto(int id)
        {
            contactoDAL.EliminarContacto(id);
        }
    }
}
