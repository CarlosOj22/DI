using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace EjemploBD
{
    public class BBDD
    {
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet almacenamientoEnMemoria;

        public void AbrirConexion()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            miConexion.Open();
        }

        public void CerrarConexion()
        {
            miConexion.Close();
        }
        public bool Conectar(string servidor, string puerto, string usuario, string pass)
        {
            try
            {
                string cadenaConexion = $"Server={servidor};Port={puerto};User Id={usuario};Password={pass};Database=world;Allow Zero Datetime=True;Charset=utf8;";
                miConexion = new MySqlConnection(cadenaConexion);
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error intentado realizar la conexion");
                return false;
            }
        }

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
    }
}
