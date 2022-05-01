using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACINOX.Components.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using SICSTET.Codificadores;


namespace SICSTET
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
           
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void CreateForm(Form form)
        {
            //foreach(Control f in Controls)
            //    if (f is MdiClient)
            //    {

            //    }
            form.MdiParent = this;
            form.Show();
            pictureBox1.Visible = false;
        }


        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
       
            }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmEquipo());
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmProvincia());
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmEmpresa());
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmGrupo());
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmModelo());
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmLubricante());
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmMotivoCambio());
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmDestinoLubRec());
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmNeumatico());
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmMarca());
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmTipo());
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmBateria());
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmEstado());
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmCausasDesint());
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmUsuario());
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmRol());
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_CalculoTableAdapter();

            P.Fill(DS.p_Calculo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\KmReal.repx",
                                          DS.p_Calculo, null);
            CreateForm(report);
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEquipoPorLubricante eq = new FrmEquipoPorLubricante();
            if (eq.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            {
                
                var DS = new DSReport();
                var P = new DSReportTableAdapters.P_LubricantesTableAdapter();
                
                P.Fill(DS.P_Lubricantes,(DateTime?) eq.fecha_CambioDateEdit.EditValue); 
                
                FrmReport report  =new FrmReport();
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\EquiposPorCambioLubricante.repx",
                                              DS.P_Lubricantes, null);
                CreateForm(report);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_ModeloEquipoTableAdapter();

            P.Fill(DS.p_ModeloEquipo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Modelo.repx",
                                          DS.p_ModeloEquipo, null);
            CreateForm(report);
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            FSave save = new FSave { Save = true, Connection = Properties.Settings.Default.sicstetConnectionString1 };
            save.ShowDialog(this);
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            FSave save = new FSave { Save = false, Connection = Properties.Settings.Default.sicstetConnectionString1 };
            save.ShowDialog(this);
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmEquipo());
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmLubricante());
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmNeumatico());
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmBateria());
        }

        private DSDatos.T_UsuarioRow Fuser;
        public DSDatos.T_UsuarioRow User { get { return Fuser; }

            set { Fuser = value;
            if (value.IDRol != 1)
                ribbonPage1.Visible = false;

            }
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_MarcasssTableAdapter();

            P.Fill(DS.p_Marcasss);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\marcas.repx",
                                          DS.p_Marcasss, null);
            CreateForm(report);
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_CalculoTableAdapter();

            P.Fill(DS.p_Calculo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Ind_ConsReal.repx",
                                          DS.p_Calculo, null);
            CreateForm(report);
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_CalculoTableAdapter();

            P.Fill(DS.p_Calculo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\CombReal.repx",
                                          DS.p_Calculo, null);
            CreateForm(report);
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.P_NeumaticosTableAdapter();

            P.Fill(DS.P_Neumaticos);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\neumaticos.repx",
                                          DS.P_Neumaticos, null);
            CreateForm(report);
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.P_BateriasTableAdapter();

            P.Fill(DS.P_Baterias);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\baterias.repx",
                                          DS.P_Baterias, null);
            CreateForm(report);
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.P_LubricantesTableAdapter();

            P.Fill(DS.P_Lubricantes,null);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\lubricantes.repx",
                                          DS.P_Lubricantes, null);
            CreateForm(report);
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEquipoPorLubricante eq = new FrmEquipoPorLubricante();
            if (eq.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            {
                
                var DS = new DSReport();
                var P = new DSReportTableAdapters.P_LubricantesTableAdapter();
                
                P.Fill(DS.P_Lubricantes,(DateTime?) eq.fecha_CambioDateEdit.EditValue); 
                
                FrmReport report  =new FrmReport();
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\EquiposPorCambioLubricante.repx",
                                              DS.P_Lubricantes, null);
                CreateForm(report);
        }
    }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_CalculoTableAdapter();

            P.Fill(DS.p_Calculo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Ind_ConsReal.repx",
                                          DS.p_Calculo, null);
            CreateForm(report);
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_CalculoTableAdapter();

            P.Fill(DS.p_Calculo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\CombReal.repx",
                                          DS.p_Calculo, null);
            CreateForm(report);
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DS = new DSReport();
            var P = new DSReportTableAdapters.p_CalculoTableAdapter();

            P.Fill(DS.p_Calculo);

            FrmReport report = new FrmReport();
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\KmReal.repx",
                                          DS.p_Calculo, null);
            CreateForm(report);
        }
    }
}