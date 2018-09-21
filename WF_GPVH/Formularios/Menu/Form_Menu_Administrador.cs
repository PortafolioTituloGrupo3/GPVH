using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Clases;

namespace WF_GPVH.Formularios.Menu
{
    public partial class Form_Menu_Administrador : Form
    {
        Login.Form_Login mainForm;
        Sesion sesion;

        public Form_Menu_Administrador(Login.Form_Login pMainForm, Sesion pSesion)
        {
            mainForm = pMainForm;
            sesion = pSesion;
            InitializeComponent();
            lblUsuario.Text = "Usuario: "+sesion.Usuario.Nombre;
        }

        private void btnGestionarFuncionario_Click(object sender, EventArgs e)
        {
            new Mantenedores.Funcionario.Form_M_Funcionario().Show();
        }

        private void btnGestionarUsuario_Click(object sender, EventArgs e)
        {
            new Mantenedores.Usuario.Form_M_Usuario().Show();
        }

        private void btnGestionarUnidad_Click(object sender, EventArgs e)
        {
            new Mantenedores.Unidad.Form_M_Unidad().Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Dispose();
        }

        private void Form_Menu_Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }
    }
}
