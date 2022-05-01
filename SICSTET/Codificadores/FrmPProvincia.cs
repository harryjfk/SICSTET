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
    public partial class FrmPProvincia : DevExpress.XtraEditors.XtraForm
    {
        public FrmPProvincia()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void t_EstFisicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_EstFisicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Provincia' Puede moverla o quitarla según sea necesario.
            this.t_ProvinciaTableAdapter.Fill(this.dSDatos.T_Provincia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.Fill(this.dSDatos.T_Marca);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstFisico' Puede moverla o quitarla según sea necesario.
            this.t_EstFisicoTableAdapter.Fill(this.dSDatos.T_EstFisico);

        }
    }
}