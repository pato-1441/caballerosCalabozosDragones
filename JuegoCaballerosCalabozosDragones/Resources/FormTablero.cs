using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCaballerosCalabozosDragones.Resources
{
    public partial class FormTablero : Form
    {
        public FormTablero()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnTirarDado_Click(object sender, EventArgs e)
        {
            
        }

        private void FormTablero_Load(object sender, EventArgs e)
        {
            FormNombreJugador modal = new FormNombreJugador();
            if (modal.ShowDialog() == DialogResult.OK)
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

                Form1.sistema.CrearPartida(Convert.ToInt32(modal.nudCantJugadores.Value),
                                    dificultad, modal.tbNombre.Text, color);



            }
        }
    }
}
