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
    public partial class FrmEquipoPorLubricante : DevExpress.XtraEditors.XtraForm
    {
        public FrmEquipoPorLubricante()
        {
            InitializeComponent();
        }

        private void t_LubricanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_LubricanteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmEquipoPorLubricante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Lubricante' Puede moverla o quitarla según sea necesario.
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}