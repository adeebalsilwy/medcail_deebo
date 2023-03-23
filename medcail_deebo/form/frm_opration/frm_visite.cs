using DevExpress.XtraEditors;
using medcail_deebo.db;
using medcail_deebo.form.fm_med;
using medcail_deebo.form.frm_list;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.frm_opration
{
    public partial class frm_visite : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
       public  int coust_id, coust_code, visit_code, order_id,visit_id;
        public float totoal_service = 0, totoal_medcheak=0,total_all_vist=0;

        public frm_visite()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_visite_Load(object sender, EventArgs e)
        {
            clear();
            get_order_data();
            get_state();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_order_data();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {

        }
        void delete_order()
        {
            if (grid_order.RowCount > 0)
            {
                order_id = Convert.ToInt32(grid_order.GetFocusedRowCellValue("ORDER_ID").ToString());
                string name_delete = grid_order.GetFocusedRowCellValue("CUST_F_NAME").ToString();
                DialogResult res = MessageBox.Show("هل تريد الغاء +'" + name_delete + "'+ من القائمه  ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    db.ORDER_TBL del_doc = con.ORDER_TBL.Find(order_id);
                    // del_doc.DOC_ID = id;

                    con.ORDER_TBL.Remove(del_doc);
                    con.SaveChanges();
                    MessageBox.Show("تم الغاء  من القائمه  ");
                }
               
                get_order_data();
                clear();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
            get_state();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

            frm_dag_list frm = new frm_dag_list();
            frm.visit_id = visit_id;
            frm.coust_id=coust_id;
           
           frm.ShowDialog();
           


        }

        private void grid_order_DoubleClick(object sender, EventArgs e)
        {
            get_select();
            get_state();
        }

        private void btn_list_coust_Click(object sender, EventArgs e)
        {
            frm_cust_list frm = new frm_cust_list();
            frm.ShowDialog();
            coust_id=frm.coust_id;
            try
            {
                txt_coust_code.Text = con.CUST_TBL.Find(coust_id).CUST_CODE.ToString();
                txt_coust_age.Text = con.CUST_TBL.Find(coust_id).CUST_AGE;
                txt_coust_note.Text = con.CUST_TBL.Find(coust_id).CUST_NOTE;
                txt_coust_phone.Text = con.CUST_TBL.Find(coust_id).CUST_MOBLIE1;
                com_clin_id.Text = con.CUST_TBL.Find(coust_id).CLI_ID.ToString();
                txt_coust_fname.Text = con.CUST_TBL.Find(coust_id).CUST_F_NAME.ToString();
                txt_coust_fname.Text += " " + con.CUST_TBL.Find(coust_id).CUST_S_NAME.ToString();
                txt_coust_fname.Text += " " + con.CUST_TBL.Find(coust_id).CUST_T_NAME.ToString();
                txt_coust_fname.Text += " " + con.CUST_TBL.Find(coust_id).CUST_L_NAME.ToString();

                com_clinc_name.Text = con.CLINC_TBL.Find(Convert.ToInt32(com_clin_id.Text)).CLI_NAME;

            }
            catch (Exception ex) { }
                //  txt_coust_fname.Text = grid_order.GetFocusedRowCellValue("CUST_F_NAME").ToString();
            //get_select();

        }

        private void btn_list_cli_Click(object sender, EventArgs e)
        {
            frm_clinc_list frm = new frm_clinc_list();
            frm.ShowDialog();
            com_clin_id.Text=frm.clin_id.ToString();
            com_clinc_name.Text = con.CLINC_TBL.Find(Convert.ToInt32(com_clin_id.Text)).CLI_NAME.ToString();
            get_select();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            delete_order();
            clear();
            get_state();
        }
        void add_vist()
        {

            if (cheack_empty() == true)
            {
                try
                {
                    VISIT_TBL vis = new VISIT_TBL();
                   //vis.VIS_ID = visit_id;
                    vis.VIS_CODE = Convert.ToInt32(txt_vist_code.Text);
                    vis.VIS_DATE = DateTime.Now;
                    vis.VIS_TIME=DateTime.Now.ToShortTimeString();
                    vis.VIS_TYPE = "";
                    
                    vis.CUST_ID = coust_id;
                    vis.CLI_ID = Convert.ToInt32(com_clin_id.Text);
                    vis.DOC_ID = medcail_deebo.Properties.Settings.Default.doc_id;
                    vis.VIS_PRICE=Convert.ToDecimal(txt_price.Text);
                    vis.VIS_DIS_COUNT = Convert.ToDecimal(txt_discount.Text);
                    vis.VIS_PAY_TYPE = com_pay_type.Text;
                    vis.VIS_TOTAL = Convert.ToDecimal(txt_total.Text);
                    vis.VIS_NOTE = txt_doc_note.Text;
                    con.VISIT_TBL.AddOrUpdate(vis);
                  con.SaveChanges();
                    MessageBox.Show("تم الاضافه ");

                }
                catch (Exception ex)
                {
                    // MessageBox.Show("ملاحضه لايمكن ان يكون هناك بطاه ائئتمان لاكثر من شخص ","تحذير ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message +ex.InnerException);
                }


            }
            clear();
        }

        void get_select()
        {
            if (grid_order.RowCount > 0)
            {
                order_id = Convert.ToInt32(grid_order.GetFocusedRowCellValue("ORDER_ID"));
                coust_id = Convert.ToInt32(grid_order.GetFocusedRowCellValue("CUST_ID").ToString());
              txt_coust_code.Text= con.CUST_TBL.Find(coust_id).CUST_CODE.ToString();
                txt_coust_age.Text = con.CUST_TBL.Find(coust_id).CUST_AGE;
               txt_coust_note.Text = con.CUST_TBL.Find(coust_id).CUST_NOTE;
                txt_coust_phone.Text= con.CUST_TBL.Find(coust_id).CUST_MOBLIE1;
                com_clin_id.Text = con.CUST_TBL.Find(coust_id).CLI_ID.ToString();
                com_clinc_name.Text = con.CLINC_TBL.Find(Convert.ToInt32(com_clin_id.Text)).CLI_NAME;
                txt_coust_fname.Text = grid_order.GetFocusedRowCellValue("CUST_F_NAME").ToString();

            }
          
            get_state();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            clear_pric();
        }



       
        void get_state()
        {
            try
            {

                //  decimal temp =Convert.ToDecimal(con.VISIT_TBL.Select(p => p.VIS_ID).DefaultIfEmpty(0).Max().ToString());

                decimal maxAge = con.VISIT_TBL.Select(p => p.VIS_ID).Cast<decimal?>().Max() ?? 0;
                //var temp=(from vi in con.VISIT_TBL
                // select vi.VIS_ID).Max();
                //var temp = con.VISIT_TBL.Max(w=>w.VIS_CODE).ToString();
                if (maxAge != 0)
                {
                    visit_id = Convert.ToInt32(maxAge) + 1;
                    txt_vist_id.Text=visit_id.ToString();
                    txt_vist_code.Text = visit_id.ToString();
                   // txt_vist_id.Text= visit_id.ToString();
                 
                }
                else
                {
                    visit_id = 1;
                    txt_vist_id.Text = visit_id.ToString();
                    txt_vist_code.Text = visit_id.ToString();

                    //txt_vist_code.Text = visit_id.ToString();
                    //txt_vist_code.Text = (visit_id).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.InnerException);
                //visit_id = 1;
                //txt_vist_id.Text = visit_id.ToString();
                //txt_vist_code.Text = visit_id.ToString();
            }
            


            if (txt_coust_code.Text != "")
            {
                grb_control.Enabled = true;
                grb_price.Enabled = true;

            }
            else
            {
                grb_control.Enabled = false;
                grb_price.Enabled = false;
            }
            total_all_vist = totoal_medcheak + totoal_service;
            txt_price.Text = total_all_vist.ToString();
            //visit_id = Convert.ToInt32(con.VISIT_TBL.Max(w => w.VIS_ID).ToString()) + 1;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            add_vist();
            clear();
            get_state();
        }

        private void btn_servic_Click(object sender, EventArgs e)
        {
            frm_serv_menu frm = new frm_serv_menu();
            frm.visit_id = visit_id;
            frm.coust_id = coust_id;
            frm.ShowDialog();
            totoal_service= frm.total_price;
            get_state();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frm_med_menu frm = new frm_med_menu();
            frm.visit_id = visit_id;
            frm.coust_id = coust_id;
            
            frm.ShowDialog();
            totoal_medcheak = frm.total;
            get_state();

        }

        public bool cheack_empty()
        {
            if (txt_coust_code.Text != "" && txt_coust_fname.Text != "" && coust_id!=0 && txt_vist_code.Text != "") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void clear_pric()
        {
            txt_discount.Text = "0";
            txt_price.Text = "0";
            txt_total.Text = "0";
        }
        void clear()
        {

          
            order_id = 0;
            clear_pric();
            com_pay_type.Text = "";
            txt_doc_note.Text = "";
            txt_coust_age.Text = "";
            txt_coust_code.Text = "";
            txt_coust_fname.Text = "";
            txt_coust_note.Text = "";
            txt_doc_note.Text = "";
            com_clinc_name.Text = "";
            txt_coust_phone.Text = "";
           
            com_clin_id.DataSource = con.CLINC_TBL.ToList();
            com_clin_id.DisplayMember = "CLI_ID";
            com_clin_id.ValueMember = "CLI_NAME";
            com_clinc_name.DataSource = com_clin_id.DataSource;
            com_clinc_name.DisplayMember = "CLI_NAME";
            com_clinc_name.ValueMember = "CLI_ID";
            com_clinc_name.Text = "";
            com_clin_id.Text = "";

            get_state();
            
        }
        void get_order_data()
        {
            var data = (from ord in con.ORDER_TBL
                        join coust in con.CUST_TBL
                  on ord.CUST_ID equals coust.CUST_ID
                        select new
                        {
                            coust.CUST_ID,
                            ord.ORDER_CODE,
                            ord.ORDER_DATE,
                            ord.ORDER_TIME,
                            CUST_F_NAME = coust.CUST_F_NAME + " " + coust.CUST_S_NAME + " " + coust.CUST_T_NAME + " " + coust.CUST_L_NAME,
                            ord.ORDER_ID

                        }).ToList();
            dgv_order.DataSource = data;

            grid_order.Columns.Remove(grid_order.Columns["CUST_ID"]);
            grid_order.Columns.Remove(grid_order.Columns["ORDER_ID"]);
            grid_order.Columns["ORDER_CODE"].Caption = "الكود ";
            grid_order.Columns["CUST_F_NAME"].Caption = "اسم المريض ";
            grid_order.Columns["ORDER_DATE"].Caption = " التاريخ ";
            grid_order.Columns["ORDER_TIME"].Caption = "الوقت";
            get_state();
        }
        
    }
}