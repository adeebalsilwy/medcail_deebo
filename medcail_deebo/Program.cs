using medcail_deebo.form;
using medcail_deebo.form.fm_med;
using medcail_deebo.form.form_list;
using medcail_deebo.form.form_main;
using medcail_deebo.form.frm_list;
using medcail_deebo.form.frm_opration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medcail_deebo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_main());
        }
    }
}
