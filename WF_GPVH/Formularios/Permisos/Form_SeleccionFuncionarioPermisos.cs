﻿using LB_GPVH.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Permisos
{
    public partial class Form_SeleccionFuncionarioPermisos : MetroFramework.Forms.MetroForm
    {
        private GestionadorFuncionario gestionador; //Clase controlador
        private List<LB_GPVH.Modelo.Funcionario> funcionarios; //Lista completa de permisos desde la base de datos
        private List<LB_GPVH.Modelo.Funcionario> funcionariosGridView; //Lista  de permisos a mostrar en el gridview segun filtros
        Form mainForm; //Formulario principal
        Form formAnterior; //Formulario de donde se accedio
        Sesion sesion;

        public Form_SeleccionFuncionarioPermisos(Form pMainForm, Form pFormAnterior, Sesion pSesion)
        {
            InitializeComponent();
            formAnterior = pFormAnterior;
            mainForm = pMainForm;
            sesion = pSesion;
            gestionador = new GestionadorFuncionario();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            this.loadFuncionarios();
            this.loadDdlUnidades();
        }
        
        public void loadFuncionarios()
        {
            if (sesion.Usuario.Tipo == LB_GPVH.Enums.TipoUsuario.JefeUnidadSuperior)
                funcionarios = gestionador.ListarFuncionariosDeUnidad(sesion.Usuario.Funcionario.Unidad.Id);
            else
                funcionarios = gestionador.ListarFuncionarios();
            CargarFuncionariosGridView(this.funcionarios);
        }
        private void loadDdlUnidades()
        {
            this.mcmbUnidad.DisplayMember = "Value";
            this.mcmbUnidad.ValueMember = "Key";
            if (sesion.Usuario.Tipo == LB_GPVH.Enums.TipoUsuario.JefeUnidadSuperior)
                this.mcmbUnidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadConHijas(sesion.Usuario.Funcionario.Unidad.Id, true), null);
            else
                this.mcmbUnidad.DataSource = new BindingSource(new GestionadorUnidad().DiccionarioUnidadClaveValor(true), null);

            this.mcmbUnidad.SelectedIndex = 0;
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
            column.ReadOnly = true;
            dgv.Columns.Add(column);
            dgv.Refresh();

        }
        public void CargarFuncionariosGridView(List<LB_GPVH.Modelo.Funcionario> funcionarios)
        {
            this.mgFuncionarios.AutoGenerateColumns = false;
            this.mgFuncionarios.AutoSize = true;
            IEnumerable<LB_GPVH.Modelo.Funcionario> funcionariosFiltrados;
            if (mchkVerSoloHabilitados.Checked)
            {
                funcionariosFiltrados = funcionarios.Where(s => s.Habilitado == true);
                mgFuncionarios.Columns[9].Visible = false;
            }
            else
            {
                funcionariosFiltrados = funcionarios;
                mgFuncionarios.Columns[9].Visible = true;
            }
            if (mcmbUnidad.SelectedIndex != 0 && mcmbUnidad.SelectedIndex != -1) // Por defecto un combobox tiene seleccionado al indexo -1
            {
                int idUnidad = (int)mcmbUnidad.SelectedValue;
                funcionariosFiltrados = funcionariosFiltrados.Where(s => s.Unidad.Id == idUnidad);
            }
            funcionariosGridView = funcionariosFiltrados.ToList();
            mgFuncionarios.DataSource = funcionariosGridView;
            mgFuncionarios.Refresh();
        }
        //Funcion que carga las columnas a mostrar del gridview, segun la lista a mostrar
        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(0, nombrePropiedades[0], "RUN", true, "1", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[1], "DV", true, "9", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[2], "Nombre", true, "FUNCIONARIO SIN NOMBRE", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[3], "Apellido Paterno", true, "SIN APELLIDO PATERNO", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[4], "Apellido Materno", true, "SIN APELLIDO MATERNO", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[5], "Fecha Nacimiento", true, "SIN FECHA", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[6], "Correo", true, "SIN CORREO", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[7], "Direccion", true, "SIN DIRECCION", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[8], "Cargo", true, "SIN TIPO", mgFuncionarios);
            this.addColumn(1, nombrePropiedades[9], "Habilitado", true, "1", mgFuncionarios);
            this.addColumn(0, nombrePropiedades[10], "Unidad", true, "SIN UNIDAD", mgFuncionarios);
        }

        #region eventos
        private void mcmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFuncionariosGridView(funcionarios);
        }
        private void mchkVerSoloHabilitados_CheckedChanged(object sender, EventArgs e)
        {
            CargarFuncionariosGridView(funcionarios);
        }
        private void mgFuncionarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                new Form_BuscarPermiso(this, funcionariosGridView[e.RowIndex]).Show();
                this.Visible = false;
            }
        }
        private void mtVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Visible = true;
            this.Dispose();
        }
        private void Form_SeleccionFuncionarioPermisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Dispose();
        }
        #endregion  
    }
}
