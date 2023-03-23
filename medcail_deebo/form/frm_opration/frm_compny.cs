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
    public partial class frm_compny : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id=0, code;
        public frm_compny()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_com();
        }
        void clear()
        {
            id = 0;
            txt_com_address.Text = "";
            txt_com_code.Text = "";
            txt_com_name.Text = "";
            txt_com_state.Text = "";
            txt_cpm_phone.Text = "";
            get_cod();

        }
        void get_cod()
        {
            string temp_code = con.COMPANY_TBL.Max(w => w.COM_CODE).ToString();
            if (temp_code == "")
            {
                txt_com_code.Text = (1).ToString();
            }
            else
            {
                txt_com_code.Text = (Convert.ToInt32(temp_code) + 1).ToString();
            }
            }
            bool is_empty()
        {
            if(txt_com_address.Text!="" && txt_com_code.Text!="" &&txt_com_name.Text!=""&&txt_com_state.Text!="" &&txt_cpm_phone.Text!="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void add_com()
        {
            if(is_empty()!=true)
            {
                try
                {
                    db.COMPANY_TBL com = new db.COMPANY_TBL();
                    com.COM_CODE = Convert.ToInt32(txt_com_code.Text);
                    com.COM_ADDRESS=txt_com_address.Text;
                    com.COM_MOBILE1 = txt_cpm_phone.Text;
                    com.COM_NAME = txt_com_name.Text;
                    com.COM_STATE = txt_com_state.Text;
                    if (id != 0)
                    {
                        com.COM_ID = id;
                    }
                    con.COMPANY_TBL.AddOrUpdate(com);
                    con.SaveChanges();
                    if (id != 0)
                    {
                        MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        MessageBox.Show("تمت الاضافه بنجاح ");
                    }

                    id = 0;


                }catch(Exception ex)
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
            dgv_com.DataSource = con.COMPANY_TBL.ToList();
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

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_select();  
        } 

        void get_select()
           {
            if (gridView1.RowCount > 0)
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("COM_ID").ToString());
                txt_com_address.Text = gridView1.GetFocusedRowCellValue("COM_ADDRESS").ToString();
                txt_com_code.Text = gridView1.GetFocusedRowCellValue("COM_CODE").ToString();
                txt_com_name.Text = gridView1.GetFocusedRowCellValue("COM_NAME").ToString();
                txt_cpm_phone.Text = gridView1.GetFocusedRowCellValue("COM_MOBILE1").ToString();
                txt_com_state.Text = gridView1.GetFocusedRowCellValue("COM_STATE").ToString();
                // txt_com_address.Text = gridView1.GetFocusedRowCellValue("COM_ADDRESS").ToString();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            get_delete();
        }
        void get_delete()
        {

            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.COMPANY_TBL del_com = con.COMPANY_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.COMPANY_TBL.Remove(del_com);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_com();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
           // get_select();
        }

        private void frm_compny_Load(object sender, EventArgs e)
        {
            get_data();
            clear();

        }
    }
}