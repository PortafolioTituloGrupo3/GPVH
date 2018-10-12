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
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    public partial class Form_M_Funcionario : Form
    {
        private GestionadorFuncionario gestionador;
        private List<LB_GPVH.Modelo.Funcionario> funcionarios;
        private List<LB_GPVH.Modelo.Funcionario> funcionariosGridView;

        public Form_M_Funcionario()
        {
            InitializeComponent();
            gestionador = new GestionadorFuncionario();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            this.loadFuncionarios();
            this.loadDdlUnidades();
        }

        public void loadFuncionarios()
        {
            funcionarios = gestionador.ListarFuncionarios();
            CargarFuncionariosGridView(this.funcionarios);
        }

        private void loadDdlUnidades()
        {
            this.ddl_unidad.DisplayMember = "Value";
            this.ddl_unidad.ValueMember = "Key";
            this.ddl_unidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadClaveValor(true), null);
            this.ddl_unidad.SelectedIndex = 0;
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
                Form_M_Funcionario_Modificar popUpEditar = new Form_M_Funcionario_Modificar(this, funcionariosGridView[dgv_funcionarios.CurrentRow.Index].Run);
                popUpEditar.Show();
                this.Enabled = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (this.dgv_funcionarios.CurrentRow == null)
                MessageBox.Show("Primero debe seleccionar una fila!");
            else
            {
                switch (gestionador.EliminarFuncionario(funcionariosGridView[this.dgv_funcionarios.CurrentRow.Index].Run)) // Se entrega el run del funcionario seleccionado al gestionador para que este proceda a eliminar tal funcionario.
                {
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Valido:
                        MessageBox.Show("Funcionario eliminado con exito!");
                        loadFuncionarios();
                        break;
                    case GestionadorFuncionario.ResultadoGestionFuncionario.Invalido:
                        MessageBox.Show("Ocurrio un error no controlado durante la eliminacion.");
                        break;
                }
            }
        }



        public void CargarFuncionariosGridView(List<LB_GPVH.Modelo.Funcionario> funcionarios)
        {
            this.dgv_funcionarios.AutoGenerateColumns = false;
            this.dgv_funcionarios.AutoSize = true;
            IEnumerable<LB_GPVH.Modelo.Funcionario> funcionariosFiltrados;
            if (chkVerSoloHabilitados.Checked)
            {
                funcionariosFiltrados = funcionarios.Where(s => s.Habilitado == true);
                dgv_funcionarios.Columns[9].Visible = false;
            }
            else
            {
                funcionariosFiltrados = funcionarios;
                dgv_funcionarios.Columns[9].Visible = true;
            }
            if(ddl_unidad.SelectedIndex != 0 && ddl_unidad.SelectedIndex != -1) // Por defecto un combobox tiene seleccionado al indexo -1
            {
                int idUnidad = (int)ddl_unidad.SelectedValue;
                funcionariosFiltrados = funcionariosFiltrados.Where(s => s.Unidad.Id == idUnidad);
            }
            funcionariosGridView = funcionariosFiltrados.ToList();
            dgv_funcionarios.DataSource = funcionariosGridView;
        }

        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "RUN", true, "1", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[1], "DV", true, "9", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[2], "Nombre", true, "FUNCIONARIO SIN NOMBRE", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[3], "Apellido Paterno", true, "SIN APELLIDO PATERNO", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[4], "Apellido Materno", true, "SIN APELLIDO MATERNO", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[5], "Fecha Nacimiento", true, "SIN FECHA", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[6], "Correo", true, "SIN CORREO", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[7], "Direccion", true, "SIN DIRECCION", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[8], "Cargo", true, "SIN TIPO", dgv_funcionarios);
            this.addColumn(1, nombrePropiedades[9], "Habilitado", true, "1", dgv_funcionarios);
            this.addColumn(0, nombrePropiedades[10], "Unidad", true, "SIN UNIDAD", dgv_funcionarios);
        }

        private void chkVerSoloHabilitados_CheckedChanged(object sender, EventArgs e)
        {
            CargarFuncionariosGridView(funcionarios);
        }

        private void ddl_unidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFuncionariosGridView(funcionarios);
        }
    }
}
