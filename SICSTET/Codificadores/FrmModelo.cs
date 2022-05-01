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
    public partial class FrmModelo : DevExpress.XtraEditors.XtraForm
    {
        public FrmModelo()
        {
            InitializeComponent();
        }

        private void t_ModeloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ModeloBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Modelo' Puede moverla o quitarla según sea necesario.
            this.t_ModeloTableAdapter.Fill(this.dSDatos.T_Modelo);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_ModeloTableAdapter.Update(dSDatos.T_Modelo);
        }

        private void FrmModelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_ModeloTableAdapter.Update(dSDatos.T_Modelo);
        }
    }
}