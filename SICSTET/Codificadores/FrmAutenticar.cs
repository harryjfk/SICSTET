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
    public partial class FrmAutenticar : DevExpress.XtraEditors.XtraForm
    {
        public FrmAutenticar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void t_UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_UsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmAutenticar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Usuario' Puede moverla o quitarla según sea necesario.
            this.t_UsuarioTableAdapter.Fill(this.dSDatos.T_Usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_UsuarioBindingSource.Filter = " Usuario = '" + textEdit1.Text + "' and Contrasenna = '" + textEdit2.Text+"'";
            if (t_UsuarioBindingSource.Count == 0)
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            else
            {
                var main = new MainForm();


                main.User = (DSDatos.T_UsuarioRow)((DataRowView)t_UsuarioBindingSource.Current).Row;  
                 main.Show();
                Hide();
                

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}