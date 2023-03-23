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
    public partial class frm_service_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();

        public frm_service_list()
        {
            InitializeComponent();
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
                List<db.SERVICE_TBL> tbl = con.SERVICE_TBL.Where(x => x.SER_NAME.Contains(txt_search.Text) || x.SER_TYPE.Contains(txt_search.Text)).ToList();
                dgv_ser.DataSource = tbl;
            }
            else
                dgv_ser.DataSource = con.SERVICE_TBL.ToList();

            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SERLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);

            gridView1.Columns["SER_CODE"].Caption = "الكود";
            gridView1.Columns["SER_NAME"].Caption = "اسم الخدمه ";
            gridView1.Columns["SER_TYPE"].Caption = "نوع الخدمه";
            gridView1.Columns["SER_PRICE"].Caption = "السعر";
            gridView1.Columns["SER_NOTE"].Caption = " ملاحضات  ";



        }

        private void frm_service_list_Load(object sender, EventArgs e)
        {
            get_data();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            get_data();
        }
    }
}