using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Modelo;
using LB_GPVH.Enums;
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Login
{
    public partial class Form_Login : MetroFramework.Forms.MetroForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void IniciarSesion()
        {
            string clave = txbClave.Text;
            string nombre = txbNombre.Text;
            txbClave.Text = "";
            Sesion sesion = new Sesion();
            //Se verifica la autenticidad de los datos ingresados
            if (sesion.AutenticarUsuario(nombre, clave))
            {
                txbNombre.Text = "";
                switch (sesion.TipoUsuario)
                {
                    case TipoUsuario.Administrador:
                        new Menu.Form_Menu_Administrador(this, sesion).Show();
                        this.Hide();
                        break;
                    case TipoUsuario.JefeUnidadSuperior:
                        new Menu.Form_Menu_Jefe_Unidad_Superior(this, sesion).Show();
                        this.Hide();
                        break;
                    case TipoUsuario.Alcalde:
                        new Menu.Form_Menu_Alcalde(this, sesion).Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Acceso denegado. Debes ser un Administrador, Jefe de unidad superior o Alcalde para ingresar.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("El nombre y clave de usuario no son validos.");
            }
        }

        #region eventos
        private void mtIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
        private void txbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13) // 13 es ENTER en numeracion ANCII
            {
                e.Handled = true;
                IniciarSesion();
            }
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.ActiveControl = txbNombre;
            txbNombre.Select();
        }
        #endregion 
    }
}
