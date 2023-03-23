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
    public partial class frm_card_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
       public int card_id = 0, cod;
        public frm_card_list()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        private void frm_card_list_Load(object sender, EventArgs e)
        {
            get_data();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            get_data();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                sel();
                this.Close();
            }
            }
            void sel(){
            card_id =Convert.ToInt32( gridView1.GetFocusedRowCellValue("CARD_ID"));
            }
        void get_data()
        {
            int a=0;
           int  ce = 0;
            try {
               a= Convert.ToInt32(txt_search.Text);
                    ce = 1;
            }
            catch( Exception e)
            { ce = 0;
            }
            //remove from dgv

            if (txt_search.Text != "")
            {
                if (ce == 1)
                {
                    List<db.CARD_TBL> tb = con.CARD_TBL.Where(x => x.CARD_CODE==(a)).ToList();
                    dgv_card.DataSource = tb;

                }
                else
                {
                    List<db.CARD_TBL> tbl = con.CARD_TBL.Where(x => x.CARD_NAME.Contains(txt_search.Text) ).ToList();
                    dgv_card.DataSource = tbl;
                }
            }
            else
            dgv_card.DataSource = con.CARD_TBL.ToList();
            gridView1.Columns.Remove(gridView1.Columns["CARD_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["COMPANY_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_NOTE"]);

            ///
            gridView1.Columns["CARD_CODE"].Caption = "الكود";
            gridView1.Columns["CARD_NAME"].Caption = "اسم البطاقه ";
            gridView1.Columns["CARD_DATE"].Caption = "تاريخ البطاقه ";
            gridView1.Columns["CARD_STATE"].Caption = "حاله البطاقه ";
            gridView1.Columns["CARD_PER"].Caption = "نسبة التامين ";
            //gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
            //gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";
        }

    }
}