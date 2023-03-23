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
    public partial class frm_servic : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id = 0, code;
        public frm_servic()
        {
            InitializeComponent();
        }
        void get_delete()
        {

            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.SERVICE_TBL del_com = con.SERVICE_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.SERVICE_TBL.Remove(del_com);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }

        void get_select()
        {
            if (gridView1.RowCount > 0)
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SER_ID").ToString());
                txt_ser_code.Text = gridView1.GetFocusedRowCellValue("SER_CODE").ToString();
                txt_ser_name.Text = gridView1.GetFocusedRowCellValue("SER_NAME").ToString();
                txt_ser_type.Text = gridView1.GetFocusedRowCellValue("SER_TYPE").ToString();
                txt_ser_price.Text = gridView1.GetFocusedRowCellValue("SER_PRICE").ToString();
                txt_ser_note.Text = gridView1.GetFocusedRowCellValue("SER_NOTE").ToString();
                // txt_com_address.Text = gridView1.GetFocusedRowCellValue("COM_ADDRESS").ToString();

            }
        }
        void clear()
        {
            id = 0;
            txt_ser_code.Text = "";
            txt_ser_name.Text = "";
            txt_ser_type.Text = "";
            txt_ser_price.Text = "";
            txt_ser_note.Text = "";
            get_cod();

        }
        void get_cod()
        {
            string temp_code = con.SERVICE_TBL.Max(w => w.SER_CODE).ToString();
            if (temp_code == "")
            {
                txt_ser_code.Text = (1).ToString();
            }
            else
            {
                txt_ser_code.Text = (Convert.ToInt32(temp_code) + 1).ToString();
            }
        }
        bool is_empty()
        {
            if (txt_ser_code.Text != "" && txt_ser_name.Text != "" && txt_ser_price.Text != "" && txt_ser_type.Text != "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void add_service()
        {
            if (is_empty() != true)
            {
                try
                {
                    db.SERVICE_TBL com = new db.SERVICE_TBL();
                    com.SER_CODE = Convert.ToInt32(txt_ser_code.Text);
                    com.SER_TYPE = txt_ser_type.Text;
                    com.SER_NOTE = txt_ser_note.Text;
                    com.SER_PRICE = txt_ser_price.Text;
                    com.SER_NAME = txt_ser_name.Text;
                    if (id != 0)
                    {
                        com.SER_ID = id;
                    }
                    con.SERVICE_TBL.AddOrUpdate(com);
                    con.SaveChanges();
                    if (id != 0)
                    {
                        MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        MessageBox.Show("تمت الاضافه بنجاح ");
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                get_data();
                clear();

            }
            else
            {
                MessageBox.Show("الرجاء ادخال جميع البيانات ");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_service();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_service();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            get_delete();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frm_servic_Load(object sender, EventArgs e)
        {
            get_data();
            clear();
           
        }

        private void txt_ser_note_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
            get_select();
        }

        private void txt_ser_price_EditValueChanged(object sender, EventArgs e)
        {

        }

        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"
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
    }
}