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
    public partial class FrmDestinoLubRec : DevExpress.XtraEditors.XtraForm
    {
        public FrmDestinoLubRec()
        {
            InitializeComponent();
        }

        private void t_DestinoLubRecBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_DestinoLubRecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmDestinoLubRec_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_DestinoLubRec' Puede moverla o quitarla según sea necesario.
            this.t_DestinoLubRecTableAdapter.Fill(this.dSDatos.T_DestinoLubRec);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_DestinoLubRecTableAdapter.Update(dSDatos.T_DestinoLubRec);
        }

        private void FrmDestinoLubRec_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_DestinoLubRecTableAdapter.Update(dSDatos.T_DestinoLubRec);
        }
    }
}