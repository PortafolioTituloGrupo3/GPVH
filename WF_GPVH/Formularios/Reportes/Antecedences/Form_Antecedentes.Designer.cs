namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    partial class Form_Antecedentes
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
            this.crv_antecedentes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_PermNoResuelto = new MetroFramework.Controls.MetroTile();
            this.btn_PermRechazados = new MetroFramework.Controls.MetroTile();
            this.btn_PermAprobados = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // crv_antecedentes
            // 
            this.crv_antecedentes.ActiveViewIndex = -1;
            this.crv_antecedentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crv_antecedentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_antecedentes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_antecedentes.Location = new System.Drawing.Point(0, 65);
            this.crv_antecedentes.Name = "crv_antecedentes";
            this.crv_antecedentes.Size = new System.Drawing.Size(856, 329);
            this.crv_antecedentes.TabIndex = 0;
            this.crv_antecedentes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_antecedentes.Load += new System.EventHandler(this.crv_antecedentes_Load);
            // 
            // btn_PermNoResuelto
            // 
            this.btn_PermNoResuelto.ActiveControl = null;
            this.btn_PermNoResuelto.Location = new System.Drawing.Point(418, 12);
            this.btn_PermNoResuelto.Name = "btn_PermNoResuelto";
            this.btn_PermNoResuelto.Size = new System.Drawing.Size(173, 38);
            this.btn_PermNoResuelto.TabIndex = 1;
            this.btn_PermNoResuelto.Text = "Ver permisos no resueltos";
            this.btn_PermNoResuelto.UseSelectable = true;
            this.btn_PermNoResuelto.Click += new System.EventHandler(this.btn_PermNoResuelto_Click);
            // 
            // btn_PermRechazados
            // 
            this.btn_PermRechazados.ActiveControl = null;
            this.btn_PermRechazados.Location = new System.Drawing.Point(597, 12);
            this.btn_PermRechazados.Name = "btn_PermRechazados";
            this.btn_PermRechazados.Size = new System.Drawing.Size(165, 39);
            this.btn_PermRechazados.TabIndex = 2;
            this.btn_PermRechazados.Text = "Ver permisos rechazados";
            this.btn_PermRechazados.UseSelectable = true;
            this.btn_PermRechazados.Click += new System.EventHandler(this.btn_PermRechazados_Click);
            // 
            // btn_PermAprobados
            // 
            this.btn_PermAprobados.ActiveControl = null;
            this.btn_PermAprobados.Location = new System.Drawing.Point(248, 12);
            this.btn_PermAprobados.Name = "btn_PermAprobados";
            this.btn_PermAprobados.Size = new System.Drawing.Size(164, 38);
            this.btn_PermAprobados.TabIndex = 3;
            this.btn_PermAprobados.Text = "Ver permisos aprobados";
            this.btn_PermAprobados.UseSelectable = true;
            this.btn_PermAprobados.Click += new System.EventHandler(this.btn_PermAprobados_Click);
            // 
            // Form_Antecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 394);
            this.Controls.Add(this.btn_PermAprobados);
            this.Controls.Add(this.btn_PermRechazados);
            this.Controls.Add(this.btn_PermNoResuelto);
            this.Controls.Add(this.crv_antecedentes);
            this.Name = "Form_Antecedentes";
            this.Text = "Form_Antecedentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Antecedentes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_antecedentes;
        private MetroFramework.Controls.MetroTile btn_PermNoResuelto;
        private MetroFramework.Controls.MetroTile btn_PermRechazados;
        private MetroFramework.Controls.MetroTile btn_PermAprobados;
    }
}