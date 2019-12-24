using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sepyar.program.Class
{
    public partial class pic_mnu_cmd : UserControl
    {
        public pic_mnu_cmd()
        {
            InitializeComponent();
        }

        private void pic_cmd_Click(object sender, EventArgs e)
        {
            pnl_user_Click(sender, e);
        }

        private void pnl_user_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            pnl_user_Click(sender, e);
        }
    }
}
