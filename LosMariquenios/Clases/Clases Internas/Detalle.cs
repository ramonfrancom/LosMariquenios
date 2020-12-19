using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMariquenios.Clases.Clases_Internas
{
    class Detalle : ConexionBaseDeDatos
    {
        protected string codigo_barras_producto;
        protected string nombre;
        protected int cantidad;
        protected int cantidad_maxima;
    }
}
