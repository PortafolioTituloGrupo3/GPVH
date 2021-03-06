﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB_GPVH.Controlador;

namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    public partial class Form_Listado_Funcionarios : MetroFramework.Forms.MetroForm
    {
        private GestionadorFuncionario gestionador; //Clase controlador
        private List<LB_GPVH.Modelo.Funcionario> funcionarios; //Lista completa de funcionarios desde la base de datos
        private List<LB_GPVH.Modelo.Funcionario> funcionariosGridView; //Lista de funcionarios que se mostraran en el gridview segun filtros

        public Form_Listado_Funcionarios()
        {
            InitializeComponent();
            gestionador = new GestionadorFuncionario();
            CargarHeadersGridView(gestionador.ListarNombresParametros());
            this.loadFuncionarios();
        }

        public void loadFuncionarios()
        {
            funcionarios = gestionador.ListarFuncionarios();
            CargarFuncionariosGridView(this.funcionarios);
        }
        public void CargarFuncionariosGridView(List<LB_GPVH.Modelo.Funcionario> funcionarios)
        {
            this.dgv_funcionarios.AutoGenerateColumns = false;
            this.dgv_funcionarios.AutoSize = true;
            IEnumerable<LB_GPVH.Modelo.Funcionario> funcionariosFiltrados;
            //ACTUALMENTE SE MUESTRAN TODOS
            funcionariosFiltrados = funcionarios;
            dgv_funcionarios.Columns[9].Visible = true;

            funcionariosGridView = funcionariosFiltrados.ToList();
            dgv_funcionarios.DataSource = funcionariosGridView;
        }
        //Funcion que carga las columnas a mostrar del gridview, segun la lista a mostrar
        public void CargarHeadersGridView(List<String> nombrePropiedades)
        {
            //Se agreagan las columnas de forma personalisada
            this.addColumn(3, "revisar", "revisar", true, "Ver antecedentes", dgv_funcionarios);
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
                case 3: //Si es 2 sera una columna de ComboBox
                    column = new DataGridViewLinkColumn();
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

        private void dgv_funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celda = dgv_funcionarios.CurrentCell;
            int indice_columna = e.RowIndex;
            int run = -1;
            if (celda.ColumnIndex.Equals(0) && indice_columna != -1)
            {
                run = int.Parse(this.dgv_funcionarios.Rows[indice_columna].Cells[1].Value.ToString());
                Form_Antecedentes form_antecedentes = new Form_Antecedentes(run, this);
                form_antecedentes.Show();
                this.Enabled = false;
            }
        }
    }
}
