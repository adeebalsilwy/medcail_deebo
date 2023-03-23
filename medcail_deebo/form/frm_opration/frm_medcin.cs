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
    public partial class frm_medcin : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id = 0, code;
        public frm_medcin()
        {
            InitializeComponent();
        }

        private void frm_medcin_Load(object sender, EventArgs e)
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
                    db.MEDCIN_TBL mes = new db.MEDCIN_TBL();
                    mes.MED_CODE = Convert.ToInt32(txt_med_code.Text);
                    mes.MED_SOURSE = txt_med_prof.Text;
                    mes.MED_S_NAME = txt_med_ex_name.Text;
                    mes.MED_NAME = txt_med_name.Text;
                    mes.MED_PRICE =Convert.ToDecimal(txt_med_price.Text);
                    if (id != 0)
                    {
                        mes.MED_ID = id;
                    }
                    con.MEDCIN_TBL.AddOrUpdate(mes);
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
        void get_data()
        {
            //string s = "CARD_TBL   CLINC_TBL"
            dgv_medcin.DataSource = con.MEDCIN_TBL.ToList();


            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MED_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);

            gridView1.Columns["MED_CODE"].Caption = "الكود";
            gridView1.Columns["MED_NAME"].Caption = "اسم الدواء ";
            gridView1.Columns["MED_S_NAME"].Caption = "الاسم العلمي ";
            gridView1.Columns["MED_SOURSE"].Caption = "المصدر ";
             gridView1.Columns["MED_PRICE"].Caption = "السعر";



        }
        void get_delete()
        {

            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.MEDCIN_TBL del_com = con.MEDCIN_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.MEDCIN_TBL.Remove(del_com);
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
                
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MED_ID").ToString());
                    txt_med_code.Text = gridView1.GetFocusedRowCellValue("MED_CODE").ToString();
                    txt_med_name.Text = gridView1.GetFocusedRowCellValue("MED_NAME").ToString();
                    txt_med_prof.Text = gridView1.GetFocusedRowCellValue("MED_SOURSE").ToString();
                    txt_med_ex_name.Text = gridView1.GetFocusedRowCellValue("MED_S_NAME").ToString();
                    txt_med_price.Text = gridView1.GetFocusedRowCellValue("MED_PRICE").ToString();

                }
        }
        void clear()
        {
            id = 0;
            txt_med_ex_name.Text = "";
            txt_med_prof.Text = "";
            txt_med_name.Text = "";
            txt_med_code.Text = "";
            txt_med_price.Text = "";
            get_cod();

        }
        void get_cod()
        {
            string temp_code = con.MEDCIN_TBL.Max(w => w.MED_CODE).ToString();
            if (temp_code == "")
            {
                txt_med_code.Text = (1).ToString();
            }
            else
            {
                txt_med_code.Text = (Convert.ToInt32(temp_code) + 1).ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_medcin();
        }

        private void btn_update_Click(object sender, EventArgs e)
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

        private void txt_med_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_med_price_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_select();
        }

        bool is_empty()
        {
            if (txt_med_code.Text != "" && txt_med_name.Text != "" && txt_med_prof.Text != "" && txt_med_ex_name.Text != "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}