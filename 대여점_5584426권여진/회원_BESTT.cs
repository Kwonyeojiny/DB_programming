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
    public partial class 회원_BESTT : Form
    {
        static public string user_name;
        static public string user_id;

        public 회원_BESTT()
        {
            InitializeComponent();
        }

        private void 회원_BESTT_Load(object sender, EventArgs e)
        {
            textBox2.Text = user_name;
            textBox2.Enabled = false;


            dateTimePicker1.Value = DateTime.Now.AddDays(-6);
            dateTimePicker2.Value = DateTime.Now.AddDays(+0);

            string sday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string eday = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet10.DB_ITEM_COUNT_BEST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_COUNT_BESTTableAdapter.FillBydate(this.dataSet10.DB_ITEM_COUNT_BEST,sday,eday);

            dateTimePicker4.Value = DateTime.Now.AddMonths(-1);
            string month = dateTimePicker4.Value.ToString("yyyy-MM");
            // TODO: 이 코드는 데이터를 'dataSet17.DB_ITEM_COUNT_BEST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_COUNT_BESTTableAdapter1.FillBydate(this.dataSet17.DB_ITEM_COUNT_BEST,month,month);

        }

        private void button3_Click(object sender, EventArgs e)  // 회원 홈으로
        {
            회원 window2 = new 회원();
            window2.Show();
            this.Hide();
        }
    }
}
