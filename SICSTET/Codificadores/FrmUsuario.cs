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
    public partial class FrmUsuario : DevExpress.XtraEditors.XtraForm
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void t_UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_UsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Rol' Puede moverla o quitarla según sea necesario.
            this.t_RolTableAdapter.Fill(this.dSDatos.T_Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Usuario' Puede moverla o quitarla según sea necesario.
            this.t_UsuarioTableAdapter.Fill(this.dSDatos.T_Usuario);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_UsuarioTableAdapter.Update(dSDatos.T_Usuario);
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_UsuarioTableAdapter.Update(dSDatos.T_Usuario);
        }
    }
}