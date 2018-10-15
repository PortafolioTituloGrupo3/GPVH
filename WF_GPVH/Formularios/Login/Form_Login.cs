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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            /** ESTO GUATEO, DEBE SER UN PROBLEMA DEL GITHUB POR QUE EL WSUSUARIOS NO TIENE LOS METODOS
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                ServiceWSUsuarios.Usuario wsUsuario = serviceUsuarios.AutenticarUsuario(txbNombre.Text, txbClave.Text);
                txbClave.Text = "";
                if (wsUsuario != null)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = wsUsuario.Id_usuario;
                    usuario.Nombre = wsUsuario.Nombre_usuario;
                    usuario.RunFuncionario = (int)wsUsuario.Funcionario_run_sin_dv;
                    usuario.Tipo = MetodosTipoUsuario.setTipo(wsUsuario.Tipo_usuario);
                    Sesion sesion = new Sesion();


                    sesion.Usuario = usuario;

                    txbNombre.Text = "";

                    switch (usuario.Tipo)
                    {
                        case TipoUsuario.Administrador:
                            new Menu.Form_Menu_Administrador(this,sesion).Show();
                            this.Hide();
                            break;
                        case TipoUsuario.JefeUnidadSuperior:
                            new Menu.Form_Menu_Jefe_Unidad_Superior(this, sesion).Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {

                    MessageBox.Show("El nombre y clave de usuario no son validos.");
                }


            }**/
        }
    }
}
