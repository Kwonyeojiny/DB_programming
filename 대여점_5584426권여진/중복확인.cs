using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB대여점_5584426권여진
{
    public partial class 중복확인 : Form
    {
        public 중복확인()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            회원가입.yesno = 1;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            회원가입.yesno = 0;
            this.Visible = false;
        }
    }
}
