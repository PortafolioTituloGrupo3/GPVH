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
    public partial class Form_Antecedentes : Form
    {
        private int run_funcionario = -1;
        private Form padre_temp;
        public Form_Antecedentes(int run, Form padre)
        {
            InitializeComponent();
            this.run_funcionario = run;
            padre_temp = padre;
        }

        private void crv_antecedentes_Load(object sender, EventArgs e)
        {
            //Datatable
            DataTable dt_ReportePermisos = new DataTable();
            dt_ReportePermisos.Columns.Add("estado", typeof(string));
            dt_ReportePermisos.Columns.Add("tipo_permiso", typeof(string));
            dt_ReportePermisos.Columns.Add("cantidad", typeof(Int32));

            DataTable dt_ReporteAntecedentes = new DataTable();
            dt_ReporteAntecedentes.Columns.Add("Feriados_anuales_restantes", typeof(Int32));
            dt_ReporteAntecedentes.Columns.Add("Permisos_administrativos_restantes", typeof(Int32));
        
            //Agregar filas desde WS
            using (ServiceWSReportes.WSReportesClient service = new ServiceWSReportes.WSReportesClient())
            {
                ServiceWSReportes.Antecedentes antecedentes = service.ReporteAntecedentes(run_funcionario);
                //antecedentes = (ServiceWSReportes.Antecedentes)antecedentes;
                var filas = antecedentes.Filas;
                dt_ReporteAntecedentes.Rows.Add(antecedentes.Feriados_anuales_restantes,
                                            antecedentes.Permisos_administrativos_restantes);
                foreach (ServiceWSReportes.FilaReporteAntecedentes item in filas)
                {
                    dt_ReportePermisos.Rows.Add(item.Estado, item.Tipo_permiso,
                                                item.Cantidad);
                }
            }

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
    }
}
