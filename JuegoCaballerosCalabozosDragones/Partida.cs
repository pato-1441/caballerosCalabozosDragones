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
        Casilla[] tablero = new Casilla[51];
        Pieza[] calabozos;
        ArrayList jugadores;
        int turno=0;
        bool demo;
        int dificultad;
        Random dado = new Random();
        Jugador ganador = null;
        
        public int Turno { get { return turno; } }
        public ArrayList Jugadores { get { return jugadores; } }
        public Jugador Ganador { get { return ganador; } }
        //CREAMOS JUGADORES VIRTUALES Y HUMANO
        public Partida(int cantJugadores, int dificultad, string nombreJugador, int colorCaballero)
        {
            jugadores = new ArrayList();
            demo = false;
            this.dificultad = dificultad;
            CrearCasillas();
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
            CrearCasillas();
            CrearJugadoresVirtuales(cantJugadores, demo);
            CrearCalabozos();
        }

        private void CrearCasillas()
        {
            for(int i = 1; i<51; i++)
            {
                tablero[i] = new Casilla();
            }
        }
        public int Jugar(out int movimientoCaballero, ref bool hayGanador, ref int[] moverDragon) //Agregué argumentos
        {
            movimientoCaballero = 0;
            //sobre el tablero, en donde tiene el dragon el jugador, quita el dragon de la casilla (le pasa dragon) 
            Jugador jugadorJugando = ((Jugador)jugadores[turno]);
            if (!(jugadorJugando.PierdeTurno))
            {
                if(jugadorJugando.Dragones.Length < 1)
                    for (int i = 0; i < jugadorJugando.Dragones.Length; i++)
                    {
                        //quitar dragon de la casilla
                        tablero[jugadorJugando.Dragones[i].Posicion].QuitarDragon(jugadorJugando.Dragones[i]);
                    
                        int movimientoDragon = dado.Next(1, 51);
                        //moverlo
                        moverDragon[i] = jugadorJugando.Dragones[i].Mover(movimientoDragon);    //Hice que mover dragon sea un vector
                        //agregar dragon de la casilla
                        tablero[movimientoDragon].AgregarDragon(jugadorJugando.Dragones[i]);
                    }

            }

            //tira dado y mueve caballero
            int movimiento = dado.Next(1, 7);
            Casilla casilla;
            if (jugadorJugando.Caballero.Posicion + movimiento < 1)
            {
                casilla = tablero[1];
            }
            else if (jugadorJugando.Caballero.Posicion + movimiento > 50)
            {
                casilla = tablero[50];
            }
            else
            {
                casilla = tablero[jugadorJugando.Caballero.Posicion + movimiento];
            }
            int moverPieza = (jugadorJugando.MoverPieza(movimiento, casilla));
            if (moverPieza == 2)
            {
                //elimina los dragones y luego el jugador que MURIO
                tablero[jugadorJugando.Dragones[0].Posicion].QuitarDragon(jugadorJugando.Dragones[0]);
                tablero[jugadorJugando.Dragones[1].Posicion].QuitarDragon(jugadorJugando.Dragones[1]);
                jugadores.RemoveAt(turno);
                if (jugadores.Count == 1)
                {
                    ganador = (Jugador)jugadores[0];
                    hayGanador = true;
                }
            }
            if (turno >= (jugadores.Count - 1))
            {
                movimientoCaballero = jugadorJugando.Caballero.Posicion; //Agregué esta linea de código
                turno = 0;
            }
            else
            {
                movimientoCaballero = jugadorJugando.Caballero.Posicion; //Agregué esta linea de código
                turno++;

            }

            if (jugadorJugando.Caballero.Posicion >= 50)
            {
                ganador = jugadorJugando;
                hayGanador = true;
            }//Agregué esta linea de código

            //si es necesario, volver a moverse
            return moverPieza;//Cambié movimiento por moverPieza
        }


        private void CrearJugadoresVirtuales(int cantidadJugadores, bool demo)
        {
            if (demo)
            {
                for (int i = 0; i < cantidadJugadores; i++)
                {
                    
                    string nombreJugador = "Virtual " + (i+1);
                    Jugador jugador = new Jugador(nombreJugador, false, dificultad, i + 1, tablero[1]);
                    jugadores.Add(jugador);
                    
                }
            }
            else
            {
                
                for (int i = 0; i < cantidadJugadores - 1; i++)
                {
                    string nombreJugador = "Virtual " + (i+1);
                    Jugador jugador = new Jugador(nombreJugador, false, dificultad, i + 1, tablero[1]);
                    jugadores.Add(jugador);
                }
            }
               

        }

        //string nombre, bool humano, int dificultad, int color
        private void CrearJugadorHumano(string nombre, int color)
        {
            jugadores.Add(new Jugador(nombre, true, dificultad, color, tablero[1]));
        }
        
        private void CrearCalabozos()
        {
            if (dificultad > 1)
            {
                calabozos = new Pieza[3];
                for(int i = 0; i < 3; i++)
                {
                    calabozos[i]=new Pieza();
                    tablero[calabozos[i].Mover(dado.Next(1, 51))].AgregarCalabozo();
                }
            }
        }
    }

}
