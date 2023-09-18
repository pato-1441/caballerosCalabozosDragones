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
        bool pierdeTurno=false;
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

        public int MoverPieza(int cantidad, Casilla casillaActual)
        {
            int VariableQueNoSEQueHace = 0;
            if(pierdeTurno == false)
            {
                ultimoMovimiento = caballero.Mover(cantidad);
                switch (RevisarCasilla(casillaActual))
                {
                    case 0: break;
                    case 1: caballero.Mover(5); break; //adelanta 5 posiciones
                    case 2:  break;//muere
                    case 3: caballero.Mover(-5); break; //retrocede 5 posiciones
                    case 4: pierdeTurno = true; break;//pierde turno
                }
            }
            else
            {
                pierdeTurno =false;
            }
            return VariableQueNoSEQueHace;
        }

        private void Mover(int cantidad)
        {

        }

        private int RevisarCasilla(Casilla casillaActual)
        {
             /*
             Si no hay nada devuelve 0;
             Si hay dragon mio =1;
             Si hay dragonEnemigo y calabozo =2;
             Si hay dragon del otro =3;
             Si hay solo calabozo = 4;
             */

            int entidades = 0;
            if (casillaActual.Dragones.Count > 0 )
            {
               if(((Dragon)casillaActual.Dragones[0]).Duenio.Nombre == this.Nombre)
                {
                    entidades = 1;
                }
                else if (((Dragon)casillaActual.Dragones[0]).Duenio.Nombre != this.Nombre && casillaActual.Calabozos)
                {
                    entidades = 2;
                }
                else
                {
                    entidades=3;
                }
            }
            else if (casillaActual.Calabozos)
            {
                entidades =4;
            }
                return entidades;
        }
    }
}
