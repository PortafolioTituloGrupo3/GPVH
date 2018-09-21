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
    public partial class Form_M_Unidad_Agregar : Form
    {
        Form_M_Unidad padreTemp = null;
        public Form_M_Unidad_Agregar(Form_M_Unidad formPadre)
        {
            InitializeComponent();
            padreTemp = formPadre;
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de unidades en ComboBox
                salida = serviceUnidades.getListadoUnidadesClaveValor();
                this.ddl_padre.DisplayMember = "Value";
                this.ddl_padre.ValueMember = "Key";
                this.ddl_padre.DataSource = new BindingSource(salida, null);
            }
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios = new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                Dictionary<int, string> salida = new Dictionary<int, string>();
                //Cargar datos de funcionarios en ComboBox
                salida = serviceFuncionarios.getListadoFuncionariosNoJefesClaveValor();
                this.ddl_jefe.DisplayMember = "Value";
                this.ddl_jefe.ValueMember = "Key";
                this.ddl_jefe.DataSource = new BindingSource(salida, null);
            }

        }



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txt_nombre.Text;
            string descripcion = this.txt_descripcion.Text;
            string direccion = this.txt_direccion.Text;
            int? padre;
            if (this.ddl_padre.SelectedValue == null)
                padre = null;
            else
                padre = int.Parse(this.ddl_padre.SelectedValue.ToString());
            int? jefe;
            if (this.ddl_jefe.SelectedValue == null)
                jefe = null;
            else
                jefe = int.Parse(this.ddl_jefe.SelectedValue.ToString());
            using (ServiceWSUnidades.WSUnidadesClient serviceUnidades = new ServiceWSUnidades.WSUnidadesClient())
            {
                int salida = serviceUnidades.addUnidad(nombre, descripcion, direccion, padre, jefe);
                if (salida == 0)
                {
                    padreTemp.loadUnidades();
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
    }
}
