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
    public partial class frm_medcin_main : DevExpress.XtraEditors.XtraForm
    {
        public frm_medcin_main()
        {
            InitializeComponent();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            
        }

        private void tileItem4_ItemClick_1(object sender, TileItemEventArgs e)
        {
            frm_medcin_list frm = new frm_medcin_list();
            frm.ShowDialog();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem1_ItemClick_1(object sender, TileItemEventArgs e)
        {
            frm_medcin frm = new frm_medcin();
            frm.ShowDialog();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {

        }
    }
}