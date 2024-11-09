using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaArbitro.Datos
{
    internal class Funciones
    {
        public static void Logs(string nombre_archivo, string detalle)
        {
            string directorio = AppDomain.CurrentDomain.BaseDirectory +
                "logs/" +
                DateTime.Now.Year.ToString() + "/"+
            DateTime.Now.Month.ToString() + "/"+
            DateTime.Now.Day.ToString() + "/";
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            StreamWriter miArchivo=new StreamWriter(directorio+"/"+nombre_archivo+".txt",true);
            string descripcion = DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss")+"->"+detalle;
            miArchivo.WriteLine(descripcion);
            miArchivo.Close();

        }
    }
}
