namespace WF_GPVH.Formularios.Reportes
{
    partial class Form_Ver_Permiso
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
            this.crv_permiso = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_permiso
            // 
            this.crv_permiso.ActiveViewIndex = -1;
            this.crv_permiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crv_permiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_permiso.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_permiso.Location = new System.Drawing.Point(3, 61);
            this.crv_permiso.Name = "crv_permiso";
            this.crv_permiso.Size = new System.Drawing.Size(791, 366);
            this.crv_permiso.TabIndex = 1;
            this.crv_permiso.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_Ver_Permiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_permiso);
            this.Name = "Form_Ver_Permiso";
            this.Text = "Form_Ver_Permiso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ver_Permiso_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_permiso;
    }
}