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
    public partial class frm_user_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public frm_user_list()
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
                List<db.USERS_TBL> tbl = con.USERS_TBL.Where(x => x.USER_NAME.Contains(txt_search.Text) || x.USER_TYPE.Contains(txt_search.Text)).ToList();
                dgv_user.DataSource = tbl;
            }
            else
                dgv_user.DataSource = con.USERS_TBL.ToList();
            gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);

            gridView1.Columns["USER_CODE"].Caption = "الكود";
            gridView1.Columns["USER_NAME"].Caption = "اسم المستخدم";
            gridView1.Columns["USER_PASSWORD"].Caption = "كلمه السر";
            gridView1.Columns["USER_TYPE"].Caption = "الصلاحيه ";
            gridView1.Columns["CLI_ID"].Caption = "اسم الع ياده ";
           
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}