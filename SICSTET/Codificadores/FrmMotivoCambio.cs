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
    public partial class FrmMotivoCambio : DevExpress.XtraEditors.XtraForm
    {
        public FrmMotivoCambio()
        {
            InitializeComponent();
        }

        private void t_MotivoCambioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_MotivoCambioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmMotivoCambio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_MotivoCambio' Puede moverla o quitarla según sea necesario.
            this.t_MotivoCambioTableAdapter.Fill(this.dSDatos.T_MotivoCambio);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_MotivoCambioTableAdapter.Update(dSDatos.T_MotivoCambio);
        }

        private void t_MotivoCambioGridControl_Click(object sender, EventArgs e)
        {

        }

        private void FrmMotivoCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_MotivoCambioTableAdapter.Update(dSDatos.T_MotivoCambio);
        }
    }
}