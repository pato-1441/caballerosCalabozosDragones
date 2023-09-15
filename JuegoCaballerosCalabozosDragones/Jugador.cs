using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Jugador
    {
        int puntaje;
        string nombre;
        bool humano;
        Dragon [] misDragones = new Dragon[2];
        Caballero caballero;

        public int Puntaje
        {
            get { return puntaje; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public bool Humano
        {
            get { return humano; }
        }

        public Caballero Caballero
        {
            get { return Caballero; }
        }

        public Jugador(string nombre, bool humano, int dificultad, int color)
        {
            this.nombre = nombre;
            this.humano = humano;
            CrearDragones(dificultad);
            this.caballero = new Caballero(color);
        }

        private void CrearDragones(int dificultad)
        {
            if(dificultad >= 1)
            {
                Dragon dragon1 = new Dragon(this);
                Dragon dragon2 = new Dragon(this);
                misDragones[0] = dragon1;
                misDragones[1] = dragon2;

            }
        }

        public void MoverPieza()
        {
            caballero.Mover();
        }
    }
}
