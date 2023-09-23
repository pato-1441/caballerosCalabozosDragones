using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Dragon : Pieza
    {
        Jugador duenio;
        public Jugador Duenio
        {
            get { return duenio; }
        }

        public Dragon(Jugador duenio)
        {
            this.duenio = duenio;
            base.posicion = 1;
        }

        public override int Mover(int cantidad)
        {
            return base.Mover(cantidad);
        }
    }
}
