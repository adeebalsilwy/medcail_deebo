using DevExpress.XtraEditors;
using medcail_deebo.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.fm_med
{
    public partial class frm_medcin_menucs : DevExpress.XtraEditors.XtraForm
    {
        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();

        public frm_medcin_menucs()
        {
            InitializeComponent();
        }

        private void frm_medcin_menucs_Load(object sender, EventArgs e)
        {
            get_data_medcin();
            inshal();
        }
        void inshal()
        {
            com_doc_time.DataSource=con.DOS_TBL.Where(w=>w.DOS_TYPE.Equals(com_doc_time.Tag.ToString())).ToList();
            com_doc_larg.DataSource = con.DOS_TBL.Where(w => w.DOS_TYPE.Equals(com_doc_larg.Tag.ToString())).ToList();
            com_doc_gend.DataSource = con.DOS_TBL.Where(w => w.DOS_TYPE.Equals(com_doc_gend.Tag.ToString())).ToList();
            com_doc_count.DataSource = con.DOS_TBL.Where(w => w.DOS_TYPE.Equals(com_doc_count.Tag.ToString())).ToList();

            com_doc_time.DisplayMember = "DOS_NAME";
            com_doc_time.ValueMember = "DOS_ID";
            
            com_doc_larg.DisplayMember = "DOS_NAME";
            com_doc_larg.ValueMember = "DOS_ID";

            com_doc_gend.DisplayMember = "DOS_NAME";
            com_doc_gend.ValueMember = "DOS_ID";
            
            com_doc_count.DisplayMember = "DOS_NAME";
            com_doc_count.ValueMember = "DOS_ID";

        }
        void get_resent_medine()
        {
            grb_dag.Text = "قائمه الاكثر استخداما ";
           // string search = "";
            var query = (from d in con.MEDCIN_TBL
                         join
                  dl in con.MEDLIST_TBL on
                      d.MED_ID equals dl.MED_ID
                         group new { d, dl } by new { d.MED_NAME, d.MED_S_NAME, d.MED_SOURSE, d.MED_PRICE, d.MED_CODE ,d.MED_ID} into newgroup
                         select new
                         {

                             MED_CODE = newgroup.Key.MED_CODE,
                             id=newgroup.Key.MED_ID,
                             MED_NAME = newgroup.Key.MED_NAME,
                             MED_S_NAME = newgroup.Key.MED_S_NAME,
                             MED_SOURSE = newgroup.Key.MED_SOURSE,
                             MED_PRICE = newgroup.Key.MED_PRICE,



                             MEDCHEK_NOTE = newgroup.Count()
                         }).ToList();


            dgv_medc.DataSource = query.Where(w => w.MEDCHEK_NOTE > 20).OrderByDescending(w => w.MEDCHEK_NOTE).ToList();

            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MED_ID"]);

            grid_all_medcin.Columns["MED_CODE"].Caption = "الكود";
            grid_all_medcin.Columns["MED_NAME"].Caption = "اسم الدواء ";
            grid_all_medcin.Columns["MED_S_NAME"].Caption = "الاسم العلمي ";
            grid_all_medcin.Columns["MED_SOURSE"].Caption = "المصدر ";
            grid_all_medcin.Columns["MED_PRICE"].Caption = "السعر";

           


        }

        void get_data_medcin()
        {
            //string s = "CARD_TBL   CLINC_TBL"
           
                dgv_medc.DataSource = con.MEDCIN_TBL.ToList();


            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["CLI_ID"]);
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MED_ID"]);
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MEDLIST_TBL"]);
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["CLINC_TBL"]);

            grid_all_medcin.Columns["MED_CODE"].Caption = "الكود";
            grid_all_medcin.Columns["MED_NAME"].Caption = "اسم الدواء ";
            grid_all_medcin.Columns["MED_S_NAME"].Caption = "الاسم العلمي ";
            grid_all_medcin.Columns["MED_SOURSE"].Caption = "المصدر ";
            grid_all_medcin.Columns["MED_PRICE"].Caption = "السعر";



        }

        private void btn_mor_using_Click(object sender, EventArgs e)
        {
            get_resent_medine();
        }
    }
}