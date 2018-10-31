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

namespace WF_GPVH.Formularios.Menu
{
    public partial class Form_Menu_Administrador : MetroFramework.Forms.MetroForm
    {
        Login.Form_Login mainForm;
        Sesion sesion;

        public Form_Menu_Administrador(Login.Form_Login pMainForm, Sesion pSesion)
        {
            mainForm = pMainForm;
            sesion = pSesion;
            InitializeComponent();
            lblUsuario.Text = "Usuario: "+sesion.Usuario.Nombre;
            lblFuncionario.Text = "Funcionario: " + sesion.Usuario.Funcionario.NombreCompleto;
        }
        
        private void Form_Menu_Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }

        private void mtGestionarFuncionarios_Click(object sender, EventArgs e)
        {
            new Mantenedores.Funcionario.Form_M_Funcionario().Show();
        }

        private void mtGestionarUsuarios_Click(object sender, EventArgs e)
        {
            new Mantenedores.Usuario.Form_M_Usuario().Show();
        }

        private void mtGestionarUnidades_Click(object sender, EventArgs e)
        {
            new Mantenedores.Unidad.Form_M_Unidad().Show();
        }

        private void mtSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Dispose();
        }

        private void mtBuscarPermisos_Click(object sender, EventArgs e)
        {
            new Permisos.Form_SeleccionFuncionarioPermisos().Show();
        }

        private void mtGenerarReporte_Click(object sender, EventArgs e)
        {
            new Reportes.Form_Reporte_Permisos().Show();
        }

        private void mtAntecedentes_Click(object sender, EventArgs e)
        {
            new Reportes.Antecedences.Form_Listado_Funcionarios().Show();
        }
    }
}
