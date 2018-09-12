using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    public partial class Form_M_Funcionario_Agregar : Form
    {
        Form_M_Funcionario padreTemp = null;
        public Form_M_Funcionario_Agregar(Form_M_Funcionario formPadre)
        {
            InitializeComponent();
            padreTemp = formPadre;
            this.loadDdlTipos();
            this.loadDdlUnidades();
        }

        private void loadDdlUnidades()
        {
            Dictionary<int, string> salida = new Dictionary<int, string>();
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceUnidades.getListadoUnidadesClaveValor();
                this.ddl_unidad.DisplayMember = "Value";
                this.ddl_unidad.ValueMember = "Key";
                this.ddl_unidad.DataSource = new BindingSource(salida, null);
            }
        }
        private void loadDdlTipos()
        {
            this.ddl_tipo.Items.Add("Administrador");
            this.ddl_tipo.Items.Add("Jefe Unidad Superior");
            this.ddl_tipo.Items.Add("Jefe Unidad Interna");
            this.ddl_tipo.Items.Add("Alcalde");
            this.ddl_tipo.Items.Add("Funcionario");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int run = int.Parse(this.txt_run.Text);
            int dv = int.Parse(this.txt_dv.Text);
            string nombre = this.txt_nombre.Text;
            string ap_pat = this.txt_ap_pat.Text;
            string ap_mat = this.txt_ap_mat.Text;
            DateTime nacimiento = DateTime.Parse(this.cld_nacimiento.Text);
            string correo = this.txt_correo.Text;
            string direccion = this.txt_direccion.Text;
            bool habilitado = this.chk_habilitado.Checked;
            string tipo = this.ddl_tipo.GetItemText(this.ddl_tipo.SelectedItem);
            int unidad = int.Parse(this.ddl_unidad.SelectedValue.ToString());
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                int salida = serviceFuncionarios.addFuncionario(run, dv,nombre, ap_pat, ap_mat, nacimiento,
                                                                    correo, direccion, tipo, unidad);
                if (salida == 0)
                {
                    padreTemp.loadFuncionarios();
                    MessageBox.Show("Datos agregados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
        }
    }
}
