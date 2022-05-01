namespace SICSTET.Codificadores
{
    partial class FrmDestinoLubRec
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
            this.t_DestinoLubRecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_DestinoLubRecTableAdapter = new SICSTET.DSDatosTableAdapters.T_DestinoLubRecTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.t_DestinoLubRecGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDestinoLubRec = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DestinoLubRecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DestinoLubRecGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_DestinoLubRecBindingSource
            // 
            this.t_DestinoLubRecBindingSource.DataMember = "T_DestinoLubRec";
            this.t_DestinoLubRecBindingSource.DataSource = this.dSDatos;
            // 
            // t_DestinoLubRecTableAdapter
            // 
            this.t_DestinoLubRecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.T_CausasDesintTableAdapter = null;
            this.tableAdapterManager.T_CombustibleTableAdapter = null;
            this.tableAdapterManager.T_DestinoLubRecTableAdapter = this.t_DestinoLubRecTableAdapter;
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
            // t_DestinoLubRecGridControl
            // 
            this.t_DestinoLubRecGridControl.DataSource = this.t_DestinoLubRecBindingSource;
            this.t_DestinoLubRecGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_DestinoLubRecGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_DestinoLubRecGridControl.MainView = this.gridView1;
            this.t_DestinoLubRecGridControl.Name = "t_DestinoLubRecGridControl";
            this.t_DestinoLubRecGridControl.Size = new System.Drawing.Size(476, 272);
            this.t_DestinoLubRecGridControl.TabIndex = 1;
            this.t_DestinoLubRecGridControl.UseEmbeddedNavigator = true;
            this.t_DestinoLubRecGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDestinoLubRec});
            this.gridView1.GridControl = this.t_DestinoLubRecGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colDestinoLubRec
            // 
            this.colDestinoLubRec.Caption = "Destino del lubricante recuperado";
            this.colDestinoLubRec.FieldName = "DestinoLubRec";
            this.colDestinoLubRec.Name = "colDestinoLubRec";
            this.colDestinoLubRec.Visible = true;
            this.colDestinoLubRec.VisibleIndex = 0;
            // 
            // FrmDestinoLubRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 272);
            this.Controls.Add(this.t_DestinoLubRecGridControl);
            this.Name = "FrmDestinoLubRec";
            this.Text = "Gestionar Destino del lubricante recuperado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDestinoLubRec_FormClosed);
            this.Load += new System.EventHandler(this.FrmDestinoLubRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DestinoLubRecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_DestinoLubRecGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_DestinoLubRecBindingSource;
        private DSDatosTableAdapters.T_DestinoLubRecTableAdapter t_DestinoLubRecTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_DestinoLubRecGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDestinoLubRec;
    }
}