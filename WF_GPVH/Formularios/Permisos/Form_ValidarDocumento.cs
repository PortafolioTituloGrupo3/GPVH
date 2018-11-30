using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Controlador;
using LB_GPVH.Modelo;

namespace WF_GPVH.Formularios.Permisos
{
    public partial class Form_ValidarDocumento : MetroFramework.Forms.MetroForm
    {
        GestionadorPermiso gestionador;
        Form main;
        Form anterior;
        Sesion sesion;
        string codigoActual;

        public Form_ValidarDocumento(Form pMain, Form pAnterior, Sesion pSesion)
        {
            InitializeComponent();
            main = pMain;
            anterior = pAnterior;
            sesion = pSesion;
            codigoActual = "";
            gestionador = new GestionadorPermiso();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(!gestionador.ControlarCaracterCodigo(txtCodigo.Text))
            {
                txtCodigo.Text = codigoActual;
            }
            else
            {
                codigoActual = txtCodigo.Text;
            }
        }

        private void mtBuscar_Click(object sender, EventArgs e)
        {
            if (codigoActual.Length > 0)
            {
                Permiso permiso = gestionador.ValidarDocumento(Int32.Parse(codigoActual));
                if(permiso.Id != -1)
                {
                    new Reportes.Form_Ver_Permiso(permiso, main).Show();
                }
                else
                {
                    MessageBox.Show("El codigo ingresado no es valido.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el codigo de verificación.");
            }
        }
    }
}
