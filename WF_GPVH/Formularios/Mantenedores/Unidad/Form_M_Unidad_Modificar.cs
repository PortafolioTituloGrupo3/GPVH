using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Mantenedores.Unidad
{
    public partial class Form_M_Unidad_Modificar : Form
    {
        Form_M_Unidad padreTemp = null;
        private int id_unidad= -1;
        public Form_M_Unidad_Modificar(Form_M_Unidad formPadre, int id)
        {
            InitializeComponent();
            padreTemp = formPadre;
            id_unidad = id;
            WS_GPVH.WebServices.Unidades.Unidad unidadTemp;
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                unidadTemp = serviceUnidades.getUnidadById(id_unidad);
                this.txt_nombre.Text = unidadTemp.Nombre_unidad;
                this.txt_descripcion.Text = unidadTemp.Descripcion_unidad;
                this.txt_direccion.Text = unidadTemp.Direccion_unidad;
                if (unidadTemp.Habilitado == 1)
                    this.chk_habilitado.Checked = true;
                else
                    this.chk_habilitado.Checked = false;
                
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceUnidades.getListadoUnidadesNoHijasClaveValor(id);
                this.ddl_padre.DisplayMember = "Value";
                this.ddl_padre.ValueMember = "Key";
                this.ddl_padre.DataSource = new BindingSource(salida, null);
                if(unidadTemp.Unidad_id_unidad!=null)
                    this.ddl_padre.SelectedValue = unidadTemp.Unidad_id_unidad;
            }
            using(ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de funcionarios en ComboBox
                salida = serviceFuncionarios.getListadoFuncionariosNoJefesNoClaveValorModificar(this.id_unidad);
                this.ddl_jefe.DisplayMember = "Value";
                this.ddl_jefe.ValueMember = "Key";
                this.ddl_jefe.DataSource = new BindingSource(salida, null);
                if (unidadTemp.Funcionario_run_sin_dv  != null)
                    this.ddl_padre.SelectedValue = unidadTemp.Funcionario_run_sin_dv;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            padreTemp.Enabled = true;
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string descripcion = this.txt_descripcion.Text;
            string direccion = this.txt_direccion.Text;
            bool habilitado = this.chk_habilitado.Checked;
            int salida_temp = -1;
            int? padre;
            if (this.ddl_padre.SelectedValue == null)
                padre = null;
            else
                padre = int.Parse(this.ddl_padre.SelectedValue.ToString());
            salida_temp = -1;
            int? jefe;
            if (this.ddl_jefe.SelectedValue == null)
                jefe = null;
            else
                jefe = int.Parse(this.ddl_jefe.SelectedValue.ToString());
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                int salida = serviceUnidades.modifyUnidad(this.id_unidad, nombre, descripcion,
                                            direccion, habilitado, padre, jefe);
                if (salida == 0)
                {
                    padreTemp.loadUnidades();
                    MessageBox.Show("Datos modificados con exito!");
                }
                else
                    MessageBox.Show("ERROR NRO: " + salida);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ddl_jefe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddl_padre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chk_habilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
