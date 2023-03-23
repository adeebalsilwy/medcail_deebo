using DevExpress.XtraBars;
using medcail_deebo.form.form_list;
using medcail_deebo.form.form_main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace medcail_deebo.form
{
    public partial class frm_main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Login li=new Login();
           
           
            li.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_compny_main frm = new frm_compny_main();
            frm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_doctor_main frm = new frm_doctor_main();
            frm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
            frm.Dock=DockStyle.Fill;
            frm.Show();
        }

        private void الع_Click(object sender, EventArgs e)
        {

            fluentDesignFormContainer1.Controls.Clear();
            frm_clinc_main frm = new frm_clinc_main();
            frm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

            fluentDesignFormContainer1.Controls.Clear();
            frm_medcin_main frm = new frm_medcin_main();
            frm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_servc_main frm = new frm_servc_main();
            frm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear();
            frm_digno_main frm = new frm_digno_main();
            frm.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
