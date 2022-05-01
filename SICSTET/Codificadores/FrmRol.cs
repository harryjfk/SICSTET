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
    public partial class FrmRol : DevExpress.XtraEditors.XtraForm
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        private void t_RolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_RolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Rol' Puede moverla o quitarla según sea necesario.
            this.t_RolTableAdapter.Fill(this.dSDatos.T_Rol);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_RolTableAdapter.Update(dSDatos.T_Rol);
        }

        private void FrmRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_RolTableAdapter.Update(dSDatos.T_Rol);
        }
    }
}