namespace SICSTET.Codificadores
{
    partial class FrmCausasDesint
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
            this.t_CausasDesintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_CausasDesintTableAdapter = new SICSTET.DSDatosTableAdapters.T_CausasDesintTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.t_CausasDesintGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCausasDesint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidartefacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoArtefactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameartefacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_TipoArtefactoTableAdapter = new SICSTET.DSDatosTableAdapters.T_TipoArtefactoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_CausasDesintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_CausasDesintGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoArtefactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_CausasDesintBindingSource
            // 
            this.t_CausasDesintBindingSource.DataMember = "T_CausasDesint";
            this.t_CausasDesintBindingSource.DataSource = this.dSDatos;
            // 
            // t_CausasDesintTableAdapter
            // 
            this.t_CausasDesintTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_CausasDesintTableAdapter = this.t_CausasDesintTableAdapter;
            this.tableAdapterManager.T_CombustibleTableAdapter = null;
            this.tableAdapterManager.T_DestinoLubRecTableAdapter = null;
            this.tableAdapterManager.T_EmpresaTableAdapter = null;
            this.tableAdapterManager.T_EquipoTableAdapter = null;
            this.tableAdapterManager.T_EstFisicoTableAdapter = null;
            this.tableAdapterManager.T_GrupoTableAdapter = null;
            this.tableAdapterManager.T_LubricanteTableAdapter = null;
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MotivoCambioTableAdapter = null;
            this.tableAdapterManager.T_Neumatico_BateriaTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_CausasDesintGridControl
            // 
            this.t_CausasDesintGridControl.DataSource = this.t_CausasDesintBindingSource;
            this.t_CausasDesintGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_CausasDesintGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_CausasDesintGridControl.MainView = this.gridView1;
            this.t_CausasDesintGridControl.Name = "t_CausasDesintGridControl";
            this.t_CausasDesintGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_CausasDesintGridControl.Size = new System.Drawing.Size(428, 281);
            this.t_CausasDesintGridControl.TabIndex = 1;
            this.t_CausasDesintGridControl.UseEmbeddedNavigator = true;
            this.t_CausasDesintGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCausasDesint,
            this.colidartefacto});
            this.gridView1.GridControl = this.t_CausasDesintGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colCausasDesint
            // 
            this.colCausasDesint.Caption = "Causas de Desintalación";
            this.colCausasDesint.FieldName = "CausasDesint";
            this.colCausasDesint.Name = "colCausasDesint";
            this.colCausasDesint.Visible = true;
            this.colCausasDesint.VisibleIndex = 0;
            // 
            // colidartefacto
            // 
            this.colidartefacto.Caption = "Artefacto";
            this.colidartefacto.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidartefacto.FieldName = "idartefacto";
            this.colidartefacto.Name = "colidartefacto";
            this.colidartefacto.Visible = true;
            this.colidartefacto.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tTipoArtefactoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nameartefacto";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idartefacto";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tTipoArtefactoBindingSource
            // 
            this.tTipoArtefactoBindingSource.DataMember = "T_TipoArtefacto";
            this.tTipoArtefactoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameartefacto});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameartefacto
            // 
            this.colnameartefacto.Caption = "Artefacto";
            this.colnameartefacto.FieldName = "nameartefacto";
            this.colnameartefacto.Name = "colnameartefacto";
            this.colnameartefacto.Visible = true;
            this.colnameartefacto.VisibleIndex = 0;
            // 
            // t_TipoArtefactoTableAdapter
            // 
            this.t_TipoArtefactoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCausasDesint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 281);
            this.Controls.Add(this.t_CausasDesintGridControl);
            this.Name = "FrmCausasDesint";
            this.Text = "Gestionar Causas de Desintalación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CausasDesint_FormClosed);
            this.Load += new System.EventHandler(this.CausasDesint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_CausasDesintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_CausasDesintGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoArtefactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_CausasDesintBindingSource;
        private DSDatosTableAdapters.T_CausasDesintTableAdapter t_CausasDesintTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_CausasDesintGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCausasDesint;
        private DevExpress.XtraGrid.Columns.GridColumn colidartefacto;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tTipoArtefactoBindingSource;
        private DSDatosTableAdapters.T_TipoArtefactoTableAdapter t_TipoArtefactoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameartefacto;
    }
}