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
using medcail_deebo.form.form_list;
using medcail_deebo.form.frm_list;
using medcail_deebo.form.frm_opration;

namespace medcail_deebo.form.form_main
{
    public partial class frm_clinc_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_clinc_main()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_clinc_list frm = new frm_clinc_list();
            frm.ShowDialog();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_clin frm = new frm_clin();
            frm.ShowDialog();
        }
    }
}