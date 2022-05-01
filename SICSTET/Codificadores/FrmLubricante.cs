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
    public partial class FrmLubricante : DevExpress.XtraEditors.XtraForm
    {
        public FrmLubricante()
        {
            InitializeComponent();
        }

        private void t_LubricanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_LubricanteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmLubricante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTableAdapter.FillBy(this.dSDatos.T_Tipo,4);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_MotivoCambio' Puede moverla o quitarla según sea necesario.
            this.t_MotivoCambioTableAdapter.Fill(this.dSDatos.T_MotivoCambio);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_DestinoLubRec' Puede moverla o quitarla según sea necesario.
            this.t_DestinoLubRecTableAdapter.Fill(this.dSDatos.T_DestinoLubRec);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Lubricante' Puede moverla o quitarla según sea necesario.
            this.t_LubricanteTableAdapter.Fill(this.dSDatos.T_Lubricante);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_LubricanteTableAdapter.Update(dSDatos.T_Lubricante);
        }

        private void FrmLubricante_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_LubricanteTableAdapter.Update(dSDatos.T_Lubricante);
        }
    }
}