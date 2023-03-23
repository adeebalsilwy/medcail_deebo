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

namespace medcail_deebo.form.form_list
{
    public partial class frm_doct_list : DevExpress.XtraEditors.XtraForm
    {
       
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public int doc_id;
        public frm_doct_list()
        {
            InitializeComponent();
        }

        private void frm_user_list_Load(object sender, EventArgs e)
        {
            txt_search.Text = "";
            search();
        }

       
        void search()
        {
            if (txt_search.Text != "")
            {
                List<db.DOCTORS_TBL> tbl = con.DOCTORS_TBL.Where(x => x.DOC_NAME.Contains(txt_search.Text) || x.DOC_MAJOR.Contains(txt_search.Text)).ToList();
                dgv_doct.DataSource = tbl;
            }
            else
            {
                dgv_doct.DataSource = con.DOCTORS_TBL.ToList();
            }
                gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
                gridView1.Columns.Remove(gridView1.Columns["VISIT_TBL"]);
                gridView1.Columns["DOC_CODE"].Caption = "الكود";
                gridView1.Columns["DOC_NAME"].Caption = "اسم الدكتور";
                gridView1.Columns["DOC_MAJOR"].Caption = "التخصص";
                gridView1.Columns["DOC_EXP"].Caption = "الخبره";
                gridView1.Columns["DOC_BD"].Caption = "الميلاد";
                gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
                gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";
            

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                doc_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("DOC_ID"));
                this.Close();
            }
        }
    }
}