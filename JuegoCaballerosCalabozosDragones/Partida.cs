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
        Pieza[] calabozos;
        Jugador[] jugadores;
        int turno=0;
        bool demo;
        int dificultad;
        Jugador ganador = null;

        //CREAMOS JUGADORES VIRTUALES Y HUMANO
        public Partida(int cantJugadores, int dificultad, string nombreJugador, int colorCaballero)
        {
            jugadores = new Jugador[cantJugadores];
            demo = false;
            this.dificultad = dificultad;
            CrearJugadorHumano(nombreJugador, colorCaballero);
            CrearJugadoresVirtuales(cantJugadores, demo);
            CrearCalabozos();
           
        }

        //SOLO CREAMOS JUGADORES VIRTUALES
        public Partida(int cantJugadores, int dificultad)
        {
            jugadores = new Jugador[cantJugadores];
            demo = true;
            this.dificultad = dificultad;
            CrearJugadoresVirtuales(cantJugadores, demo);
        }

        public void Jugar() { 
        
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
        
        private void CrearCalabozos()
        {
            if (dificultad > 1)
            {
                calabozos = new Pieza[3];
                for(int i = 0; i < 3; i++)
                {
                    calabozos[i]=new Pieza();
                    tablero[calabozos[i].Mover()].AgregarCalabozo();
                }
            }
        }

        private bool VerificarGanador()
        {
            bool hayGanador=false;
            if(ganador != null)
            {
                hayGanador = true;
            }
            return hayGanador;  
        }

    }

}
