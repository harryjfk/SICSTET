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
    public partial class FrmCausasDesint : DevExpress.XtraEditors.XtraForm
    {
        public FrmCausasDesint()
        {
            InitializeComponent();
        }

        private void t_CausasDesintBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_CausasDesintBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void CausasDesint_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoArtefacto' Puede moverla o quitarla según sea necesario.
            this.t_TipoArtefactoTableAdapter.Fill(this.dSDatos.T_TipoArtefacto);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_CausasDesint' Puede moverla o quitarla según sea necesario.
            this.t_CausasDesintTableAdapter.Fill(this.dSDatos.T_CausasDesint);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_CausasDesintTableAdapter.Update(dSDatos.T_CausasDesint);
        }

        private void CausasDesint_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_CausasDesintTableAdapter.Update(dSDatos.T_CausasDesint);
        }
    }
}