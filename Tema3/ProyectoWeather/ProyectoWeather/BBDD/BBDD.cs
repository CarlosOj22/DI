using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ProyectoWeather.BBDD
{
    public class BBDD
    {
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet almacenamientoEnMemoria;
        int tipo;

        public BBDD()
        {
            almacenamientoEnMemoria = new DataSet();
        }
        public void AbrirConexion()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            miConexion.Open();
        }

        public int TipoDeUsuario()
        {
            return tipo;
        }
        public void CerrarConexion()
        {
            miConexion.Close();
        }
        public bool Conectar(   )
        {
            try
            {
                string cadenaConexion = $"Server=192.168.0.200;Port=3306;User Id=Carlos;Password=1234;Allow Zero Datetime=True;Charset=utf8;";
                miConexion = new MySqlConnection(cadenaConexion);
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public bool ComprobarUsuario(string email,string pass)
        {
            try
            {
                //CREO STRING DE LA CONSULTA Y LE PASO PARAMETROS CON METODO PARA EVITAR INYECCION SQL
                string sql = "SELECT ID_ROL FROM USUARIOS WHERE EMAIL=@email AND PASSWORD=@pass";
                MySqlCommand cmd = new MySqlCommand(sql, miConexion);
                ////CON METODO ADDWITHVALUE EVITAMOS INYECCION SQL
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader dr;

                AbrirConexion();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tipo = (Int32)dr["ID_ROL"];
                    dr.Close();
                    CerrarConexion();
                    return true;
                }
                else
                {

                    dr.Close();
                    CerrarConexion();
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Metodo para que el admin agreugue usuarios

        public bool AgregarUsuario(string email,string pass,int rol)
        {
            rol = 1; //NO PUEDE AÑADIR OTROS ADMINISTRADORES SOLO USERS NORMALES

            try
            {
                string sql = "INSERT INTO USUARIOS (EMAIL, PASSWORD, ID_ROL) VALUES (@email,@pass,@rol)";
                MySqlCommand cmd = new MySqlCommand(sql, miConexion);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@rol", rol);

                int filaAfectadas = cmd.ExecuteNonQuery();
                if (filaAfectadas > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /*
        public DataTable ObtenerGrid()
        {
            try
            {
                miComando = new MySqlCommand("SELECT * FROM country", miConexion);
                miAdaptador = new MySqlDataAdapter(miComando);
                almacenamientoEnMemoria = new DataSet();
                AbrirConexion();
                miAdaptador.Fill(almacenamientoEnMemoria, "pais");
                CerrarConexion();

                return almacenamientoEnMemoria.Tables["pais"];
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }

        public DataTable ObtenerSegundoSelect(string codigoPais)
        {
            try
            {
                miComando = new MySqlCommand("SELECT * FROM city WHERE country=" +codigoPais, miConexion);
                miAdaptador = new MySqlDataAdapter(miComando);
                almacenamientoEnMemoria = new DataSet();
                AbrirConexion();
                miAdaptador.Fill(almacenamientoEnMemoria, "ciudades");
                CerrarConexion();

                return almacenamientoEnMemoria.Tables["ciudades"];
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
        */
    }
}
