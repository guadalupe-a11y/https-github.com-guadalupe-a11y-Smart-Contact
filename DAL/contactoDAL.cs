using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class contactoDAL
    {
        // Conexion a la base de datos
        private string cadena = "Data Source=localhost;Initial Catalog=contactosdb;Integrated Security=True";

        public void AgregarContacto(contactoEL contacto)
        {
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO Contactos (Nombre, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                command.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                command.Parameters.AddWithValue("@Correo", contacto.Correo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable ListarContactos()
        {
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM Contactos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }

        }

        public void EliminarContacto(int id)
        {
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "DELETE FROM Contactos WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
