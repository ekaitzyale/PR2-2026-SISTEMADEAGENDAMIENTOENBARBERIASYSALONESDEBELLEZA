using System.Configuration;
using System.Data.SqlClient;

namespace SistemaAgendamiento.Datos
{
    public static class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["SistemaAgendamiento"].ConnectionString;
            return new SqlConnection(cadena);
        }

        public static bool ProbarConexion(out string mensaje)
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                }

                mensaje = "La conexión con la base de datos se realizó correctamente.";
                return true;
            }
            catch (SqlException)
            {
                mensaje = "No se pudo conectar con SQL Server. Revise el servidor y la cadena de conexión.";
                return false;
            }
            catch (System.Exception)
            {
                mensaje = "Ocurrió un error al intentar conectar con la base de datos.";
                return false;
            }
        }
    }
}
