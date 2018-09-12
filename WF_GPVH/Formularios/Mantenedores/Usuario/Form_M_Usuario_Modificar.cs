using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    public partial class Form_M_Usuario_Modificar : Form
    {
        Form_M_Usuario padreTemp = null;
        private ServiceWSUsuarios.Usuario usuario;
        public Form_M_Usuario_Modificar(Form_M_Usuario formPadre, int id_usuario)
        {
            InitializeComponent();
            padreTemp = formPadre;
            using(ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                usuario = serviceUsuarios.getUsuarioById(id_usuario);

                this.loadDdlTipos(usuario.Tipo_usuario);
            }
            this.txt_nombre.Text = usuario.Nombre_usuario;
            this.txt_clave.Text = usuario.Clave;
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceFuncionarios.getListadoFuncionariosClaveValor();
                this.ddl_funcionarios.DisplayMember = "Value";
                this.ddl_funcionarios.ValueMember = "Key";
                this.ddl_funcionarios.DataSource = new BindingSource(salida, null);
                this.ddl_funcionarios.SelectedValue = usuario.Funcionario_run_sin_dv;
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string clave = this.Clave.Text;
            string tipo = this.ddl_tipo.GetItemText(this.ddl_tipo.SelectedItem);
            int run = int.Parse(this.ddl_funcionarios.SelectedValue.ToString());
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                int salida = serviceUsuarios.modifyUsuario(usuario.Id_usuario, nombre, clave, tipo, run);
                if (salida == 0)
                {
                    padreTemp.loadUsuarios();
                    MessageBox.Show("Datos modificados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
        }
        private void loadDdlTipos(string tipo)
        {
            this.ddl_tipo.Items.Add("Administrador");
            this.ddl_tipo.Items.Add("Jefe Unidad Superior");
            this.ddl_tipo.Items.Add("Jefe Unidad Interna");
            this.ddl_tipo.Items.Add("Alcalde");
            this.ddl_tipo.Items.Add("Funcionario");
            string tipoQueCoincide = "";
            foreach (string item in this.ddl_tipo.Items)
            {
                if (item == tipo)
                {
                    tipoQueCoincide = tipo;
                }
            }
            if (tipoQueCoincide == "")
            {
                this.ddl_tipo.Items.Add(tipo);
                this.ddl_tipo.SelectedIndex = this.ddl_tipo.Items.Count-1;
            }
            else
                this.ddl_tipo.SelectedItem = tipoQueCoincide;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close(); 
        }
    }
}
