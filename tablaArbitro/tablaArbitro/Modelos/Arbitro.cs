using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaArbitro.Modelos
{
    public class Arbitro
    {
        public int idArbitro { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public bool activo { get; set; }


        public Arbitro() { }

        public Arbitro(string dni, string apellido, string nombre, string telefono, string domicilio, bool activo)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.activo = activo;
        }

        public Arbitro(int idArbitro, string dni, string apellido, string nombre, string telefono, string domicilio, bool activo)
        {
            this.idArbitro = idArbitro;
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono = telefono;
            this.domicilio = domicilio;
            this.activo = activo;
        }
    }

}
