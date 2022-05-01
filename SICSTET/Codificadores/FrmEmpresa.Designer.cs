namespace SICSTET.Codificadores
{
    partial class FrmEmpresa
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
            this.dSDatos = new SICSTET.DSDatos();
            this.t_EmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_EmpresaTableAdapter = new SICSTET.DSDatosTableAdapters.T_EmpresaTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.t_EmpresaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EmpresaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_EmpresaBindingSource
            // 
            this.t_EmpresaBindingSource.DataMember = "T_Empresa";
            this.t_EmpresaBindingSource.DataSource = this.dSDatos;
            // 
            // t_EmpresaTableAdapter
            // 
            this.t_EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_CausasDesintTableAdapter = null;
            this.tableAdapterManager.T_CombustibleTableAdapter = null;
            this.tableAdapterManager.T_DestinoLubRecTableAdapter = null;
            this.tableAdapterManager.T_EmpresaTableAdapter = this.t_EmpresaTableAdapter;
            this.tableAdapterManager.T_EquipoTableAdapter = null;
            this.tableAdapterManager.T_EstFisicoTableAdapter = null;
            this.tableAdapterManager.T_GrupoTableAdapter = null;
            this.tableAdapterManager.T_LubricanteTableAdapter = null;
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
            // t_EmpresaGridControl
            // 
            this.t_EmpresaGridControl.DataSource = this.t_EmpresaBindingSource;
            this.t_EmpresaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_EmpresaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_EmpresaGridControl.MainView = this.gridView1;
            this.t_EmpresaGridControl.Name = "t_EmpresaGridControl";
            this.t_EmpresaGridControl.Size = new System.Drawing.Size(585, 422);
            this.t_EmpresaGridControl.TabIndex = 1;
            this.t_EmpresaGridControl.UseEmbeddedNavigator = true;
            this.t_EmpresaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.t_EmpresaGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_EmpresaGridControl_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpresa});
            this.gridView1.GridControl = this.t_EmpresaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridView1_KeyPress);
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 0;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 422);
            this.Controls.Add(this.t_EmpresaGridControl);
            this.Name = "FrmEmpresa";
            this.Text = "Gestinar Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EmpresaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_EmpresaBindingSource;
        private DSDatosTableAdapters.T_EmpresaTableAdapter t_EmpresaTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_EmpresaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
    }
}