using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo.form.form_list
{
    public partial class frm_doctor_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_doctor_main()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_doctoer doc=new frm_doctoer();
            doc.ShowDialog();
            
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_doct_list frm=new frm_doct_list();
            frm.ShowDialog();
        }
    }
}