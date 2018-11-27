namespace WF_GPVH.Formularios.Permisos
{
    partial class Form_ListarDocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgDocumentos = new MetroFramework.Controls.MetroGrid();
            this.btnVerArchivo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // mgDocumentos
            // 
            this.mgDocumentos.AllowUserToResizeRows = false;
            this.mgDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnVerArchivo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDocumentos.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgDocumentos.EnableHeadersVisualStyles = false;
            this.mgDocumentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDocumentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDocumentos.Location = new System.Drawing.Point(23, 63);
            this.mgDocumentos.Name = "mgDocumentos";
            this.mgDocumentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDocumentos.Size = new System.Drawing.Size(753, 231);
            this.mgDocumentos.TabIndex = 1;
            this.mgDocumentos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mgDocumentos_CellMouseClick);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.Frozen = true;
            this.btnVerArchivo.HeaderText = "Ver Archivo";
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Text = "Ver";
            this.btnVerArchivo.ToolTipText = "Ver";
            this.btnVerArchivo.UseColumnTextForButtonValue = true;
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtVolver.Location = new System.Drawing.Point(690, 330);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(147, 42);
            this.mtVolver.TabIndex = 20;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            this.mtVolver.Click += new System.EventHandler(this.mtVolver_Click);
            // 
            // Form_ListarDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 395);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mgDocumentos);
            this.Name = "Form_ListarDocumentos";
            this.Text = "Form_ListarDocumentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ListarDocumentos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mgDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgDocumentos;
        private System.Windows.Forms.DataGridViewButtonColumn btnVerArchivo;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}