using DevExpress.XtraEditors;
using medcail_deebo.db;
using medcail_deebo.form.form_list;
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
    public partial class frm_apoyment : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public int id, cod;
        public frm_apoyment()
        {
            InitializeComponent();
        }

        private void frm_apoyment_Load(object sender, EventArgs e)
        {
            inshail();
            get_data();
            clear();
        }
        void sel_doc()
        {
            if (gridView1.RowCount > 0)
            {
                //id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CARD_ID").ToString());
                //txt_card_code.Text = gridView1.GetFocusedRowCellValue("CARD_CODE").ToString();
                //txt_card_name.Text = gridView1.GetFocusedRowCellValue("CARD_NAME").ToString();
                //txt_card_date.Text = gridView1.GetFocusedRowCellValue("CARD_DATE").ToString();
                //com_card_state.Text = gridView1.GetFocusedRowCellValue("CARD_STATE").ToString();
                //txt_card_pre.Text = gridView1.GetFocusedRowCellValue("CARD_PER").ToString();
                //txt_card_note.Text = gridView1.GetFocusedRowCellValue("CARD_NOTE").ToString();

                //int a = Convert.ToInt32(txt_card_code.Text);
                //com_com_id.Text = con.CARD_TBL.Find(a).COM_ID.ToString();




            }
        }
        void clear()
        {
            id = 0;
            txt_apoy_code.Text = "";
            txt_apoy_date.Text = "";
            txt_apoy_name.Text = "";
            txt_apoy_note.Text = "";
            txt_apoy_time.Text = "";
            string temp_code = con.APO_TBL.Max(w => w.APO_CODE).ToString();
            if (temp_code == "")
            {
                cod = 1;
                txt_apoy_code.Text = (1).ToString();
            }
            else
            {
                cod = Convert.ToInt32(temp_code);
                txt_apoy_code.Text = (cod + 1).ToString();
            }
            id = 0;
            com_doc_name.Text = "";
            com_coust_name.Text = "";
           //com_coust_id.Text = "";
           //com_doc_id.Text = "";
           
        }
        void inshail()
        {


            var data = (from c in con.CUST_TBL

                        select new
                        {
                            CUST_ID = c.CUST_ID,
                            CUST_F_NAME = c.CUST_F_NAME + " " + c.CUST_S_NAME + " " + c.CUST_T_NAME + " " + c.CUST_L_NAME,
                        }).ToList();
           
           
            com_coust_name.DataSource = data;
            com_coust_name.DisplayMember = "CUST_F_NAME";
            com_coust_name.ValueMember = "CUST_ID";
            com_coust_id.DataSource = com_coust_name.DataSource;
            com_coust_id.DisplayMember = "CUST_ID";
           
            com_doc_name.DataSource = con.DOCTORS_TBL.ToList(); ;
            com_doc_name.DisplayMember = "DOC_NAME";
            com_doc_id.ValueMember = "DOC_ID";

            com_doc_id.DataSource = com_doc_name.DataSource;
            com_doc_id.DisplayMember = "DOC_ID";

            get_data();
            clear();

        }
        void get_data()
        {
            //remove from dgv
            var tbl = (from ap in con.APO_TBL
                       join cust in con.CUST_TBL on ap.CUST_ID equals cust.CUST_ID
                       join doc in con.DOCTORS_TBL on ap.DOC_ID equals doc.DOC_ID
                       select new apoy_coust_doc
                       {
                           APO_ID = ap.APO_ID,
                           APO_CODE = ap.APO_CODE,

                           COUST_NAME = cust.CUST_F_NAME + " " + cust.CUST_S_NAME + " " + cust.CUST_T_NAME + " " + cust.CUST_L_NAME,
                           DOC_NAME = doc.DOC_NAME,
                           APO_DATE = ap.APO_DATE,
                           APO_TIME = ap.APO_TIME,


                       }).ToList();

            //gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            //gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            //gridView1.Columns.Remove(gridView1.Columns["CLINC_TBL"]);
            //gridView1.Columns.Remove(gridView1.Columns["COMPANY_TBL"]);
            //gridView1.Columns.Remove(gridView1.Columns["CUST_TBL"]);
            //gridView1.Columns.Remove(gridView1.Columns["CARD_NOTE"]);

            dgv_apoy.DataSource = tbl.ToList();
            gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
            //gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            //gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);

            gridView1.Columns["APO_CODE"].Caption = "الكود";
            gridView1.Columns["COUST_NAME"].Caption = "اسم المريض ";
            gridView1.Columns["DOC_NAME"].Caption = "اسم الدكتور ";
            gridView1.Columns["APO_TIME"].Caption = "وقت الموعد  ";
            gridView1.Columns["APO_DATE"].Caption = " تاريخ الموعد  ";
            //gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
            //gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";
        }
        public bool cheack_empty()
        {
            if (com_coust_name.Text != "" && txt_apoy_time.Text!=" : " && com_doc_name.Text != "" && txt_apoy_code.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lbl_coust_name_Click(object sender, EventArgs e)
        {
            frm_cust_list frm = new frm_cust_list();
            frm.ShowDialog();
            com_coust_id.Text=frm.coust_id.ToString();

        }

        private void lbl_doc_Click(object sender, EventArgs e)
        {
            frm_doct_list frm = new frm_doct_list();
            frm.ShowDialog();
            com_doc_id.Text=frm.doc_id.ToString();


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_apoy(); 
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                sel_cust();
            }
        }
        void sel_cust()
        {
            if (gridView1.RowCount > 0)
            {

                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("APO_ID").ToString());
                int code_se = Convert.ToInt32(gridView1.GetFocusedRowCellValue("APO_CODE").ToString());
                var list = con.APO_TBL.Where(q => q.APO_CODE == code_se).FirstOrDefault();
                if (list.APO_ID != 0)
                {
                    com_coust_id.Text= list.CUST_ID.ToString();
                    com_doc_id.Text= list.DOC_ID.ToString();
                    txt_apoy_code.Text=list.APO_CODE.ToString();
                    txt_apoy_date.Text=list.APO_DATE.ToString();
                    txt_apoy_name.Text=list.APO_NAME.ToString();
                    txt_apoy_note.Text=list.APO_NOTE.ToString();
                    txt_apoy_time.Text=list.APO_TIME.ToString();

                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            add_apoy();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }
        void delete()
        {
            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.APO_TBL del_doc = con.APO_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.APO_TBL.Remove(del_doc);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }

        void add_apoy()
        {
            if (cheack_empty() == true)
            {
                try
                {
                    db.APO_TBL apo = new db.APO_TBL();
                    apo.APO_CODE = Convert.ToInt32(txt_apoy_code.Text);
                    apo.APO_NAME = txt_apoy_name.Text;
                    apo.APO_NOTE = txt_apoy_note.Text;
                 
                    apo.APO_DATE = Convert.ToDateTime(txt_apoy_date.Value);
                    apo.APO_TIME =string.Format(txt_apoy_time.Text,"HH:MI");
                    apo.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;
                    apo.CUST_ID = Convert.ToInt32(com_coust_id.Text);
                    apo.DOC_ID = Convert.ToInt32(com_doc_id.Text);

                    if (id != 0)
                    {
                        apo.APO_ID = id;
                    }
                    con.APO_TBL.AddOrUpdate(apo);
                    con.SaveChanges();
                    if (id != 0)
                    {
                        MessageBox.Show("تم التعديل بنجاح   ");

                    }else
                    MessageBox.Show("تم الاضافه ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("الوقت والتاريخ محجوز مسبقا ","تحذير ",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    clear();
                }
                get_data();
                clear();
            }
        }


    }
}