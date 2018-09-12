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
    public partial class Form_M_Usuario_Agregar : Form
    {
        Form_M_Usuario padreTemp = null;
        public Form_M_Usuario_Agregar(Form_M_Usuario formPadre)
        {
            InitializeComponent();
            padreTemp = formPadre;
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceFuncionarios.getListadoFuncionariosClaveValor();
                this.ddl_funcionarios.DisplayMember = "Value";
                this.ddl_funcionarios.ValueMember = "Key";
                this.ddl_funcionarios.DataSource = new BindingSource(salida, null);
            }
            this.loadDdlTipos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string clave = this.Clave.Text;
            string tipo = this.ddl_tipo.GetItemText(this.ddl_tipo.SelectedItem);
            int run = int.Parse(this.ddl_funcionarios.SelectedValue.ToString());
            using (ServiceWSUsuarios.WSUsuariosClient serviceUsuarios = new ServiceWSUsuarios.WSUsuariosClient())
            {
                int salida = serviceUsuarios.addUsuario(nombre, clave, tipo, run);
                if (salida == 0)
                {
                    padreTemp.loadUsuarios();
                    MessageBox.Show("Datos agregados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close();
        }
        private void loadDdlTipos()
        {
            this.ddl_tipo.Items.Add("Administrador");
            this.ddl_tipo.Items.Add("Jefe Unidad Superior");
            this.ddl_tipo.Items.Add("Jefe Unidad Interna");
            this.ddl_tipo.Items.Add("Alcalde");
            this.ddl_tipo.Items.Add("Funcionario");
            this.ddl_tipo.SelectedIndex = 0;
        }
    }
}
