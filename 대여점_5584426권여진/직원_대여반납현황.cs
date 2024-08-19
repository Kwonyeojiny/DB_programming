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
    public partial class 직원_대여반납현황 : Form
    {
        static public string user_name;
        static public string user_id;

        public 직원_대여반납현황()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 직원 홈으로
        {
            직원 window2 = new 직원();
            window2.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void 직원_대여반납현황_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet9.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter2.FillBynull(this.dataSet9.DB_RENT);


            // TODO: 이 코드는 데이터를 'dataSet7.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter.FillBynull(this.dataSet7.DB_RENT);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter.FillByorderby(this.dataSet8.DB_ITEM);
            // TODO: 이 코드는 데이터를 'dataSet71.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.

            int nowyear = DateTime.Now.Year;
            int nowmonth = DateTime.Now.Month;
            int nowday = DateTime.Now.Day;

            dateTimePicker1.Value = new DateTime(nowyear, nowmonth, nowday);

            textBox2.Text = user_name;
            textBox2.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)  // 대여거절
        {
            dBRENTBindingSource.RemoveCurrent();
            this.dB_RENTTableAdapter.Update(this.dataSet7.DB_RENT);
            MessageBox.Show("대여거절이 완료되었습니다.");
        }

        private void button2_Click(object sender, EventArgs e)  // 대여승인
        {   
            this.dB_RENTTableAdapter.Update(this.dataSet7.DB_RENT);
            this.dB_ITEMTableAdapter.Update(this.dataSet8.DB_ITEM);
            MessageBox.Show("대여승인이 완료되었습니다.");
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)  // 반납확인
        {
            this.dB_RENTTableAdapter2.Update(this.dataSet9.DB_RENT);
            this.dB_ITEMTableAdapter.Update(this.dataSet8.DB_ITEM);
            MessageBox.Show("반납이 완료되었습니다.");
        }

        private void button1_Click(object sender, EventArgs e)  // 대여 검색
        {
            if (dBITEMBindingSource.Filter != null)
            {
                dBITEMBindingSource.RemoveFilter();
                button1.Text = "검색";
                textBox1.Clear();
            }
            else if (textBox1.Text != "")
            {
                dBITEMBindingSource.Filter = "ITEM_NO = " + textBox1.Text;
                button1.Text = "검색해제";
            }
        }

        private void button6_Click(object sender, EventArgs e)  // 반납 겁색
        {
            if (dBITEMBindingSource.Filter != null)
            {
                dBITEMBindingSource.RemoveFilter();
                button6.Text = "검색";
                textBox3.Clear();
            }
            else if (textBox3.Text != "")
            {
                dBITEMBindingSource.Filter = "ITEM_NO = " + textBox3.Text;
                button6.Text = "검색해제";
            }
        }
    }
}
