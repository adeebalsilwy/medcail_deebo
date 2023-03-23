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
    public partial class frm_compny_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_compny_main()
        {
            InitializeComponent();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_com_list frm = new frm_com_list();
            frm.ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frm_compny frm = new frm_compny();
            frm.ShowDialog();

        }
    }
}