using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;

namespace CapaVista
{
    public partial class frmMDIColegio : Form
    {
        public frmMDIColegio()
        {
            InitializeComponent();
        }

        private void facultadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultades form3 = new frmFacultades();
            form3.MdiParent = this;
            form3.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras form3 = new frmCarreras();
            form3.MdiParent = this;
            form3.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos form3 = new frmCursos();
            form3.MdiParent = this;
            form3.Show();
        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJornadas form3 = new frmJornadas();
            form3.MdiParent = this;
            form3.Show();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos form3 = new frmAlumnos();
            form3.MdiParent = this;
            form3.Show();
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecciones form3 = new frmSecciones();
            form3.MdiParent = this;
            form3.Show();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSedes form3 = new frmSedes();
            form3.MdiParent = this;
            form3.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos form3 = new frmAlumnos();
            form3.MdiParent = this;
            form3.Show();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaestros form3 = new frmMaestros();
            form3.MdiParent = this;
            form3.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
    }
}
