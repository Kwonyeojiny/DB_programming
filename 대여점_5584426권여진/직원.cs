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
    public partial class 직원 : Form
    {
        static public string user_name;
        static public string user_id;

        public 직원()
        {
            InitializeComponent();
        }

        private void 직원_Load(object sender, EventArgs e)
        {
            textBox2.Text = user_name;
            textBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)  // 로그아웃
        {
            시작화면 window2 = new 시작화면();
            window2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)  // 용품위치
        {
            직원_용품위치 window2 = new 직원_용품위치();
            window2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)  // 대여반납 현황
        {
            직원_대여반납현황 window2 = new 직원_대여반납현황();
            window2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)  // 블랙리스트
        {
            직원_블랙리스트 window2 = new 직원_블랙리스트();
            window2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)  // 회원화면
        {
            회원 window2 = new 회원();
            window2.Show();
            this.Hide();
        }
    }
}
