using DevExpress.XtraEditors;
using medcail_deebo.form.frm_list;
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
    public partial class frm_card : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id = 0, cod;
        public frm_card()
        {
            InitializeComponent();
        }

        private void frm_card_Load(object sender, EventArgs e)
        {
            inshail();
            clear();
        }
        void sel_doc()
        {
            if (gridView1.RowCount > 0)
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CARD_ID").ToString());
                txt_card_code.Text = gridView1.GetFocusedRowCellValue("CARD_CODE").ToString();
                txt_card_name.Text = gridView1.GetFocusedRowCellValue("CARD_NAME").ToString();
                txt_card_date.Text = gridView1.GetFocusedRowCellValue("CARD_DATE").ToString();
                com_card_state.Text = gridView1.GetFocusedRowCellValue("CARD_STATE").ToString();
                txt_card_pre.Text = gridView1.GetFocusedRowCellValue("CARD_PER").ToString();
                txt_card_note.Text = gridView1.GetFocusedRowCellValue("CARD_NOTE").ToString();

                int a = Convert.ToInt32(txt_card_code.Text);
                com_com_id.Text = con.CARD_TBL.Find(a).COM_ID.ToString();
              



            }
        }
        void clear()
        {
            id = 0;
            txt_card_code.Text = "";
            txt_card_date.Text = "";
            txt_card_name.Text = "";
            txt_card_note.Text = "";
            txt_card_pre.Text = "";
            string temp_code = con.CARD_TBL.Max(w => w.CARD_CODE).ToString();
            if (temp_code == "")
            {
                cod = 1;
               txt_card_code.Text = (1).ToString();
            }
            else
            {
                cod = Convert.ToInt32(temp_code);
                txt_card_code.Text = (cod + 1).ToString();
            }
            // dtp_birth.Text = "";
        }
        void inshail()
        {


            com_com_id.DataSource = con.COMPANY_TBL.ToList();
            com_com_id.DisplayMember = "COM_ID";
            com_com_name.DataSource = com_com_id.DataSource;
            com_com_name.DisplayMember = "COM_NAME";
            com_com_name.ValueMember = "COM_ID";
            get_data();
            clear();

        }
        void get_data()
        {
            //remove from dgv
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
        public bool cheack_empty()
        {
            if (txt_card_code.Text != "" && txt_card_date.Text != "" && txt_card_name.Text != "" && com_card_state.Text != "" && txt_card_note.Text != "" && txt_card_date.Text != "" && com_com_id.Text != "" && com_com_name.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        void add_card()
        {
            if (cheack_empty() == true)
            {
                try
                {
                    db.CARD_TBL doc = new db.CARD_TBL();
                    doc.CARD_CODE = Convert.ToInt32(txt_card_code.Text);
                    doc.CARD_NAME = txt_card_name.Text;
                    doc.CARD_PER =Convert.ToInt32(txt_card_pre.Text);
                    doc.CARD_STATE = com_card_state.Text;
                    doc.CARD_NOTE = txt_card_note.Text;
                    doc.CARD_DATE =Convert.ToDateTime(txt_card_date.Value.ToString());
                    doc.COM_ID =Convert.ToInt32( com_com_id.Text);
                    if (id != 0)
                    {
                        doc.CARD_ID = id;
                    }
                    con.CARD_TBL.AddOrUpdate(doc);
                    con.SaveChanges();
                    if (id != 0)
                    {
                        MessageBox.Show("تم التعديل بنجاح   ");

                    }
                    MessageBox.Show("تم الاضافه ");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    clear();
                }
                get_data();
                clear();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {
            frm_com_list frm = new frm_com_list();
            frm.ShowDialog();
            
            int s = frm.com_id;
            com_com_id.Text =(s).ToString();
           
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            sel_doc();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_card();
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_card();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void dgv_card_Click(object sender, EventArgs e)
        {

        }

        void delete()
        {
            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.CARD_TBL del_doc = con.CARD_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.CARD_TBL.Remove(del_doc);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }
    }
}