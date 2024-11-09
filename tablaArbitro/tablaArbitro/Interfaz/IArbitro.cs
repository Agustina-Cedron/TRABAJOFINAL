using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tablaArbitro.Modelos;

namespace tablaArbitro.Interfaz
{
    interface IArbitro
    {
        string agregarArbitro(Arbitro _arbitro);
        bool eliminarArbitro(int _id);
        string actualizarArbitro(Arbitro _arbitro);
        Arbitro buscarXdni(string _dni);
        DataTable listarArbitros();
        List<Arbitro>listadoXapellido(string _apellido);
    }
}
