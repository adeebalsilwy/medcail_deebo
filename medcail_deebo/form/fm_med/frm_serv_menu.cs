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
    public partial class frm_serv_menu : DevExpress.XtraEditors.XtraForm
    {
        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();
        public int coust_id, visit_id, servis_id, serv_list_code = 0, temp;
        public float total_price=0;

        public frm_serv_menu()
        {
            InitializeComponent();
        }

        private void frm_serv_menu_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("مرحبا انت في الزياره رقم  " + "   " + visit_id);

            get_all_servic();
            var da = (from c in con.CUST_TBL
                      where c.CUST_ID == coust_id
                      select new
                      {
                          full_name = c.CUST_F_NAME + " " + c.CUST_S_NAME + " " + c.CUST_T_NAME + " " + c.CUST_L_NAME,
                      }).ToList();
            if (da.Count > 0)
            {
                lbl_coust_name.Text = da.First().full_name.ToString();
            }
            get_vist_sevice();
        }
        void add_serv_List()
        {


            
            SERLIST_TBL d_serv_list = new SERLIST_TBL();
            if (grid_all_service.RowCount > 0)
            {
                try
                {

                    d_serv_list.SERLIST_CODE = serv_list_code;
                    d_serv_list.SER_ID = Convert.ToInt32(grid_all_service.GetFocusedRowCellValue("SER_ID"));

                   // d_serv_list.SERLIST_NAME = grid_all_service.GetFocusedRowCellValue("SER_NAME").ToString();
                    d_serv_list.SERLIST_DATE = DateTime.Now;
                    d_serv_list.SERLIST_TIME = DateTime.Now.ToShortTimeString();
                    d_serv_list.CUST_ID = coust_id;
                    d_serv_list.VIS_ID = visit_id;
                    d_serv_list.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;
                    d_serv_list.SER_PRICE_TOTAL =decimal.Parse(grid_all_service.GetFocusedRowCellValue("SER_PRICE").ToString());
                    var search = con.SERLIST_TBL.Where(w => w.SER_ID == d_serv_list.SER_ID && w.VIS_ID == visit_id && w.CUST_ID == coust_id).ToList();
                    if (search.Count == 0)
                    {
                        con.SERLIST_TBL.Add(d_serv_list);
                        con.SaveChanges();

                    serv_list_code = Convert.ToInt32(con.SERLIST_TBL.Max(w => w.SERLIST_CODE)) + 1;
                    lbl_coust_name.Text += "   " + serv_list_code.ToString();
                    }
                    else
                    {
                        MessageBox.Show("الاجراء مضاف الى قائمه المريض ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("الاجراء مضاف الى قائمه المريض ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void delete_serv_list()
        {
            if (gridView1.RowCount > 0)
            {
                int del = Convert.ToInt32(gridView1.GetFocusedRowCellValue("SERLIST_ID"));
                DialogResult res = MessageBox.Show("هل تريد  ازاله التشخيص من قائمه المريض  ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    SERLIST_TBL del_dig = con.SERLIST_TBL.Where(w => w.CUST_ID == coust_id && w.VIS_ID == visit_id && w.SERLIST_ID == del).FirstOrDefault(); ;
                    // del_doc.DOC_ID = id;

                    con.SERLIST_TBL.Remove(del_dig);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
            }
        
        }

        private void btn_new_dagno_Click(object sender, EventArgs e)
        {
            frm_servic frm = new frm_servic();
            frm.ShowDialog();
            get_all_servic();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_all_servic();
        }

        private void grid_all_service_DoubleClick(object sender, EventArgs e)
        {
           add_serv_List();
            get_vist_sevice();
        }

        private void btn_mor_using_Click(object sender, EventArgs e)
        {
            get_resent_service();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            get_pref_vist();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            delete_serv_list();
            get_vist_sevice();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            delete_all_list();
            get_vist_sevice();
        }

        void delete_all_list()
        {
            if (gridView1.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("هل تريد  ازاله حميع تشاخيص المريض من القائمه   ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {

                    foreach (var rem in con.SERLIST_TBL.Where(w => w.CUST_ID == coust_id && w.VIS_ID == visit_id))
                    {
                        con.SERLIST_TBL.Remove(rem);

                    }
                    con.SaveChanges();
                    // del_doc.DOC_ID = id;


                    MessageBox.Show("تم الحذف بنجاح ");
                }
            }
       
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            get_vist_sevice();
        }

        void get_all_servic()
        {
            //string s = "CARD_TBL   CLINC_TBL"
            grb_dag.Text = "قائمه الاجراءات ";

            dgv_serverce.DataSource = con.SERVICE_TBL.ToList();
            grid_all_service.Columns.Remove(grid_all_service.Columns["CLI_ID"]);
            grid_all_service.Columns.Remove(grid_all_service.Columns["SER_ID"]);
            grid_all_service.Columns.Remove(grid_all_service.Columns["SERLIST_TBL"]);
            grid_all_service.Columns.Remove(grid_all_service.Columns["CLINC_TBL"]);
            grid_all_service.Columns.Remove(grid_all_service.Columns["SER_NOTE"]);

            grid_all_service.Columns["SER_CODE"].Caption = "الكود";
            grid_all_service.Columns["SER_NAME"].Caption = "اسم الخدمه ";
            grid_all_service.Columns["SER_TYPE"].Caption = "نوع الخدمه";
            grid_all_service.Columns["SER_PRICE"].Caption = "السعر";
           // grid_all_service.Columns["SER_NOTE"].Caption = " ملاحضات  ";

            }
        void get_pref_vist()
        {
            var data = (from s_list in con.SERLIST_TBL
                        join se in con.SERVICE_TBL
on s_list.SER_ID equals se.SER_ID
                        select new
                        {
                            s_list.SERLIST_ID,
                            s_list.SERLIST_CODE,
                            se.SER_NAME,
                            se.SER_TYPE,
                            s_list.SERLIST_DATE,
                            s_list.SERLIST_TIME,
                            s_list.VIS_ID,
                            s_list.CUST_ID,




                        }).Where(w =>  w.CUST_ID == coust_id).ToList();
            dgv_vist_serv.DataSource = data;

            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["VIS_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SERLIST_ID"]);

            gridView1.Columns["SERLIST_CODE"].Caption = "الكود";
            gridView1.Columns["SER_NAME"].Caption = "اسم الاجراء ";
            gridView1.Columns["SERLIST_DATE"].Caption = "تاريخ الاجراء ";
            gridView1.Columns["SERLIST_TIME"].Caption = " وقت الاجراء ";
            gridView1.Columns["SER_TYPE"].Caption = " نوع الاجراء ";
            gridView1.BestFitColumns();
        }
       void get_vist_sevice()
            {
                //con.DIGLIST_TBL.Where(w => w.VIS_ID == visit_id || w.CUST_ID == coust_id).ToList();

                //grid_all_dagno.Columns.Remove(gridView1.Columns["CLI_ID"]);

                var data = (from s_list in con.SERLIST_TBL
                            join se in con.SERVICE_TBL
    on s_list.SER_ID equals se.SER_ID
                            select new
                            {
                                s_list.SERLIST_ID,
                                s_list.SERLIST_CODE,
                                se.SER_NAME,
                                se.SER_TYPE,
                                s_list.SERLIST_DATE,
                                s_list.SERLIST_TIME,
                                s_list.VIS_ID,
                                s_list.CUST_ID,
                                s_list.SER_PRICE_TOTAL




                            }).Where(w => w.VIS_ID == visit_id && w.CUST_ID == coust_id).ToList();
                dgv_vist_serv.DataSource = data;
           total_price=float.Parse(data.Sum(w=>w.SER_PRICE_TOTAL).ToString());
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["VIS_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["SERLIST_ID"]);
               lbl_total_price.Text=total_price.ToString();
                gridView1.Columns["SERLIST_CODE"].Caption = "الكود";
                gridView1.Columns["SER_NAME"].Caption ="اسم الاجراء ";
                gridView1.Columns["SERLIST_DATE"].Caption = "تاريخ الاجراء ";
            gridView1.Columns["SERLIST_TIME"].Caption = " وقت الاجراء ";
            gridView1.Columns["SER_TYPE"].Caption = " نوع الاجراء ";
            gridView1.BestFitColumns();
            //gridView1.Columns["SERLIST_DATE"].Caption = "تاريخ التشخيص ";


        }
        void get_resent_service()
            {
            grb_dag.Text = "قائمه الاكثر استخداما  ";

            string search = "";
                var query = (from d in con.SERVICE_TBL
                             join
                      dl in con.SERLIST_TBL on
                          d.SER_ID equals dl.SER_ID
                             group new { d, dl } by new { d.SER_CODE, d.SER_ID,d.SER_NAME, d.SER_PRICE, d.SER_TYPE } into newgroup
                             select new
                             {
                                 SER_ID= newgroup.Key.SER_ID,
                                 SER_CODE = newgroup.Key.SER_CODE,
                                 SER_NAME = newgroup.Key.SER_NAME,
                                 SER_TYPE = newgroup.Key.SER_TYPE,
                                 SER_PRICE = newgroup.Key.SER_PRICE,
                                 SER_COUNT = newgroup.Count()
                             }).ToList();


                dgv_serverce.DataSource = query.Where(w => w.SER_COUNT > 20).OrderByDescending(w => w.SER_COUNT).ToList();

            grid_all_service.Columns.Remove(grid_all_service.Columns["SER_ID"]);
            grid_all_service.Columns["SER_CODE"].Caption = "الكود";
            grid_all_service.Columns["SER_NAME"].Caption = "اسم الخدمه ";
            grid_all_service.Columns["SER_TYPE"].Caption = "نوع الخدمه";
            grid_all_service.Columns["SER_PRICE"].Caption = "السعر";
            grid_all_service.Columns["SER_COUNT"].Caption = "عدد التكرار";
            //grid_all_dagno.Columns["id"].Caption = "الكود";
            //grid_all_dagno.Columns["name"].Caption = "اسم التشيخص ";
            //grid_all_dagno.Columns["type"].Caption = "نوع التشيخص";
            //grid_all_dagno.Columns["Count"].Caption = "عدد الاستخدام  ";


        }

        }
    
}