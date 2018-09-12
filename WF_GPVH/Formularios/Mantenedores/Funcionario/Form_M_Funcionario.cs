using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_GPVH.Formularios.Mantenedores.Funcionario;

namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    public partial class Form_M_Funcionario : Form
    {
        public Form_M_Funcionario()
        {
            InitializeComponent();
            this.loadFuncionarios();
        }

        public void loadFuncionarios()
        {
            this.dgv_funcionarios.DataSource = null;
            //Diccionario que contendra el <codigoProducto, nombreProducto>
            using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionarios= new ServiceWSFuncionarios.WSFuncionariosClient())
            {
                var listadoFuncionarios = serviceFuncionarios.getListadoFuncionarios();
                //Inicialisar DGV
                this.dgv_funcionarios.AutoGenerateColumns = false;
                this.dgv_funcionarios.AutoSize = true;
                this.dgv_funcionarios.DataSource = listadoFuncionarios;
                if (dgv_funcionarios.ColumnCount <= 0)
                {
                    //Se agreagan las columnas de forma personalisada
                    this.addColumn(0, "run_sin_dv", "RUN", true, "1", dgv_funcionarios);
                    this.addColumn(0, "run_dv", "DV", true, "9", dgv_funcionarios);
                    this.addColumn(0, "nom_funcionario", "Nombre", true, "FUNCIONARIO SIN NOMBRE", dgv_funcionarios);
                    this.addColumn(0, "ap_paterno", "Apellido Paterno", true, "SIN APELLIDO PATERNO", dgv_funcionarios);
                    this.addColumn(0, "ap_materno", "Apellido Materno", true, "SIN APELLIDO MATERNO", dgv_funcionarios);
                    this.addColumn(0, "fec_nacimiento", "Fecha Nacimiento", true, "SIN FECHA", dgv_funcionarios);
                    this.addColumn(0, "correo", "Correo", true, "SIN CORREO", dgv_funcionarios);
                    this.addColumn(0, "direc_funcionario", "Direccion", true, "SIN DIRECCION", dgv_funcionarios);
                    this.addColumn(0, "tipo_funcionario", "Tipo funcionario", true, "SIN TIPO", dgv_funcionarios);
                    this.addColumn(1, "habilitado", "Habilitado", true, "1", dgv_funcionarios);
                    this.addColumn(0, "unidad_id_unidad", "Unidad", true, "SIN UNIDAD", dgv_funcionarios);
                }
            }
        }
        //Funcion que agregara columnas con los parametros ingresados
        private void addColumn(int tipoColumna, string property, string titulo, bool visible,
                                            string valorPorDefecto, DataGridView dgv)
        {
            DataGridViewColumn column;
            switch (tipoColumna)
            {
                case 0: //Si es 0 sera una columna de TextBox
                    column = new DataGridViewTextBoxColumn();
                    break;
                case 1: //Si es 1 sera una columna de CheckBox
                    column = new DataGridViewCheckBoxColumn();
                    break;
                case 2: //Si es 2 sera una columna de ComboBox
                    column = new DataGridViewComboBoxColumn();
                    break;
                default: //En cualquier otro caso, sera una columna generica
                    column = new DataGridViewColumn();
                    break;
            }
            column.DataPropertyName = property;
            column.Name = titulo;
            column.Visible = visible;
            column.DefaultCellStyle.NullValue = valorPorDefecto;
            dgv.Columns.Add(column);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Form_M_Funcionario_Agregar popUpAgregar = new Form_M_Funcionario_Agregar(this);
            popUpAgregar.Show();
            this.Enabled = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (this.dgv_funcionarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                int id_usuario_actual = int.Parse(this.dgv_funcionarios.CurrentRow.Cells[0].Value.ToString());
                Form_M_Funcionario_Modificar popUpEditar = new Form_M_Funcionario_Modificar(this, id_usuario_actual);
                popUpEditar.Show();
                this.Enabled = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_funcionarios.CurrentRow == null)
                MessageBox.Show("Primero debes seleccionar una fila!");
            else
            {
                int id_usuario_actual = int.Parse(this.dgv_funcionarios.CurrentRow.Cells[0].Value.ToString());
                using (ServiceWSFuncionarios.WSFuncionariosClient serviceFuncionario = new ServiceWSFuncionarios.WSFuncionariosClient())
                {
                    int salida = serviceFuncionario.deleteFuncionario(id_usuario_actual);
                    if (salida == 0)
                    {
                        this.loadFuncionarios();
                        MessageBox.Show("Datos eliminados con exito!");
                    }
                    else
                        MessageBox.Show("ERROR NRO: " + salida);
                }
            }
        }
    }
}
