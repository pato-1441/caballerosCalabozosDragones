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

        public void AgregarJugadorRanking() 
        {
            bool hayJugador=false;
            foreach (Jugador jugador in Ranking)
                if (jugador.Nombre.ToLower() == partidaActual.Ganador.Nombre.ToLower()) {
                    jugador.Puntaje++;
                    hayJugador = true;
                }
            if (!hayJugador)
            {
                partidaActual.Ganador.Puntaje++;
                ranking.Add(partidaActual.Ganador);
            }
            OrdenarRanking();
        }

        
    }
}
