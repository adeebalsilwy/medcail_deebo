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

namespace medcail_deebo.form.frm_list
{
    public partial class frm_medcheak_list : DevExpress.XtraEditors.XtraForm
    {
        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();

        public int id, code;
        public string name;
        public float price;

        public frm_medcheak_list()
        {
            InitializeComponent();
        }

        private void frm_medcheak_list_Load(object sender, EventArgs e)
        {
         get_data();
        }
        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"
            dgv_medc.DataSource = con.MEDCHEK_TBL.ToList();


            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["CLI_ID"]);
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MEDCHECK_ID"]);
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MEDREQ_TBL"]);
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["CLINC_TBL"]);

            grid_all_medcin.Columns["MEDCHEK_CODE"].Caption = "الكود";
            grid_all_medcin.Columns["MEDCHEK_NAME"].Caption = "اسم الفحص ";
            grid_all_medcin.Columns["MEDCHEK_TYPE"].Caption = " نوع الفحص  ";
            grid_all_medcin.Columns["MEDCHEK_PRICE"].Caption = "السعر  ";
            grid_all_medcin.Columns["MEDCHEK_NOTE"].Caption = "ملاحضات ";



        }

        private void grid_all_medcin_DoubleClick(object sender, EventArgs e)
        {
            get_select();
        }

        void get_select()
        {
            if (grid_all_medcin.RowCount > 0)
            {

                id = Convert.ToInt32(grid_all_medcin.GetFocusedRowCellValue("MEDCHECK_ID").ToString());
             name= grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_NAME").ToString();
                price =float.Parse(grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_PRICE").ToString());
                this.Close();
            }
        }
    }
}