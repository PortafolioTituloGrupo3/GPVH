namespace WF_GPVH.Formularios.Reportes
{
    partial class Form_Reporte_Permisos
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
            this.crv_ReportePermisos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cld_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cld_fechaTermino = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_ReportePermisos
            // 
            this.crv_ReportePermisos.ActiveViewIndex = -1;
            this.crv_ReportePermisos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crv_ReportePermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_ReportePermisos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_ReportePermisos.Location = new System.Drawing.Point(-1, 30);
            this.crv_ReportePermisos.Name = "crv_ReportePermisos";
            this.crv_ReportePermisos.Size = new System.Drawing.Size(653, 347);
            this.crv_ReportePermisos.TabIndex = 0;
            this.crv_ReportePermisos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_ReportePermisos.Load += new System.EventHandler(this.crv_ReportePermisos_Load);
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(538, 2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(102, 23);
            this.btn_generar.TabIndex = 1;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cld_fechaInicio
            // 
            this.cld_fechaInicio.Location = new System.Drawing.Point(56, 4);
            this.cld_fechaInicio.Name = "cld_fechaInicio";
            this.cld_fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.cld_fechaInicio.TabIndex = 2;
            // 
            // cld_fechaTermino
            // 
            this.cld_fechaTermino.Location = new System.Drawing.Point(332, 4);
            this.cld_fechaTermino.Name = "cld_fechaTermino";
            this.cld_fechaTermino.Size = new System.Drawing.Size(200, 20);
            this.cld_fechaTermino.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta";
            // 
            // Form_Reporte_Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cld_fechaTermino);
            this.Controls.Add(this.cld_fechaInicio);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.crv_ReportePermisos);
            this.Name = "Form_Reporte_Permisos";
            this.Text = "Form_Reporte_Permisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_ReportePermisos;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DateTimePicker cld_fechaInicio;
        private System.Windows.Forms.DateTimePicker cld_fechaTermino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}