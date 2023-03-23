using DevExpress.XtraEditors;
using medcail_deebo.db;
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
    public partial class frm_dos : DevExpress.XtraEditors.XtraForm
    {

        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();
        public int id, code;
        public frm_dos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void get_data()
        {
           // if (txt_doc_name.Text != "" || txt_doc_type.Text != "")
            
              //  dgv_doc.DataSource = con.DOS_TBL.Where(w => w.DOS_NAME.Contains(txt_doc_name.Text) || w.DOS_TYPE.Contains(txt_doc_type.Text)).ToList();
            
          //  else
           
                dgv_doc.DataSource = con.DOS_TBL.ToList();
            
            grid_all_doc.Columns.Remove(grid_all_doc.Columns["CLI_ID"]);

            grid_all_doc.Columns.Remove(grid_all_doc.Columns["CLINC_TBL"]);
            grid_all_doc.Columns.Remove(grid_all_doc.Columns["MEDLIST_TBL"]);
            grid_all_doc.Columns.Remove(grid_all_doc.Columns["DOS_ID"]);
            grid_all_doc.Columns["DOS_CODE"].Caption = "الكود";
            grid_all_doc.Columns["DOS_NAME"].Caption = "اسم الجرعه";
            grid_all_doc.Columns["DOS_TYPE"].Caption = "نوع الجرعه ";
           // grid_all_doc.Columns["DOS_NAME"].Caption = "الكود";


        }
        void search_type()
        {
            if ( txt_doc_type.Text != "")

             dgv_doc.DataSource = con.DOS_TBL.Where(w => w.DOS_TYPE.Equals(txt_doc_type.Text)).ToList();

              else

            dgv_doc.DataSource = con.DOS_TBL.ToList();

            grid_all_doc.Columns.Remove(grid_all_doc.Columns["CLI_ID"]);

            grid_all_doc.Columns.Remove(grid_all_doc.Columns["CLINC_TBL"]);
            grid_all_doc.Columns.Remove(grid_all_doc.Columns["MEDLIST_TBL"]);
            grid_all_doc.Columns.Remove(grid_all_doc.Columns["DOS_ID"]);
            grid_all_doc.Columns["DOS_CODE"].Caption = "الكود";
            grid_all_doc.Columns["DOS_NAME"].Caption = "اسم الجرعه";
            grid_all_doc.Columns["DOS_TYPE"].Caption = "نوع الجرعه ";
            // grid_all_doc.Columns["DOS_NAME"].Caption = "الكود";


        }
        private void frm_dos_Load(object sender, EventArgs e)
        {
            get_data();
            clear();
        }
        void clear()
        {
            id = 0;
            txt_doc_code.Text = "";
            txt_doc_name.Text = "";
            txt_doc_type.Text = "";
            get_cod();
        }
        bool is_empty()
        {
            if (txt_doc_code.Text != "" && txt_doc_name.Text != "" && txt_doc_type.Text != "" )
            {
                return false;
            }
            else
                return true;

        }
        void get_cod()
        {
            string temp_code = con.DOS_TBL.Max(w => w.DOS_CODE).ToString();
            if (temp_code == "")
            {
                txt_doc_code.Text = (1).ToString();
            }
            else
            {
                txt_doc_code.Text = (Convert.ToInt32(temp_code) + 1).ToString();
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
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.DOS_TBL del_cle = con.DOS_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.DOS_TBL.Remove(del_cle);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }
        void get_sele()
        {
            if (grid_all_doc.RowCount > 0)
            {
                id = Convert.ToInt32(grid_all_doc.GetFocusedRowCellValue("DOS_ID").ToString());
                txt_doc_code.Text = grid_all_doc.GetFocusedRowCellValue("DOS_CODE").ToString();
                txt_doc_name.Text = grid_all_doc.GetFocusedRowCellValue("DOS_NAME").ToString();
                txt_doc_type.Text = grid_all_doc.GetFocusedRowCellValue("DOS_TYPE").ToString();
                //txt_clc_note.Text = grid_all_doc.GetFocusedRowCellValue("CLI_NOTE").ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_dos();  
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_dos();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_doc_DockChanged(object sender, EventArgs e)
        {
            get_sele();
        }

        private void grid_all_doc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           // get_sele();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void txt_doc_name_TextChanged(object sender, EventArgs e)
        {
          //  get_data();
        }

        private void txt_doc_type_TextChanged(object sender, EventArgs e)
        {
            search_type();
        }

        private void grid_all_doc_DoubleClick(object sender, EventArgs e)
        {
            get_sele();
        }

        void add_dos()
        {
            if (is_empty() != true)
            {
                try
                {
                    db.DOS_TBL cl = new db.DOS_TBL();
                    cl.DOS_CODE = Convert.ToInt32(txt_doc_code.Text);
                    cl.DOS_NAME = txt_doc_name.Text;
                    cl.DOS_TYPE = txt_doc_type.Text;
                    cl.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;

                   // cl.d = txt_clc_address.Text;
                    if (id != 0)
                    
                        cl.DOS_ID = Convert.ToInt32(id);

                    
                    con.DOS_TBL.AddOrUpdate(cl);
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