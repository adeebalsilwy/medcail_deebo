using DevExpress.XtraEditors;
using medcail_deebo.db;
using medcail_deebo.form.frm_opration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.fm_med
{
    public partial class frm_med_menu : DevExpress.XtraEditors.XtraForm
    {
        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();
        public int coust_id, med_req_id, visit_id, dagno_id, med_req_code = 0, temp;
        public float total=0;
        public string med_req_name;


        public frm_med_menu()
        {
            InitializeComponent();
        }

    
          

    
           
            void get_resent_medcheak()
            {
            grb_dag.Text = "قائمه الاكثر استخداما ";
                string search = "";
                var query = (from d in con.MEDCHEK_TBL
                             join
                      dl in con.MEDREQ_TBL on
                          d.MEDCHECK_ID equals dl.MEDCHECK_ID
                             group new { d, dl } by new { d.MEDCHEK_NAME, d.MEDCHECK_ID, d.MEDCHEK_TYPE,d.MEDCHEK_CODE,d.MEDCHEK_PRICE } into newgroup
                             select new
                             {
                                 MEDCHEK_CODE = newgroup.Key.MEDCHEK_CODE,
                                 MEDCHEK_NAME = newgroup.Key.MEDCHEK_NAME,
                                 MEDCHEK_TYPE = newgroup.Key.MEDCHEK_TYPE,
                                 MEDCHEK_PRICE = newgroup.Key.MEDCHEK_PRICE,
                                 MEDCHECK_ID = newgroup.Key.MEDCHECK_ID,

                                 MEDCHEK_NOTE = newgroup.Count()
                             }).ToList();


                dgv_medc.DataSource = query.Where(w => w.MEDCHEK_NOTE > 20).OrderByDescending(w => w.MEDCHEK_NOTE).ToList();
            grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MEDCHECK_ID"]);
            grid_all_medcin.Columns["MEDCHEK_CODE"].Caption = "الكود";
            grid_all_medcin.Columns["MEDCHEK_NAME"].Caption = "اسم الفحص ";
            grid_all_medcin.Columns["MEDCHEK_TYPE"].Caption = " نوع الفحص  ";
            grid_all_medcin.Columns["MEDCHEK_PRICE"].Caption = "السعر  ";
            grid_all_medcin.Columns["MEDCHEK_NOTE"].Caption = "ملاحضات ";

            //grid_all_dagno.Columns["name"].Caption = "اسم التشيخص ";
            //grid_all_dagno.Columns["type"].Caption = "نوع التشيخص";
            //grid_all_dagno.Columns["Count"].Caption = "عدد الاستخدام  ";


        }

        void get_vist_medreq()
            {
                //con.DIGLIST_TBL.Where(w => w.VIS_ID == visit_id || w.CUST_ID == coust_id).ToList();

                //grid_all_dagno.Columns.Remove(gridView1.Columns["CLI_ID"]);

                var data = (from mc in con.MEDCHEK_TBL
                            join mr in con.MEDREQ_TBL
    on mc.MEDCHECK_ID equals mr.MEDCHECK_ID
                            select new
                            {
                               mr.MEDREQ_CODE,
                                mr.MEDREQ_ID,
                                mr.MEDREQ_NAME,
                                mr.MEDREQ_DATE,
                                mr.MEDREQ_TIME,
                                mr.MEDREQ_RESULT,
                                mr.VIS_ID,
                                mr.CUST_ID,
                                mc.MEDCHEK_PRICE,
                                //mr.MEDREQ_STATE


                            }).Where(w => w.VIS_ID == visit_id && w.CUST_ID == coust_id).ToList();
                dgv_vist_med_req.DataSource = data;
                gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            //gridView1.Columns.Remove(gridView1.Columns["MEDREQ_STATE"]);

            gridView1.Columns.Remove(gridView1.Columns["VIS_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["MEDREQ_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDCHEK_PRICE"]);
            if (data.Count > 0)
            {
                var temp =data.Sum(a => a.MEDCHEK_PRICE).ToString();
                if (temp !="")
                    total = float.Parse(temp.ToString());
            }
            else
            {
                total = 0;
            }
                gridView1.Columns["MEDREQ_CODE"].Caption = "الكود";
                gridView1.Columns["MEDREQ_NAME"].Caption = "اسم الفحص ";
                gridView1.Columns["MEDREQ_DATE"].Caption = "تاريخ الفحص ";
                gridView1.Columns["MEDREQ_TIME"].Caption = " وقت الفحص  ";
                gridView1.Columns["MEDREQ_RESULT"].Caption = "النتيجه  ";
            //gridView1.Columns["MEDREQ_DATE"].Caption = "تاريخ التشخيص ";

            string te = con.MEDREQ_TBL.Max(w => w.MEDREQ_CODE).ToString();
                if (te != "")
                {
                    med_req_code = Convert.ToInt32(te);
                }
                lbl_total.Text = total.ToString();

            }

           

          
           

            void get_all_medcheak()
            {
                grb_dag.Text = "قائمه التسخايص  ";
           
                //string s = "CARD_TBL   CLINC_TBL"
                dgv_medc.DataSource = con.MEDCHEK_TBL.ToList();


                grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["CLI_ID"]);
                grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MEDCHECK_ID"]);
                grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["MEDREQ_TBL"]);
                grid_all_medcin.Columns.Remove(grid_all_medcin.Columns["CLINC_TBL"]);

                grid_all_medcin.Columns["MEDCHEK_CODE"].Caption = "الكود";
                grid_all_medcin.Columns["MEDCHEK_NAME"].Caption = "اسم الفحص ";
                grid_all_medcin.Columns["MEDCHEK_TYPE"].Caption = " نوع الفحص  ";
                grid_all_medcin.Columns["MEDCHEK_PRICE"].Caption = "السعر  ";
                grid_all_medcin.Columns["MEDCHEK_NOTE"].Caption = "ملاحضات ";



            

        }

            private void simpleButton3_Click(object sender, EventArgs e)
            {
                delete_all_list();
            get_vist_medreq();
            }

           
            void get_pref_digno()
            {

            var data = (from mc in con.MEDCHEK_TBL
                        join mr in con.MEDREQ_TBL
on mc.MEDCHECK_ID equals mr.MEDCHECK_ID
                        select new
                        {

                            mr.MEDREQ_ID,
                            mr.MEDREQ_NAME,
                            mr.MEDREQ_DATE,
                            mr.MEDREQ_TIME,
                            mr.MEDREQ_RESULT,
                            mr.MEDREQ_CODE,
                            mr.VIS_ID,
                            mr.CUST_ID,



                        }).Where(w => w.CUST_ID == coust_id &&w.VIS_ID!=visit_id).ToList();
            dgv_vist_med_req.DataSource = data;
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["VIS_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["MEDREQ_ID"]);

            gridView1.Columns["MEDREQ_CODE"].Caption = "الكود";
            gridView1.Columns["MEDREQ_NAME"].Caption = "اسم الفحص ";
            gridView1.Columns["MEDREQ_DATE"].Caption = "تاريخ الفحص ";
            gridView1.Columns["MEDREQ_TIME"].Caption = " وقت الفحص  ";
            gridView1.Columns["MEDREQ_RESULT"].Caption = "النتيجه  ";
            //gridView1.Columns["MEDREQ_DATE"].Caption = "تاريخ التشخيص ";

            string te = con.MEDREQ_TBL.Max(w => w.MEDREQ_CODE).ToString();
            if (te != "")
            {
                med_req_code = Convert.ToInt32(te);
            }

       
             
            }

        private void frm_med_menu_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("مرحبا انت في الزياره رقم  " + "   " + visit_id);

            load();
        }

        private void btn_new_dagno_Click(object sender, EventArgs e)
        {
            frm_medchek frm = new frm_medchek();
            frm.ShowDialog();
            get_all_medcheak();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_all_medcheak();
        }

        private void btn_mor_using_Click(object sender, EventArgs e)
        {
            get_resent_medcheak();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            get_pref_digno();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            get_vist_medreq();
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            delete_all_list();
            get_vist_medreq();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            delete_med_req_list();
            get_vist_medreq();
        }

        private void grid_all_medcin_DoubleClick(object sender, EventArgs e)
        {
            add_medreq_list();
            get_vist_medreq();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                med_req_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MEDREQ_ID"));
                med_req_name = gridView1.GetFocusedRowCellValue("MEDREQ_NAME").ToString();
                frm_medresult frm = new frm_medresult();
                frm.txt_medreq_id.Text = med_req_id.ToString();
                frm.txt_medcreq_name.Text = med_req_name.ToString();
                frm.ShowDialog();

            }
            get_vist_medreq();
        }
       
        void add_medreq_list()
            {
                decimal d_l_id;
                try
                {

                    d_l_id = con.MEDREQ_TBL.Select(p => p.MEDREQ_ID).Cast<decimal?>().Max() ?? 0;
                    // d_l_id = Convert.ToInt32(con.DIGLIST_TBL.Max(w => w.DIGLIST_ID).ToString()) + 1;
                    med_req_code = Convert.ToInt32(con.MEDREQ_TBL.Max(w => w.MEDREQ_CODE).ToString()) + 1;


                }
                catch (Exception ex)
                {
                    d_l_id = 1;
                    med_req_code = 1;
                }
                MEDREQ_TBL medch_List = new MEDREQ_TBL();
                if (grid_all_medcin.RowCount > 0)
                {
                    try
                    {

                        medch_List.MEDREQ_CODE = med_req_code;
                        medch_List.MEDCHECK_ID = Convert.ToInt32(grid_all_medcin.GetFocusedRowCellValue("MEDCHECK_ID"));
                        medch_List.MEDREQ_NAME = grid_all_medcin.GetFocusedRowCellValue("MEDCHEK_NAME").ToString();
                        medch_List.MEDREQ_DATE = DateTime.Now;
                        medch_List.MEDREQ_TIME =DateTime.Now.ToShortTimeString();
                        medch_List.CUST_ID = coust_id;
                        medch_List.VIS_ID = visit_id;
                        medch_List.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;
                       // medch_List.MEDREQ_STATE = "open";
                        var search = con.MEDREQ_TBL.Where(w => w.MEDCHECK_ID == medch_List.MEDCHECK_ID && w.VIS_ID == visit_id && w.CUST_ID == coust_id).ToList();
                        if (search.Count == 0)
                        {
                            con.MEDREQ_TBL.Add(medch_List);
                            con.SaveChanges();
                        }
                    else
                    {
                        MessageBox.Show("التشخيص مضاف الى قائمه المريض ");
                    }


                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message+ex.InnerException);
                    }
                }
            }
            void delete_med_req_list()
            {
                if (gridView1.RowCount > 0)
                {
                    int del = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MEDREQ_ID"));
                    DialogResult res = MessageBox.Show("هل تريد  ازاله التشخيص من قائمه المريض  ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        MEDREQ_TBL del_dig = con.MEDREQ_TBL.Where(w => w.CUST_ID == coust_id  && w.MEDREQ_ID == del).FirstOrDefault(); ;
                        // del_doc.DOC_ID = id;

                        con.MEDREQ_TBL.Remove(del_dig);
                        con.SaveChanges();
                        MessageBox.Show("تم الحذف بنجاح ");
                    }
                }
                get_vist_medreq();
            }
            void delete_all_list()
            {
                if (gridView1.RowCount > 0)
                {
                    DialogResult res = MessageBox.Show("هل تريد  ازاله حميع تشاخيص المريض من القائمه   ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {

                        foreach (var rem in con.MEDREQ_TBL.Where(w => w.CUST_ID == coust_id && w.VIS_ID == visit_id))
                        {
                            con.MEDREQ_TBL.Remove(rem);

                        }
                        con.SaveChanges();
                        // del_doc.DOC_ID = nmj89 id;


                        MessageBox.Show("تم الحذف بنجاح ");
                    }
                }
                get_vist_medreq();
            }
           void load()
            { 
                get_all_medcheak();
                get_vist_medreq();
                var da = (from c in con.CUST_TBL
                          where c.CUST_ID == coust_id
                          select new
                          {
                              full_name = c.CUST_F_NAME + "" + c.CUST_S_NAME + "" + c.CUST_T_NAME + "" + c.CUST_L_NAME,
                          }).ToList();
                if (da.Count > 0)
                {
                    lbl_coust_name.Text = da.First().full_name.ToString();
                }

            }

        }
    }

