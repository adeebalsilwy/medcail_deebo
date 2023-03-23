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
    public partial class frm_clin : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int cod, id=0;
        public frm_clin()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_clinc();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_clinc();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void get_data()
        {
            
            dgv_clinc.DataSource = con.CLINC_TBL.ToList();
            gridView1.Columns.Remove(gridView1.Columns["MEDCHEK_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDCIN_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDREQ_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["SERLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["SERVICE_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["USERS_TBL"]);

            gridView1.Columns.Remove(gridView1.Columns["COMPANY_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DIAGNOIS_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DIGLIST_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DOCTORS_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["DOS_TBL"]);

            gridView1.Columns.Remove(gridView1.Columns["APO_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CARD_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["VISIT_TBL"]);
            gridView1.Columns["CLI_CODE"].Caption = "الكود";
            gridView1.Columns["CLI_NAME"].Caption = "اسم العياده ";
            gridView1.Columns["CLI_LOC"].Caption = "الموقع ";
            gridView1.Columns["CLI_NOTE"].Caption = "ملاحضات ";
        }

        private void frm_clin_Load(object sender, EventArgs e)
        {
            get_data();
            clear();
        }
        void clear()
        {
            id = 0;
            txt_clc_address.Text = "";
            txt_clc_cod.Text = "";
            txt_clc_name.Text = "";
            txt_clc_note.Text = "";
            get_cod();
        }
        bool is_empty()
        {
            if (txt_clc_cod.Text != "" && txt_clc_address.Text != "" && txt_clc_name.Text != "" && txt_clc_note.Text != "")
            {
                return false;
            }
            else
                return true;

         }
        void get_cod()
        {
            string temp_code = con.CLINC_TBL.Max(w => w.CLI_CODE).ToString();
            if (temp_code == "")
            {
                txt_clc_cod.Text = (1).ToString();
            }
            else
            {
                txt_clc_cod.Text = (Convert.ToInt32(temp_code) + 1).ToString();
            }
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sele();
        }
        void delete()
        {
            if (id != 0)
            {
              DialogResult res=  MessageBox.Show("هل تريد تاكيد الحذف ","تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.CLINC_TBL del_cle = con.CLINC_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.CLINC_TBL.Remove(del_cle);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }
        void get_sele()
        {
            if (gridView1.RowCount > 0)
            {
                id=Convert.ToInt32(gridView1.GetFocusedRowCellValue("CLI_ID").ToString());
                txt_clc_address.Text=gridView1.GetFocusedRowCellValue("CLI_LOC").ToString();
                txt_clc_cod.Text = gridView1.GetFocusedRowCellValue("CLI_CODE").ToString();
                txt_clc_name.Text = gridView1.GetFocusedRowCellValue("CLI_NAME").ToString();
                txt_clc_note.Text = gridView1.GetFocusedRowCellValue("CLI_NOTE").ToString();
            }
        }

        private void txt_clc_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        void add_clinc()
        {
            if (is_empty() != true)
            {
                try
                {
                    db.CLINC_TBL cl = new db.CLINC_TBL();
                    cl.CLI_CODE = Convert.ToInt32(txt_clc_cod.Text);
                    cl.CLI_NAME = txt_clc_name.Text;
                    cl.CLI_NOTE = txt_clc_note.Text;
                    cl.CLI_LOC = txt_clc_address.Text;
                    if (id != 0)
                        cl.CLI_ID = Convert.ToInt32(id);
                    con.CLINC_TBL.AddOrUpdate(cl);
                    con.SaveChanges();
                    if (id != 0)
                        MessageBox.Show("تم التعديل بنجاح ");
                    else
                        MessageBox.Show("تمت الاضافه بنجاح ");
                   
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