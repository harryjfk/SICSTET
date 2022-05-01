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
    public partial class FrmBateria : DevExpress.XtraEditors.XtraForm
    {
        public FrmBateria()
        {
            InitializeComponent();
        }

        private void t_Neumatico_BateriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_Neumatico_BateriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmBateria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_CausasDesint' Puede moverla o quitarla según sea necesario.
            this.t_CausasDesintTableAdapter.FillBy(this.dSDatos.T_CausasDesint,6);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstFisico' Puede moverla o quitarla según sea necesario.
            this.t_EstFisicoTableAdapter.FillBy(this.dSDatos.T_EstFisico,6);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.FillBy(this.dSDatos.T_Marca,6);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Neumatico_Bateria' Puede moverla o quitarla según sea necesario.
            this.t_Neumatico_BateriaTableAdapter.FillBy(this.dSDatos.T_Neumatico_Bateria,6);
            dSDatos.T_Neumatico_Bateria.idartefactoColumn.DefaultValue = 6;

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_Neumatico_BateriaTableAdapter.Update(dSDatos.T_Neumatico_Bateria);
        }

        private void FrmBateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_Neumatico_BateriaTableAdapter.Update(dSDatos.T_Neumatico_Bateria);
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
         
         
        }
    }
}