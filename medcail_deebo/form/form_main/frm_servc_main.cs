using DevExpress.XtraEditors;
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

namespace medcail_deebo.form.form_main
{
    public partial class frm_servc_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_servc_main()
        {
            InitializeComponent();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_service_list frm = new frm_service_list();
            frm.ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_servic frm = new frm_servic();
            frm.ShowDialog();
        }
    }
}