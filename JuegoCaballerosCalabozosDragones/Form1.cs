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
                    color = 0;
                else if (modal.rbAzul.Checked)
                    color = 1;
                else if (modal.rbAmarillo.Checked)
                    color = 2;
                else if (modal.rbVerde.Checked)
                    color = 3;
                if (modal.tbNombre.Text != "")
                {
                    jugo = true;
                    sistema.CrearPartida(Convert.ToInt32(modal.nudCantJugadores.Value),
                                        dificultad, modal.tbNombre.Text, color);

                    formTablero.pbCaballeroVerde.Location = new Point(330, 90);
                    formTablero.pbCaballeroRojo.Location = new Point(344, 90);
                    formTablero.pbCaballeroAzul.Location = new Point(367, 90);
                    formTablero.pbCaballeroAmarillo.Location = new Point(389, 90);

                    bool salir = false;
                    while (sistema.PartidaActual.Ganador == null && salir == false)
                    {
                        formTablero.Show();
                        Jugador jugadorActual = ((Jugador)sistema.PartidaActual.Jugadores[sistema.PartidaActual.Turno]);
                        int movimientoJugador;
                        int[] movimientoDragones = new int[2];
                        bool hayGanador = false;
                        //Funcion para que solo tire si es humano
                        DialogResult resultadoDados;
                        if (jugadorActual.Humano)
                        {
                            resultadoDados = tirarDados.ShowDialog();
                            if (resultadoDados == DialogResult.Cancel)
                            {
                                formTablero.Dispose();
                                salir = true;
                            }
                        }
                        else
                        {
                            resultadoDados = DialogResult.OK;
                        }
                        //Mostrar Resultados en el listBox
                        if (resultadoDados == DialogResult.OK)
                        {
                            int resultado = sistema.PartidaActual.Jugar(out movimientoJugador, ref hayGanador, ref movimientoDragones, dado.Next(1, 7));
                            //int posX, posY, PosBase ;
                            switch (resultado)
                            {
                                case 0:
<<<<<<< HEAD
                                    if (dificultad > 0)
                                    {
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
=======
                                    if(dificultad>0)
                                    formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
>>>>>>> 37978167d18419c6765e699764ad06f883070fbe
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " se movió a la posición: " + movimientoJugador);
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 1:
                                    if (dificultad > 0)
<<<<<<< HEAD
                                    {
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
=======
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
>>>>>>> 37978167d18419c6765e699764ad06f883070fbe
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " avanzó 5 posiciones hacia la posición: " + movimientoJugador);
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 2:
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " murió.");
                                    break;
                                case 3:
                                    if (dificultad > 0)
<<<<<<< HEAD
                                    {
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
=======
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
>>>>>>> 37978167d18419c6765e699764ad06f883070fbe
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " retrocedió 5 posiciones hacia la posición: " + movimientoJugador);
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 4:
                                    if (dificultad > 0)
<<<<<<< HEAD
                                    {
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
=======
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
>>>>>>> 37978167d18419c6765e699764ad06f883070fbe
                                    formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " perdió su turno.");
                                    break;
                                case 5:
                                    if (dificultad > 0)
<<<<<<< HEAD
                                    {
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
=======
                                        formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
>>>>>>> 37978167d18419c6765e699764ad06f883070fbe
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
                formTablero.pbCaballeroVerde.Location = new Point(330, 90);
                formTablero.pbCaballeroRojo.Location = new Point(344, 90);
                formTablero.pbCaballeroAzul.Location = new Point(389, 90);
                formTablero.pbCaballeroAmarillo.Location = new Point(330, 90);
                while (sistema.PartidaActual.Ganador == null)
                {
                    formTablero.Show();
                    Jugador jugadorActual = ((Jugador)sistema.PartidaActual.Jugadores[sistema.PartidaActual.Turno]);
                    int movimientoJugador;
                    int[] movimientoDragones = new int[2];
                    bool hayGanador = false;

                    int resultado = sistema.PartidaActual.Jugar(out movimientoJugador, ref hayGanador, ref movimientoDragones, dado.Next(1, 7));
                    int[] posiciones = new int[2];
                    switch (resultado)
                    {
                        case 0:
                            if (dificultad > 0)
                            {
                                formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                            }

                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " se movió a la posición: " + movimientoJugador);
                            if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");

                            break;
                        case 1:
                            if (dificultad > 0)
                            {
                                formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                            }
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " avanzó 5 posiciones hacia la posición: " + movimientoJugador);
                            if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");

                            break;
                        case 2:
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " murió.");
                            break;
                        case 3:
                            if (dificultad > 0)
                            {
                                formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                            }
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " retrocedió 5 posiciones hacia la posición: " + movimientoJugador);
                            if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");

                            break;
                        case 4:
                            if (dificultad > 0)
                            {
                                formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                            }
                            formTablero.lbEstado.Items.Add(jugadorActual.Nombre + " perdió su turno.");
                            break;
                        case 5:
                            if (dificultad > 0)
                            {
                                formTablero.lbEstado.Items.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                            }

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
        private bool MoverDragon(int color, int[] posiciones, FormTablero tablero)
        {
            bool exito = false;
            int posX, posY;

            switch (color)
            {
                case 0:
                    for (int i = 0; i < 2; i++)
                    {
                        if ((posiciones[i] % 10) == 0) posX = 344 + 9 * 103;
                        else posX = 344 + (((posiciones[i] % 10) - 1) * 103);
                        if (posiciones[i] % 10 == 0) posY = 46 + ((((int)posiciones[i] / 10) - 1) * 119);
                        else posY = 46 + (((int)posiciones[i] / 10) * 119);
                        if (i == 1)
                            tablero.pbDragonRojo1.Location = new Point(posX, posY);
                        else tablero.pbDragonRojo2.Location = new Point(posX, posY - 10);
                    }
                    exito = true;
                    break;
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        if ((posiciones[i] % 10) == 0) posX = 367 + 9 * 103;
                        else posX = 367 + (((posiciones[i] % 10) - 1) * 103); ;
                        if (posiciones[i] % 10 == 0) posY = 46 + ((((int)posiciones[i] / 10) - 1) * 119);
                        else posY = 46 + (((int)posiciones[i] / 10) * 119);
                        if (i == 1)
                            tablero.pbDragonAzul1.Location = new Point(posX, posY);
                        else tablero.pbDragonAzul2.Location = new Point(posX, posY - 10);

                    }
                    exito = true;
                    break;

                case 2:
                    for (int i = 0; i < 2; i++)
                    {
                        if ((posiciones[i] % 10) == 0) posX = 389 + 9 * 103;
                        else posX = 389 + (((posiciones[i] % 10) - 1) * 103); ;
                        if (posiciones[i] % 10 == 0) posY = 46 + ((((int)posiciones[i] / 10) - 1) * 119);
                        else posY = 46 + (((int)posiciones[i] / 10) * 119);
                        if (i == 1)
                            tablero.pbDragonAmarillo1.Location = new Point(posX, posY);
                        else tablero.pbDragonAmarillo2.Location = new Point(posX, posY - 10);

                    }
                    exito = true;
                    break;
                case 3:
                    for (int i = 0; i < 2; i++)
                    {
                        if ((posiciones[i] % 10) == 0) posX = 330 + 9 * 103;
                        else posX = 330 + (((posiciones[i] % 10) - 1) * 103); ;
                        if (posiciones[i] % 10 == 0) posY = 46 + ((((int)posiciones[i] / 10) - 1) * 119);
                        else posY = 46 + (((int)posiciones[i] / 10) * 119);
                        if (i == 1)
                            tablero.pbDragonVerde1.Location = new Point(posX, posY);
                        else tablero.pbDragonVerde2.Location = new Point(posX, posY - 10);

                    }
                    exito = true;
                    break;
            }
            return exito;
        }
        private bool MoverCaballero(int color, int posicion, FormTablero tablero)
        {
            bool exito = false;
            int posX, posY;

            switch (color)
            {
                case 0:
                    if ((posicion % 10) == 0) posX = 344 + 9 * 103;
                    else posX = 344 + (((posicion % 10) - 1) * 103);
                    if (posicion % 10 == 0) posY = 90 + ((((int)posicion / 10) - 1) * 119);
                    else posY = 90 + (((int)posicion / 10) * 119);
                    tablero.pbCaballeroRojo.Location = new Point(posX, posY);
                    exito = true;
                    break;
                case 1:
                    if ((posicion % 10) == 0) posX = 367 + 9 * 103;
                    else posX = 367 + (((posicion % 10) - 1) * 103); ;
                    if (posicion % 10 == 0) posY = 90 + ((((int)posicion / 10) - 1) * 119);
                    else posY = 90 + (((int)posicion / 10) * 119);
                    tablero.pbCaballeroAzul.Location = new Point(posX, posY);
                    exito = true;
                    break;
                case 2:
                    if ((posicion % 10) == 0) posX = 389 + 9 * 103;
                    else posX = 389 + (((posicion % 10) - 1) * 103); ;
                    if (posicion % 10 == 0) posY = 90 + ((((int)posicion / 10) - 1) * 119);
                    else posY = 90 + (((int)posicion / 10) * 119);
                    tablero.pbCaballeroAmarillo.Location = new Point(posX, posY);
                    exito = true;
                    break;
                case 3:
                    if ((posicion % 10) == 0) posX = 330 + 9 * 103;
                    else posX = 330 + (((posicion % 10) - 1) * 103); ;
                    if (posicion % 10 == 0) posY = 90 + ((((int)posicion / 10) - 1) * 119);
                    else posY = 90 + (((int)posicion / 10) * 119);
                    tablero.pbCaballeroVerde.Location = new Point(posX, posY);
                    exito = true;
                    break;
            }
            return exito;
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
