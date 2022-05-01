namespace SICSTET.Codificadores
{
    partial class FrmEquipoPorLubricante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fecha_CambioLabel;
            this.dSDatos = new SICSTET.DSDatos();
            this.t_LubricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_LubricanteTableAdapter = new SICSTET.DSDatosTableAdapters.T_LubricanteTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.fecha_CambioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            fecha_CambioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_LubricanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_CambioDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_CambioDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_CambioLabel
            // 
            fecha_CambioLabel.AutoSize = true;
            fecha_CambioLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            fecha_CambioLabel.Location = new System.Drawing.Point(74, 36);
            fecha_CambioLabel.Name = "fecha_CambioLabel";
            fecha_CambioLabel.Size = new System.Drawing.Size(88, 13);
            fecha_CambioLabel.TabIndex = 1;
            fecha_CambioLabel.Text = "Fecha Cambio:";
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_LubricanteBindingSource
            // 
            this.t_LubricanteBindingSource.DataMember = "T_Lubricante";
            this.t_LubricanteBindingSource.DataSource = this.dSDatos;
            // 
            // t_LubricanteTableAdapter
            // 
            this.t_LubricanteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_CausasDesintTableAdapter = null;
            this.tableAdapterManager.T_CombustibleTableAdapter = null;
            this.tableAdapterManager.T_DestinoLubRecTableAdapter = null;
            this.tableAdapterManager.T_EmpresaTableAdapter = null;
            this.tableAdapterManager.T_EquipoTableAdapter = null;
            this.tableAdapterManager.T_EstFisicoTableAdapter = null;
            this.tableAdapterManager.T_GrupoTableAdapter = null;
            this.tableAdapterManager.T_LubricanteTableAdapter = this.t_LubricanteTableAdapter;
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MotivoCambioTableAdapter = null;
            this.tableAdapterManager.T_Neumatico_BateriaTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_RolTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoTableAdapter = null;
            this.tableAdapterManager.T_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fecha_CambioDateEdit
            // 
            this.fecha_CambioDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_LubricanteBindingSource, "Fecha_Cambio", true));
            this.fecha_CambioDateEdit.EditValue = null;
            this.fecha_CambioDateEdit.Location = new System.Drawing.Point(165, 31);
            this.fecha_CambioDateEdit.Name = "fecha_CambioDateEdit";
            this.fecha_CambioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha_CambioDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fecha_CambioDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fecha_CambioDateEdit.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmEquipoPorLubricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(fecha_CambioLabel);
            this.Controls.Add(this.fecha_CambioDateEdit);
            this.Name = "FrmEquipoPorLubricante";
            this.Text = "Precisar Fecha";
            this.Load += new System.EventHandler(this.FrmEquipoPorLubricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_LubricanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_CambioDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_CambioDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_LubricanteBindingSource;
        private DSDatosTableAdapters.T_LubricanteTableAdapter t_LubricanteTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public DevExpress.XtraEditors.DateEdit fecha_CambioDateEdit;
    }
}