using LB_GPVH.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Menu
{
    public partial class Form_Menu_Alcalde : MetroFramework.Forms.MetroForm
    {
        Login.Form_Login mainForm;
        Sesion sesion;

        public Form_Menu_Alcalde(Login.Form_Login pMainForm, Sesion pSesion)
        {
            mainForm = pMainForm;
            sesion = pSesion;
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + sesion.Usuario.Nombre;
            lblFuncionario.Text = "Funcionario: " + sesion.Usuario.Funcionario.NombreCompleto;
        }

        private void mtBuscarPermisos_Click(object sender, EventArgs e)
        {
            new Permisos.Form_SeleccionFuncionarioPermisos(mainForm, this, sesion).Show();
            this.Visible = false;
        }

        private void mtBuscarResoluciones_Click(object sender, EventArgs e)
        {
            new Resoluciones.Form_BuscarResolucion(mainForm, this, sesion).Show();
            this.Visible = false;
        }

        private void mtGenerarReporte_Click(object sender, EventArgs e)
        {
            new Reportes.Form_Reporte_Permisos().Show();
        }

        private void mtAntecedentes_Click(object sender, EventArgs e)
        {
            new Reportes.Antecedences.Form_Listado_Funcionarios().Show();
        }

        private void mtSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Dispose();
        }

        private void Form_Menu_Alcalde_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }
    }
}
