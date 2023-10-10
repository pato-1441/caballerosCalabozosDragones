using JuegoCaballerosCalabozosDragones.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        ArrayList jugadas, reversa;
        SoundPlayer musica = new SoundPlayer();
        string[] directorioBase;
        string directorioReal = "";
        bool sonido = true;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Splash ventanaSplash = new Splash();
            ventanaSplash.ShowDialog();
            directorioBase = Application.StartupPath.Split('\\');       
            for (int i = 0; i < directorioBase.Length - 2; i++) directorioReal += directorioBase[i] + "/";
            CancionInicio();
            sistema = new Sistema();
            jugadas = new ArrayList();
            reversa = new ArrayList();
        }
        private void CancionInicio()    
        {

            musica.SoundLocation = directorioReal + "Sonidos/SonidoInicioRecortado.wav";
            if(sonido)musica.PlayLooping();
        }
        private void CancionJuego()
        {
            musica.SoundLocation = directorioReal + "Sonidos/SonidoJuegoRecortado.wav";
            if (sonido) musica.PlayLooping();
        }
        private async void btnJugar_Click(object sender, EventArgs e)
        {
            jugadas.Clear();
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
                    musica.Stop();         
                    CancionJuego();

                    jugo = true;
                    sistema.CrearPartida(Convert.ToInt32(modal.nudCantJugadores.Value),
                                        dificultad, modal.tbNombre.Text, color);

                    if (dificultad > 1) MoverCalabozo(sistema.PartidaActual.Calabozos, formTablero);
                    else
                    {
                        formTablero.pbCalabozo1.Visible=false;
                        formTablero.pbCalabozo2.Visible = false;
                        formTablero.pbCalabozo3.Visible = false;
                        if(dificultad < 1)
                        {
                            foreach(PictureBox dragon in formTablero.Dragones)
                            {
                                dragon.Visible=false;
                            }
                        }
                    }
                    bool salir = false;
                    modal.Dispose();
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
                                tirarDados.Dispose();
                                salir = true;
                            }
                            
                        }
                        else
                        {
                            
                            await Task.Delay(500);
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
                                    if (dificultad > 0)
                                    {
                                        jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
                                    jugadas.Add(jugadorActual.Nombre + " se movió a la posición: " + movimientoJugador);
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 1:
                                    if (dificultad > 0)
                                    {
                                       jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
                                    jugadas.Add(jugadorActual.Nombre + " avanzó 5 posiciones hacia la posición: " + movimientoJugador);
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 2:
                                   if (dificultad > 0)
                                    {
                                        int[] murieron = { 1, 1 };
                                        if (!MoverDragon(jugadorActual.Caballero.Color, murieron, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
                                    jugadas.Add(jugadorActual.Nombre + " murió.");
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, 1, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 3:
                                    if (dificultad > 0)
                                    {
                                        jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
                                    jugadas.Add(jugadorActual.Nombre + " retrocedió 5 posiciones hacia la posición: " + movimientoJugador);
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    break;
                                case 4:
                                    if (dificultad > 0)
                                    {
                                        jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                                        if (!MoverDragon(jugadorActual.Caballero.Color, movimientoDragones, formTablero)) MessageBox.Show("No se pudieron mover los dragones");
                                    }
                                    if (!MoverCaballero(jugadorActual.Caballero.Color, movimientoJugador, formTablero)) MessageBox.Show("No se pudo realizar el movimiento");
                                    jugadas.Add(jugadorActual.Nombre + " perdió su turno.");
                                    break;
                                case 5:
                                    
                                    jugadas.Add(jugadorActual.Nombre + " puede jugar en la próxima.");
                                    break;
                            }
                            ActualizarListBox(formTablero.lbEstado);

                            if (hayGanador)
                            {
                                jugadas.Add(jugadorActual.Nombre + " ganó.");

                                sistema.AgregarJugadorRanking();
                                formTablero.btnSalir.Visible = true;
                                MessageBox.Show("¡El jugador ganador es " + ((Jugador)sistema.PartidaActual.Ganador).Nombre.ToString() + ", felicidades!");
                                tirarDados.Dispose();

                            }
                        }

                    }
                }
                else MessageBox.Show("Debe ingresar un nombre.");
            }
            musica.Stop(); 
            CancionInicio();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            jugadas.Clear();
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

                if(dificultad>1)MoverCalabozo(sistema.PartidaActual.Calabozos, formTablero);
                else
                {
                    formTablero.pbCalabozo1.Visible = false;
                    formTablero.pbCalabozo2.Visible = false;
                    formTablero.pbCalabozo3.Visible = false;
                }
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
                                jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                            }

                            jugadas.Add(jugadorActual.Nombre + " se movió a la posición: " + movimientoJugador);

                            break;
                        case 1:
                            if (dificultad > 0)
                            {
                                jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                            }
                            jugadas.Add(jugadorActual.Nombre + " avanzó 5 posiciones hacia la posición: " + movimientoJugador);

                            break;
                        case 2:
                            jugadas.Add(jugadorActual.Nombre + " murió.");
                            break;
                        case 3:
                            if (dificultad > 0)
                            {
                                jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                            }
                            jugadas.Add(jugadorActual.Nombre + " retrocedió 5 posiciones hacia la posición: " + movimientoJugador);

                            break;
                        case 4:
                            if (dificultad > 0)
                            {
                                jugadas.Add("Los dragones de " + jugadorActual.Nombre + " se movieron a las posiciones: " + movimientoDragones[0] + " y " + movimientoDragones[1]);
                            }
                            jugadas.Add(jugadorActual.Nombre + " perdió su turno.");
                            break;
                        case 5:
                            jugadas.Add(jugadorActual.Nombre + " puede jugar en la próxima.");
                            break;

                    }
                    ActualizarListBox(formTablero.lbEstado);
                    if (hayGanador)
                    {
                        formTablero.btnSalir.Visible = true;
                        jugadas.Add(((Jugador)sistema.PartidaActual.Ganador).Nombre + " ganó.");
                        MessageBox.Show("¡El jugador ganador es " + ((Jugador)sistema.PartidaActual.Ganador).Nombre.ToString() + ", felicidades!");
                    }
                }
            }
        }

        private void MoverCalabozo(Pieza[] calabozos, FormTablero tablero)
        {
            int posX, posY;

            for (int i = 0; i < 3; i++)
            {
                if ((calabozos[i].Posicion % 10) == 0) posX = 354 + 9 * 103;
                else posX = 354 + (((calabozos[i].Posicion % 10) - 1) * 103);
                if (calabozos[i].Posicion % 10 == 0) posY = 59 + ((((int)calabozos[i].Posicion / 10) - 1) * 119);
                else posY = 59 + (((int)calabozos[i].Posicion / 10) * 119);
                if (i == 0)
                    tablero.pbCalabozo1.Location = new Point(posX, posY);
                else if (i == 1) tablero.pbCalabozo2.Location = new Point(posX, posY - 10);
                else tablero.pbCalabozo3.Location = new Point(posX, posY - 10);
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
        private void ActualizarListBox(ListBox lbEstado)
        {
            reversa.Clear();
           // jugadas.CopyTo(reversa.ToArray());
            reversa.AddRange(jugadas);
            reversa.Reverse();
            lbEstado.Items.Clear();
            foreach(string frase in reversa)
            {
            lbEstado.Items.Add(frase.ToString());
            }
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            if (sonido) musica.Stop();
            else musica.PlayLooping();
            sonido = !sonido;
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FormRanking modal = new FormRanking();
            sistema.OrdenarRanking();
            foreach(Jugador jugador in sistema.Ranking)
            {
                modal.lbRanking.Items.Add(jugador.Nombre+" // Puntos: "+jugador.Puntaje);
            }
            modal.ShowDialog();
            modal.Dispose();
        }
        
    }
}
/*
 © 2023 Abella, Albornoz y Rutar. Todos los derechos reservados.

Este videojuego, incluyendo su código fuente, gráficos, música, efectos de sonido y cualquier otro material relacionado, está protegido por las leyes de derechos de autor y otras leyes aplicables. Queda estrictamente prohibida la reproducción, distribución, exhibición pública, ingeniería inversa o cualquier otro uso no autorizado de este videojuego, en su totalidad o en parte, sin el permiso expreso por escrito de Abella, Albornoz y Rutar.

Cualquier infracción de nuestros derechos de autor dará lugar a acciones legales y a la búsqueda de daños y perjuicios conforme a la ley.

Para solicitar permisos o para cualquier pregunta relacionada con los derechos de autor de este videojuego, por favor contáctenos en:

Abella Matias, Albornoz Patricio, Rutar Julieta
Dirección: Universidad Tecnológica Nacional. Av. Almafuerte 1033, E3100 Paraná, Entre Ríos
Correo electrónico: matiasabella@alu.frp.utn.edu.ar, patricioalbornoz@alu.frp.utn.edu.ar, julietarutar@alu.frp.utn.edu.ar

Todas las marcas registradas y nombres comerciales mencionados en este videojuego son propiedad de sus respectivos propietarios y se utilizan aquí solo con fines informativos y educativos.

Última actualización: 28/09/2023

 */