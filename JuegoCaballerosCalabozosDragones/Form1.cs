using JuegoCaballerosCalabozosDragones.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCaballerosCalabozosDragones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sistema = new Sistema();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Random dado = new Random();
            TirarDados tirarDados = new TirarDados();
            FormTablero formTablero = new FormTablero();
            FormNombreJugador modal = new FormNombreJugador();
            bool jugo = false;
            while (!jugo && modal.ShowDialog() == DialogResult.OK)
            {
                int dificultad = 0;
                int color = 0;
                if (rbBasico.Checked)
                    dificultad = 0;
                else if (rbIntermedio.Checked)
                    dificultad = 1;
                else if (rbExperto.Checked)
                    dificultad = 2;

                if (modal.rbRojo.Checked)
                    color = 1;
                else if (modal.rbAzul.Checked)
                    color = 2;
                else if (modal.rbAmarillo.Checked)
                    color = 3;
                else if (modal.rbVerde.Checked)
                    color = 4;
                if (modal.tbNombre.Text != "")
                {
                    jugo = true;
                    sistema.CrearPartida(Convert.ToInt32(modal.nudCantJugadores.Value),
                                        dificultad, modal.tbNombre.Text, color);
                    
                    while (sistema.PartidaActual.Ganador == null)
                    {
                        formTablero.Show();
                        Jugador jugadorActual = ((Jugador)sistema.PartidaActual.Jugadores[sistema.PartidaActual.Turno]);
                        int movimientoJugador;
                        int[] movimientoDragones = new int[2];
                        bool hayGanador = false;

                        DialogResult resultadoDados = tirarDados.ShowDialog();
                        if (resultadoDados == DialogResult.Cancel)
                        {
                            formTablero.Close();
                        }
                        if (resultadoDados == DialogResult.OK)
                        {                              
                            int resultado = sistema.PartidaActual.Jugar(out movimientoJugador, ref hayGanador, ref movimientoDragones, dado.Next(1,7));
                            switch (resultado)
                            {
                                case 0:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " se movió a la posición: " + movimientoJugador);
                                    break;
                                case 1:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " avanzó 5 posiciones hacia la posición: " + movimientoJugador);
                                    break;
                                case 2:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " murió.");
                                    break;
                                case 3:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " retrocedió 5 posiciones hacia la posición: " + movimientoJugador);
                                    break;
                                case 4:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " perdió su turno.");
                                    break;
                                case 5:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " puede jugar en la próxima.");
                                    break;

                            }
                            if (hayGanador)
                            {
                                formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " ganó.");
                                sistema.AgregarJugadorRanking();
                                MessageBox.Show("¡El jugador ganador es " + ((Jugador)sistema.PartidaActual.Ganador).Nombre.ToString() + ", felicidades!");
                            }
                        }
                        
                    }
                }
                else MessageBox.Show("Debe ingresar un nombre.");               
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            Random dado = new Random();
            FormTablero formTablero = new FormTablero();
            FormNombreJugador modal = new FormNombreJugador();
            modal.tbNombre.Enabled = false;
            modal.rbAmarillo.Enabled = false;
            modal.rbAzul.Enabled = false;
            modal.rbRojo.Enabled = false;
            modal.rbVerde.Enabled = false;
            if (modal.ShowDialog() == DialogResult.OK)
            {
                int dificultad = 0;
                if (rbBasico.Checked)
                    dificultad = 0;
                else if (rbIntermedio.Checked)
                    dificultad = 1;
                else if (rbExperto.Checked)
                    dificultad = 2;

                sistema.CrearPartida(Convert.ToInt32(modal.nudCantJugadores.Value), dificultad);

                while (sistema.PartidaActual.Ganador == null)
                {
                    formTablero.Show();
                    Jugador jugadorActual = ((Jugador)sistema.PartidaActual.Jugadores[sistema.PartidaActual.Turno]);
                    int movimientoJugador;
                    int[] movimientoDragones = new int[2];
                    bool hayGanador = false;

                    int resultado = sistema.PartidaActual.Jugar(out movimientoJugador, ref hayGanador, ref movimientoDragones, dado.Next(1,7));
                    switch (resultado)
                    {
                        case 0:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " se movió a la posición: " + movimientoJugador);
                            break;
                        case 1:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " avanzó 5 posiciones hacia la posición: " + movimientoJugador);
                            break;
                        case 2:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " murió.");
                            break;
                        case 3:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " retrocedió 5 posiciones hacia la posición: " + movimientoJugador);
                            break;
                        case 4:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " perdió su turno.");
                            break;
                        case 5:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " puede jugar en la próxima.");
                            break;

                    }
                    if (hayGanador)
                    {
                        formTablero.lbEstado.Items.Add(((Jugador)sistema.PartidaActual.Ganador).Nombre + " ganó.");
                        MessageBox.Show("¡El jugador ganador es " + ((Jugador)sistema.PartidaActual.Ganador).Nombre.ToString() + ", felicidades!");
                    }
                }
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FormRanking modal = new FormRanking();
            sistema.OrdenarRanking();
            foreach(Jugador jugador in sistema.Ranking)
            {
                modal.lbRanking.Items.Add(jugador.Nombre+" // Puntos: "+jugador.Puntaje);
            }
            modal.Show();
        }
    }
}
