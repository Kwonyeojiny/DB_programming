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
    public partial class 회원 : Form
    {
        static public string user_name;
        static public string user_id;

        public 회원()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // 악기검색 버튼
        {
            회원_악기검색 window2 = new 회원_악기검색();
            window2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)  // BEST 버튼
        {
            회원_BESTT window2 = new 회원_BESTT();
            window2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)  // 악기대여 버튼
        {
            회원_악기대여 window2 = new 회원_악기대여();
            window2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)  // 마이페이지 버튼
        {
            회원_마이페이지 window2 = new 회원_마이페이지();
            window2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)  // 로그아웃 버튼 (로그아웃 누르면 시작화면으로)
        {
            시작화면 window2 = new 시작화면();
            window2.Show();
            this.Hide();
        }

        private void 회원_Load(object sender, EventArgs e)
        {
            textBox2.Text = user_name;
            textBox2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = user_name;
            textBox2.Enabled = false;
        }
    }
}
