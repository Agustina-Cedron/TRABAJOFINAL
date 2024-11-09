using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaArbitro.Modelos
{
     class Equipo
    {
        private int idEquipo {  get; set; }
        private string nombre {  get; set; }
        private string ciudad {  get; set; }
        private string estadio {  get; set; }
        private bool activo {  get; set; }

        public Equipo() { }

        public Equipo(int idEquipo, string nombre, string ciudad, string estadio,bool activo)
        {
            this.idEquipo = idEquipo;
            this.nombre=nombre;
            this.ciudad=ciudad;
            this.estadio=estadio;
            this.activo=activo;
        }
        public Equipo(string nombre, string ciudad, string estadio, bool activo)
        {
           
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.estadio = estadio;
            this.activo = activo;
        }
    }
}
