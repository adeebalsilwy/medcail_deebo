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
    public partial class frm_com_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public int com_id=0;
        public frm_com_list()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            get_data();
        }

        private void frm_com_list_Load(object sender, EventArgs e)
        {
            get_data();
        }
        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"

            if (txt_search.Text != "")
            {
                List<db.COMPANY_TBL> tbl = con.COMPANY_TBL.Where(x => x.COM_NAME.Contains(txt_search.Text) || x.COM_ADDRESS.Contains(txt_search.Text)).ToList();
                dgv_com.DataSource = tbl;
            }
            else
            {
                dgv_com.DataSource = con.COMPANY_TBL.ToList();
            }
            gridView1.Columns.Remove(gridView1.Columns["CARD_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);

            gridView1.Columns["COM_CODE"].Caption = "الكود";
            gridView1.Columns["COM_NAME"].Caption = "اسم الشركه ";
            gridView1.Columns["COM_ADDRESS"].Caption = "العنوان";
            gridView1.Columns["COM_MOBILE1"].Caption = "الهاتف";
            gridView1.Columns["COM_STATE"].Caption = " الحاله ";



        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            get_data();
        }

        private void frm_com_list_Activated(object sender, EventArgs e)
        {
            get_data();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
           
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                com_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("COM_ID").ToString());
                this.Close();
            }
        }
    }
}