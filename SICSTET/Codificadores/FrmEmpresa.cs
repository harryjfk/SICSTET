using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SICSTET.Codificadores
{
    public partial class FrmEmpresa : DevExpress.XtraEditors.XtraForm
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void t_EmpresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_EmpresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empresa' Puede moverla o quitarla según sea necesario.
            this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_EmpresaTableAdapter.Update(dSDatos.T_Empresa);
        }

        private void FrmEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_EmpresaTableAdapter.Update(dSDatos.T_Empresa);
        }

        private bool IsNum(char c)
        {
            string s ="";
            s += c;
            short r = 0;
            return Int16.TryParse(s,out r);
        }
        private bool HasNum(string  str)
        {
            foreach (char s in str)
                if (IsNum(s))
                    return true;
            return false;


        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
    
            
            if (HasNum(((DSDatos.T_EmpresaRow)((System.Data.DataRowView)e.Row).Row).Empresa ))
            {
                e.ErrorText = "El Nombre no puede contener numeros.";
                e.Valid = false;
            }
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
     
        }

        private void t_EmpresaGridControl_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}