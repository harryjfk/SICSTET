namespace SICSTET.Codificadores
{
    partial class FrmBateria
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
            this.t_Neumatico_BateriaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEstFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCausasDesint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tCausasDesintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCausasDesint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Inst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Desint = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_MarcaTableAdapter = new SICSTET.DSDatosTableAdapters.T_MarcaTableAdapter();
            this.t_EstFisicoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EstFisicoTableAdapter();
            this.t_EquipoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.t_CausasDesintTableAdapter = new SICSTET.DSDatosTableAdapters.T_CausasDesintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstFisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCausasDesintBindingSource)).BeginInit();
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
            this.t_Neumatico_BateriaGridControl.Size = new System.Drawing.Size(461, 367);
            this.t_Neumatico_BateriaGridControl.TabIndex = 0;
            this.t_Neumatico_BateriaGridControl.UseEmbeddedNavigator = true;
            this.t_Neumatico_BateriaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDEquipo,
            this.colIDMarca,
            this.colMedida,
            this.colIDEstFisico,
            this.colIDCausasDesint,
            this.colFecha_Inst,
            this.colFecha_Desint,
            this.colNumero});
            this.gridView1.GridControl = this.t_Neumatico_BateriaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colIDEquipo
            // 
            this.colIDEquipo.Caption = "Equipo";
            this.colIDEquipo.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colIDEquipo.FieldName = "IDEquipo";
            this.colIDEquipo.Name = "colIDEquipo";
            this.colIDEquipo.Visible = true;
            this.colIDEquipo.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tEquipoBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "Matricula";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "IDEquipo";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // tEquipoBindingSource
            // 
            this.tEquipoBindingSource.DataMember = "T_Equipo";
            this.tEquipoBindingSource.DataSource = this.dSDatosBindingSource;
            // 
            // dSDatosBindingSource
            // 
            this.dSDatosBindingSource.DataSource = this.dSDatos;
            this.dSDatosBindingSource.Position = 0;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatricula,
            this.colNo_serie});
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
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
            // colIDMarca
            // 
            this.colIDMarca.Caption = "Marca";
            this.colIDMarca.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colIDMarca.FieldName = "IDMarca";
            this.colIDMarca.Name = "colIDMarca";
            this.colIDMarca.Visible = true;
            this.colIDMarca.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tMarcaBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "namemarca";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idmarca";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tMarcaBindingSource
            // 
            this.tMarcaBindingSource.DataMember = "T_Marca";
            this.tMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemarca});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemarca
            // 
            this.colnamemarca.Caption = "Marca";
            this.colnamemarca.FieldName = "namemarca";
            this.colnamemarca.Name = "colnamemarca";
            this.colnamemarca.Visible = true;
            this.colnamemarca.VisibleIndex = 0;
            // 
            // colMedida
            // 
            this.colMedida.Caption = "Medida";
            this.colMedida.FieldName = "Medida";
            this.colMedida.Name = "colMedida";
            this.colMedida.Visible = true;
            this.colMedida.VisibleIndex = 2;
            // 
            // colIDEstFisico
            // 
            this.colIDEstFisico.Caption = "Estado";
            this.colIDEstFisico.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colIDEstFisico.FieldName = "IDEstFisico";
            this.colIDEstFisico.Name = "colIDEstFisico";
            this.colIDEstFisico.Visible = true;
            this.colIDEstFisico.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tEstFisicoBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "EstFisico";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "IDEstFisico";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tEstFisicoBindingSource
            // 
            this.tEstFisicoBindingSource.DataMember = "T_EstFisico";
            this.tEstFisicoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstFisico});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colEstFisico
            // 
            this.colEstFisico.Caption = "Estado";
            this.colEstFisico.FieldName = "EstFisico";
            this.colEstFisico.Name = "colEstFisico";
            this.colEstFisico.Visible = true;
            this.colEstFisico.VisibleIndex = 0;
            // 
            // colIDCausasDesint
            // 
            this.colIDCausasDesint.Caption = "Causas de Desintalación";
            this.colIDCausasDesint.ColumnEdit = this.repositoryItemGridLookUpEdit4;
            this.colIDCausasDesint.FieldName = "IDCausasDesint";
            this.colIDCausasDesint.Name = "colIDCausasDesint";
            this.colIDCausasDesint.Visible = true;
            this.colIDCausasDesint.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.AutoHeight = false;
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DataSource = this.tCausasDesintBindingSource;
            this.repositoryItemGridLookUpEdit4.DisplayMember = "CausasDesint";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.ValueMember = "IDCausasDesint";
            this.repositoryItemGridLookUpEdit4.View = this.repositoryItemGridLookUpEdit4View;
            // 
            // tCausasDesintBindingSource
            // 
            this.tCausasDesintBindingSource.DataMember = "T_CausasDesint";
            this.tCausasDesintBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit4View
            // 
            this.repositoryItemGridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCausasDesint});
            this.repositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit4View.Name = "repositoryItemGridLookUpEdit4View";
            this.repositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colCausasDesint
            // 
            this.colCausasDesint.Caption = "Causas de Desintalación";
            this.colCausasDesint.FieldName = "CausasDesint";
            this.colCausasDesint.Name = "colCausasDesint";
            this.colCausasDesint.Visible = true;
            this.colCausasDesint.VisibleIndex = 0;
            // 
            // colFecha_Inst
            // 
            this.colFecha_Inst.Caption = "Fechad e Instalación";
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
            // t_CausasDesintTableAdapter
            // 
            this.t_CausasDesintTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 367);
            this.Controls.Add(this.t_Neumatico_BateriaGridControl);
            this.Name = "FrmBateria";
            this.Text = "Gestionar Bateria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBateria_FormClosed);
            this.Load += new System.EventHandler(this.FrmBateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_Neumatico_BateriaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstFisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCausasDesintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_Neumatico_BateriaBindingSource;
        private DSDatosTableAdapters.T_Neumatico_BateriaTableAdapter t_Neumatico_BateriaTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_Neumatico_BateriaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tMarcaBindingSource;
        private DSDatosTableAdapters.T_MarcaTableAdapter t_MarcaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource tEstFisicoBindingSource;
        private DSDatosTableAdapters.T_EstFisicoTableAdapter t_EstFisicoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEquipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private System.Windows.Forms.BindingSource dSDatosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEstFisico;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCausasDesint;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Inst;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Desint;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colEstFisico;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit4View;
        private System.Windows.Forms.BindingSource tEquipoBindingSource;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_serie;
        private System.Windows.Forms.BindingSource tCausasDesintBindingSource;
        private DSDatosTableAdapters.T_CausasDesintTableAdapter t_CausasDesintTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCausasDesint;
    }
}