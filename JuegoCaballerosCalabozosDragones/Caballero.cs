using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Caballero : Pieza
    {
        readonly int color; 
        public int Color { get { return color; } }

        public Caballero(int color)
        {
            this.color = color;
        }

        public override int Mover()
        {
            int dado = base.movimiento.Next(1, 7);
            base.posicion += dado;
            return dado;
        }

        

    }
}
