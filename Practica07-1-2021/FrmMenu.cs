using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Practica07_1_2021
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciamos al formulario
            FrmTest frm = new FrmTest ();
            frm.MdiParent = this; //definir formulario padre
            frm.Show(); // mostrar formulario
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocumento fmr = new frmDocumento();

            fmr.MdiParent = this;
            fmr.Show();
        }
    }
}
