using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaArbitro.Modelos
{
     class Jugador
    {
        private int idJugador {  get; set; }
        private int carnet {  get; set; }
        private string apellido {  get; set; }
        private string nombre {  get; set; }
        private DateTime fechaNaci {  get; set; }
        private string posicion {  get; set; }
        private int idEquipo {  get; set; }
        private bool activo {  get; set; }

        public Jugador() { }
        public Jugador(int idJugador, int carnet, string apellido, string nombre, DateTime fechaNaci, string posicion, int edEquipo, bool activo)
        {
            this.idJugador=idJugador;
            this.carnet=carnet;
            this.apellido=apellido;
            this.nombre=nombre;
            this.fechaNaci = fechaNaci;
            this.posicion = posicion;
            this.idEquipo = idEquipo;
            this.activo=activo;
        }
        public Jugador(int carnet, string apellido, string nombre, DateTime fechaNaci, string posicion, int edEquipo, bool activo)
        {
            
            this.carnet = carnet;
            this.apellido = apellido;
            this.nombre = nombre;
            this.fechaNaci = fechaNaci;
            this.posicion = posicion;
            this.idEquipo = idEquipo;
            this.activo = activo;
        }
    }
}
