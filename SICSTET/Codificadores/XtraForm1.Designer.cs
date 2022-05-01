namespace SICSTET.Codificadores
{
    partial class XtraForm1
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.dSDatos = new SICSTET.DSDatos();
            this.t_EstFisicoBindingSource = new System.Windows.Forms.BindingSource();
            this.t_EstFisicoTableAdapter = new SICSTET.DSDatosTableAdapters.T_EstFisicoTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.t_MarcaBindingSource = new System.Windows.Forms.BindingSource();
            this.t_MarcaTableAdapter = new SICSTET.DSDatosTableAdapters.T_MarcaTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnamemarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidartefacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidrelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_MarcaGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EstFisicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "1111";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(717, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Size = new System.Drawing.Size(717, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 66);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 400);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(717, 66);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 400);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "3222";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_EstFisicoBindingSource
            // 
            this.t_EstFisicoBindingSource.DataMember = "T_EstFisico";
            this.t_EstFisicoBindingSource.DataSource = this.dSDatos;
            // 
            // t_EstFisicoTableAdapter
            // 
            this.t_EstFisicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_EquipoTableAdapter = null;
            this.tableAdapterManager.T_EstFisicoTableAdapter = this.t_EstFisicoTableAdapter;
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoEquipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidmarca,
            this.colnamemarca,
            this.colidartefacto,
            this.colidrelacion});
            this.gridView1.GridControl = this.t_MarcaGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colidmarca
            // 
            this.colidmarca.FieldName = "idmarca";
            this.colidmarca.Name = "colidmarca";
            this.colidmarca.OptionsColumn.ReadOnly = true;
            this.colidmarca.Visible = true;
            this.colidmarca.VisibleIndex = 0;
            // 
            // colnamemarca
            // 
            this.colnamemarca.FieldName = "namemarca";
            this.colnamemarca.Name = "colnamemarca";
            this.colnamemarca.Visible = true;
            this.colnamemarca.VisibleIndex = 1;
            // 
            // colidartefacto
            // 
            this.colidartefacto.FieldName = "idartefacto";
            this.colidartefacto.Name = "colidartefacto";
            this.colidartefacto.Visible = true;
            this.colidartefacto.VisibleIndex = 2;
            // 
            // colidrelacion
            // 
            this.colidrelacion.FieldName = "idrelacion";
            this.colidrelacion.Name = "colidrelacion";
            this.colidrelacion.Visible = true;
            this.colidrelacion.VisibleIndex = 3;
            // 
            // t_MarcaGridControl
            // 
            this.t_MarcaGridControl.DataSource = this.t_MarcaBindingSource;
            this.t_MarcaGridControl.Location = new System.Drawing.Point(169, 177);
            this.t_MarcaGridControl.MainView = this.gridView1;
            this.t_MarcaGridControl.MenuManager = this.barManager1;
            this.t_MarcaGridControl.Name = "t_MarcaGridControl";
            this.t_MarcaGridControl.Size = new System.Drawing.Size(300, 220);
            this.t_MarcaGridControl.TabIndex = 4;
            this.t_MarcaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 466);
            this.Controls.Add(this.t_MarcaGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_EstFisicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MarcaGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.BindingSource t_EstFisicoBindingSource;
        private DSDatos dSDatos;
        private DSDatosTableAdapters.T_EstFisicoTableAdapter t_EstFisicoTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource t_MarcaBindingSource;
        private DSDatosTableAdapters.T_MarcaTableAdapter t_MarcaTableAdapter;
        private DevExpress.XtraGrid.GridControl t_MarcaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidmarca;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca;
        private DevExpress.XtraGrid.Columns.GridColumn colidartefacto;
        private DevExpress.XtraGrid.Columns.GridColumn colidrelacion;
    }
}