using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.frm_list
{
    public partial class frm_medcin_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public frm_medcin_list()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            get_data();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"
            if (txt_search.Text != "")
            {
                List<db.MEDCIN_TBL> tbl = con.MEDCIN_TBL.Where(x => x.MED_NAME.Contains(txt_search.Text) || x.MED_S_NAME.Contains(txt_search.Text) || x.MED_SOURSE.Contains(txt_search.Text)).ToList();
                dgv_medcin.DataSource = tbl;
            }
            else
                dgv_medcin.DataSource = con.MEDCIN_TBL.ToList();


            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MED_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);

            gridView1.Columns["MED_CODE"].Caption = "الكود";
            gridView1.Columns["MED_NAME"].Caption = "اسم الدواء ";
            gridView1.Columns["MED_S_NAME"].Caption = "الاسم العلمي ";
            gridView1.Columns["MED_SOURSE"].Caption = "المصدر ";
            gridView1.Columns["MED_PRICE"].Caption = "السعر";



        }

        private void frm_medcin_list_Load(object sender, EventArgs e)
        {
            get_data();
        }
    }
}