namespace SICSTET.Codificadores
{
    partial class FrmNeumatico
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
            this.t_Neumatico_BateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_Neumatico_BateriaTableAdapter = new SICSTET.DSDatosTableAdapters.T_Neumatico_BateriaTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.tEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTipoArtefactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCausasDesintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEstFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_TipoArtefactoTableAdapter = new SICSTET.DSDatosTableAdapters.T_TipoArtefactoTableAdapter();
            this.t_CausasDesintTableAdapter = new SICSTET.DSDatosTableAdapters.T_CausasDesintTableAdapter();
            this.t_MarcaTableAdapter = new SICSTET.DSDatosTableAdapters.T_MarcaTableAdapter();
            this.t_EstFisicoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EstFisicoTableAdapter();
            this.t_EquipoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.t_Neumatico_BateriaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCausasDesint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCausasDesint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Inst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Desint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoArtefactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCausasDesintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstFisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_Neumatico_BateriaBindingSource
            // 
            this.t_Neumatico_BateriaBindingSource.DataMember = "T_Neumatico_Bateria";
            this.t_Neumatico_BateriaBindingSource.DataSource = this.dSDatos;
            // 
            // t_Neumatico_BateriaTableAdapter
            // 
            this.t_Neumatico_BateriaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_Neumatico_BateriaTableAdapter = this.t_Neumatico_BateriaTableAdapter;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_RolTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoTableAdapter = null;
            this.tableAdapterManager.T_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tEquipoBindingSource
            // 
            this.tEquipoBindingSource.DataMember = "T_Equipo";
            this.tEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // tTipoArtefactoBindingSource
            // 
            this.tTipoArtefactoBindingSource.DataMember = "T_TipoArtefacto";
            this.tTipoArtefactoBindingSource.DataSource = this.dSDatos;
            // 
            // tCausasDesintBindingSource
            // 
            this.tCausasDesintBindingSource.DataMember = "T_CausasDesint";
            this.tCausasDesintBindingSource.DataSource = this.dSDatos;
            // 
            // tMarcaBindingSource
            // 
            this.tMarcaBindingSource.DataMember = "T_Marca";
            this.tMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // tEstFisicoBindingSource
            // 
            this.tEstFisicoBindingSource.DataMember = "T_EstFisico";
            this.tEstFisicoBindingSource.DataSource = this.dSDatos;
            // 
            // t_TipoArtefactoTableAdapter
            // 
            this.t_TipoArtefactoTableAdapter.ClearBeforeFill = true;
            // 
            // t_CausasDesintTableAdapter
            // 
            this.t_CausasDesintTableAdapter.ClearBeforeFill = true;
            // 
            // t_MarcaTableAdapter
            // 
            this.t_MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // t_EstFisicoTableAdapter
            // 
            this.t_EstFisicoTableAdapter.ClearBeforeFill = true;
            // 
            // t_EquipoTableAdapter
            // 
            this.t_EquipoTableAdapter.ClearBeforeFill = true;
            // 
            // t_Neumatico_BateriaGridControl
            // 
            this.t_Neumatico_BateriaGridControl.DataSource = this.t_Neumatico_BateriaBindingSource;
            this.t_Neumatico_BateriaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_Neumatico_BateriaGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_Neumatico_BateriaGridControl.MainView = this.gridView1;
            this.t_Neumatico_BateriaGridControl.Name = "t_Neumatico_BateriaGridControl";
            this.t_Neumatico_BateriaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemGridLookUpEdit4});
            this.t_Neumatico_BateriaGridControl.Size = new System.Drawing.Size(694, 410);
            this.t_Neumatico_BateriaGridControl.TabIndex = 0;
            this.t_Neumatico_BateriaGridControl.UseEmbeddedNavigator = true;
            this.t_Neumatico_BateriaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCausasDesint,
            this.colIDMarca,
            this.colIDEstFisico,
            this.colMedida,
            this.colFecha_Inst,
            this.colFecha_Desint,
            this.colNumero,
            this.colIDEquipo});
            this.gridView1.GridControl = this.t_Neumatico_BateriaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated_1);
            // 
            // colIDCausasDesint
            // 
            this.colIDCausasDesint.Caption = "Causas de Desintalación";
            this.colIDCausasDesint.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colIDCausasDesint.FieldName = "IDCausasDesint";
            this.colIDCausasDesint.Name = "colIDCausasDesint";
            this.colIDCausasDesint.Visible = true;
            this.colIDCausasDesint.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tCausasDesintBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "CausasDesint";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "IDCausasDesint";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCausasDesint});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCausasDesint
            // 
            this.colCausasDesint.Caption = "Causas de Desintalación";
            this.colCausasDesint.FieldName = "CausasDesint";
            this.colCausasDesint.Name = "colCausasDesint";
            this.colCausasDesint.Visible = true;
            this.colCausasDesint.VisibleIndex = 0;
            // 
            // colIDMarca
            // 
            this.colIDMarca.Caption = "Marca";
            this.colIDMarca.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colIDMarca.FieldName = "IDMarca";
            this.colIDMarca.Name = "colIDMarca";
            this.colIDMarca.Visible = true;
            this.colIDMarca.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tMarcaBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "namemarca";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idmarca";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemarca});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemarca
            // 
            this.colnamemarca.Caption = "Marca";
            this.colnamemarca.FieldName = "namemarca";
            this.colnamemarca.Name = "colnamemarca";
            this.colnamemarca.Visible = true;
            this.colnamemarca.VisibleIndex = 0;
            // 
            // colIDEstFisico
            // 
            this.colIDEstFisico.Caption = "Estado";
            this.colIDEstFisico.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colIDEstFisico.FieldName = "IDEstFisico";
            this.colIDEstFisico.Name = "colIDEstFisico";
            this.colIDEstFisico.Visible = true;
            this.colIDEstFisico.VisibleIndex = 2;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tEstFisicoBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "EstFisico";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "IDEstFisico";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstFisico});
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // colEstFisico
            // 
            this.colEstFisico.Caption = "Estado";
            this.colEstFisico.FieldName = "EstFisico";
            this.colEstFisico.Name = "colEstFisico";
            this.colEstFisico.Visible = true;
            this.colEstFisico.VisibleIndex = 0;
            // 
            // colMedida
            // 
            this.colMedida.Caption = "Medida";
            this.colMedida.FieldName = "Medida";
            this.colMedida.Name = "colMedida";
            this.colMedida.Visible = true;
            this.colMedida.VisibleIndex = 3;
            // 
            // colFecha_Inst
            // 
            this.colFecha_Inst.Caption = "Fecha de Instalación";
            this.colFecha_Inst.FieldName = "Fecha_Inst";
            this.colFecha_Inst.Name = "colFecha_Inst";
            this.colFecha_Inst.Visible = true;
            this.colFecha_Inst.VisibleIndex = 5;
            // 
            // colFecha_Desint
            // 
            this.colFecha_Desint.Caption = "Fecha de Desintalación";
            this.colFecha_Desint.FieldName = "Fecha_Desint";
            this.colFecha_Desint.Name = "colFecha_Desint";
            this.colFecha_Desint.Visible = true;
            this.colFecha_Desint.VisibleIndex = 6;
            // 
            // colNumero
            // 
            this.colNumero.Caption = "Número";
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 7;
            // 
            // colIDEquipo
            // 
            this.colIDEquipo.Caption = "Equipo";
            this.colIDEquipo.ColumnEdit = this.repositoryItemGridLookUpEdit4;
            this.colIDEquipo.FieldName = "IDEquipo";
            this.colIDEquipo.Name = "colIDEquipo";
            this.colIDEquipo.Visible = true;
            this.colIDEquipo.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.AutoHeight = false;
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DataSource = this.tEquipoBindingSource;
            this.repositoryItemGridLookUpEdit4.DisplayMember = "Matricula";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.ValueMember = "IDEquipo";
            this.repositoryItemGridLookUpEdit4.View = this.repositoryItemGridLookUpEdit4View;
            // 
            // repositoryItemGridLookUpEdit4View
            // 
            this.repositoryItemGridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatricula,
            this.colNo_serie});
            this.repositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit4View.Name = "repositoryItemGridLookUpEdit4View";
            this.repositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colMatricula
            // 
            this.colMatricula.Caption = "Matricula";
            this.colMatricula.FieldName = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Visible = true;
            this.colMatricula.VisibleIndex = 0;
            // 
            // colNo_serie
            // 
            this.colNo_serie.Caption = "No. Serie";
            this.colNo_serie.FieldName = "No_serie";
            this.colNo_serie.Name = "colNo_serie";
            this.colNo_serie.Visible = true;
            this.colNo_serie.VisibleIndex = 1;
            // 
            // FrmNeumatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 410);
            this.Controls.Add(this.t_Neumatico_BateriaGridControl);
            this.Name = "FrmNeumatico";
            this.Text = "Gestionar Neumático";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNeumatico_FormClosed);
            this.Load += new System.EventHandler(this.FrmNeumatico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoArtefactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCausasDesintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstFisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_Neumatico_BateriaBindingSource;
        private DSDatosTableAdapters.T_Neumatico_BateriaTableAdapter t_Neumatico_BateriaTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tTipoArtefactoBindingSource;
        private DSDatosTableAdapters.T_TipoArtefactoTableAdapter t_TipoArtefactoTableAdapter;
        private System.Windows.Forms.BindingSource tCausasDesintBindingSource;
        private DSDatosTableAdapters.T_CausasDesintTableAdapter t_CausasDesintTableAdapter;
        private System.Windows.Forms.BindingSource tMarcaBindingSource;
        private DSDatosTableAdapters.T_MarcaTableAdapter t_MarcaTableAdapter;
        private System.Windows.Forms.BindingSource tEstFisicoBindingSource;
        private DSDatosTableAdapters.T_EstFisicoTableAdapter t_EstFisicoTableAdapter;
        private System.Windows.Forms.BindingSource tEquipoBindingSource;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter;
        private DevExpress.XtraGrid.GridControl t_Neumatico_BateriaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCausasDesint;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCausasDesint;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMarca;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEstFisico;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn colEstFisico;
        private DevExpress.XtraGrid.Columns.GridColumn colMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Inst;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Desint;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEquipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit4View;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_serie;
    }
}