using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sepyar
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void mnu_setting_Click(object sender, EventArgs e)
        {
            grp_menu_check(4);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl_user_Click(sender,e);
        }

        private void pnl_user_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnl_user_Click(sender, e);
        }

        private void mnu_base_Click(object sender, EventArgs e)
        {
            grp_menu_check(1);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            grp_menu_check(1);
        }
        private void grp_menu_check(int index)
        {
            grp_menu_base.Visible = false;
            grp_menu_trans.Visible = false;
            grp_menu_report.Visible = false;
            grp_menu_setting.Visible = false;
            switch (index)
            {
                case 1:
                    grp_menu_base.Visible = true;
                    break;
                case 2:
                    grp_menu_trans.Visible = true;
                    break;
                case 3:
                    grp_menu_report.Visible = true;
                    break;
                case 4:
                    grp_menu_setting.Visible = true;
                    break;
            }
        }

        private void mnu_trans_Click(object sender, EventArgs e)
        {
            grp_menu_check(2);
        }

        private void mnu_report_Click(object sender, EventArgs e)
        {
            grp_menu_check(3);
        }
    }
}
