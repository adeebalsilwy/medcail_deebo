using DevExpress.XtraEditors;
using medcail_deebo.db;
using medcail_deebo.form.form_list;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.frm_list
{
    public partial class frm_apoy_list : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public int apo_id;
        public frm_apoy_list()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_apoy_list_Load(object sender, EventArgs e)
        {
            inshail();
            get_clear();
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
            com_doc_id.DataSource = con.DOCTORS_TBL.ToList();
            com_doc_id.DisplayMember = "DOC_ID";
            com_doc_name.DataSource = com_doc_id.DataSource;
            com_doc_name.DisplayMember = "DOC_NAME";
           
        }
        void get_clear()
        {
            com_coust_id.Text = "";
            com_doc_id.Text = "";
            com_doc_name.Text = "";
            com_coust_name.Text = "";
            txt_apoy_s_date.Value = DateTime.Now.AddDays(-1); 
            txt_apoy_to_date.Value= DateTime.Now;
            get_data();

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

            dgv_apoy.DataSource = tbl.ToList();
            gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
            gridView1.Columns["APO_CODE"].Caption = "الكود";
            gridView1.Columns["COUST_NAME"].Caption = "اسم المريض ";
            gridView1.Columns["DOC_NAME"].Caption = "تاريخ الموعد ";
            gridView1.Columns["APO_TIME"].Caption = "وقت الموعد  ";
            gridView1.Columns["APO_DATE"].Caption = " تاريخ الموعد  ";
            
        }

        private void lbl_coust_name_Click(object sender, EventArgs e)
        {
            frm_cust_list frm = new frm_cust_list();
            frm.ShowDialog();
            com_coust_id.Text = frm.coust_id.ToString();
        }

        private void lbl_doc_Click(object sender, EventArgs e)
        {
            frm_doct_list fmm = new frm_doct_list();
            fmm.ShowDialog();
            com_doc_id.Text=fmm.doc_id.ToString();
        }
        void search()
        {
            if (com_coust_name.Text != "" && com_doc_name.Text=="")
            {
                var tbl = (from ap in con.APO_TBL
                           join cust in con.CUST_TBL on ap.CUST_ID equals cust.CUST_ID
                           join doc in con.DOCTORS_TBL on ap.DOC_ID equals doc.DOC_ID
                           select new 
                           {
                               APO_ID = ap.APO_ID,
                               APO_CODE = ap.APO_CODE,

                               COUST_NAME = cust.CUST_F_NAME+" "+ cust.CUST_S_NAME+" " + cust.CUST_T_NAME +" "+ cust.CUST_L_NAME,
                               DOC_NAME = doc.DOC_NAME,
                               APO_DATE = ap.APO_DATE,
                               APO_TIME = ap.APO_TIME,


                           }).Where(w => w.COUST_NAME.Contains(com_coust_name.Text) || w.COUST_NAME.Equals(com_coust_name.Text) && w.APO_DATE >= txt_apoy_s_date.Value && w.APO_DATE <= txt_apoy_to_date.Value).ToList();


                dgv_apoy.DataSource = tbl.ToList();
                gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
                gridView1.Columns["APO_CODE"].Caption = "الكود";
                gridView1.Columns["COUST_NAME"].Caption = "اسم المريض ";
                gridView1.Columns["DOC_NAME"].Caption = "اسم الدكتور";
                gridView1.Columns["APO_TIME"].Caption = "وقت الموعد  ";
                gridView1.Columns["APO_DATE"].Caption = " تاريخ الموعد  ";
            }
            else if(com_doc_name.Text!="" && com_coust_name.Text == "")
            {
                var tbl = (from ap in con.APO_TBL
                           join cust in con.CUST_TBL on ap.CUST_ID equals cust.CUST_ID
                           join doc in con.DOCTORS_TBL on ap.DOC_ID equals doc.DOC_ID
                           select new 
                           {
                               APO_ID = ap.APO_ID,
                               APO_CODE = ap.APO_CODE,

                               COUST_NAME = cust.CUST_F_NAME + " " + cust.CUST_S_NAME + " " + cust.CUST_T_NAME + " " + cust.CUST_L_NAME,
                               DOC_NAME = doc.DOC_NAME,
                               APO_DATE = ap.APO_DATE,
                               APO_TIME = ap.APO_TIME,
                               


                           }).Where(w =>  w.DOC_NAME.Contains(com_doc_name.Text)  || w.DOC_NAME.Equals(com_doc_name.Text)&& w.APO_DATE >= txt_apoy_s_date.Value && w.APO_DATE <= txt_apoy_to_date.Value).ToList();


                dgv_apoy.DataSource = tbl.ToList();
                gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
                gridView1.Columns["APO_CODE"].Caption = "الكود";
                gridView1.Columns["COUST_NAME"].Caption = "اسم المريض ";
                gridView1.Columns["DOC_NAME"].Caption = "اسم الدكتور";
                gridView1.Columns["APO_TIME"].Caption = "وقت الموعد  ";
                gridView1.Columns["APO_DATE"].Caption = " تاريخ الموعد  ";
            }
            else if (com_coust_name.Text != "" && com_doc_name.Text != "")
            {
                var tbl = (from ap in con.APO_TBL
                           join cust in con.CUST_TBL on ap.CUST_ID equals cust.CUST_ID
                           join doc in con.DOCTORS_TBL on ap.DOC_ID equals doc.DOC_ID
                           select new 
                           {
                               APO_ID = ap.APO_ID,
                               APO_CODE = ap.APO_CODE,

                               COUST_NAME = cust.CUST_F_NAME + " " + cust.CUST_S_NAME + " " + cust.CUST_T_NAME + " " + cust.CUST_L_NAME,
                               DOC_NAME = doc.DOC_NAME,
                               APO_DATE = ap.APO_DATE,
                               APO_TIME = ap.APO_TIME,


                           }).Where(w => w.COUST_NAME.Contains(com_coust_name.Text) && w.DOC_NAME.Equals(com_doc_name.Text) && w.APO_DATE >= txt_apoy_s_date.Value && w.APO_DATE <= txt_apoy_to_date.Value).ToList();


                dgv_apoy.DataSource = tbl.ToList();
                gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
                gridView1.Columns["APO_CODE"].Caption = "الكود";
                gridView1.Columns["COUST_NAME"].Caption = "اسم المريض ";
                gridView1.Columns["DOC_NAME"].Caption = "اسم الدكتور";
                gridView1.Columns["APO_TIME"].Caption = "وقت الموعد  ";
                gridView1.Columns["APO_DATE"].Caption = " تاريخ الموعد  ";

            }
            else
                get_data();


            

            
           
           
            
            
               
        }

        private void com_coust_name_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void com_doc_name_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txt_apoy_s_date_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_apoy_to_date_ValueChanged(object sender, EventArgs e)
        {
        }

        private void frm_apoy_list_Activated(object sender, EventArgs e)
        {
        }

        private void com_coust_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void com_doc_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            get_clear();
        }
    }
}