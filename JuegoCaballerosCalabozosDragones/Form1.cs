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
            
            FormTablero formTablero = new FormTablero();
            if (formTablero.ShowDialog() == DialogResult.OK)
            {
               
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
