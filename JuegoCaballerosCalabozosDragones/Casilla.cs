using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace JuegoCaballerosCalabozosDragones
{
    internal class Casilla
    {
        ArrayList dragones = new ArrayList();
        bool calabozos;
        //bool caballero;
        public ArrayList Dragones
        {
            get { return dragones; }
        }

        public bool Calabozos
        {
            get { return calabozos; }

        }

        public void AgregarDragon(Dragon dragon)
        {
            dragones.Add(dragon);
        }

        public void QuitarDragon(Dragon dragon)
        {
            dragones.RemoveAt(dragon.Posicion);
        }

        public void AgregarCalabozo()
        {
            calabozos = true;
        }
    }
}
