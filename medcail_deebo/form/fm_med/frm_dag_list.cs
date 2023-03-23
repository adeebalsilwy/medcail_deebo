using DevExpress.XtraEditors;
using medcail_deebo.db;
using medcail_deebo.form.frm_list;
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
    public partial class frm_dag_list : DevExpress.XtraEditors.XtraForm
    {
        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();
        public int coust_id, visit_id, dagno_id, dlist_code=0, temp;

        private void btn_new_dagno_Click(object sender, EventArgs e)
        {
            frm_dignos frm = new frm_dignos();
            frm.ShowDialog();
            get_all_dagno();
            get_vist_dagno();
        }

        public frm_dag_list()
        {
            InitializeComponent();
        }

        private void btn_mor_using_Click(object sender, EventArgs e)
        {
            grb_dag.Text = "قائمه الاكثر استخداما ";
            get_resent_dagno();
           //get_temp();
        }
        void get_resent_dagno()
        {
            string search = "";
            var query = (from d in con.DIAGNOIS_TBL
                         join
                  dl in con.DIGLIST_TBL on
                      d.DIG_ID equals dl.DIG_ID
                         group new { d, dl } by new { d.DIG_NAME, d.DIG_ID,d.DIG_TYPE  } into newgroup
                         select new
                         {
                             DIG_CODE = newgroup.Key.DIG_ID,
                             DIG_NAME = newgroup.Key.DIG_NAME,
                             DIG_TYPE = newgroup.Key.DIG_TYPE,
                             DIG_NOTE = newgroup.Count()
                         }).ToList();
            
                           
            dgv_dagino.DataSource=query.Where(w=>w.DIG_NOTE>20).OrderByDescending(w=>w.DIG_NOTE).ToList();


            grid_all_dagno.Columns["DIG_CODE"].Caption = "الكود";
            grid_all_dagno.Columns["DIG_NAME"].Caption = "اسم التشيخص ";
            grid_all_dagno.Columns["DIG_TYPE"].Caption = "نوع التشيخص";
            grid_all_dagno.Columns["DIG_NOTE"].Caption = "عدد الاستخدام ";
            //grid_all_dagno.Columns["id"].Caption = "الكود";
            //grid_all_dagno.Columns["name"].Caption = "اسم التشيخص ";
            //grid_all_dagno.Columns["type"].Caption = "نوع التشيخص";
            //grid_all_dagno.Columns["Count"].Caption = "عدد الاستخدام  ";


        }
        
        void get_vist_dagno()
        {
            //con.DIGLIST_TBL.Where(w => w.VIS_ID == visit_id || w.CUST_ID == coust_id).ToList();

            //grid_all_dagno.Columns.Remove(gridView1.Columns["CLI_ID"]);

            var data = (from d_list in con.DIGLIST_TBL
                        join dagno in con.DIAGNOIS_TBL
on d_list.DIG_ID equals dagno.DIG_ID
                        select new
                        {
                            d_list.DIGLIST_ID,
                            d_list.DIGLIST_CODE,
                            dagno.DIG_NAME,
                            d_list.DIGLIST_DATE,
                            d_list.VIS_ID,
                            d_list.CUST_ID,



                        }).Where(w => w.VIS_ID == visit_id && w.CUST_ID == coust_id).ToList() ;
            dgv_vist_dagno.DataSource = data;
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["VIS_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DIGLIST_ID"]);

            gridView1.Columns["DIGLIST_CODE"].Caption = "الكود";
            gridView1.Columns["DIG_NAME"].Caption = "اسم التشيخص ";
            gridView1.Columns["DIGLIST_DATE"].Caption = "تاريخ التشخيص ";
            string te = con.DIGLIST_TBL.Max(w => w.DIGLIST_CODE).ToString();
            if (te !="")
            {
                dlist_code = Convert.ToInt32(te);
            }
        }

        private void grid_all_dagno_DoubleClick(object sender, EventArgs e)
        {
            add_dagno_list();
            get_vist_dagno();
            //get_all_dagno();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            delete_dagno_list();
            get_vist_dagno();
            get_all_dagno();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            delete_dagno_list();
        }

        void get_all_dagno()
        {
            grb_dag.Text = "قائمه التسخايص  ";
            dgv_dagino.DataSource = con.DIAGNOIS_TBL.ToList();


            grid_all_dagno.Columns.Remove(grid_all_dagno.Columns["CLI_ID"]);
            grid_all_dagno.Columns.Remove(grid_all_dagno.Columns["DIG_ID"]);
            grid_all_dagno.Columns.Remove(grid_all_dagno.Columns["DIGLIST_TBL"]);
            grid_all_dagno.Columns.Remove(grid_all_dagno.Columns["CLINC_TBL"]);
            grid_all_dagno.Columns.Remove(grid_all_dagno.Columns["DIG_ID"]);
            //grid_all_dagno.Columns.Remove(gridView1.Columns["CLI_ID"]);
            //grid_all_dagno.Columns.Remove(gridView1.Columns["CLI_ID"]);

            grid_all_dagno.Columns["DIG_CODE"].Caption = "الكود";
            grid_all_dagno.Columns["DIG_NAME"].Caption = "اسم التشيخص ";
            grid_all_dagno.Columns["DIG_TYPE"].Caption = "نوع التشيخص";
            grid_all_dagno.Columns["DIG_NOTE"].Caption = "ملاحضات ";

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            delete_all_list();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            get_pref_digno();
        }
        void get_pref_digno()
        {
            var data = (from d_list in con.DIGLIST_TBL
                        join dagno in con.DIAGNOIS_TBL
on d_list.DIG_ID equals dagno.DIG_ID
                        select new
                        {
                            d_list.DIGLIST_ID,
                            d_list.DIGLIST_CODE,
                            dagno.DIG_NAME,
                            d_list.DIGLIST_DATE,
                            d_list.VIS_ID,
                            d_list.CUST_ID,



                        }).Where( w=>w.CUST_ID == coust_id).ToList();
            dgv_vist_dagno.DataSource = data;
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["VIS_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DIGLIST_ID"]);

            gridView1.Columns["DIGLIST_CODE"].Caption = "الكود";
            gridView1.Columns["DIG_NAME"].Caption = "اسم التشيخص ";
            gridView1.Columns["DIGLIST_DATE"].Caption = "تاريخ التشخيص ";
            string te = con.DIGLIST_TBL.Max(w => w.DIGLIST_CODE).ToString();
            if (te != "")
            {
                dlist_code = Convert.ToInt32(te);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_all_dagno();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            get_vist_dagno();
        }

        void add_dagno_list()
        {
            decimal d_l_id;
            try
            {

                d_l_id = con.DIGLIST_TBL.Select(p => p.DIGLIST_ID).Cast<decimal?>().Max() ?? 0;
               // d_l_id = Convert.ToInt32(con.DIGLIST_TBL.Max(w => w.DIGLIST_ID).ToString()) + 1;
                dlist_code= Convert.ToInt32(con.DIGLIST_TBL.Max(w => w.DIGLIST_ID).ToString()) + 1;


            }
            catch(Exception ex)
            {
                d_l_id = 1;
                dlist_code = 1;
            }
            DIGLIST_TBL dlist = new DIGLIST_TBL();
            if (grid_all_dagno.RowCount > 0)
            {
                try
                {
                    
                        dlist.DIGLIST_CODE = dlist_code;
                    dlist.DIG_ID = Convert.ToInt32(grid_all_dagno.GetFocusedRowCellValue("DIG_ID"));
                   
                 

                   
                        dlist.DIGLIST_NAME = grid_all_dagno.GetFocusedRowCellValue("DIG_NAME").ToString();
                        dlist.DIGLIST_DATE = DateTime.Now;
                        dlist.DIGLIST_TIME = DateTime.Now.ToShortTimeString();
                        dlist.CUST_ID = coust_id;
                        dlist.VIS_ID = visit_id;
                        dlist.CLI_ID = medcail_deebo.Properties.Settings.Default.clinc_id;

                        var search = con.DIGLIST_TBL.Where(w=>w.DIG_ID ==dlist.DIG_ID &&  w.VIS_ID== visit_id &&w.CUST_ID==coust_id).ToList();
                        if (search.Count == 0)
                        {
                            con.DIGLIST_TBL.Add(dlist);
                            con.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("التشخيص مضاف الى قائمه المريض ");
                        }
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("التشخيص مضاف الى قائمه المريض ");
                }
            }
        }
        void delete_dagno_list()
        {
            if (gridView1.RowCount > 0)
            {
                int del = Convert.ToInt32(gridView1.GetFocusedRowCellValue("DIGLIST_ID"));
                DialogResult res = MessageBox.Show("هل تريد  ازاله التشخيص من قائمه المريض  ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    DIGLIST_TBL del_dig = con.DIGLIST_TBL.Where(w => w.CUST_ID == coust_id && w.VIS_ID == visit_id&&w.DIGLIST_ID==del).FirstOrDefault(); ;
                    // del_doc.DOC_ID = id;
                    
                    con.DIGLIST_TBL.Remove(del_dig);
                    con.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح ");
                }
            }
            get_vist_dagno();
        }
        void delete_all_list()
        {
            if (gridView1.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("هل تريد  ازاله حميع تشاخيص المريض من القائمه   ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {

                    foreach(var rem in  con.DIGLIST_TBL.Where(w => w.CUST_ID == coust_id && w.VIS_ID == visit_id)){
                        con.DIGLIST_TBL.Remove(rem);
                       
                    }
                    con.SaveChanges();
                    // del_doc.DOC_ID = nmj89 id;


                    MessageBox.Show("تم الحذف بنجاح ");
                }
            }
            get_vist_dagno();
        }
        private void frm_dag_list_Load(object sender, EventArgs e)
        {
           get_all_dagno();
            get_vist_dagno();
            var da = (from c in con.CUST_TBL where c.CUST_ID == coust_id
                       select new 
                       {
                           full_name = c.CUST_F_NAME +""+ c.CUST_S_NAME + "" + c.CUST_T_NAME + "" + c.CUST_L_NAME,
                       }).ToList();
            if (da.Count>0)
            {
                lbl_coust_name.Text = da.First().full_name.ToString();
            }

        }

    }
}