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
    public partial class FrmEquipo : DevExpress.XtraEditors.XtraForm
    {
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void t_EquipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_EquipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Grupo' Puede moverla o quitarla según sea necesario.
            this.t_GrupoTableAdapter.Fill(this.dSDatos.T_Grupo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empresa' Puede moverla o quitarla según sea necesario.
            this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Provincia' Puede moverla o quitarla según sea necesario.
            this.t_ProvinciaTableAdapter.Fill(this.dSDatos.T_Provincia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstFisico' Puede moverla o quitarla según sea necesario.
            this.t_EstFisicoTableAdapter.FillBy(this.dSDatos.T_EstFisico,1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Modelo' Puede moverla o quitarla según sea necesario.
            this.t_ModeloTableAdapter.Fill(this.dSDatos.T_Modelo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoEquipo' Puede moverla o quitarla según sea necesario.
            this.t_TipoEquipoTableAdapter.FillBy(this.dSDatos.T_Tipo,1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            this.t_MarcaTableAdapter.FillBy(this.dSDatos.T_Marca,1);
            
            if (t_EquipoBindingSource.Count>0)
                
            t_EquipoBindingSource.Position = 0;
        t_EquipoBindingSource_CurrentChanged(t_EquipoBindingSource,null);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_EquipoTableAdapter.Update(this.dSDatos.T_Equipo);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var eq = new FrmEditEquipo();
            eq.setequipo(-1);
            eq.ShowDialog(this);
            t_EquipoTableAdapter.Fill(dSDatos.T_Equipo);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var eq = new FrmEditEquipo();

            eq.setequipo(((DSDatos.T_EquipoRow)((DataRowView)t_EquipoBindingSource.Current).Row).IDEquipo);
            eq.Show(this);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            t_EquipoBindingSource.RemoveCurrent();
            t_EquipoBindingSource.EndEdit();
            t_EquipoTableAdapter.Update(dSDatos.T_Equipo);

        }

        private void t_EquipoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            barButtonItem2.Enabled = t_EquipoBindingSource.Count > 0;
            barButtonItem3.Enabled = barButtonItem2.Enabled;
        }
    }
}