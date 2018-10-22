namespace WF_GPVH.Formularios.Resoluciones
{
    partial class Form_BuscarResolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgResoluciones = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rbVerSoloPendientes = new MetroFramework.Controls.MetroRadioButton();
            this.rbVerSoloInvalidados = new MetroFramework.Controls.MetroRadioButton();
            this.rbVerSoloValidados = new MetroFramework.Controls.MetroRadioButton();
            this.rbVerTodos = new MetroFramework.Controls.MetroRadioButton();
            this.txbMes = new MetroFramework.Controls.MetroTextBox();
            this.btnMesInc = new MetroFramework.Controls.MetroButton();
            this.btnMesDec = new MetroFramework.Controls.MetroButton();
            this.btnAnnoDec = new MetroFramework.Controls.MetroButton();
            this.btnAnnoInc = new MetroFramework.Controls.MetroButton();
            this.txbAnno = new MetroFramework.Controls.MetroTextBox();
            this.lblMes = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbUnidad = new MetroFramework.Controls.MetroComboBox();
            this.lblUnidad = new MetroFramework.Controls.MetroLabel();
            this.mtBuscar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgResoluciones)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgResoluciones
            // 
            this.mgResoluciones.AllowUserToResizeRows = false;
            this.mgResoluciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgResoluciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgResoluciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgResoluciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.mgResoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgResoluciones.DefaultCellStyle = dataGridViewCellStyle23;
            this.mgResoluciones.EnableHeadersVisualStyles = false;
            this.mgResoluciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgResoluciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgResoluciones.Location = new System.Drawing.Point(24, 64);
            this.mgResoluciones.Name = "mgResoluciones";
            this.mgResoluciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgResoluciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.mgResoluciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgResoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgResoluciones.Size = new System.Drawing.Size(753, 152);
            this.mgResoluciones.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.rbVerSoloPendientes);
            this.metroPanel1.Controls.Add(this.rbVerSoloInvalidados);
            this.metroPanel1.Controls.Add(this.rbVerSoloValidados);
            this.metroPanel1.Controls.Add(this.rbVerTodos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 268);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 100);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rbVerSoloPendientes
            // 
            this.rbVerSoloPendientes.AutoSize = true;
            this.rbVerSoloPendientes.Checked = true;
            this.rbVerSoloPendientes.Location = new System.Drawing.Point(17, 76);
            this.rbVerSoloPendientes.Name = "rbVerSoloPendientes";
            this.rbVerSoloPendientes.Size = new System.Drawing.Size(126, 15);
            this.rbVerSoloPendientes.TabIndex = 5;
            this.rbVerSoloPendientes.TabStop = true;
            this.rbVerSoloPendientes.Text = "Ver Solo Pendientes";
            this.rbVerSoloPendientes.UseSelectable = true;
            this.rbVerSoloPendientes.CheckedChanged += new System.EventHandler(this.rbVerSoloPendientes_CheckedChanged);
            // 
            // rbVerSoloInvalidados
            // 
            this.rbVerSoloInvalidados.AutoSize = true;
            this.rbVerSoloInvalidados.Location = new System.Drawing.Point(17, 55);
            this.rbVerSoloInvalidados.Name = "rbVerSoloInvalidados";
            this.rbVerSoloInvalidados.Size = new System.Drawing.Size(127, 15);
            this.rbVerSoloInvalidados.TabIndex = 4;
            this.rbVerSoloInvalidados.Text = "Ver Solo Invalidadas";
            this.rbVerSoloInvalidados.UseSelectable = true;
            this.rbVerSoloInvalidados.CheckedChanged += new System.EventHandler(this.rbVerSoloInvalidados_CheckedChanged);
            // 
            // rbVerSoloValidados
            // 
            this.rbVerSoloValidados.AutoSize = true;
            this.rbVerSoloValidados.Location = new System.Drawing.Point(17, 34);
            this.rbVerSoloValidados.Name = "rbVerSoloValidados";
            this.rbVerSoloValidados.Size = new System.Drawing.Size(117, 15);
            this.rbVerSoloValidados.TabIndex = 3;
            this.rbVerSoloValidados.Text = "Ver Solo Validadas";
            this.rbVerSoloValidados.UseSelectable = true;
            this.rbVerSoloValidados.CheckedChanged += new System.EventHandler(this.rbVerSoloValidados_CheckedChanged);
            // 
            // rbVerTodos
            // 
            this.rbVerTodos.AutoSize = true;
            this.rbVerTodos.Location = new System.Drawing.Point(17, 13);
            this.rbVerTodos.Name = "rbVerTodos";
            this.rbVerTodos.Size = new System.Drawing.Size(73, 15);
            this.rbVerTodos.TabIndex = 2;
            this.rbVerTodos.Text = "Ver Todas";
            this.rbVerTodos.UseSelectable = true;
            this.rbVerTodos.CheckedChanged += new System.EventHandler(this.rbVerTodos_CheckedChanged);
            // 
            // txbMes
            // 
            // 
            // 
            // 
            this.txbMes.CustomButton.Image = null;
            this.txbMes.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.txbMes.CustomButton.Name = "";
            this.txbMes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbMes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbMes.CustomButton.TabIndex = 1;
            this.txbMes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbMes.CustomButton.UseSelectable = true;
            this.txbMes.CustomButton.Visible = false;
            this.txbMes.Lines = new string[0];
            this.txbMes.Location = new System.Drawing.Point(716, 251);
            this.txbMes.MaxLength = 2;
            this.txbMes.Name = "txbMes";
            this.txbMes.PasswordChar = '\0';
            this.txbMes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMes.SelectedText = "";
            this.txbMes.SelectionLength = 0;
            this.txbMes.SelectionStart = 0;
            this.txbMes.ShortcutsEnabled = true;
            this.txbMes.Size = new System.Drawing.Size(29, 23);
            this.txbMes.TabIndex = 2;
            this.txbMes.UseSelectable = true;
            this.txbMes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbMes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbMes.TextChanged += new System.EventHandler(this.txbMes_TextChanged);
            // 
            // btnMesInc
            // 
            this.btnMesInc.Location = new System.Drawing.Point(746, 251);
            this.btnMesInc.Name = "btnMesInc";
            this.btnMesInc.Size = new System.Drawing.Size(18, 10);
            this.btnMesInc.TabIndex = 4;
            this.btnMesInc.UseSelectable = true;
            this.btnMesInc.Click += new System.EventHandler(this.btnMesInc_Click);
            // 
            // btnMesDec
            // 
            this.btnMesDec.Location = new System.Drawing.Point(746, 264);
            this.btnMesDec.Name = "btnMesDec";
            this.btnMesDec.Size = new System.Drawing.Size(18, 10);
            this.btnMesDec.TabIndex = 5;
            this.btnMesDec.UseSelectable = true;
            this.btnMesDec.Click += new System.EventHandler(this.btnMesDec_Click);
            // 
            // btnAnnoDec
            // 
            this.btnAnnoDec.Location = new System.Drawing.Point(746, 301);
            this.btnAnnoDec.Name = "btnAnnoDec";
            this.btnAnnoDec.Size = new System.Drawing.Size(18, 10);
            this.btnAnnoDec.TabIndex = 8;
            this.btnAnnoDec.UseSelectable = true;
            this.btnAnnoDec.Click += new System.EventHandler(this.btnAnnoDec_Click);
            // 
            // btnAnnoInc
            // 
            this.btnAnnoInc.Location = new System.Drawing.Point(746, 288);
            this.btnAnnoInc.Name = "btnAnnoInc";
            this.btnAnnoInc.Size = new System.Drawing.Size(18, 10);
            this.btnAnnoInc.TabIndex = 7;
            this.btnAnnoInc.UseSelectable = true;
            this.btnAnnoInc.Click += new System.EventHandler(this.btnAnnoInc_Click);
            // 
            // txbAnno
            // 
            // 
            // 
            // 
            this.txbAnno.CustomButton.Image = null;
            this.txbAnno.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txbAnno.CustomButton.Name = "";
            this.txbAnno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbAnno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbAnno.CustomButton.TabIndex = 1;
            this.txbAnno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbAnno.CustomButton.UseSelectable = true;
            this.txbAnno.CustomButton.Visible = false;
            this.txbAnno.Lines = new string[0];
            this.txbAnno.Location = new System.Drawing.Point(685, 288);
            this.txbAnno.MaxLength = 4;
            this.txbAnno.Name = "txbAnno";
            this.txbAnno.PasswordChar = '\0';
            this.txbAnno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbAnno.SelectedText = "";
            this.txbAnno.SelectionLength = 0;
            this.txbAnno.SelectionStart = 0;
            this.txbAnno.ShortcutsEnabled = true;
            this.txbAnno.Size = new System.Drawing.Size(60, 23);
            this.txbAnno.TabIndex = 6;
            this.txbAnno.UseSelectable = true;
            this.txbAnno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbAnno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbAnno.TextChanged += new System.EventHandler(this.txbAnno_TextChanged);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(674, 255);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(36, 19);
            this.lblMes.TabIndex = 9;
            this.lblMes.Text = "Mes:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(643, 292);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Año:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.ItemHeight = 23;
            this.cmbUnidad.Location = new System.Drawing.Point(85, 374);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(121, 29);
            this.cmbUnidad.TabIndex = 11;
            this.cmbUnidad.UseSelectable = true;
            this.cmbUnidad.SelectedIndexChanged += new System.EventHandler(this.cmbUnidad_SelectedIndexChanged);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(25, 384);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(54, 19);
            this.lblUnidad.TabIndex = 12;
            this.lblUnidad.Text = "Unidad:";
            // 
            // mtBuscar
            // 
            this.mtBuscar.ActiveControl = null;
            this.mtBuscar.Location = new System.Drawing.Point(643, 317);
            this.mtBuscar.Name = "mtBuscar";
            this.mtBuscar.Size = new System.Drawing.Size(134, 54);
            this.mtBuscar.TabIndex = 13;
            this.mtBuscar.Text = "Buscar";
            this.mtBuscar.UseSelectable = true;
            this.mtBuscar.Click += new System.EventHandler(this.mtBuscar_Click);
            // 
            // Form_BuscarResolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtBuscar);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.cmbUnidad);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnAnnoDec);
            this.Controls.Add(this.btnAnnoInc);
            this.Controls.Add(this.txbAnno);
            this.Controls.Add(this.btnMesDec);
            this.Controls.Add(this.btnMesInc);
            this.Controls.Add(this.txbMes);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.mgResoluciones);
            this.Name = "Form_BuscarResolucion";
            this.Text = "Form_BuscarResolucion";
            ((System.ComponentModel.ISupportInitialize)(this.mgResoluciones)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgResoluciones;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txbMes;
        private MetroFramework.Controls.MetroButton btnMesInc;
        private MetroFramework.Controls.MetroButton btnMesDec;
        private MetroFramework.Controls.MetroRadioButton rbVerTodos;
        private MetroFramework.Controls.MetroRadioButton rbVerSoloPendientes;
        private MetroFramework.Controls.MetroRadioButton rbVerSoloInvalidados;
        private MetroFramework.Controls.MetroRadioButton rbVerSoloValidados;
        private MetroFramework.Controls.MetroButton btnAnnoDec;
        private MetroFramework.Controls.MetroButton btnAnnoInc;
        private MetroFramework.Controls.MetroTextBox txbAnno;
        private MetroFramework.Controls.MetroLabel lblMes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbUnidad;
        private MetroFramework.Controls.MetroLabel lblUnidad;
        private MetroFramework.Controls.MetroTile mtBuscar;
    }
}