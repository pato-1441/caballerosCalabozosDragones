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
            dragones = new List<PictureBox>();
            AgregarDragones();
        }
        List<PictureBox> dragones;
        public List<PictureBox> Dragones { get { return dragones; } }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Dispose();
        } 
        private void FormTablero_Load(object sender, EventArgs e)
        {
            
        }
        private void AgregarDragones()
        {
            dragones.Add(pbDragonRojo1);
            dragones.Add(pbDragonRojo2);
            dragones.Add(pbDragonAzul1);
            dragones.Add(pbDragonAzul2);
            dragones.Add(pbDragonAmarillo1);
            dragones.Add(pbDragonAmarillo2);
            dragones.Add(pbDragonVerde1);
            dragones.Add(pbDragonVerde2);
        }

       
    }
}
