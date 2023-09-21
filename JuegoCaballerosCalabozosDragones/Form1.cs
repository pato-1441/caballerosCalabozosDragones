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
            if(modal.ShowDialog() == DialogResult.OK)
            {
                if (modal.rbRojo.Checked)
                {
                    if (rbBasico.Checked)
                    {
                        sistema.CrearPartida(4, 0, modal.tbNombre.Text, 1);
                    }
                    else if (rbIntermedio.Checked)
                    {
                        sistema.CrearPartida(4, 1, modal.tbNombre.Text, 1);
                    }
                    else if (rbExperto.Checked)
                    {
                        sistema.CrearPartida(4, 2, modal.tbNombre.Text, 1);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una dificultad para continuar por favor!");
                    }
                } else if (modal.rbAzul.Checked)
                {
                    if (rbBasico.Checked)
                    {
                        sistema.CrearPartida(4, 0, modal.tbNombre.Text, 2);
                    }
                    else if (rbIntermedio.Checked)
                    {
                        sistema.CrearPartida(4, 1, modal.tbNombre.Text, 2);
                    }
                    else if (rbExperto.Checked)
                    {
                        sistema.CrearPartida(4, 2, modal.tbNombre.Text, 2);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una dificultad para continuar por favor!");
                    }
                } else if (modal.rbVerde.Checked)
                {
                    if (rbBasico.Checked)
                    {
                        sistema.CrearPartida(4, 0, modal.tbNombre.Text, 3);
                    }
                    else if (rbIntermedio.Checked)
                    {
                        sistema.CrearPartida(4, 1, modal.tbNombre.Text, 3);
                    }
                    else if (rbExperto.Checked)
                    {
                        sistema.CrearPartida(4, 2, modal.tbNombre.Text, 3);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una dificultad para continuar por favor!");
                    }
                }
                else if (modal.rbAmarillo.Checked)
                {
                    if (rbBasico.Checked)
                    {
                        sistema.CrearPartida(4, 0, modal.tbNombre.Text, 4);
                    }
                    else if (rbIntermedio.Checked)
                    {
                        sistema.CrearPartida(4, 1, modal.tbNombre.Text, 4);
                    }
                    else if (rbExperto.Checked)
                    {
                        sistema.CrearPartida(4, 2, modal.tbNombre.Text, 4);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una dificultad para continuar por favor!");
                    }
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
