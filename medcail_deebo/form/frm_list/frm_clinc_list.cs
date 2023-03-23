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
    public partial class frm_clinc_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public int  clin_id;
        public frm_clinc_list()
        {
            InitializeComponent();
        }

        private void frm_clinc_list_Load(object sender, EventArgs e)
        {
            search();
        }
       
        void search()
        {
            if (txt_search.Text != "")
            {
                List<db.CLINC_TBL> tbl = con.CLINC_TBL.Where(x => x.CLI_NAME.Contains(txt_search.Text) || x.CLI_LOC.Contains(txt_search.Text)).ToList();
                dgv_clinc.DataSource = tbl;
            }
            else
                dgv_clinc.DataSource = con.CLINC_TBL.ToList();
            gridView1.Columns.Remove(gridView1.Columns["MEDCHEK_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDCIN_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDREQ_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["SERLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["SERVICE_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["USERS_TBL"]);

            gridView1.Columns.Remove(gridView1.Columns["COMPANY_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DIAGNOIS_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DIGLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DOCTORS_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DOS_TBL"]);

            gridView1.Columns.Remove(gridView1.Columns["APO_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["VISIT_TBL"]);
            gridView1.Columns["CLI_CODE"].Caption = "الكود";
            gridView1.Columns["CLI_NAME"].Caption = "اسم العياده ";
            gridView1.Columns["CLI_LOC"].Caption = "الموقع ";
            gridView1.Columns["CLI_NOTE"].Caption = "ملاحضات ";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text="";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                clin_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CLI_ID").ToString());
                this.Close();
            }
        }
    }
}