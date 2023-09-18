using System;
using System.Collections;
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
        ArrayList jugadores;
        int turno=0;
        bool demo;
        int dificultad;
        Random dado = new Random();
        Jugador ganador = null;

        //CREAMOS JUGADORES VIRTUALES Y HUMANO
        public Partida(int cantJugadores, int dificultad, string nombreJugador, int colorCaballero)
        {
            jugadores = new ArrayList();
            demo = false;
            this.dificultad = dificultad;
            CrearJugadorHumano(nombreJugador, colorCaballero);
            CrearJugadoresVirtuales(cantJugadores, demo);
            CrearCalabozos();
           
        }

        //SOLO CREAMOS JUGADORES VIRTUALES
        public Partida(int cantJugadores, int dificultad)
        {
            jugadores = new ArrayList();
            demo = true;
            this.dificultad = dificultad;
            CrearJugadoresVirtuales(cantJugadores, demo);
        }


        public int Jugar() 
        {
            
            //tirar el dado y moverse
            int movimiento = dado.Next(1, 7);
            int moverPieza = ((Jugador)jugadores[turno]).MoverPieza(movimiento, (tablero[((Jugador)jugadores[turno]).Caballero.Posicion + movimiento]));
            if (moverPieza == 2)
            {
                jugadores.RemoveAt(turno);
            }
            if (turno == (jugadores.Count - 1))
            {
                turno = 0;
            }else turno++;
            //si es necesario, volver a moverse
            return moverPieza;
        }


        private void CrearJugadoresVirtuales(int cantidadJugadores, bool demo)
        {
            if (demo)
            {
                for (int i = 0; i < cantidadJugadores; i++)
                {
                    
                    string nombreJugador = "Virtual " + (i+1);
                    Jugador jugador = new Jugador(nombreJugador, false, dificultad, i + 1);
                    jugadores.Add(jugador);
                    
                }
            }
            else
            {
                
                for (int i = 0; i < cantidadJugadores - 1; i++)
                {
                    string nombreJugador = "Virtual " + (i+1);
                    Jugador jugador = new Jugador(nombreJugador, false, dificultad, i + 1);
                    jugadores.Add(jugador);
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
                    tablero[calabozos[i].Mover(dado.Next(1,51))].AgregarCalabozo();
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
