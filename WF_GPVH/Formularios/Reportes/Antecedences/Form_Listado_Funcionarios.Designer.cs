namespace WF_GPVH.Formularios.Reportes.Antecedences
{
    partial class Form_Listado_Funcionarios
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
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Location = new System.Drawing.Point(12, 39);
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.Size = new System.Drawing.Size(649, 210);
            this.dgv_funcionarios.TabIndex = 23;
            this.dgv_funcionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funcionarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seleccione un funcionario";
            // 
            // Form_Listado_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_funcionarios);
            this.Name = "Form_Listado_Funcionarios";
            this.Text = "Form_Listado_Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_funcionarios;
        private System.Windows.Forms.Label label1;
    }
}