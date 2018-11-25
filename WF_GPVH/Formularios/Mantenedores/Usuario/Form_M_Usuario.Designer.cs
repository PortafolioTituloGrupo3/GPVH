namespace WF_GPVH.Formularios.Mantenedores.Usuario
{
    partial class Form_M_Usuario
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
            this.dgv_Usuarios = new MetroFramework.Controls.MetroGrid();
            this.mtAgregar = new MetroFramework.Controls.MetroTile();
            this.mtEditar = new MetroFramework.Controls.MetroTile();
            this.mtEliminar = new MetroFramework.Controls.MetroTile();
            this.mtVolver = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToResizeRows = false;
            this.dgv_Usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Usuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Usuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgv_Usuarios.EnableHeadersVisualStyles = false;
            this.dgv_Usuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_Usuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Usuarios.Location = new System.Drawing.Point(14, 63);
            this.dgv_Usuarios.MaximumSize = new System.Drawing.Size(650, 164);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(477, 150);
            this.dgv_Usuarios.TabIndex = 22;
            // 
            // mtAgregar
            // 
            this.mtAgregar.ActiveControl = null;
            this.mtAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtAgregar.Location = new System.Drawing.Point(14, 284);
            this.mtAgregar.Name = "mtAgregar";
            this.mtAgregar.Size = new System.Drawing.Size(122, 40);
            this.mtAgregar.TabIndex = 25;
            this.mtAgregar.Text = "Agregar";
            this.mtAgregar.UseSelectable = true;
            this.mtAgregar.Click += new System.EventHandler(this.mtAgregar_Click);
            // 
            // mtEditar
            // 
            this.mtEditar.ActiveControl = null;
            this.mtEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtEditar.Location = new System.Drawing.Point(142, 284);
            this.mtEditar.Name = "mtEditar";
            this.mtEditar.Size = new System.Drawing.Size(122, 40);
            this.mtEditar.TabIndex = 26;
            this.mtEditar.Text = "Editar";
            this.mtEditar.UseSelectable = true;
            this.mtEditar.Click += new System.EventHandler(this.mtEditar_Click);
            // 
            // mtEliminar
            // 
            this.mtEliminar.ActiveControl = null;
            this.mtEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtEliminar.Location = new System.Drawing.Point(270, 284);
            this.mtEliminar.Name = "mtEliminar";
            this.mtEliminar.Size = new System.Drawing.Size(122, 40);
            this.mtEliminar.TabIndex = 27;
            this.mtEliminar.Text = "Eliminar";
            this.mtEliminar.UseSelectable = true;
            this.mtEliminar.Click += new System.EventHandler(this.mtEliminar_Click);
            // 
            // mtVolver
            // 
            this.mtVolver.ActiveControl = null;
            this.mtVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtVolver.Location = new System.Drawing.Point(437, 285);
            this.mtVolver.Name = "mtVolver";
            this.mtVolver.Size = new System.Drawing.Size(122, 39);
            this.mtVolver.TabIndex = 37;
            this.mtVolver.Text = "Volver";
            this.mtVolver.UseSelectable = true;
            // 
            // Form_M_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 347);
            this.Controls.Add(this.mtVolver);
            this.Controls.Add(this.mtEliminar);
            this.Controls.Add(this.mtEditar);
            this.Controls.Add(this.mtAgregar);
            this.Controls.Add(this.dgv_Usuarios);
            this.Name = "Form_M_Usuario";
            this.Text = "Form_M_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgv_Usuarios;
        private MetroFramework.Controls.MetroTile mtAgregar;
        private MetroFramework.Controls.MetroTile mtEditar;
        private MetroFramework.Controls.MetroTile mtEliminar;
        private MetroFramework.Controls.MetroTile mtVolver;
    }
}