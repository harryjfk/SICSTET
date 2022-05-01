namespace SICSTET.Codificadores
{
    partial class FrmMotivoCambio
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
            this.t_MotivoCambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_MotivoCambioTableAdapter = new SICSTET.DSDatosTableAdapters.T_MotivoCambioTableAdapter();
            this.tableAdapterManager = new SICSTET.DSDatosTableAdapters.TableAdapterManager();
            this.t_MotivoCambioGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMotivoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MotivoCambioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MotivoCambioGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_MotivoCambioBindingSource
            // 
            this.t_MotivoCambioBindingSource.DataMember = "T_MotivoCambio";
            this.t_MotivoCambioBindingSource.DataSource = this.dSDatos;
            // 
            // t_MotivoCambioTableAdapter
            // 
            this.t_MotivoCambioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_MotivoCambioTableAdapter = this.t_MotivoCambioTableAdapter;
            this.tableAdapterManager.T_Neumatico_BateriaTableAdapter = null;
            this.tableAdapterManager.T_ProvinciaTableAdapter = null;
            this.tableAdapterManager.T_TipoArtefactoTableAdapter = null;
            this.tableAdapterManager.T_TipoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SICSTET.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_MotivoCambioGridControl
            // 
            this.t_MotivoCambioGridControl.DataSource = this.t_MotivoCambioBindingSource;
            this.t_MotivoCambioGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_MotivoCambioGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_MotivoCambioGridControl.MainView = this.gridView1;
            this.t_MotivoCambioGridControl.Name = "t_MotivoCambioGridControl";
            this.t_MotivoCambioGridControl.Size = new System.Drawing.Size(427, 361);
            this.t_MotivoCambioGridControl.TabIndex = 1;
            this.t_MotivoCambioGridControl.UseEmbeddedNavigator = true;
            this.t_MotivoCambioGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.t_MotivoCambioGridControl.Click += new System.EventHandler(this.t_MotivoCambioGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMotivoCambio});
            this.gridView1.GridControl = this.t_MotivoCambioGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colMotivoCambio
            // 
            this.colMotivoCambio.FieldName = "MotivoCambio";
            this.colMotivoCambio.Name = "colMotivoCambio";
            this.colMotivoCambio.Visible = true;
            this.colMotivoCambio.VisibleIndex = 0;
            // 
            // FrmMotivoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 361);
            this.Controls.Add(this.t_MotivoCambioGridControl);
            this.Name = "FrmMotivoCambio";
            this.Text = "Gestionar Motivo de cambio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMotivoCambio_FormClosed);
            this.Load += new System.EventHandler(this.FrmMotivoCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MotivoCambioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_MotivoCambioGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_MotivoCambioBindingSource;
        private DSDatosTableAdapters.T_MotivoCambioTableAdapter t_MotivoCambioTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_MotivoCambioGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoCambio;
    }
}