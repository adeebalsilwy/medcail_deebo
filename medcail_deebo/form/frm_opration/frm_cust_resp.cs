using DevExpress.XtraEditors;
using medcail_deebo.db;
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
    public partial class frm_cust_resp : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int coust_id, coust_code,order_code,order_id;
        public frm_cust_resp()
        {
            InitializeComponent();
        }

        private void frm_cust_resp_Load(object sender, EventArgs e)
        {
            get_data();
            get_order_data();
            inshail();


        }
        void inshail()
        {

            com_card_id.Enabled = false;
            com_card_name.Enabled = false;

            get_data();
            clear();

        }
        void search()
        {

            if (txt_search_coust.Text != "")
            {
                var data = (from c in con.CUST_TBL

                            select new
                            {
                                CUST_ID = c.CUST_ID,
                                CUST_CODE = c.CUST_CODE.ToString(),
                                CUST_F_NAME = c.CUST_F_NAME + " " + c.CUST_S_NAME + " " + c.CUST_T_NAME + " " + c.CUST_L_NAME,
                                CUST_BD = c.CUST_AGE.ToString(),
                                CUST_ADDRESS = c.CUST_ADDRESS,
                                CUST_MOBLIE1 = c.CUST_MOBLIE1,
                            }).Where(w => w.CUST_F_NAME.Contains(txt_search_coust.Text)).ToList();

                dgv_customera.DataSource = data;

                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_BD"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_AGE"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_ADDRESS"]);

                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_ID"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_BD"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_MOBILE2"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_SAVE_STATE"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_NOTE"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_ID"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CLI_ID"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CLINC_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["APO_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["MEDLIST_TBL"]);
                dgv_customer.Columns.Remove(dgv_customer.Columns["VISIT_TBL"]);


                dgv_customer.Columns["CUST_CODE"].Caption = "الكود";
                dgv_customer.Columns["CUST_F_NAME"].Caption = "اسم المريض  ";
                // dgv_customer.Columns["CUST_AGE"].Caption = " العمر  ";
                dgv_customer.Columns["CUST_MOBLIE1"].Caption = " رقم الهاتف  ";
                // dgv_customer.Columns["CUST_ADDRESS"].Caption = " العنوان  ";
                //gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
                //gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";
            }
            else
            {
                get_data();
            }
        }
        void sel_cust()
        {
            DataRow row = null;
            if (dgv_customer.RowCount > 0)
            {


                // id = Convert.ToInt32(dgv_customer.GetFocusedRowCellValue("CUST_ID").ToString());
                int code_se = Convert.ToInt32(dgv_customer.GetFocusedRowCellValue("CUST_CODE").ToString());
                var list = con.CUST_TBL.Where(q => q.CUST_CODE == code_se).FirstOrDefault();
                if (list.CUST_ID != 0)
                {

                    txt_coust_code.Text = list.CUST_CODE.ToString();
                    coust_id = Convert.ToInt32(list.CUST_ID);
                    txt_coust_fname.Text = list.CUST_F_NAME;
                    txt_coust_address.Text = list.CUST_ADDRESS;
                    txt_coust_age.Text = list.CUST_AGE;
                    txt_coust_birth.Text = list.CUST_BD.ToString();
                    txt_coust_lname.Text = list.CUST_L_NAME;
                    txt_coust_note.Text = list.CUST_NOTE;
                    txt_coust_phone1.Text = list.CUST_MOBLIE1;
                    txt_coust_phone2.Text = list.CUST_MOBILE2;
                    txt_coust_sname.Text = list.CUST_S_NAME;
                    txt_coust_state.Text = list.CUST_SAVE_STATE;
                    txt_coust_tname.Text = list.CUST_T_NAME;
                    com_card_id.Text = list.CARD_ID.ToString();


                }


            }

        }
        void set_search()
        {

           //txt_search_coust.Text = txt_coust_fname.Text+" "+txt_coust_sname.Text  +" "+  txt_coust_tname.Text+" "+  txt_coust_lname.Text;

            txt_search_coust.Text = txt_coust_fname.Text + txt_coust_sname.Text + txt_coust_tname.Text +  txt_coust_lname.Text;
            ;

        }
        void clear()
        {
            coust_id = 0;
            txt_coust_fname.Text = "";
            txt_coust_address.Text = "";
            txt_coust_age.Text = "";
            txt_coust_birth.Text = "";
            txt_coust_code.Text = "";
            txt_coust_lname.Text = "";
            txt_coust_note.Text = "";
            txt_coust_phone1.Text = "";
            txt_coust_phone2.Text = "";
            txt_coust_sname.Text = "";
            txt_coust_state.Text = "";
            txt_coust_tname.Text = "";
            txt_search_coust.Text = "";
            txt_coust_birth.Value = DateTime.Now;
            txt_search_coust.Text = "";
            com_card_id.DataSource = null;
            com_card_id.Text = "";

            com_card_name.Text = "";
            string temp_code = con.CUST_TBL.Max(w => w.CUST_CODE).ToString();
            if (temp_code == "")
            {
                coust_code = 1;
                txt_coust_code.Text = (1).ToString();
            }
            else
            {
                coust_code = Convert.ToInt32(temp_code);
                txt_coust_code.Text = (coust_code + 1).ToString();
            }

            // dtp_birth.Text = "";

            get_satate();

        }
        void get_satate()
        {
            if (txt_coust_state.Text == "مؤمن")
            {
                com_card_id.DataSource = con.CARD_TBL.ToList();
                com_card_id.DisplayMember = "CARD_ID";
                com_card_name.DataSource = com_card_id.DataSource;
                com_card_name.DisplayMember = "CARD_NAME";
                com_card_name.ValueMember = "CARD_ID";
                com_card_id.Enabled = true;
                com_card_name.Enabled = true;
                lbl_card.Enabled = true;

            }
            else
            {
                com_card_id.DataSource = null;
                txt_search_coust.Text = "";
                com_card_id.Text = "1";
                com_card_id.Enabled = false;
                com_card_name.Enabled = false;
                lbl_card.Enabled = false;

            }
        }
        void get_order_data()
        {
            var data = (from ord in con.ORDER_TBL
                        join coust in con.CUST_TBL
                  on ord.CUST_ID equals coust.CUST_ID
                        select new
                        {
                            ord.ORDER_CODE,
                            ord.ORDER_DATE,
                            ord.ORDER_TIME,
                            CUST_F_NAME = coust.CUST_F_NAME + " " + coust.CUST_S_NAME + " " + coust.CUST_T_NAME + " " + coust.CUST_L_NAME,
                            ord.ORDER_ID

                        }).ToList();
            dgv_oder.DataSource = data;
            grid_order.Columns.Remove(grid_order.Columns["ORDER_ID"]);
            grid_order.Columns["ORDER_CODE"].Caption = "الكود ";
            grid_order.Columns["CUST_F_NAME"].Caption = "اسم المريض ";
            grid_order.Columns["ORDER_DATE"].Caption = " التاريخ ";
            grid_order.Columns["ORDER_TIME"].Caption = "الوقت";

        }
        void get_data()
        {

            var data = (from c in con.CUST_TBL

                        select new
                        {
                            CUST_ID = c.CUST_ID,
                            CUST_CODE = c.CUST_CODE.ToString(),
                            CUST_F_NAME = c.CUST_F_NAME + " " + c.CUST_S_NAME + " " + c.CUST_T_NAME + " " + c.CUST_L_NAME,
                            CUST_AGE = c.CUST_AGE.ToString(),
                            CUST_ADDRESS = c.CUST_ADDRESS,
                            CUST_MOBLIE1 = c.CUST_MOBLIE1,
                        }).ToList();
            dgv_customera.DataSource = data;

            //APO_TBL MEDLIST_TBL VISIT_TBL


            // GridControl1.DataSource = con.CUST_TBL.ToString();
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_BD"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_AGE"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_ADDRESS"]);

            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_ID"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_BD"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_MOBILE2"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_SAVE_STATE"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CUST_NOTE"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_ID"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CLI_ID"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CLINC_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["CARD_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["APO_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["MEDLIST_TBL"]);
            dgv_customer.Columns.Remove(dgv_customer.Columns["VISIT_TBL"]);


            dgv_customer.Columns["CUST_CODE"].Caption = "الكود";
            dgv_customer.Columns["CUST_F_NAME"].Caption = "اسم المريض  ";
           // dgv_customer.Columns["CUST_AGE"].Caption = " العمر  ";
            dgv_customer.Columns["CUST_MOBLIE1"].Caption = " رقم الهاتف  ";
           // dgv_customer.Columns["CUST_ADDRESS"].Caption = " العنوان  ";
            //gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
            //gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";

        }
        void add_coustom()
        {

            if (cheack_empty() == true)
            {
                try
                {
                    CUST_TBL coust = new CUST_TBL();
                    coust.CUST_CODE = Convert.ToInt32(txt_coust_code.Text);
                    coust.CUST_F_NAME = txt_coust_fname.Text;
                    coust.CUST_S_NAME = txt_coust_sname.Text;
                    coust.CUST_T_NAME = txt_coust_tname.Text;
                    coust.CUST_L_NAME = txt_coust_lname.Text;
                    coust.CUST_AGE = txt_coust_age.Text;
                    coust.CUST_BD = Convert.ToDateTime(txt_coust_birth.Value);
                    coust.CUST_MOBLIE1 = txt_coust_phone1.Text;
                    coust.CUST_MOBILE2 = txt_coust_phone2.Text;
                    coust.CUST_ADDRESS = txt_coust_address.Text;

                    coust.CUST_SAVE_STATE = txt_coust_state.Text;

                    coust.CUST_NOTE = txt_coust_note.Text;

                    coust.CARD_ID = Convert.ToInt32(com_card_id.Text);


                    coust.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;

                    if (coust_id != 0)
                        coust.CUST_ID = coust_id;
                    if (coust_id != 0)
                        MessageBox.Show("تم التعديل بنجاح ");
                    else
                    {
                        MessageBox.Show("تم الاضافه ");
                        
                    }
                    con.CUST_TBL.AddOrUpdate(coust);

                    con.SaveChanges();
                    coust_id = Convert.ToInt32(coust.CUST_ID);
                    get_data();
                    
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("ملاحضه لايمكن ان يكون هناك بطاه ائئتمان لاكثر من شخص ","تحذير ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message + ex.InnerException);
                }


            }
        }

        private void txt_coust_fname_TextChanged(object sender, EventArgs e)
        {
            set_search();
        }

        private void txt_coust_sname_TextChanged(object sender, EventArgs e)
        {
            set_search();
        }

        private void txt_coust_tname_TextChanged(object sender, EventArgs e)
        {
            set_search();
        }

        private void txt_coust_lname_TextChanged(object sender, EventArgs e)
        {
            set_search();
        }

        private void lbl_card_Click(object sender, EventArgs e)
        {
            frm_card_list frm = new frm_card_list();
            frm.ShowDialog();
            com_card_id.Text = frm.card_id.ToString();
            txt_coust_state.Text = "مؤمن";

        }

        private void txt_search_coust_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_customer_DoubleClick(object sender, EventArgs e)
        {
            sel_cust();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_coustom();
            add_order();
            clear();


        }
        void add_order()
        {
            try
            {
                ORDER_TBL ord = new ORDER_TBL();
                string temp_code = con.ORDER_TBL.Max(w => w.ORDER_CODE).ToString();
                if (temp_code == "")
                {
                    order_code = 1;

                }
                else
                {
                    order_code = Convert.ToInt32(temp_code)+1;

                }
                ord.ORDER_CODE = order_code;
                ord.CUST_ID = coust_id;
                ord.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;
                ord.ORDER_DATE = DateTime.Now;
                ord.ORDER_TIME =DateTime.Now.ToShortTimeString();
                ord.ORDER_NOTE = "";
                con.ORDER_TBL.Add(ord);
                con.SaveChanges();
                get_data();
                get_order_data();
                clear();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(string.Format(DateTime.Now.ToShortTimeString(),"HH:MI"));
            if (coust_id != 0)
            {
                add_order();
            }
            else
                MessageBox.Show("الرجاء اختيار المريض من القائمه او اضافه مريض جديد ");
        }

        private void dgv_customera_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            delete_order();
        }
        void delete_order()
        {
            if (grid_order.RowCount> 0)
            {
                order_id =Convert.ToInt32(grid_order.GetFocusedRowCellValue("ORDER_ID").ToString());
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
                get_data();
                get_order_data();
                clear();
            }
        }
private void btn_update_Click(object sender, EventArgs e)
        {
            add_coustom();
            add_order();
            clear();
        }

        private void txt_coust_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_satate();
        }

        public bool cheack_empty()
        {
            if (txt_coust_code.Text != "" && txt_coust_fname.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}