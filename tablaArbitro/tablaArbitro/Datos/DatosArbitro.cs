using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using tablaArbitro.Interfaz;
using tablaArbitro.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tablaArbitro.Datos
{
    public class DatosArbitro : IArbitro
    {
        Conexion conexion = new Conexion();
        public bool eliminarArbitro(int _id)
        {
            MySqlConnection SQLdatos= new MySqlConnection();
            bool respuesta=true;

            try
            {
                SQLdatos = conexion.crearConexion();
                MySqlCommand comando = new MySqlCommand("psa_borrar_arbitro", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_id", MySqlDbType.Int16).Value = _id;
                SQLdatos.Open();
                respuesta = comando.ExecuteNonQuery() > 0 ? true : false;

            }
            catch (Exception ex)
            {

                Funciones.Logs("Datos_Agregar", ex.ToString());
            }
            finally 
            {
                if (SQLdatos.State==ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return respuesta;
        }

        public DataTable listarArbitros()
        {

            DataTable tabla = new DataTable();
            using (MySqlConnection SQLdatos = conexion.crearConexion())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("psa_listadoArbitro", SQLdatos))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        SQLdatos.Open();

                        using (MySqlDataReader resultado = comando.ExecuteReader())
                        {
                            tabla.Load(resultado);
                        }
                    }
                }

                catch (Exception ex)
                {

                    Funciones.Logs("Datos_metodoListarArbitro", ex.ToString());
                }
                finally
                {
                    if (SQLdatos.State == ConnectionState.Open)
                    {
                        SQLdatos.Close();
                    }
                }
                return tabla;
               
      
            }

        }

        string IArbitro.actualizarArbitro(Arbitro _arbitro)
        {
            throw new NotImplementedException();
        }

        public string agregarArbitro(Arbitro _arbitro)
        {
            MySqlConnection SQLDatos = conexion.crearConexion();
            SQLDatos = conexion.crearConexion();
            
            string respuesta = null;

            try
            {
                SQLDatos = conexion.crearConexion();
                MySqlTransaction tras;
                SQLDatos.Open();
                tras = SQLDatos.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("asp_guardar_arbitro", SQLDatos);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("_dni", MySqlDbType.VarChar).Value = _arbitro.dni;
                comando.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = _arbitro.apellido;
                comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _arbitro.nombre;
                comando.Parameters.Add("_telefono", MySqlDbType.VarChar).Value = _arbitro.telefono;
                comando.Parameters.Add("_domicilio", MySqlDbType.VarChar).Value = _arbitro.domicilio;
                comando.Parameters.Add("_activo", MySqlDbType.Int16).Value = 1;
                
                respuesta = comando.ExecuteNonQuery() > 0 ? "Ok" : "Error al guardar";
                tras.Commit();

            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_Agregar",respuesta+ ">>"+ ex.ToString());
                //tras.Rollback();

            }
            finally 
            {
                if (SQLDatos.State==ConnectionState.Open)
                {
                    SQLDatos.Close();
                }
            }
            return respuesta ;
        }

        Arbitro IArbitro.buscarXdni(string _dni)
        {
            throw new NotImplementedException();
        }

        List<Arbitro> IArbitro.listadoXapellido(string _apellido)
        {
            throw new NotImplementedException();
        }
    }
}
