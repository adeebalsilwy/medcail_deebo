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
    public partial class frm_dignos_listcs : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public frm_dignos_listcs()
        {
            InitializeComponent();
        }

        private void frm_dignos_Load(object sender, EventArgs e)
        {
            get_data();
        }
        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"
            if (txt_search.Text != "")
            {
                List<db.DIAGNOIS_TBL> tbl = con.DIAGNOIS_TBL.Where(x => x.DIG_NAME.Contains(txt_search.Text) || x.DIG_TYPE.Contains(txt_search.Text)).ToList();
                dgv_dog.DataSource = tbl;
            }
            else
            {
                dgv_dog.DataSource = con.DIAGNOIS_TBL.ToList();


                gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["DIG_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["DIGLIST_TBL"]);
                gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);

                gridView1.Columns["DIG_CODE"].Caption = "الكود";
                gridView1.Columns["DIG_NAME"].Caption = "اسم التشيخص ";
                gridView1.Columns["DIG_TYPE"].Caption = "نوع التشيخص";
                gridView1.Columns["DIG_NOTE"].Caption = "ملاحضات ";
                // gridView1.Columns["SER_NOTE"].Caption = " ملاحضات  ";
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            get_data();
        }
    }
}