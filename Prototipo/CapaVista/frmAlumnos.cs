using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
            //Usuario
            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "alumnos", "siu");
            navegador1.MetodoSalirVista(this);
            // navegador1.funLlenarComboControl(cbxCodMarca, "marcaP", "idMarca", "nombre", "estatus");

            //inicio de elementos para dar de baja
            navegador1.campoEstado = "Estatus";
            //fin de elementos para dar de baja

            /* Inicio ID Aplicacion usada para reportes y ayudas */
            navegador1.idAplicacion = "1002";
            /* Inicio ID Aplicacion usada para reportes y ayudas */

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda


            // Inicio datos para ejecurar reportes
            navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes

            navegador1.ObtenerNombreDGV(this.dtgFraccionamiento);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);

        }
        private void rbnActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstatus, rbnHabilitado, "1");
        }
        private void rbnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstatus, rbnInhabilitado, "0");
        }
        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.ActivaRadiobtn(rbnHabilitado, rbnInhabilitado, txtEstatus);
        }
    }
}
