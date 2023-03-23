using medcail_deebo.db;
using medcail_deebo.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo
{
    public partial class Login : Form
    {
        CLINIC_DATABASE_2020Entities con = new db.CLINIC_DATABASE_2020Entities();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cheack_login();
        }

        void cheack_login()
        {
            if (com_pass.Text != "")
            {
                string user_name = com_user_name.Text;
                string pass = com_pass.Text;
                var cheak = con.USERS_TBL.Where(w => w.USER_NAME.Equals(user_name) && w.USER_PASSWORD.Equals(pass));
                decimal use =cheak.FirstOrDefault().USER_ID;
                if (cheak.Count() > 0)
                {
                   var found= con.DOCTORS_TBL.Where(w => w.USER_ID == Convert.ToInt16(use)).FirstOrDefault();
                    if (found.USER_ID!=0) {
                      int a =Convert.ToInt32( found.USER_ID);
                       // Properties.Settings.Default.doc_id = a;
                            }
                    frm_main home = new frm_main();
                    this.Hide();
                    home.Show();
                   // MessageBox.Show("مرحبا " + cheak.FirstOrDefault().USER_NAME);
                }
                else
                {
                    MessageBox.Show("  كلمه السر خاطئه ");
                }
            }
            else
                MessageBox.Show("الرجاء ادخال كلمه السر");
                }
        private void Login_Load(object sender, EventArgs e)
        {
            start();  
        }

        void start()
        {
            com_clinc_name.DataSource = con.CLINC_TBL.ToList();
            com_clinc_name.DisplayMember = "CLI_NAME";
            com_clinc_name.ValueMember = "CLI_ID";

            com_type.DataSource = con.USERS_TBL.ToList();
            com_type.DisplayMember = "USER_TYPE";
            com_type.ValueMember = "USER_ID";

            com_user_name.DataSource = con.USERS_TBL.ToList();
            com_user_name.ValueMember = "USER_ID";
            com_user_name.DisplayMember = "USER_NAME";
        }

        private void com_user_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            com_type.DataSource = com_user_name.DataSource;
            com_type.DisplayMember = "USER_TYPE";
            com_type.ValueMember = "USER_ID";
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cheack_login();
        }

        private void com_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            cheack_login();
        }

        private void com_clinc_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        int sel = 0;
        private void com_clinc_name_SelectedValueChanged(object sender, EventArgs e)
        {
           


        }
        void get_cli()
        {

            if (com_clinc_name.Text != "")
            {
               
                
              var a= con.CLINC_TBL.Where(s => s.CLI_NAME.Equals(com_clinc_name.Text)).FirstOrDefault();
                //  object valu = com_clinc_name.SelectedValue;
                if (a!=null) {
                    var q = con.USERS_TBL.Where(w => w.CLI_ID ==a.CLI_ID).ToList();
                    if (q.Count() > 0)
                    {
                        com_user_name.DataSource = q.ToList();
                        com_user_name.DisplayMember = "USER_NAME";
                        com_user_name.ValueMember = "USER_ID";
                    }
                    else
                    {
                        MessageBox.Show("لايوجد اي مستخدمين في العياده ");
                    }
                }
            }
        }

        private void com_clinc_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void com_clinc_name_TextChanged(object sender, EventArgs e)
        {
            get_cli();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void com_pass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void com_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
