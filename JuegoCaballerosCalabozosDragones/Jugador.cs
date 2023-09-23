using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCaballerosCalabozosDragones
{
    internal class Jugador: IComparable
    {
        int puntaje;
        string nombre;
        bool humano;
        int ultimoMovimiento = 0;
        bool pierdeTurno = false;
        Dragon [] misDragones = new Dragon[2];
        Caballero caballero;

        public int Puntaje
        {
            get { return puntaje; }
            set {puntaje = value; }
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
            get { return caballero; }
        }
        public bool PierdeTurno { get { return pierdeTurno; } }

        public Dragon[] Dragones { get { return misDragones; } }  

        public Jugador(string nombre, bool humano, int dificultad, int color, Casilla casillaUno)
        {
            this.nombre = nombre;
            this.humano = humano;
            CrearDragones(dificultad, casillaUno);
            caballero = new Caballero(color);
        }

        private void CrearDragones(int dificultad, Casilla casillaUno)
        {
            if(dificultad >= 1)
            {
                misDragones[0] = new Dragon(this);                
                misDragones[1] = new Dragon(this);
                casillaUno.AgregarDragon(misDragones[0]);
                casillaUno.AgregarDragon(misDragones[1]);
            }
        }

        public void MoverDragones(Casilla casilla)
        {
            Random random = new Random();
            casilla.QuitarDragon(misDragones[0]);
            misDragones[0].Mover(random.Next(1, 51));
            misDragones[1].Mover(random.Next(1, 51));        
            
        }

        public int MoverPieza(int cantidad, Casilla casillaActual)
        {
            int resultado = 0;
            if(pierdeTurno == false)
            {
                ultimoMovimiento = caballero.Mover(cantidad);
                resultado = RevisarCasilla(casillaActual);
                switch (resultado)
                {
                    case 0: break;
                    case 1: ultimoMovimiento = caballero.Mover(5); break; //adelanta 5 posiciones
                    case 2: break;//muere
                    case 3: ultimoMovimiento = caballero.Mover(-5); break; //retrocede 5 posiciones
                    case 4: pierdeTurno = true; break;//pierde turno
                }
            }
            else
            {
                pierdeTurno = false;
                resultado = 5;
            }
            return resultado;
        }

        private int RevisarCasilla(Casilla casillaActual)
        {
            int entidades = 0; //no hay nada devuelve 0;
            if (casillaActual.Dragones.Count > 0 )
            {
                if(((Dragon)casillaActual.Dragones[0]).Duenio.Nombre == this.Nombre)
                {
                    entidades = 1; //hay dragon mio = 1;
                }
                else if (((Dragon)casillaActual.Dragones[0]).Duenio.Nombre != this.Nombre && casillaActual.Calabozos)
                {
                    entidades = 2; //hay dragonEnemigo y calabozo = 2;
                }
                else
                {
                    entidades = 3; //hay dragon del otro = 3;
                }
            }
            else if (casillaActual.Calabozos)
            {
                entidades = 4; //hay solo calabozo = 4; 
            }
            return entidades;
        }

        public int CompareTo(object obj)
        {
            if (obj != null) { }

            Jugador otroJugador = obj as Jugador;
            if (otroJugador != null)
            {
                // Comparar los jugadores por puntaje
                return this.Puntaje.CompareTo(otroJugador.Puntaje);
            }
        return 1;
        }
        }
    }

