namespace SICSTET.Codificadores
{
    partial class FrmMarca
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
            this.t_MarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_MarcaTableAdapter = new SICSTET.DSDatosTableAdapters.T_MarcaTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.t_MarcaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidartefacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tTipoArtefactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_TipoArtefactoTableAdapter = new SICSTET.DSDatosTableAdapters.T_TipoArtefactoTableAdapter();
            this.colnameartefacto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoArtefactoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_MarcaBindingSource
            // 
            this.t_MarcaBindingSource.DataMember = "T_Marca";
            this.t_MarcaBindingSource.DataSource = this.dSDatos;
            // 
            // t_MarcaTableAdapter
            // 
            this.t_MarcaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_LubricanteTableAdapter = null;
            this.tableAdapterManager.T_MarcaTableAdapter = this.t_MarcaTableAdapter;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MotivoCambioTableAdapter = null;
            this.tableAdapterManager.T_Neumatico_BateriaTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_MarcaGridControl
            // 
            this.t_MarcaGridControl.DataSource = this.t_MarcaBindingSource;
            this.t_MarcaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_MarcaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_MarcaGridControl.MainView = this.gridView1;
            this.t_MarcaGridControl.Name = "t_MarcaGridControl";
            this.t_MarcaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_MarcaGridControl.Size = new System.Drawing.Size(419, 340);
            this.t_MarcaGridControl.TabIndex = 1;
            this.t_MarcaGridControl.UseEmbeddedNavigator = true;
            this.t_MarcaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemarca,
            this.colidartefacto});
            this.gridView1.GridControl = this.t_MarcaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnamemarca
            // 
            this.colnamemarca.Caption = "Marca";
            this.colnamemarca.FieldName = "namemarca";
            this.colnamemarca.Name = "colnamemarca";
            this.colnamemarca.Visible = true;
            this.colnamemarca.VisibleIndex = 0;
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
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameartefacto});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tTipoArtefactoBindingSource
            // 
            this.tTipoArtefactoBindingSource.DataMember = "T_TipoArtefacto";
            this.tTipoArtefactoBindingSource.DataSource = this.dSDatos;
            // 
            // t_TipoArtefactoTableAdapter
            // 
            this.t_TipoArtefactoTableAdapter.ClearBeforeFill = true;
            // 
            // colnameartefacto
            // 
            this.colnameartefacto.Caption = "Artefacto";
            this.colnameartefacto.FieldName = "nameartefacto";
            this.colnameartefacto.Name = "colnameartefacto";
            this.colnameartefacto.Visible = true;
            this.colnameartefacto.VisibleIndex = 0;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 340);
            this.Controls.Add(this.t_MarcaGridControl);
            this.Name = "FrmMarca";
            this.Text = "Gestionar Marca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMarca_FormClosed);
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoArtefactoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_MarcaBindingSource;
        private DSDatosTableAdapters.T_MarcaTableAdapter t_MarcaTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_MarcaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca;
        private DevExpress.XtraGrid.Columns.GridColumn colidartefacto;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tTipoArtefactoBindingSource;
        private DSDatosTableAdapters.T_TipoArtefactoTableAdapter t_TipoArtefactoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameartefacto;
    }
}