namespace SICSTET.Codificadores
{
    partial class FrmEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipo));
            this.dSDatos = new SICSTET.DSDatos();
            this.t_EquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_EquipoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.tTipoEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEstFisicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tProvinciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_TipoEquipoTableAdapter = new SICSTET.DSDatosTableAdapters.T_TipoTableAdapter();
            this.t_ModeloTableAdapter = new SICSTET.DSDatosTableAdapters.T_ModeloTableAdapter();
            this.t_MarcaTableAdapter = new SICSTET.DSDatosTableAdapters.T_MarcaTableAdapter();
            this.t_EstFisicoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EstFisicoTableAdapter();
            this.t_ProvinciaTableAdapter = new SICSTET.DSDatosTableAdapters.T_ProvinciaTableAdapter();
            this.t_EmpresaTableAdapter = new SICSTET.DSDatosTableAdapters.T_EmpresaTableAdapter();
            this.t_GrupoTableAdapter = new SICSTET.DSDatosTableAdapters.T_GrupoTableAdapter();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTipoE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit5View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit6View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit7View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDTipoE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEstFisico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDMarcaE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProvincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnno_Fab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_Motor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR_Contable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR_Vehiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInd_ConsPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCombPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiene_Somaton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Venc_Som = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiene_LO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_LO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Venc_LO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo_LO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_EquipoGridControl = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstFisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProvinciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EquipoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_EquipoBindingSource
            // 
            this.t_EquipoBindingSource.DataMember = "T_Equipo";
            this.t_EquipoBindingSource.DataSource = this.dSDatos;
            this.t_EquipoBindingSource.CurrentChanged += new System.EventHandler(this.t_EquipoBindingSource_CurrentChanged);
            // 
            // t_EquipoTableAdapter
            // 
            this.t_EquipoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_CausasDesintTableAdapter = null;
            this.tableAdapterManager.T_CombustibleTableAdapter = null;
            this.tableAdapterManager.T_DestinoLubRecTableAdapter = null;
            this.tableAdapterManager.T_EmpresaTableAdapter = null;
            this.tableAdapterManager.T_EquipoTableAdapter = this.t_EquipoTableAdapter;
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
            // tTipoEquipoBindingSource
            // 
            this.tTipoEquipoBindingSource.DataMember = "T_Tipo";
            this.tTipoEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // tEstFisicoBindingSource
            // 
            this.tEstFisicoBindingSource.DataMember = "T_EstFisico";
            this.tEstFisicoBindingSource.DataSource = this.dSDatos;
            // 
            // tModeloBindingSource
            // 
            this.tModeloBindingSource.DataMember = "T_Modelo";
            this.tModeloBindingSource.DataSource = this.dSDatos;
            // 
            // tMarcaBindingSource
            // 
            this.tMarcaBindingSource.DataMember = "T_Marca";
            this.tMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // tProvinciaBindingSource
            // 
            this.tProvinciaBindingSource.DataMember = "T_Provincia";
            this.tProvinciaBindingSource.DataSource = this.dSDatos;
            // 
            // tEmpresaBindingSource
            // 
            this.tEmpresaBindingSource.DataMember = "T_Empresa";
            this.tEmpresaBindingSource.DataSource = this.dSDatos;
            // 
            // tGrupoBindingSource
            // 
            this.tGrupoBindingSource.DataMember = "T_Grupo";
            this.tGrupoBindingSource.DataSource = this.dSDatos;
            // 
            // t_TipoEquipoTableAdapter
            // 
            this.t_TipoEquipoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ModeloTableAdapter
            // 
            this.t_ModeloTableAdapter.ClearBeforeFill = true;
            // 
            // t_MarcaTableAdapter
            // 
            this.t_MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // t_EstFisicoTableAdapter
            // 
            this.t_EstFisicoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ProvinciaTableAdapter
            // 
            this.t_ProvinciaTableAdapter.ClearBeforeFill = true;
            // 
            // t_EmpresaTableAdapter
            // 
            this.t_EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // t_GrupoTableAdapter
            // 
            this.t_GrupoTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tTipoEquipoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "TipoE";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "IDTipoE";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTipoE});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTipoE
            // 
            this.colTipoE.Caption = "Tipo";
            this.colTipoE.FieldName = "TipoE";
            this.colTipoE.Name = "colTipoE";
            this.colTipoE.Visible = true;
            this.colTipoE.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tModeloBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "Modelo";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "IDModelo";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tMarcaBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "namemarca";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "idmarca";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.AutoHeight = false;
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DataSource = this.tEstFisicoBindingSource;
            this.repositoryItemGridLookUpEdit4.DisplayMember = "EstFisico";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.ValueMember = "IDEstFisico";
            this.repositoryItemGridLookUpEdit4.View = this.repositoryItemGridLookUpEdit4View;
            // 
            // repositoryItemGridLookUpEdit4View
            // 
            this.repositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit4View.Name = "repositoryItemGridLookUpEdit4View";
            this.repositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit5
            // 
            this.repositoryItemGridLookUpEdit5.AutoHeight = false;
            this.repositoryItemGridLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit5.DataSource = this.tProvinciaBindingSource;
            this.repositoryItemGridLookUpEdit5.DisplayMember = "Provincia";
            this.repositoryItemGridLookUpEdit5.Name = "repositoryItemGridLookUpEdit5";
            this.repositoryItemGridLookUpEdit5.ValueMember = "IDProvincia";
            this.repositoryItemGridLookUpEdit5.View = this.repositoryItemGridLookUpEdit5View;
            // 
            // repositoryItemGridLookUpEdit5View
            // 
            this.repositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit5View.Name = "repositoryItemGridLookUpEdit5View";
            this.repositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit6
            // 
            this.repositoryItemGridLookUpEdit6.AutoHeight = false;
            this.repositoryItemGridLookUpEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit6.DataSource = this.tEmpresaBindingSource;
            this.repositoryItemGridLookUpEdit6.DisplayMember = "Empresa";
            this.repositoryItemGridLookUpEdit6.Name = "repositoryItemGridLookUpEdit6";
            this.repositoryItemGridLookUpEdit6.ValueMember = "IDEmpresa";
            this.repositoryItemGridLookUpEdit6.View = this.repositoryItemGridLookUpEdit6View;
            // 
            // repositoryItemGridLookUpEdit6View
            // 
            this.repositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit6View.Name = "repositoryItemGridLookUpEdit6View";
            this.repositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit7
            // 
            this.repositoryItemGridLookUpEdit7.AutoHeight = false;
            this.repositoryItemGridLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit7.DataSource = this.tGrupoBindingSource;
            this.repositoryItemGridLookUpEdit7.DisplayMember = "Grupo";
            this.repositoryItemGridLookUpEdit7.Name = "repositoryItemGridLookUpEdit7";
            this.repositoryItemGridLookUpEdit7.ValueMember = "IDGrupo";
            this.repositoryItemGridLookUpEdit7.View = this.repositoryItemGridLookUpEdit7View;
            // 
            // repositoryItemGridLookUpEdit7View
            // 
            this.repositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit7View.Name = "repositoryItemGridLookUpEdit7View";
            this.repositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDTipoE,
            this.colIDEstFisico,
            this.colIDModelo,
            this.colIDMarcaE,
            this.colIDProvincia,
            this.colIDEmpresa,
            this.colIDGrupo,
            this.colMatricula,
            this.colNo_serie,
            this.colAnno_Fab,
            this.colCapacidad,
            this.colNo_Motor,
            this.colComb,
            this.colR_Contable,
            this.colR_Vehiculo,
            this.colInd_ConsPlan,
            this.colCombPlan,
            this.colTiene_Somaton,
            this.colFecha_Venc_Som,
            this.colTiene_LO,
            this.colTipo_LO,
            this.colFecha_Venc_LO,
            this.colNo_LO});
            this.gridView1.GridControl = this.t_EquipoGridControl;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colIDTipoE
            // 
            this.colIDTipoE.Caption = "Tipo";
            this.colIDTipoE.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colIDTipoE.FieldName = "IDTipoE";
            this.colIDTipoE.Name = "colIDTipoE";
            this.colIDTipoE.Visible = true;
            this.colIDTipoE.VisibleIndex = 0;
            this.colIDTipoE.Width = 74;
            // 
            // colIDEstFisico
            // 
            this.colIDEstFisico.Caption = "Est. Físico";
            this.colIDEstFisico.ColumnEdit = this.repositoryItemGridLookUpEdit4;
            this.colIDEstFisico.FieldName = "IDEstFisico";
            this.colIDEstFisico.Name = "colIDEstFisico";
            this.colIDEstFisico.Visible = true;
            this.colIDEstFisico.VisibleIndex = 1;
            this.colIDEstFisico.Width = 53;
            // 
            // colIDModelo
            // 
            this.colIDModelo.Caption = "Modelo";
            this.colIDModelo.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colIDModelo.FieldName = "IDModelo";
            this.colIDModelo.Name = "colIDModelo";
            this.colIDModelo.Visible = true;
            this.colIDModelo.VisibleIndex = 2;
            this.colIDModelo.Width = 53;
            // 
            // colIDMarcaE
            // 
            this.colIDMarcaE.Caption = "Marca";
            this.colIDMarcaE.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colIDMarcaE.FieldName = "IDMarcaE";
            this.colIDMarcaE.Name = "colIDMarcaE";
            this.colIDMarcaE.Visible = true;
            this.colIDMarcaE.VisibleIndex = 3;
            this.colIDMarcaE.Width = 58;
            // 
            // colIDProvincia
            // 
            this.colIDProvincia.Caption = "Provincia";
            this.colIDProvincia.ColumnEdit = this.repositoryItemGridLookUpEdit5;
            this.colIDProvincia.FieldName = "IDProvincia";
            this.colIDProvincia.Name = "colIDProvincia";
            this.colIDProvincia.Visible = true;
            this.colIDProvincia.VisibleIndex = 4;
            this.colIDProvincia.Width = 34;
            // 
            // colIDEmpresa
            // 
            this.colIDEmpresa.Caption = "Empresa";
            this.colIDEmpresa.ColumnEdit = this.repositoryItemGridLookUpEdit6;
            this.colIDEmpresa.FieldName = "IDEmpresa";
            this.colIDEmpresa.Name = "colIDEmpresa";
            this.colIDEmpresa.Visible = true;
            this.colIDEmpresa.VisibleIndex = 5;
            this.colIDEmpresa.Width = 54;
            // 
            // colIDGrupo
            // 
            this.colIDGrupo.Caption = "Grupo";
            this.colIDGrupo.ColumnEdit = this.repositoryItemGridLookUpEdit7;
            this.colIDGrupo.FieldName = "IDGrupo";
            this.colIDGrupo.Name = "colIDGrupo";
            this.colIDGrupo.Visible = true;
            this.colIDGrupo.VisibleIndex = 6;
            this.colIDGrupo.Width = 20;
            // 
            // colMatricula
            // 
            this.colMatricula.Caption = "Matricula";
            this.colMatricula.FieldName = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Visible = true;
            this.colMatricula.VisibleIndex = 7;
            this.colMatricula.Width = 24;
            // 
            // colNo_serie
            // 
            this.colNo_serie.Caption = "No.Serie";
            this.colNo_serie.FieldName = "No_serie";
            this.colNo_serie.Name = "colNo_serie";
            this.colNo_serie.Visible = true;
            this.colNo_serie.VisibleIndex = 8;
            this.colNo_serie.Width = 21;
            // 
            // colAnno_Fab
            // 
            this.colAnno_Fab.Caption = "Año. Fab";
            this.colAnno_Fab.FieldName = "Anno_Fab";
            this.colAnno_Fab.Name = "colAnno_Fab";
            this.colAnno_Fab.Visible = true;
            this.colAnno_Fab.VisibleIndex = 9;
            this.colAnno_Fab.Width = 27;
            // 
            // colCapacidad
            // 
            this.colCapacidad.Caption = "Capacidad";
            this.colCapacidad.FieldName = "Capacidad";
            this.colCapacidad.Name = "colCapacidad";
            this.colCapacidad.Visible = true;
            this.colCapacidad.VisibleIndex = 10;
            this.colCapacidad.Width = 27;
            // 
            // colNo_Motor
            // 
            this.colNo_Motor.Caption = "No.Motor";
            this.colNo_Motor.FieldName = "No_Motor";
            this.colNo_Motor.Name = "colNo_Motor";
            this.colNo_Motor.Visible = true;
            this.colNo_Motor.VisibleIndex = 11;
            this.colNo_Motor.Width = 22;
            // 
            // colComb
            // 
            this.colComb.Caption = "Comb";
            this.colComb.FieldName = "Comb";
            this.colComb.Name = "colComb";
            this.colComb.Visible = true;
            this.colComb.VisibleIndex = 12;
            this.colComb.Width = 20;
            // 
            // colR_Contable
            // 
            this.colR_Contable.Caption = "R.Contable";
            this.colR_Contable.FieldName = "R_Contable";
            this.colR_Contable.Name = "colR_Contable";
            this.colR_Contable.Visible = true;
            this.colR_Contable.VisibleIndex = 13;
            this.colR_Contable.Width = 34;
            // 
            // colR_Vehiculo
            // 
            this.colR_Vehiculo.Caption = "R.Vehiculo";
            this.colR_Vehiculo.FieldName = "R_Vehiculo";
            this.colR_Vehiculo.Name = "colR_Vehiculo";
            this.colR_Vehiculo.Visible = true;
            this.colR_Vehiculo.VisibleIndex = 14;
            this.colR_Vehiculo.Width = 32;
            // 
            // colInd_ConsPlan
            // 
            this.colInd_ConsPlan.Caption = "Ind. Cons. Plan";
            this.colInd_ConsPlan.FieldName = "Ind_ConsPlan";
            this.colInd_ConsPlan.Name = "colInd_ConsPlan";
            this.colInd_ConsPlan.Visible = true;
            this.colInd_ConsPlan.VisibleIndex = 15;
            this.colInd_ConsPlan.Width = 51;
            // 
            // colCombPlan
            // 
            this.colCombPlan.Caption = "Comb. Plan";
            this.colCombPlan.FieldName = "CombPlan";
            this.colCombPlan.Name = "colCombPlan";
            this.colCombPlan.Visible = true;
            this.colCombPlan.VisibleIndex = 17;
            this.colCombPlan.Width = 44;
            // 
            // colTiene_Somaton
            // 
            this.colTiene_Somaton.Caption = "Somaton";
            this.colTiene_Somaton.FieldName = "Tiene_Somaton";
            this.colTiene_Somaton.Name = "colTiene_Somaton";
            this.colTiene_Somaton.Visible = true;
            this.colTiene_Somaton.VisibleIndex = 16;
            this.colTiene_Somaton.Width = 57;
            // 
            // colFecha_Venc_Som
            // 
            this.colFecha_Venc_Som.Caption = "Fecha. Vec. Som";
            this.colFecha_Venc_Som.FieldName = "Fecha_Venc_Som";
            this.colFecha_Venc_Som.Name = "colFecha_Venc_Som";
            this.colFecha_Venc_Som.Visible = true;
            this.colFecha_Venc_Som.VisibleIndex = 18;
            this.colFecha_Venc_Som.Width = 74;
            // 
            // colTiene_LO
            // 
            this.colTiene_LO.Caption = "L. Operativa";
            this.colTiene_LO.FieldName = "Tiene_LO";
            this.colTiene_LO.Name = "colTiene_LO";
            this.colTiene_LO.Visible = true;
            this.colTiene_LO.VisibleIndex = 19;
            this.colTiene_LO.Width = 42;
            // 
            // colTipo_LO
            // 
            this.colTipo_LO.Caption = "Tipo. LO";
            this.colTipo_LO.FieldName = "Tipo_LO";
            this.colTipo_LO.Name = "colTipo_LO";
            this.colTipo_LO.Visible = true;
            this.colTipo_LO.VisibleIndex = 20;
            this.colTipo_LO.Width = 35;
            // 
            // colFecha_Venc_LO
            // 
            this.colFecha_Venc_LO.Caption = "Fecha. Ven. LO";
            this.colFecha_Venc_LO.FieldName = "Fecha_Venc_LO";
            this.colFecha_Venc_LO.Name = "colFecha_Venc_LO";
            this.colFecha_Venc_LO.Visible = true;
            this.colFecha_Venc_LO.VisibleIndex = 21;
            this.colFecha_Venc_LO.Width = 74;
            // 
            // colNo_LO
            // 
            this.colNo_LO.Caption = "No. LO";
            this.colNo_LO.FieldName = "No_LO";
            this.colNo_LO.Name = "colNo_LO";
            this.colNo_LO.Visible = true;
            this.colNo_LO.VisibleIndex = 22;
            this.colNo_LO.Width = 62;
            // 
            // t_EquipoGridControl
            // 
            this.t_EquipoGridControl.DataSource = this.t_EquipoBindingSource;
            this.t_EquipoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_EquipoGridControl.Location = new System.Drawing.Point(0, 26);
            this.t_EquipoGridControl.MainView = this.gridView1;
            this.t_EquipoGridControl.Name = "t_EquipoGridControl";
            this.t_EquipoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemGridLookUpEdit4,
            this.repositoryItemGridLookUpEdit5,
            this.repositoryItemGridLookUpEdit6,
            this.repositoryItemGridLookUpEdit7});
            this.t_EquipoGridControl.Size = new System.Drawing.Size(1014, 398);
            this.t_EquipoGridControl.TabIndex = 1;
            this.t_EquipoGridControl.UseEmbeddedNavigator = true;
            this.t_EquipoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar1.Text = "Herramientas";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Insertar";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Editar";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Eliminar";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageIndex = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1014, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Size = new System.Drawing.Size(1014, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1014, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "800px-Lada_1200.jpg");
            this.imageCollection1.Images.SetKeyName(1, "broken.ico");
            this.imageCollection1.Images.SetKeyName(2, "_DIT_ADD.ICO");
            this.imageCollection1.Images.SetKeyName(3, "edit_remove.ico");
            this.imageCollection1.Images.SetKeyName(4, "folder_recicl.ico");
            this.imageCollection1.Images.SetKeyName(5, "Undo.ico");
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 424);
            this.Controls.Add(this.t_EquipoGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquipo";
            this.Text = "FrmEquipo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstFisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProvinciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EquipoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_EquipoBindingSource;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tTipoEquipoBindingSource;
        private DSDatosTableAdapters.T_TipoTableAdapter t_TipoEquipoTableAdapter;
        private System.Windows.Forms.BindingSource tModeloBindingSource;
        private DSDatosTableAdapters.T_ModeloTableAdapter t_ModeloTableAdapter;
        private System.Windows.Forms.BindingSource tMarcaBindingSource;
        private DSDatosTableAdapters.T_MarcaTableAdapter t_MarcaTableAdapter;
        private System.Windows.Forms.BindingSource tEstFisicoBindingSource;
        private DSDatosTableAdapters.T_EstFisicoTableAdapter t_EstFisicoTableAdapter;
        private System.Windows.Forms.BindingSource tProvinciaBindingSource;
        private DSDatosTableAdapters.T_ProvinciaTableAdapter t_ProvinciaTableAdapter;
        private System.Windows.Forms.BindingSource tEmpresaBindingSource;
        private DSDatosTableAdapters.T_EmpresaTableAdapter t_EmpresaTableAdapter;
        private System.Windows.Forms.BindingSource tGrupoBindingSource;
        private DSDatosTableAdapters.T_GrupoTableAdapter t_GrupoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoE;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit4View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit5View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit6;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit6View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit7;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit7View;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDTipoE;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEstFisico;
        private DevExpress.XtraGrid.Columns.GridColumn colIDModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMarcaE;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProvincia;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIDGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_serie;
        private DevExpress.XtraGrid.Columns.GridColumn colAnno_Fab;
        private DevExpress.XtraGrid.Columns.GridColumn colCapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_Motor;
        private DevExpress.XtraGrid.Columns.GridColumn colComb;
        private DevExpress.XtraGrid.Columns.GridColumn colR_Contable;
        private DevExpress.XtraGrid.Columns.GridColumn colR_Vehiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colInd_ConsPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colCombPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colTiene_Somaton;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Venc_Som;
        private DevExpress.XtraGrid.Columns.GridColumn colTiene_LO;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_LO;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Venc_LO;
        private DevExpress.XtraGrid.Columns.GridColumn colNo_LO;
        private DevExpress.XtraGrid.GridControl t_EquipoGridControl;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}