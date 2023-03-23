using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.frm_opration
{
    public partial class frm_medchek : DevExpress.XtraEditors.XtraForm
    {

        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id = 0, code;
        public frm_medchek()
        {
            InitializeComponent();
        }

        private void frm_medchek_Load(object sender, EventArgs e)
        {
            get_data();
            clear();
        }
        void add_medcin()
        {
            if (is_empty() != true)
            {
                try
                {
                    db.MEDCHEK_TBL mes = new db.MEDCHEK_TBL();
                    mes.MEDCHEK_CODE = Convert.ToInt32(txt_med_cheak_code.Text);
                    mes.MEDCHEK_NAME = txt_med_cheak_name.Text;
                    mes.MEDCHEK_NOTE = txt_med_cheak_note.Text;
                    mes.MEDCHEK_TYPE = txt_med_cheak_type.Text;
                    mes.MEDCHEK_PRICE = Convert.ToDecimal(txt_med_cheak_price.Text);
                    if (id != 0)
                    {
                        mes.MEDCHECK_ID = id;
                    }
                    con.MEDCHEK_TBL.AddOrUpdate(mes);
                    con.SaveChanges();
                    if (id != 0)
                    {
                        MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        MessageBox.Show("تمت الاضافه بنجاح ");
                    }


                    clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                get_data();
              
            }
            else
            {
                MessageBox.Show("الرجاء ادخال جميع البيانات ");
            }
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
        void get_delete()
        {

            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.MEDCHEK_TBL del_com = con.MEDCHEK_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.MEDCHEK_TBL.Remove(del_com);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }

        void get_select()
        {
            if (grid_all_medcin.RowCount > 0)
            {

                id = Convert.ToInt32(grid_all_medcin.GetFocusedRowCellValue("MEDCHECK_ID").ToString());
                txt_med_cheak_code.Text = grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_CODE").ToString();
                txt_med_cheak_name.Text = grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_NAME").ToString();
                txt_med_cheak_price.Text = grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_PRICE").ToString();
                txt_med_cheak_type.Text = grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_TYPE").ToString();
                txt_med_cheak_note.Text = grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_NOTE").ToString();

            }
        }
        void clear()
        {
            id = 0;
            txt_med_cheak_code.Text = "";
            txt_med_cheak_name.Text = "";
            txt_med_cheak_note.Text = "";
            txt_med_cheak_price.Text = "";
            txt_med_cheak_type.Text = "";
            get_cod();

        }
        bool is_empty()
        {
            if (txt_med_cheak_code.Text != "" && txt_med_cheak_name.Text != "" && txt_med_cheak_price.Text != "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grid_all_medcin_DoubleClick(object sender, EventArgs e)
        {
            get_select();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            add_medcin();
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            add_medcin();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            get_delete();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        void get_cod()
        {
            string temp_code = con.MEDCHEK_TBL.Max(w => w.MEDCHEK_CODE).ToString();
            if (temp_code == "")
            {
                txt_med_cheak_code.Text = (1).ToString();
            }
            else
            {
                txt_med_cheak_code.Text = (Convert.ToInt32(temp_code) + 1).ToString();
            }
        }

    }
}