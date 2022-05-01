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
    public partial class FrmGrupo : DevExpress.XtraEditors.XtraForm
    {
        public FrmGrupo()
        {
            InitializeComponent();
        }

        private void t_GrupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_GrupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Grupo' Puede moverla o quitarla según sea necesario.
            this.t_GrupoTableAdapter.Fill(this.dSDatos.T_Grupo);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_GrupoTableAdapter.Update(dSDatos.T_Grupo);
        }

        private void FrmGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_GrupoTableAdapter.Update(dSDatos.T_Grupo);
        }
    }
}