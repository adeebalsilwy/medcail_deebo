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
    public partial class frm_digno_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_digno_main()
        {
            InitializeComponent();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_dignos_listcs frm =new frm_dignos_listcs();
            frm.ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_dignos frma = new frm_dignos();
            frma.ShowDialog();

        }
    }
}