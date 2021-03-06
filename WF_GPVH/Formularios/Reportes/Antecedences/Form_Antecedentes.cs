﻿using LB_GPVH.Controlador;
using LB_GPVH.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    public partial class Form_Antecedentes : MetroFramework.Forms.MetroForm
    {
        private GestionadorPermiso gestionadorPermiso = new GestionadorPermiso(); //Clase controlador
        private int run_funcionario = -1; //Run del funcionario seleccionado
        private Form padre_temp; //Formulario de donde se accedio

        public Form_Antecedentes(int run, Form padre)
        {
            InitializeComponent();
            this.run_funcionario = run;
            padre_temp = padre;
        }

        #region eventos
        private void crv_antecedentes_Load(object sender, EventArgs e)
        {
            //Datatable para carga de reporte
            DataTable dt_ReportePermisos = new DataTable();
            dt_ReportePermisos.Columns.Add("estado", typeof(string));
            dt_ReportePermisos.Columns.Add("tipo_permiso", typeof(string));
            dt_ReportePermisos.Columns.Add("cantidad", typeof(Int32));
            dt_ReportePermisos.Columns.Add("periodo", typeof(Int32));
            //Datatable para carga de reporte
            DataTable dt_ReporteAntecedentes = new DataTable();
            dt_ReporteAntecedentes.Columns.Add("Feriados_anuales_restantes", typeof(Int32));
            dt_ReporteAntecedentes.Columns.Add("Permisos_administrativos_restantes", typeof(Int32));
            Antecedentes antecedentes = gestionadorPermiso.ReporteAntecedentes(this.run_funcionario);
            dt_ReporteAntecedentes.Rows.Add(antecedentes.Feriados_anuales_restantes,
                                            antecedentes.Permisos_administrativos_restantes);
            //Se cargan las filas para el reporte
            foreach (List<object> item in antecedentes.Filas)
            {
                dt_ReportePermisos.Rows.Add(((LB_GPVH.Enums.EstadoPermiso)item.ElementAt(0)).ToString(),   //estado
                                            item.ElementAt(1).ToString(),   //Tipo_permiso
                                            item.ElementAt(2).ToString(),   //Cantidad
                                            item.ElementAt(3).ToString());  //Periodo
            }
            //Se crea un reporte de Crystal report y se cargan los datos
            CR_antecedentes reporte = new CR_antecedentes();
            reporte.Database.Tables["WF_GPVH_ServiceWSReportes_FilaReporteAntecedentes"].SetDataSource(dt_ReportePermisos);
            reporte.Database.Tables["WF_GPVH_ServiceWSReportes_Antecedentes"].SetDataSource(dt_ReporteAntecedentes);
            crv_antecedentes.ReportSource = null;
            crv_antecedentes.ReportSource = reporte;
        }
        private void Form_Antecedentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre_temp.Enabled = true;
        }
        private void btn_PermAprobados_Click(object sender, EventArgs e)
        {
            Form_Listado_Permisos_Filtrado form_listado = new Form_Listado_Permisos_Filtrado(run_funcionario, 1, this);
            form_listado.Show();
            this.Enabled = false;
        }
        private void btn_PermNoResuelto_Click(object sender, EventArgs e)
        {
            Form_Listado_Permisos_Filtrado form_listado = new Form_Listado_Permisos_Filtrado(run_funcionario, 0, this);
            form_listado.Show();
            this.Enabled = false;
        }
        private void btn_PermRechazados_Click(object sender, EventArgs e)
        {
            Form_Listado_Permisos_Filtrado form_listado = new Form_Listado_Permisos_Filtrado(run_funcionario, 2, this);
            form_listado.Show();
            this.Enabled = false;
        }
        #endregion
    }
}
