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
    public partial class frm_cust_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public int coust_id,coust_card;
        public frm_cust_list()
        {
            InitializeComponent();
        }

        private void txt_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void get_data()
        {

            var data = (from c in con.CUST_TBL

                        select new
                        {
                            CUST_ID = c.CUST_ID,
                            CUST_CODE = c.CUST_CODE.ToString(),
                            CUST_F_NAME = c.CUST_F_NAME + " " + c.CUST_S_NAME + " " + c.CUST_T_NAME + " " + c.CUST_L_NAME,
                            CUST_AGE = c.CUST_AGE.ToString(),
                            CUST_ADDRESS = c.CUST_ADDRESS,
                            CUST_MOBLIE1 = c.CUST_MOBLIE1,
                        }).ToList();
            GridControl1.DataSource = data;

            //APO_TBL MEDLIST_TBL VISIT_TBL


            // GridControl1.DataSource = con.CUST_TBL.ToString();

            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_ID"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_BD"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_MOBILE2"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_SAVE_STATE"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_NOTE"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_ID"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CLI_ID"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CLINC_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["APO_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["MEDLIST_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["VISIT_TBL"]);


            dgv_customer.Columns["CUST_CODE"].Caption = "الكود";
            dgv_customer.Columns["CUST_F_NAME"].Caption = "اسم المريض  ";
            dgv_customer.Columns["CUST_AGE"].Caption = " العمر  ";
            dgv_customer.Columns["CUST_MOBLIE1"].Caption = " رقم الهاتف  ";
            dgv_customer.Columns["CUST_ADDRESS"].Caption = " العنوان  ";
        }

        private void frm_cust_list_Load(object sender, EventArgs e)
        {
            get_data();
        }

        void sel()
        {

            if (dgv_customer.RowCount > 0)
            {

                coust_id = Convert.ToInt32(dgv_customer.GetFocusedRowCellValue("CUST_ID").ToString());
           this.Close();
            }
        }
        void search()
        {

            if (txt_search_coust.Text != "")
            {
                var data = (from c in con.CUST_TBL

                            select new
                            {
                                CUST_ID = c.CUST_ID,
                                CUST_CODE = c.CUST_CODE.ToString(),
                                CUST_F_NAME = c.CUST_F_NAME + " " + c.CUST_S_NAME + " " + c.CUST_T_NAME + " " + c.CUST_L_NAME,
                                CUST_BD = c.CUST_AGE.ToString(),
                                CUST_ADDRESS = c.CUST_ADDRESS,
                                CUST_MOBLIE1 = c.CUST_MOBLIE1,
                            }).Where(w => w.CUST_F_NAME.Contains(txt_search_coust.Text)).ToList();

                GridControl1.DataSource = data;

                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_ID"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_BD"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_MOBILE2"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_SAVE_STATE"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_NOTE"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_ID"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CLI_ID"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CLINC_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["APO_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["MEDLIST_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["VISIT_TBL"]);


                dgv_customer.Columns["CUST_CODE"].Caption = "الكود";
                dgv_customer.Columns["CUST_F_NAME"].Caption = "اسم المريض  ";
                dgv_customer.Columns["CUST_AGE"].Caption = " العمر  ";
                dgv_customer.Columns["CUST_MOBLIE1"].Caption = " رقم الهاتف  ";
                dgv_customer.Columns["CUST_ADDRESS"].Caption = " العنوان  ";
            }
            else
            {
                get_data();
            }
        }

        private void txt_search_coust_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            MessageBox.Show(coust_id.ToString());
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            sel();
        }
    }
}