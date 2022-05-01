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
    public partial class FrmTipo : DevExpress.XtraEditors.XtraForm
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void t_MarcaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_MarcaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void XtraForm2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTableAdapter.Fill(this.dSDatos.T_Tipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoArtefacto' Puede moverla o quitarla según sea necesario.
            this.t_TipoArtefactoTableAdapter.Fill(this.dSDatos.T_TipoArtefacto);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.Fill(this.dSDatos.T_Marca);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoTableAdapter.Update(dSDatos.T_Tipo);
        }

        private void XtraForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_TipoTableAdapter.Update(dSDatos.T_Tipo);
        }
    }
}