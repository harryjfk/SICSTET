using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SICSTET.Codificadores
{
    public partial class FrmProvincia : DevExpress.XtraEditors.XtraForm
    {
        public FrmProvincia()
        {
            InitializeComponent();
        }

        private void t_ProvinciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ProvinciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmEditProvincia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Provincia' Puede moverla o quitarla según sea necesario.
            this.t_ProvinciaTableAdapter.Fill(this.dSDatos.T_Provincia);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_ProvinciaTableAdapter.Update(dSDatos.T_Provincia);
        }

        private void t_ProvinciaGridControl_Click(object sender, EventArgs e)
        {

        }

        private void FrmProvincia_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_ProvinciaTableAdapter.Update(dSDatos.T_Provincia);

        }
    }
}