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
        List<PictureBox> listaCaballeros;
        public List<PictureBox> ListaCaballeros { get { return listaCaballeros; } }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Dispose();
        } 
        private void FormTablero_Load(object sender, EventArgs e)
        {
            listaCaballeros=new List<PictureBox>();
            ArmarListaCaballeros();
        }
        private void ArmarListaCaballeros()
        {
            listaCaballeros.Add(pbCaballeroRojo);
            listaCaballeros.Add( pbCaballeroAzul);
            listaCaballeros.Add( pbCaballeroAmarillo);
            listaCaballeros.Add(pbCaballeroVerde);
        }

       
    }
}
