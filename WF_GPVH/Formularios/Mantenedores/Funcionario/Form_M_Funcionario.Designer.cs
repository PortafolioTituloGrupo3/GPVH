namespace WF_GPVH.Formularios.Mantenedores.Funcionario
{
    partial class Form_M_Funcionario
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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.chkVerSoloHabilitados = new System.Windows.Forms.CheckBox();
            this.ddl_unidad = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(227, 168);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(128, 23);
            this.btn_eliminar.TabIndex = 24;
            this.btn_eliminar.Text = "Eliminar seleccionado";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(93, 168);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(128, 23);
            this.btn_editar.TabIndex = 23;
            this.btn_editar.Text = "Editar seleccionado";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Location = new System.Drawing.Point(12, 12);
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.Size = new System.Drawing.Size(649, 150);
            this.dgv_funcionarios.TabIndex = 22;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(12, 168);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // chkVerSoloHabilitados
            // 
            this.chkVerSoloHabilitados.AutoSize = true;
            this.chkVerSoloHabilitados.Checked = true;
            this.chkVerSoloHabilitados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVerSoloHabilitados.Location = new System.Drawing.Point(544, 174);
            this.chkVerSoloHabilitados.Name = "chkVerSoloHabilitados";
            this.chkVerSoloHabilitados.Size = new System.Drawing.Size(117, 17);
            this.chkVerSoloHabilitados.TabIndex = 25;
            this.chkVerSoloHabilitados.Text = "Ver solo habilitados";
            this.chkVerSoloHabilitados.UseVisualStyleBackColor = true;
            this.chkVerSoloHabilitados.CheckedChanged += new System.EventHandler(this.chkVerSoloHabilitados_CheckedChanged);
            // 
            // ddl_unidad
            // 
            this.ddl_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_unidad.FormattingEnabled = true;
            this.ddl_unidad.Location = new System.Drawing.Point(544, 207);
            this.ddl_unidad.Name = "ddl_unidad";
            this.ddl_unidad.Size = new System.Drawing.Size(121, 21);
            this.ddl_unidad.TabIndex = 26;
            this.ddl_unidad.SelectedIndexChanged += new System.EventHandler(this.ddl_unidad_SelectedIndexChanged);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(494, 210);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(44, 13);
            this.lblUnidad.TabIndex = 27;
            this.lblUnidad.Text = "Unidad:";
            // 
            // Form_M_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 276);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.ddl_unidad);
            this.Controls.Add(this.chkVerSoloHabilitados);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_funcionarios);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form_M_Funcionario";
            this.Text = "Form_M_Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView dgv_funcionarios;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.CheckBox chkVerSoloHabilitados;
        private System.Windows.Forms.ComboBox ddl_unidad;
        private System.Windows.Forms.Label lblUnidad;
    }
}