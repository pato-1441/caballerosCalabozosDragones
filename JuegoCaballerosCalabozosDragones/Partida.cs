using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Partida
    {
        Casilla[] tablero = new Casilla[51] ;
        Jugador[] jugadores;
        int turno=0;
        bool demo;
        int dificultad;

        //CREAMOS JUGADORES VIRTUALES Y HUMANO
        public Partida(int cantJugadores, int dificultad, bool demo, string nombreJugador, int colorCaballero)
        {
            jugadores = new Jugador[cantJugadores];
            this.demo = demo;
            this.dificultad = dificultad;
            CrearJugadorHumano(nombreJugador, colorCaballero);
            CrearJugadoresVirtuales(cantJugadores, demo);
            
           
        }

        //SOLO CREAMOS JUGADORES VIRTUALES
        public Partida(int cantJugadores, int dificultad, bool demo)
        {
            jugadores = new Jugador[cantJugadores];
            this.demo = demo;
            this.dificultad = dificultad;
            CrearJugadoresVirtuales(cantJugadores, demo);
        }

        private void CrearJugadoresVirtuales(int cantidadJugadores, bool demo)
        {
            if (demo)
            {
                for (int i = 0; i < cantidadJugadores; i++)
                {
                    
                    string nombreJugador = "Jugador" + (i+1);
                    Jugador jugador = new Jugador(nombreJugador, false, dificultad, i + 1);
                    jugadores[i] = jugador;
                    
                }
            }
            else
            {
                
                for (int i = 0; i < cantidadJugadores - 1; i++)
                {
                    string nombreJugador = "Jugador" + (i+1);
                    Jugador jugador = new Jugador(nombreJugador, false, dificultad, i + 1);
                    jugadores[i+1] = jugador;
                }
            }
               

        }

        //string nombre, bool humano, int dificultad, int color
        private void CrearJugadorHumano(string nombre, int color)
        {
            jugadores[0] = new Jugador(nombre, true, dificultad, color);
        }


    }

}
