using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Persona.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjemploBD
{
    public class BBDD
    {
        private MySqlConnection miConexion;
   

        public void AbrirConexion()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            miConexion.Open();
        }//AbrirConexion

        public void CerrarConexion()
        {
            miConexion.Close();
        }//CerrarConexion

        public bool Conectar(string servidor, string puerto, string usuario, string pass)
        {
            try
            {
                string cadenaConexion = $"Server={servidor};Port={puerto};User Id={usuario};Password={pass};Database=person;Allow Zero Datetime=True;Charset=utf8;";
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
        }//Conectar

        public bool Conectar2()
        {
            try
            {
                string cadenaConexion = $"Server=127.0.0.1;Port=33060;User Id=root;Password=root;Database=person;Allow Zero Datetime=True;Charset=utf8;";
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
        }//Conectar2


        public List<ModelPersona> LeerBBDD()
        {
            List<ModelPersona> listaPersona = new List<ModelPersona>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM estudiantes", miConexion);
            MySqlDataReader lector;

            AbrirConexion();
            lector = comando.ExecuteReader();

            while (lector.Read())//Lector coje una fila por cada read
            {
                //Cada indice es una columna
                ModelPersona nuevaPersona = new ModelPersona(lector[0].ToString(), lector[1].ToString(), lector[2].ToString());
                listaPersona.Add(nuevaPersona);
            }
            lector.Close();
            CerrarConexion();

            return listaPersona;
        }//LeerBBDD

        public void Agregar(string nombre, string apellidos)
        {
            MySqlCommand comando = new MySqlCommand($"INSERT INTO ESTUDIANTES (nombre,apellido) VALUES ('{nombre}','{apellidos}')", miConexion);
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }//Agregar


        public void Eliminar(string id)
        {
            //Obtenemos el id INT con el string pasado o no necesario? NO HACE FALTA
            MySqlCommand comando = new MySqlCommand($"DELETE FROM ESTUDIANTES WHERE id='{id}'", miConexion);
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
            //DEJAR ID LIBRE
        }

        public void Actualizar(string id)
        {

            MySqlCommand comando = new MySqlCommand($"UPDATE ESTUDIANTES SET nombre = nombre, apellido = @apellido, edad = @edad WHERE id = @id",miConexion);
            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}
