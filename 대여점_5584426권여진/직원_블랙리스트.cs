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
    public partial class 직원_블랙리스트 : Form
    {
        static public string user_name;
        static public string user_id;

        public 직원_블랙리스트()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 관리자 홈으로
        {
            직원 window2 = new 직원();
            window2.Show();
            this.Hide();
        }

        private void 관리자_블랙리스트_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet16.DB_MEMBER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_MEMBERTableAdapter1.FillBytrue(this.dataSet16.DB_MEMBER);

            // TODO: 이 코드는 데이터를 'dataSet8.DB_MEMBER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_MEMBERTableAdapter.FillBymem(this.dataSet8.DB_MEMBER);
            textBox2.Text = user_name;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) // 회원 수정
        {
            this.dB_MEMBERTableAdapter.Update(this.dataSet8.DB_MEMBER);
            MessageBox.Show("업데이트 되었습니다.");
        }

        private void button2_Click(object sender, EventArgs e)  // 블랙
        {
            this.dB_MEMBERTableAdapter1.Update(this.dataSet16.DB_MEMBER);
            MessageBox.Show("업데이트 되었습니다.");
        }
    }
}
