using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form
{
    public partial class frm_doctoer : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        string name, magor, exp, addess, phone, code, birth;
        int id=0, cod;
        public frm_doctoer()
        {
            InitializeComponent();
        }
       
       
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_doctoer_Load(object sender, EventArgs e)
        {
          
            inshail();
            get_data();
            clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            add_doctor();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_doc();
           // MessageBox.Show(id.ToString());
        }

        private void dgv_doc_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.DOCTORS_TBL del_doc = con.DOCTORS_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.DOCTORS_TBL.Remove(del_doc);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            sel_doc();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void update_doc()
        {

            if (cheack_empty() == true)
            {
                try
                {
                    db.DOCTORS_TBL doc = new db.DOCTORS_TBL();
                    doc.DOC_ID = id;
                    doc.DOC_CODE = Convert.ToInt32(txt_doc_cod.Text);
                    doc.DOC_NAME = txt_doc_name.Text;
                    doc.DOC_ADDRESS = txt_doc_address.Text;
                    doc.DOC_MOBILE = txt_doc_phone.Text;
                    doc.DOC_MAJOR = txt_doc_mag.Text;
                    doc.DOC_EXP = txt_doc_exp.Text;
                    doc.CLI_ID = 1;
                    doc.DOC_BD = Convert.ToDateTime(dtp_birth.Value);
                    doc.USER_ID = Convert.ToInt32(com_user_id.Text);
                    con.DOCTORS_TBL.AddOrUpdate(doc);
                    con.SaveChanges();
                    MessageBox.Show("تم التعديل بنجاح  ");
                    get_data();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clear();
                }
            }
        }

        void sel_doc()
        {
            if (gridView1.RowCount > 0)
            {
                id=Convert.ToInt32(gridView1.GetFocusedRowCellValue("DOC_ID").ToString());
                txt_doc_cod.Text = gridView1.GetFocusedRowCellValue("DOC_CODE").ToString();
                txt_doc_name.Text = gridView1.GetFocusedRowCellValue("DOC_NAME").ToString();
                txt_doc_phone.Text = gridView1.GetFocusedRowCellValue("DOC_MOBILE").ToString();
                txt_doc_mag.Text = gridView1.GetFocusedRowCellValue("DOC_MAJOR").ToString();
                txt_doc_exp.Text = gridView1.GetFocusedRowCellValue("DOC_EXP").ToString();
                dtp_birth.Text = gridView1.GetFocusedRowCellValue("DOC_BD").ToString();
                txt_doc_address.Text = gridView1.GetFocusedRowCellValue("DOC_ADDRESS").ToString();


                // var s = con.DOCTORS_TBL.Where(w => w.DOC_CODE.Equals(Convert.ToInt32(txt_doc_cod.Text))).Select(w => w.USER_ID).FirstOrDefault();
                com_user_id.Text = gridView1.GetFocusedRowCellValue("USER_ID").ToString();



            }
        }
        void clear()
        {
            id = 0;
            txt_doc_cod.Text = "";
            txt_doc_address.Text = "";
            txt_doc_exp.Text = "";
            txt_doc_mag.Text = "";
            txt_doc_name.Text = "";
            txt_doc_phone.Text = "";
             string temp_code =con.DOCTORS_TBL.Max(w => w.DOC_CODE).ToString();
            if (temp_code == "")
            {
                cod = 1;
                txt_doc_cod.Text = (1).ToString();
            }
            else
            {
                cod = Convert.ToInt32(temp_code);
                txt_doc_cod.Text = (cod + 1).ToString();
            }
            // dtp_birth.Text = "";
        }
        void inshail()
        {
            

            com_user_id.DataSource = con.USERS_TBL.ToList();
            com_user_id.DisplayMember = "USER_ID";
            com_user_name.DataSource = com_user_id.DataSource;
            com_user_name.DisplayMember = "USER_NAME";
            com_user_name.ValueMember = "USER_ID";
         
        }
        void get_data()
        {
            dgv_doc.DataSource = con.DOCTORS_TBL.ToList();
            gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
            gridView1.Columns.Remove(gridView1.Columns["VISIT_TBL"]);
            gridView1.Columns["DOC_CODE"].Caption = "الكود";
            gridView1.Columns["DOC_NAME"].Caption = "اسم الدكتور";
            gridView1.Columns["DOC_MAJOR"].Caption = "التخصص";
            gridView1.Columns["DOC_EXP"].Caption = "الخبره";
            gridView1.Columns["DOC_BD"].Caption = "الميلاد";
            gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
            gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";
        }
        public bool cheack_empty()
        {
            if (txt_doc_name.Text != "" && txt_doc_mag.Text != "" && txt_doc_exp.Text != "" && txt_doc_address.Text != "" && txt_doc_phone.Text != "" && dtp_birth.Text != "" && com_user_id.Text != "" && com_user_name.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      

        void add_doctor()
        {
            if (cheack_empty() == true)
            {
                try
                {
                    db.DOCTORS_TBL doc = new db.DOCTORS_TBL();
                    doc.DOC_CODE =Convert.ToInt32(txt_doc_cod.Text);
                    doc.DOC_NAME = txt_doc_name.Text;
                    doc.DOC_ADDRESS = txt_doc_address.Text;
                    doc.DOC_MOBILE = txt_doc_phone.Text;
                    doc.DOC_MAJOR = txt_doc_mag.Text;
                    doc.DOC_EXP = txt_doc_exp.Text;
                    doc.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;
                    doc.DOC_BD = Convert.ToDateTime(dtp_birth.Value);
                    doc.USER_ID = Convert.ToInt32(com_user_id.Text);
                    con.DOCTORS_TBL.Add(doc);
                    con.SaveChanges();
                    MessageBox.Show("تم الاضافه ");
                    get_data();
                    clear();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clear();
                }
            }
        }
    }
   
}