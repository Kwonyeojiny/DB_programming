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
    public partial class 관리자_용품관리 : Form
    {
        static public string user_name;
        static public string user_id;

        public 관리자_용품관리()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 관리자 홈으로
        {
            관리자 window2 = new 관리자();
            window2.Show();
            this.Hide();
        }

        private void 관리자_용품관리_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet4.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter1.FillByorderbyy(this.dataSet4.DB_ITEM);


            textBox2.Text = user_name;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)  // 삭제
        {
            dBITEMBindingSource1.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)  // 추가
        {
            dBITEMBindingSource1.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)  // 수정
        {
            this.dB_ITEMTableAdapter1.Update(this.dataSet4.DB_ITEM);
            MessageBox.Show("용품 수정이 완료되었습니다.");
        }
    }
}
