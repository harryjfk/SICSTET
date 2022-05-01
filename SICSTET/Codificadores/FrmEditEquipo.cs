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
    public partial class FrmEditEquipo : DevExpress.XtraEditors.XtraForm
    {
        public FrmEditEquipo()
        {
            InitializeComponent();
        }

        private void t_EquipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_EquipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }
        public void setequipo(int equip)
        {
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            if (equip == -1)
            {
                t_EquipoBindingSource.AddNew();
                t_EquipoBindingSource.MoveLast();
                
            }
            else
                t_EquipoBindingSource.Filter = "idequipo = " + equip;

            
        }

        private void FrmEditEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Combustible' Puede moverla o quitarla según sea necesario.
            this.t_CombustibleTableAdapter.Fill(this.dSDatos.T_Combustible);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Provincia' Puede moverla o quitarla según sea necesario.
            this.t_ProvinciaTableAdapter.Fill(this.dSDatos.T_Provincia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Grupo' Puede moverla o quitarla según sea necesario.
            this.t_GrupoTableAdapter.Fill(this.dSDatos.T_Grupo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstFisico' Puede moverla o quitarla según sea necesario.
            this.t_EstFisicoTableAdapter.FillBy(this.dSDatos.T_EstFisico,1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Modelo' Puede moverla o quitarla según sea necesario.
            this.t_ModeloTableAdapter.Fill(this.dSDatos.T_Modelo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empresa' Puede moverla o quitarla según sea necesario.
            this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoEquipo' Puede moverla o quitarla según sea necesario.
            this.t_TipoEquipoTableAdapter.FillBy(this.dSDatos.T_Tipo,1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.FillBy(this.dSDatos.T_Marca,1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
          

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (dxValidationProvider1.Validate())
            {
            t_EquipoBindingSource.EndEdit();

            t_EquipoTableAdapter.Update(dSDatos.T_Equipo);
            Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            t_EquipoBindingSource.CancelEdit();
            
            Close();
        }

        private void tiene_LOCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if  (tiene_LOCheckEdit.Checked)
            {
                layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
   
            }

        }

        private void tiene_SomatonCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (tiene_SomatonCheckEdit.Checked)
            {
                layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
 
            }
        }
    }
}