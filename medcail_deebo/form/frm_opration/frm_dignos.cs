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
    public partial class frm_dignos : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id = 0, code;
        public frm_dignos()
        {
            InitializeComponent();
        }

        private void frm_dignos_Load(object sender, EventArgs e)
        {
            get_data();
            clear();
        }
        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"
            dgv_digno.DataSource = con.DIAGNOIS_TBL.ToList();


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
        void get_delete()
        {

            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.DIAGNOIS_TBL del_com = con.DIAGNOIS_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.DIAGNOIS_TBL.Remove(del_com);
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
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("DIG_ID").ToString());
                txt_digno_code.Text = gridView1.GetFocusedRowCellValue("DIG_CODE").ToString();
                txt_digno_name.Text = gridView1.GetFocusedRowCellValue("DIG_NAME").ToString();
                txt_digno_note.Text = gridView1.GetFocusedRowCellValue("DIG_TYPE").ToString();
                txt_digno_type.Text = gridView1.GetFocusedRowCellValue("DIG_NOTE").ToString();

            }
        }
        void clear()
        {
            id = 0;
            txt_digno_type.Text = "";
            txt_digno_note.Text = "";
            txt_digno_name.Text = "";
            txt_digno_code.Text = "";
            get_cod();

        }
        void get_cod()
        {
            string temp_code = con.DIAGNOIS_TBL.Max(w => w.DIG_CODE).ToString();
            if (temp_code == "")
            {
                txt_digno_code.Text = (1).ToString();
            }
            else
            {
                txt_digno_code.Text = (Convert.ToInt32(temp_code) + 1).ToString();
            }
        }
        bool is_empty()
        {
            if (txt_digno_code.Text != "" && txt_digno_name.Text != "" && txt_digno_note.Text != "" && txt_digno_type.Text != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_dignos();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_dignos();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            get_delete();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            get_data();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_select();
        }

        void add_dignos()
        {
            if (is_empty() != true)
            {
                try
                {
                    db.DIAGNOIS_TBL com = new db.DIAGNOIS_TBL();
                    com.DIG_CODE = Convert.ToInt32(txt_digno_code.Text);
                    com.DIG_NOTE = txt_digno_note.Text;
                    com.DIG_TYPE = txt_digno_type.Text;
                    com.DIG_NAME = txt_digno_name.Text;
                    if (id != 0)
                    {
                        com.DIG_ID = id;
                    }
                    con.DIAGNOIS_TBL.AddOrUpdate(com);
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
     }
}