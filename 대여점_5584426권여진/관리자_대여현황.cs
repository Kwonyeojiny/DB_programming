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
    public partial class 관리자_대여현황 : Form
    {
        static public string user_name;
        static public string user_id;

        public 관리자_대여현황()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 관리자 홈으로
        {
            관리자 window2 = new 관리자();
            window2.Show();
            this.Hide();
        }

        private void 관리자_대여현황_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet19.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter2.FillBy(this.dataSet19.DB_RENT);
            // TODO: 이 코드는 데이터를 'dataSet19.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter1.FillByitem(this.dataSet19.DB_ITEM);

            // TODO: 이 코드는 데이터를 'dataSet15.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter.Fill(this.dataSet15.DB_ITEM_SUM);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter.Fill(this.dataSet8.DB_RENT);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter.FillByorderby(this.dataSet8.DB_ITEM);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter.Fill(this.dataSet8.DB_ITEM);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter.FillBynow(this.dataSet8.DB_RENT);

            textBox2.Text = user_name;
            textBox2.Enabled = false;


            // 기간 설정 매출
            dateTimePicker4.Value = DateTime.Now;
            string sday = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            dateTimePicker5.Value = DateTime.Now;
            string eday = dateTimePicker5.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet15.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter.FillBydayday(this.dataSet15.DB_ITEM_SUM, sday, eday);
            // TODO: 이 코드는 데이터를 'dataSet18.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter1.FillByrent(this.dataSet18.DB_RENT, sday, eday);

            int sum4 = 0;
            for (int i = 0; i < dataGridView5.Rows.Count; ++i)
            {
                sum4 += Convert.ToInt32(dataGridView5.Rows[i].Cells[1].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dBRENTBindingSource.Filter != null)
            {
                dBRENTBindingSource.RemoveFilter();
                button1.Text = "검색";
                textBox1.Clear();
            }
            else if (textBox1.Text != "")
            {
                dBRENTBindingSource.Filter = "ITEM_NO = " + textBox1.Text;
                button1.Text = "검색해제";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sday = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            string eday = dateTimePicker5.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet15.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter.FillBydayday(this.dataSet15.DB_ITEM_SUM, sday, eday);
            // TODO: 이 코드는 데이터를 'dataSet18.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter1.FillByrent(this.dataSet18.DB_RENT, sday, eday);

            int sum4 = 0;
            for (int i = 0; i < dataGridView5.Rows.Count; ++i)
            {
                //sum4 += Convert.ToInt32(dataGridView5.Rows[i].Cells[1].Value);
            }
        }
    }
}
