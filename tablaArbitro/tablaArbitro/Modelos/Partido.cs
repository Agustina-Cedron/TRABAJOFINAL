using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaArbitro.Modelos
{
     class Partido
    {
        private int idPartido {  get; set; }
        private DateTime fecha { get; set; }
        private DateTime hora {  get; set; }
        private int fechaNum {  get; set; }
        private int idEquipolocal {  get; set; }
        private int idEquipovisitante {  get; set; }
        private int idArbitro {  get; set; }
        private string resultado {  get; set; }
        private bool activo {  get; set; }

        public Partido() { }

        public Partido(int idPartido, DateTime fecha, DateTime hora, int fechaNum, int idEquipolocal, int idEquipovisitante, int idArbitro, string arbitro, bool activo)
        {
            this.idPartido=idPartido;
            this.fecha = fecha;
            this.hora=hora;
            this.fechaNum=fechaNum;
            this.idEquipolocal = idEquipolocal;
            this.idEquipovisitante = idEquipovisitante;
            this.idArbitro = idArbitro;
            this.resultado = resultado;
            this.activo = activo;
        }
        public Partido( DateTime fecha, DateTime hora, int fechaNum, int idEquipolocal, int idEquipovisitante, int idArbitro, string arbitro, bool activo)
        {
           
            this.fecha = fecha;
            this.hora = hora;
            this.fechaNum = fechaNum;
            this.idEquipolocal = idEquipolocal;
            this.idEquipovisitante = idEquipovisitante;
            this.idArbitro = idArbitro;
            this.resultado = resultado;
            this.activo = activo;
        }
    }
}
