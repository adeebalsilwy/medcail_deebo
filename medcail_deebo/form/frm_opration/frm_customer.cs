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
    public partial class frm_customer : DevExpress.XtraEditors.XtraForm
    {
        db.CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        int id = 0,cod;
        string search_word;
        public frm_customer()
        {
            InitializeComponent();
        }

        private void frm_customer_Load(object sender, EventArgs e)
        {
            inshail();
            get_data();
            clear();
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

                    GridControl1.DataSource = data;

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
                dgv_customer.Columns["CUST_AGE"].Caption = " العمر  ";
                dgv_customer.Columns["CUST_MOBLIE1"].Caption = " رقم الهاتف  ";
                dgv_customer.Columns["CUST_ADDRESS"].Caption = " العنوان  ";
            }
            else
            {
                get_data();
            }
        }
        private void labelControl12_Click(object sender, EventArgs e)
        {
            frm_card_list frm = new frm_card_list();
            frm.ShowDialog();
            com_card_id.Text = frm.card_id.ToString();
            txt_coust_state.Text = "مؤمن";

        }
        void sel_cust()
        {
            DataRow row=null;
            if (dgv_customer.RowCount >0 )
            {
                
                
                // id = Convert.ToInt32(dgv_customer.GetFocusedRowCellValue("CUST_ID").ToString());
               int code_se =Convert.ToInt32( dgv_customer.GetFocusedRowCellValue("CUST_CODE").ToString());
                var list = con.CUST_TBL.Where(q => q.CUST_CODE == code_se).FirstOrDefault();
                if (list.CUST_ID != 0)
                {

                    txt_coust_code.Text = list.CUST_CODE.ToString();
                    id = Convert.ToInt32(list.CUST_ID);
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
        void clear()
        {
            id = 0;
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
            com_card_id.DataSource =null;
            com_card_id.Text = "";
            
            com_card_name.Text = "";
            string temp_code = con.CUST_TBL.Max(w => w.CUST_CODE).ToString();
            if (temp_code == "")
            {
                cod = 1;
                txt_coust_code.Text = (1).ToString();
            }
            else
            {
                cod = Convert.ToInt32(temp_code);
                txt_coust_code.Text = (cod + 1).ToString();
            }

            // dtp_birth.Text = "";
            
            get_satate();

        }
        void inshail()
        {

            com_card_id.Enabled = false;
            com_card_name.Enabled = false;

            get_data();
            clear();

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
            GridControl1.DataSource = data;

            //APO_TBL MEDLIST_TBL VISIT_TBL
          

               // GridControl1.DataSource = con.CUST_TBL.ToString();
           
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
            dgv_customer.Columns["CUST_AGE"].Caption = " العمر  ";
            dgv_customer.Columns["CUST_MOBLIE1"].Caption = " رقم الهاتف  ";
            dgv_customer.Columns["CUST_ADDRESS"].Caption = " العنوان  ";
            //gridView1.Columns["DOC_MOBILE"].Caption = "الهاتف";
            //gridView1.Columns["DOC_ADDRESS"].Caption = "الغنوان";
          
        }
        public bool cheack_empty()
        {
            if (txt_coust_code.Text != "" && txt_coust_fname.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txt_search_coust_EditValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_coustom();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
             add_coustom();
          //  MessageBox.Show(id + "");

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
                    db.CUST_TBL del_doc = con.CUST_TBL.Find(id);
                    // del_doc.DOC_ID = id;

                    con.CUST_TBL.Remove(del_doc);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                get_data();
                clear();
            }
        }

        private void dgv_customer_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_search_coust_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txt_coust_fname_TextChanged(object sender, EventArgs e)
        {
            set_search();
        }
        void set_search()
        {
            //txt_search_coust.Text = "";
            //txt_search_coust.Text = txt_coust_fname.Text;
            //txt_search_coust.Text += txt_coust_sname.Text;
            //txt_search_coust.Text += txt_coust_tname.Text;
            //txt_search_coust.Text += txt_coust_lname.Text;
           
            txt_search_coust.Text = txt_coust_fname.Text+" "+txt_coust_sname.Text  +" "+  txt_coust_tname.Text+" "+  txt_coust_lname.Text;
            ;

        }

        private void txt_coust_sname_TextChanged(object sender, EventArgs e)
        {
            set_search();

        }

        private void txt_coust_tname_EditValueChanged(object sender, EventArgs e)
        {
            set_search();

        }

        private void txt_coust_lname_EditValueChanged(object sender, EventArgs e)
        {
            set_search();

        }

        private void txt_coust_fname_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_coust_state_SelectedValueChanged(object sender, EventArgs e)
        {
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
        private void dgv_customer_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            sel_cust();
        }

        private void dgv_customer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            sel_cust();
        }

        private void dgv_customer_DoubleClick(object sender, EventArgs e)
        {
            sel_cust();

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

                        if (id != 0)
                            coust.CUST_ID = id;
                            con.CUST_TBL.AddOrUpdate(coust);
                    if (id != 0)
                        MessageBox.Show("تم التعديل بنجاح ");
                    else
                           MessageBox.Show("تم الاضافه ");
                    con.SaveChanges();
                    get_data();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("ملاحضه لايمكن ان يكون هناك بطاه ائئتمان لاكثر من شخص ","تحذير ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message + ex.InnerException);
                    }


                }
            }

    }
}