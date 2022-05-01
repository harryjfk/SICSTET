namespace SICSTET.Codificadores
{
    partial class FrmProvincia
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.t_ProvinciaGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_ProvinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new SICSTET.DSDatos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tProvinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.t_ProvinciaTableAdapter = new SICSTET.DSDatosTableAdapters.T_ProvinciaTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_ProvinciaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ProvinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProvinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.t_ProvinciaGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(699, 409);
            this.panelControl1.TabIndex = 0;
            // 
            // t_ProvinciaGridControl
            // 
            this.t_ProvinciaGridControl.DataSource = this.t_ProvinciaBindingSource;
            this.t_ProvinciaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_ProvinciaGridControl.Location = new System.Drawing.Point(2, 2);
            this.t_ProvinciaGridControl.MainView = this.gridView1;
            this.t_ProvinciaGridControl.Name = "t_ProvinciaGridControl";
            this.t_ProvinciaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_ProvinciaGridControl.Size = new System.Drawing.Size(695, 405);
            this.t_ProvinciaGridControl.TabIndex = 0;
            this.t_ProvinciaGridControl.UseEmbeddedNavigator = true;
            this.t_ProvinciaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.t_ProvinciaGridControl.Click += new System.EventHandler(this.t_ProvinciaGridControl_Click);
            // 
            // t_ProvinciaBindingSource
            // 
            this.t_ProvinciaBindingSource.DataMember = "T_Provincia";
            this.t_ProvinciaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProvincia});
            this.gridView1.GridControl = this.t_ProvinciaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colProvincia
            // 
            this.colProvincia.FieldName = "Provincia";
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.Visible = true;
            this.colProvincia.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tProvinciaBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Provincia";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "Provincia";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tProvinciaBindingSource
            // 
            this.tProvinciaBindingSource.DataMember = "T_Provincia";
            this.tProvinciaBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // t_ProvinciaTableAdapter
            // 
            this.t_ProvinciaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MotivoCambioTableAdapter = null;
            this.tableAdapterManager.T_Neumatico_BateriaTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = this.t_ProvinciaTableAdapter;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 409);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmProvincia";
            this.Text = "Gestionar Provincia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProvincia_FormClosed);
            this.Load += new System.EventHandler(this.FrmEditProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_ProvinciaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ProvinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProvinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_ProvinciaBindingSource;
        private DSDatosTableAdapters.T_ProvinciaTableAdapter t_ProvinciaTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_ProvinciaGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource tProvinciaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProvincia;
    }
}