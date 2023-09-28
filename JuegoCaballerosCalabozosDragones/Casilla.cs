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
        bool calabozos = false;
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
            if (dragon != null)       
                dragones.Add(dragon);
        }

        public void QuitarDragon(Dragon dragon)
        {
            if (dragon != null)
            {
                int posicionDragon = dragones.IndexOf(dragon);
                dragones.RemoveAt(posicionDragon);
            }
        }

        public void AgregarCalabozo()
        {
            calabozos = true;
        }
    }
}
