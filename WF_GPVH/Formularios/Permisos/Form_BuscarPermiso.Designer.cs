namespace WF_GPVH.Formularios.Permisos
{
    partial class Form_BuscarPermiso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgPermisos = new MetroFramework.Controls.MetroGrid();
            this.btnVerDocumentos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbVerTodos = new MetroFramework.Controls.MetroRadioButton();
            this.mpGupoRB = new MetroFramework.Controls.MetroPanel();
            this.rbVerSoloPendientes = new MetroFramework.Controls.MetroRadioButton();
            this.rbVerSoloRechazados = new MetroFramework.Controls.MetroRadioButton();
            this.rbVerSoloAutorizados = new MetroFramework.Controls.MetroRadioButton();
            this.mpBusquedaEntreFechas = new MetroFramework.Controls.MetroPanel();
            this.lblTermino = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mdtFechaTermino = new MetroFramework.Controls.MetroDateTime();
            this.mdtFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.chkBuscarEntreFechas = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgPermisos)).BeginInit();
            this.mpGupoRB.SuspendLayout();
            this.mpBusquedaEntreFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgPermisos
            // 
            this.mgPermisos.AllowUserToResizeRows = false;
            this.mgPermisos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnVerDocumentos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgPermisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgPermisos.EnableHeadersVisualStyles = false;
            this.mgPermisos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgPermisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgPermisos.Location = new System.Drawing.Point(24, 79);
            this.mgPermisos.MaximumSize = new System.Drawing.Size(650, 164);
            this.mgPermisos.Name = "mgPermisos";
            this.mgPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgPermisos.Size = new System.Drawing.Size(650, 159);
            this.mgPermisos.TabIndex = 0;
            this.mgPermisos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mgPermisos_CellMouseClick);
            // 
            // btnVerDocumentos
            // 
            this.btnVerDocumentos.Frozen = true;
            this.btnVerDocumentos.HeaderText = "Ver documentos";
            this.btnVerDocumentos.Name = "btnVerDocumentos";
            this.btnVerDocumentos.Text = "Ver";
            this.btnVerDocumentos.ToolTipText = "Ver";
            this.btnVerDocumentos.UseColumnTextForButtonValue = true;
            // 
            // rbVerTodos
            // 
            this.rbVerTodos.AutoSize = true;
            this.rbVerTodos.Checked = true;
            this.rbVerTodos.Location = new System.Drawing.Point(17, 3);
            this.rbVerTodos.Name = "rbVerTodos";
            this.rbVerTodos.Size = new System.Drawing.Size(74, 15);
            this.rbVerTodos.TabIndex = 1;
            this.rbVerTodos.TabStop = true;
            this.rbVerTodos.Text = "Ver Todos";
            this.rbVerTodos.UseSelectable = true;
            this.rbVerTodos.CheckedChanged += new System.EventHandler(this.rbVerTodos_CheckedChanged);
            // 
            // mpGupoRB
            // 
            this.mpGupoRB.Controls.Add(this.rbVerSoloPendientes);
            this.mpGupoRB.Controls.Add(this.rbVerSoloRechazados);
            this.mpGupoRB.Controls.Add(this.rbVerSoloAutorizados);
            this.mpGupoRB.Controls.Add(this.rbVerTodos);
            this.mpGupoRB.HorizontalScrollbarBarColor = true;
            this.mpGupoRB.HorizontalScrollbarHighlightOnWheel = false;
            this.mpGupoRB.HorizontalScrollbarSize = 10;
            this.mpGupoRB.Location = new System.Drawing.Point(41, 287);
            this.mpGupoRB.Name = "mpGupoRB";
            this.mpGupoRB.Size = new System.Drawing.Size(173, 86);
            this.mpGupoRB.TabIndex = 2;
            this.mpGupoRB.VerticalScrollbarBarColor = true;
            this.mpGupoRB.VerticalScrollbarHighlightOnWheel = false;
            this.mpGupoRB.VerticalScrollbarSize = 10;
            // 
            // rbVerSoloPendientes
            // 
            this.rbVerSoloPendientes.AutoSize = true;
            this.rbVerSoloPendientes.Location = new System.Drawing.Point(17, 65);
            this.rbVerSoloPendientes.Name = "rbVerSoloPendientes";
            this.rbVerSoloPendientes.Size = new System.Drawing.Size(126, 15);
            this.rbVerSoloPendientes.TabIndex = 4;
            this.rbVerSoloPendientes.Text = "Ver Solo Pendientes";
            this.rbVerSoloPendientes.UseSelectable = true;
            this.rbVerSoloPendientes.CheckedChanged += new System.EventHandler(this.rbVerSoloPendientes_CheckedChanged);
            // 
            // rbVerSoloRechazados
            // 
            this.rbVerSoloRechazados.AutoSize = true;
            this.rbVerSoloRechazados.Location = new System.Drawing.Point(17, 45);
            this.rbVerSoloRechazados.Name = "rbVerSoloRechazados";
            this.rbVerSoloRechazados.Size = new System.Drawing.Size(130, 15);
            this.rbVerSoloRechazados.TabIndex = 3;
            this.rbVerSoloRechazados.Text = "Ver Solo Rechazados";
            this.rbVerSoloRechazados.UseSelectable = true;
            this.rbVerSoloRechazados.CheckedChanged += new System.EventHandler(this.rbVerSoloRechazados_CheckedChanged);
            // 
            // rbVerSoloAutorizados
            // 
            this.rbVerSoloAutorizados.AutoSize = true;
            this.rbVerSoloAutorizados.Location = new System.Drawing.Point(17, 24);
            this.rbVerSoloAutorizados.Name = "rbVerSoloAutorizados";
            this.rbVerSoloAutorizados.Size = new System.Drawing.Size(131, 15);
            this.rbVerSoloAutorizados.TabIndex = 2;
            this.rbVerSoloAutorizados.Text = "Ver Solo Autorizados";
            this.rbVerSoloAutorizados.UseSelectable = true;
            this.rbVerSoloAutorizados.CheckedChanged += new System.EventHandler(this.rbVerSoloAutorizados_CheckedChanged);
            // 
            // mpBusquedaEntreFechas
            // 
            this.mpBusquedaEntreFechas.Controls.Add(this.lblTermino);
            this.mpBusquedaEntreFechas.Controls.Add(this.metroLabel1);
            this.mpBusquedaEntreFechas.Controls.Add(this.mdtFechaTermino);
            this.mpBusquedaEntreFechas.Controls.Add(this.mdtFechaInicio);
            this.mpBusquedaEntreFechas.HorizontalScrollbarBarColor = true;
            this.mpBusquedaEntreFechas.HorizontalScrollbarHighlightOnWheel = false;
            this.mpBusquedaEntreFechas.HorizontalScrollbarSize = 10;
            this.mpBusquedaEntreFechas.Location = new System.Drawing.Point(439, 287);
            this.mpBusquedaEntreFechas.Name = "mpBusquedaEntreFechas";
            this.mpBusquedaEntreFechas.Size = new System.Drawing.Size(357, 86);
            this.mpBusquedaEntreFechas.TabIndex = 3;
            this.mpBusquedaEntreFechas.VerticalScrollbarBarColor = true;
            this.mpBusquedaEntreFechas.VerticalScrollbarHighlightOnWheel = false;
            this.mpBusquedaEntreFechas.VerticalScrollbarSize = 10;
            this.mpBusquedaEntreFechas.Visible = false;
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Location = new System.Drawing.Point(11, 55);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(56, 19);
            this.lblTermino.TabIndex = 5;
            this.lblTermino.Text = "Termino";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Inicio:";
            // 
            // mdtFechaTermino
            // 
            this.mdtFechaTermino.Location = new System.Drawing.Point(73, 51);
            this.mdtFechaTermino.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFechaTermino.Name = "mdtFechaTermino";
            this.mdtFechaTermino.Size = new System.Drawing.Size(265, 29);
            this.mdtFechaTermino.TabIndex = 3;
            this.mdtFechaTermino.ValueChanged += new System.EventHandler(this.mdtFechaTermino_ValueChanged);
            // 
            // mdtFechaInicio
            // 
            this.mdtFechaInicio.Location = new System.Drawing.Point(73, 10);
            this.mdtFechaInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFechaInicio.Name = "mdtFechaInicio";
            this.mdtFechaInicio.Size = new System.Drawing.Size(265, 29);
            this.mdtFechaInicio.TabIndex = 2;
            this.mdtFechaInicio.ValueChanged += new System.EventHandler(this.mdtFechaInicio_ValueChanged);
            // 
            // chkBuscarEntreFechas
            // 
            this.chkBuscarEntreFechas.AutoSize = true;
            this.chkBuscarEntreFechas.Location = new System.Drawing.Point(306, 287);
            this.chkBuscarEntreFechas.Name = "chkBuscarEntreFechas";
            this.chkBuscarEntreFechas.Size = new System.Drawing.Size(127, 15);
            this.chkBuscarEntreFechas.TabIndex = 4;
            this.chkBuscarEntreFechas.Text = "Buscar Entre Fechas";
            this.chkBuscarEntreFechas.UseSelectable = true;
            this.chkBuscarEntreFechas.CheckedChanged += new System.EventHandler(this.chkBuscarEntreFechas_CheckedChanged);
            // 
            // Form_BuscarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBuscarEntreFechas);
            this.Controls.Add(this.mpBusquedaEntreFechas);
            this.Controls.Add(this.mpGupoRB);
            this.Controls.Add(this.mgPermisos);
            this.Name = "Form_BuscarPermiso";
            this.Text = "Form_BuscarPermiso";
            ((System.ComponentModel.ISupportInitialize)(this.mgPermisos)).EndInit();
            this.mpGupoRB.ResumeLayout(false);
            this.mpGupoRB.PerformLayout();
            this.mpBusquedaEntreFechas.ResumeLayout(false);
            this.mpBusquedaEntreFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgPermisos;
        private MetroFramework.Controls.MetroRadioButton rbVerTodos;
        private MetroFramework.Controls.MetroPanel mpGupoRB;
        private MetroFramework.Controls.MetroRadioButton rbVerSoloRechazados;
        private MetroFramework.Controls.MetroRadioButton rbVerSoloAutorizados;
        private MetroFramework.Controls.MetroPanel mpBusquedaEntreFechas;
        private MetroFramework.Controls.MetroLabel lblTermino;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime mdtFechaTermino;
        private MetroFramework.Controls.MetroDateTime mdtFechaInicio;
        private MetroFramework.Controls.MetroCheckBox chkBuscarEntreFechas;
        private MetroFramework.Controls.MetroRadioButton rbVerSoloPendientes;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerDocumentos;
    }
}