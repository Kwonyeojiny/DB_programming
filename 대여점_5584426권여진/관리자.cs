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
    public partial class 관리자 : Form
    {
        static public string user_name;
        static public string user_id;

        public 관리자()
        {
            InitializeComponent();
        }

        private void 관리자_Load(object sender, EventArgs e)
        {
            textBox2.Text = user_name;
            textBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)  // 시작화면
        {
            시작화면 window2 = new 시작화면();
            window2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)  // 용품관리
        {
            관리자_용품관리 window2 = new 관리자_용품관리();
            window2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)  // 대여현황
        {
            관리자_대여현황 window2 = new 관리자_대여현황();
            window2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)  // 매출
        {
            관리자_매출 window2 = new 관리자_매출();
            window2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)  // 회원화면
        {
            회원 window2 = new 회원();
            window2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)  // 직원화면
        {
            직원 window2 = new 직원();
            window2.Show();
            this.Hide();
        }
    }
}
