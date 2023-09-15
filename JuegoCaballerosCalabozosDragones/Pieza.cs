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
        protected Random movimiento = new Random();

        public int Posicion { get { return posicion; } }

        
        public virtual int Mover()
        {
            posicion = movimiento.Next(1, 51);
            return posicion;
        }
    }
}
