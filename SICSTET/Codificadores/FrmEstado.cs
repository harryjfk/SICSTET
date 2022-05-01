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
    public partial class FrmEstado : DevExpress.XtraEditors.XtraForm
    {
        public FrmEstado()
        {
            InitializeComponent();
        }

        private void t_EstFisicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_EstFisicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoArtefacto' Puede moverla o quitarla según sea necesario.
            this.t_TipoArtefactoTableAdapter.Fill(this.dSDatos.T_TipoArtefacto);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstFisico' Puede moverla o quitarla según sea necesario.
            this.t_EstFisicoTableAdapter.Fill(this.dSDatos.T_EstFisico);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_EstFisicoTableAdapter.Update(dSDatos.T_EstFisico);
        }

        private void FrmEstado_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_EstFisicoTableAdapter.Update(dSDatos.T_EstFisico);
        }
    }
}