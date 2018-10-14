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
        private GestionadorFuncionario gestionador;
        private List<LB_GPVH.Modelo.Funcionario> funcionarios;
        private List<LB_GPVH.Modelo.Funcionario> funcionariosGridView;

        public Form_SeleccionFuncionarioPermisos()
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
            this.mcmbUnidad.DisplayMember = "Value";
            this.mcmbUnidad.ValueMember = "Key";
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
        }

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
            if(e.ColumnIndex == 0)
            {
                MessageBox.Show("You did it!");
            }
        }
    }
}
