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
            FormNombreJugador modal = new FormNombreJugador();
            FormTablero formTablero = new FormTablero();
            if(modal.ShowDialog() == DialogResult.OK)
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

                sistema.CrearPartida(Convert.ToInt32(modal.nudCantJugadores.Value),
                                    dificultad, modal.tbNombre.Text, color);
                if(formTablero.ShowDialog() == DialogResult.OK)
                {
                    while(sistema.PartidaActual.Ganador == null)
                    {

                    }
                    MessageBox.Show("sexo");
                }
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            if (rbBasico.Checked)
            {
                sistema.CrearPartida(4,0);
            }
            else if (rbIntermedio.Checked)
            {
                sistema.CrearPartida(4, 1);
            }
            else if (rbExperto.Checked)
            {
                sistema.CrearPartida(4, 2);
            } else
            {
                MessageBox.Show("Seleccione una dificultad para continuar por favor!");
            }
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            FormRanking modal = new FormRanking();
            sistema.OrdenarRanking();
            foreach(Jugador jugador in sistema.Ranking)
            {
                modal.lbRanking.Items.Add(jugador);
            }
            modal.Show();
        }
    }
}
