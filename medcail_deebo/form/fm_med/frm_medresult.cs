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
    public partial class frm_medresult : DevExpress.XtraEditors.XtraForm
    {
        CLINIC_DATABASE_2020Entities con = new CLINIC_DATABASE_2020Entities();
        public frm_medresult()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }
        void save()
        {
            MEDREQ_TBL medch_List = new MEDREQ_TBL();

            try
            {
                decimal  id =Convert.ToDecimal(txt_medreq_id.Text);

                var data = con.MEDREQ_TBL.Where(w => w.MEDREQ_ID.Equals(id) && w.MEDREQ_NAME.Equals(txt_medcreq_name.Text)).FirstOrDefault();
                if (data != null)
                {
                    medch_List.MEDREQ_ID = id;
                    medch_List.MEDCHECK_ID = data.MEDCHECK_ID;
                    medch_List.MEDREQ_NAME = txt_medcreq_name.Text;
                    medch_List.MEDREQ_NOTE = txt_medreq_note.Text;
                    medch_List.MEDREQ_RESULT = txt_medreq_result.Text;
                    medch_List.MEDREQ_DATE = DateTime.Now;
                    medch_List.MEDREQ_TIME = DateTime.Now.ToShortTimeString();
                    medch_List.CUST_ID = data.CUST_ID;
                    medch_List.CLI_ID = data.CLI_ID;
                    medch_List.VIS_ID = data.VIS_ID;
                    medch_List.MEDREQ_CODE = data.MEDREQ_CODE;

                    con.MEDREQ_TBL.AddOrUpdate(medch_List);
                    con.SaveChanges();
                    this.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}