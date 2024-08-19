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
    public partial class 직원_용품위치 : Form
    {
        static public string user_name;
        static public string user_id;

        public 직원_용품위치()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // 직원 홈으로
        {
            직원 window2 = new 직원();
            window2.Show();
            this.Hide();
        }

        private void 직원_용품위치_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet8.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter.FillByorderby(this.dataSet8.DB_ITEM);

            textBox1.Text = user_name;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dB_ITEMTableAdapter.Update(this.dataSet8.DB_ITEM);
            MessageBox.Show("악기 위치 수정이 완료되었습니다.");
        }
    }
}
