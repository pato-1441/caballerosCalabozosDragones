using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Pieza
    {
        protected int posicion = 1;

        public int Posicion { get { return posicion; } }

        
        public virtual int Mover(int cantidad)
        {
            posicion = cantidad;
            return posicion;
        }
    }
}
