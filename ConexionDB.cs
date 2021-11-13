using System;
using System.Data.SqlClient;
using System.Text;


namespace LP3_Examen2_Angie
{
    class ConexionDB
    {
        readonly string cadena = "Data Source = DESKTOP-E43MVJP\\SQLEXPRESS; Initial Catalog = soporte_db; Integrated Security =True";


        public int ValidarLogin(string correo, string contrasena)
        {
            int esLoginValido = 0;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT id FROM USUARIOS WHERE EMAIL  = @EMAIL AND CONTRASENA = @CONTRASENA");

                SqlConnection _conexion = new SqlConnection(cadena);

                SqlCommand comando = new SqlCommand(sql.ToString(), _conexion);

                comando.Parameters.AddWithValue("@EMAIL", correo);
                comando.Parameters.AddWithValue("@CONTRASENA", contrasena);

                _conexion.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        esLoginValido = Convert.ToInt32(reader["id"]);
                    }
                }
                _conexion.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("ERROR", error.Message);
            }

            return esLoginValido;
        }

    }
}
    

