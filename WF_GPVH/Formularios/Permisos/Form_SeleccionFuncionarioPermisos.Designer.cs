namespace WF_GPVH.Formularios.Permisos
{
    partial class Form_SeleccionFuncionarioPermisos
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
            this.mchkVerSoloHabilitados = new MetroFramework.Controls.MetroCheckBox();
            this.mcmbUnidad = new MetroFramework.Controls.MetroComboBox();
            this.mlblUnidad = new MetroFramework.Controls.MetroLabel();
            this.mgFuncionarios = new MetroFramework.Controls.MetroGrid();
            this.verPermisos = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // mchkVerSoloHabilitados
            // 
            this.mchkVerSoloHabilitados.AutoSize = true;
            this.mchkVerSoloHabilitados.Checked = true;
            this.mchkVerSoloHabilitados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkVerSoloHabilitados.Location = new System.Drawing.Point(555, 251);
            this.mchkVerSoloHabilitados.Name = "mchkVerSoloHabilitados";
            this.mchkVerSoloHabilitados.Size = new System.Drawing.Size(125, 15);
            this.mchkVerSoloHabilitados.TabIndex = 38;
            this.mchkVerSoloHabilitados.Text = "Ver solo habilitados";
            this.mchkVerSoloHabilitados.UseSelectable = true;
            this.mchkVerSoloHabilitados.CheckedChanged += new System.EventHandler(this.mchkVerSoloHabilitados_CheckedChanged);
            // 
            // mcmbUnidad
            // 
            this.mcmbUnidad.FormattingEnabled = true;
            this.mcmbUnidad.ItemHeight = 23;
            this.mcmbUnidad.Location = new System.Drawing.Point(555, 282);
            this.mcmbUnidad.Name = "mcmbUnidad";
            this.mcmbUnidad.Size = new System.Drawing.Size(117, 29);
            this.mcmbUnidad.TabIndex = 37;
            this.mcmbUnidad.UseSelectable = true;
            this.mcmbUnidad.SelectedIndexChanged += new System.EventHandler(this.mcmbUnidad_SelectedIndexChanged);
            // 
            // mlblUnidad
            // 
            this.mlblUnidad.AutoSize = true;
            this.mlblUnidad.Location = new System.Drawing.Point(495, 282);
            this.mlblUnidad.Name = "mlblUnidad";
            this.mlblUnidad.Size = new System.Drawing.Size(54, 19);
            this.mlblUnidad.TabIndex = 36;
            this.mlblUnidad.Text = "Unidad:";
            // 
            // mgFuncionarios
            // 
            this.mgFuncionarios.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.mgFuncionarios.AllowUserToAddRows = false;
            this.mgFuncionarios.AllowUserToDeleteRows = false;
            this.mgFuncionarios.AllowUserToResizeColumns = false;
            this.mgFuncionarios.AllowUserToResizeRows = false;
            this.mgFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verPermisos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgFuncionarios.EnableHeadersVisualStyles = false;
            this.mgFuncionarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgFuncionarios.Location = new System.Drawing.Point(23, 63);
            this.mgFuncionarios.MaximumSize = new System.Drawing.Size(650, 164);
            this.mgFuncionarios.MultiSelect = false;
            this.mgFuncionarios.Name = "mgFuncionarios";
            this.mgFuncionarios.ReadOnly = true;
            this.mgFuncionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgFuncionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgFuncionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgFuncionarios.Size = new System.Drawing.Size(649, 164);
            this.mgFuncionarios.TabIndex = 35;
            this.mgFuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mgFuncionarios_CellMouseClick);
            // 
            // verPermisos
            // 
            this.verPermisos.Frozen = true;
            this.verPermisos.HeaderText = "Ver Permisos";
            this.verPermisos.Name = "verPermisos";
            this.verPermisos.ReadOnly = true;
            this.verPermisos.Text = "Ver";
            this.verPermisos.ToolTipText = "Ver el permiso del funcionario.";
            this.verPermisos.UseColumnTextForButtonValue = true;
            // 
            // Form_SeleccionFuncionarioPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mchkVerSoloHabilitados);
            this.Controls.Add(this.mcmbUnidad);
            this.Controls.Add(this.mlblUnidad);
            this.Controls.Add(this.mgFuncionarios);
            this.Name = "Form_SeleccionFuncionarioPermisos";
            this.Text = "Form_SeleccionFuncionarioPermiso";
            ((System.ComponentModel.ISupportInitialize)(this.mgFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox mchkVerSoloHabilitados;
        private MetroFramework.Controls.MetroComboBox mcmbUnidad;
        private MetroFramework.Controls.MetroLabel mlblUnidad;
        private MetroFramework.Controls.MetroGrid mgFuncionarios;
        private System.Windows.Forms.DataGridViewButtonColumn verPermisos;
    }
}