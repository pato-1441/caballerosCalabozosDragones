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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            prbrCarga.Maximum = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmProgBar_Tick(object sender, EventArgs e)
        {
            if(prbrCarga.Value<prbrCarga.Maximum)
            prbrCarga.Value += 250;
        }
    }
}
