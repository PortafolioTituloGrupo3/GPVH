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
    public partial class Form_M_Funcionario_Modificar : Form
    {
        Form_M_Funcionario padreTemp = null;
        private int run_funcionario = -1;
        public Form_M_Funcionario_Modificar(Form_M_Funcionario formPadre, int run)
        {
            InitializeComponent();
            padreTemp = formPadre;
            run_funcionario = run;
            ServiceWSFuncionarios.Funcionario funcionarioTemp;
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                funcionarioTemp = serviceFuncionarios.getFuncionarioByRun(run_funcionario);
                this.txt_run.Text = funcionarioTemp.Run_sin_dv.ToString();
                this.txt_nombre.Text = funcionarioTemp.Nom_funcionario;
                this.txt_ap_pat.Text = funcionarioTemp.Ap_paterno;
                this.txt_ap_mat.Text = funcionarioTemp.Ap_materno;
                this.cld_nacimiento.Value = funcionarioTemp.Fec_nacimiento;
                this.txt_correo.Text = funcionarioTemp.Correo;
                this.txt_direccion.Text = funcionarioTemp.Direc_funcionario;
                this.ddl_tipo.Text = funcionarioTemp.Tipo_funcionario;

                if (funcionarioTemp.Habilitado == 1)
                    this.chk_habilitado.Checked = true;
                else
                    this.chk_habilitado.Checked = false;
            }
            this.loadDdlUnidades(funcionarioTemp.Unidad_id_unidad);
            this.loadDdlTipos(funcionarioTemp.Tipo_funcionario);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int run = int.Parse(this.txt_run.Text);
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
                int salida = serviceFuncionarios.modifyFuncionario(run, nombre, ap_pat, ap_mat, nacimiento,
                                                                    correo, direccion, tipo, habilitado, unidad);
                if (salida == 0)
                {
                    padreTemp.loadFuncionarios();
                    MessageBox.Show("Datos modificados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
        }
        private void loadDdlUnidades(int id_unidad)
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
                this.ddl_unidad.SelectedValue = id_unidad;
            }
        }
        private void loadDdlTipos(string tipo)
        {
            this.ddl_tipo.Items.Add("Administrador");
            this.ddl_tipo.Items.Add("Jefe Unidad Superior");
            this.ddl_tipo.Items.Add("Jefe Unidad Interna");
            this.ddl_tipo.Items.Add("Alcalde");
            this.ddl_tipo.Items.Add("Funcionario");
            foreach(string item in this.ddl_tipo.Items)
            {
                if(item == tipo)
                {
                    this.ddl_tipo.SelectedText = tipo;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close();
        }
    }
}
