using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Sistema
    {
        ArrayList ranking = new ArrayList();
        Partida partidaActual;
        public ArrayList Ranking { get { return ranking; } }
        public Partida PartidaActual { get { return partidaActual; } }
        public void OrdenarRanking()
        {
            ranking.Sort();
            ranking.Reverse();
        }

        public void CrearPartida(int cantidadJugadores, int modoJuego, string nombreJugador, int colorCaballero)
        {
            partidaActual = new Partida(cantidadJugadores, modoJuego, nombreJugador, colorCaballero);
        }

        public void CrearPartida(int cantidadJugadores, int modoJuego)
        {
            partidaActual = new Partida(cantidadJugadores, modoJuego);
        }

        public void AgregarJugadorRanking()   //Le saqué el argumento y le puse el ganador de la partida actual
        {
            bool hayJugador=false;
            foreach (Jugador jugador in Ranking)
                if (jugador.Nombre == partidaActual.Ganador.Nombre) {
                    jugador.Puntaje++;
                    hayJugador = true;
                }
            if (!hayJugador)
            {
                partidaActual.Ganador.Puntaje++;
                ranking.Add(partidaActual.Ganador);
            }

           /* if (ranking.Contains(partidaActual.Ganador))
            {
                partidaActual.Ganador.Puntaje++;
            }else ranking.Add(partidaActual.Ganador);*/
            OrdenarRanking();
        }

        
    }
}
