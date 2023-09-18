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
        int ultimoMovimiento=0;
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
            caballero = new Caballero(color);
        }

        private void CrearDragones(int dificultad)
        {
            if(dificultad >= 1)
            {
                misDragones[0] = new Dragon(this);
                misDragones[1] = new Dragon(this);
            }
        }

        public void MoverPieza()
        {
            ultimoMovimiento = caballero.Mover();

        }

        private int RevisarCasilla()
        {
            /*
             Si no hay nada devuelve 0;
             Si hay dragon mio =1;
             Si hay dragonEnemigo y calabozo =2;
             Si hay dragon del otro =3;
             Si hay solo calabozo = 4;
             */
            int entidades = 0;
            if ()

                return entidades;
        }
    }
}
