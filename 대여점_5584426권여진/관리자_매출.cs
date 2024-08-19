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
    public partial class 관리자_매출 : Form
    {
        static public string user_name;
        static public string user_id;

        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;
        DataTable mytable4;
        public 관리자_매출()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 관리자 홈으로
        {
            관리자 window2 = new 관리자();
            window2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 관리자_매출_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = user_name;
            textBox2.Enabled = false;

            // 총 매출     
            this.dB_ITEM_SUMTableAdapter1.Fill(this.dataSet111.DB_ITEM_SUM);

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            textBox1.Text = sum.ToString();

            // 일 매출
            dateTimePicker2.Value = DateTime.Now;
            string day = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet12.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter.FillByday(this.dataSet12.DB_ITEM_SUM,day);
            mytable1 = dataSet12.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable1.Rows)
            {
                chart2.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum1 = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum1 += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }
            textBox3.Text = sum1.ToString();


            // 주 매출
            dateTimePicker3.Value = DateTime.Now.AddDays(-6);
            string week = dateTimePicker3.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet13.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter2.FillByweek(this.dataSet13.DB_ITEM_SUM, week);
            mytable2 = dataSet13.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable2.Rows)
            {
                chart3.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum2 = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                //sum2 += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);
            }
            textBox4.Text = sum2.ToString();

            // 월 매출
            dateTimePicker1.Value = DateTime.Now;
            string month = dateTimePicker1.Value.ToString("yyyy-MM");

            // TODO: 이 코드는 데이터를 'dataSet14.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter3.FillBymonth(this.dataSet14.DB_ITEM_SUM, month);
            mytable3 = dataSet14.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable3.Rows)
            {
                chart4.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum3 = 0;
            for (int i = 0; i < dataGridView4.Rows.Count; ++i)
            {
                //sum3 += Convert.ToInt32(dataGridView4.Rows[i].Cells[1].Value);
            }
            textBox5.Text = sum3.ToString();


            // 기간 설정 매출
            dateTimePicker4.Value = DateTime.Now;
            string sday = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            dateTimePicker5.Value = DateTime.Now;
            string eday = dateTimePicker5.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet15.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter4.FillBydayday(this.dataSet15.DB_ITEM_SUM,sday,eday);
            mytable4 = dataSet15.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable4.Rows)
            {
                chart5.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum4 = 0;
            for (int i = 0; i < dataGridView5.Rows.Count; ++i)
            {
                sum4 += Convert.ToInt32(dataGridView5.Rows[i].Cells[1].Value);
            }
            textBox6.Text = sum4.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // 일 매출
        {
            chart2.Series[0].Points.Clear();

            string day = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet12.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter.FillByday(this.dataSet12.DB_ITEM_SUM, day);
            mytable1 = dataSet12.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable1.Rows)
            {
                chart2.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }

            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }
            textBox3.Text = sum.ToString();


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  // 주 매출
        {
            chart3.Series[0].Points.Clear();
            string week = dateTimePicker3.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet13.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter2.FillByweek(this.dataSet13.DB_ITEM_SUM,week);
            mytable2 = dataSet13.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable2.Rows)
            {
                chart3.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum2 = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; ++i)
            {
                sum2 += Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value);
            }
            textBox4.Text = sum2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)  // 월 매출
        {
            chart4.Series[0].Points.Clear();
            string month = dateTimePicker1.Value.ToString("yyyy-MM");

            // TODO: 이 코드는 데이터를 'dataSet14.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter3.FillBymonth(this.dataSet14.DB_ITEM_SUM, month);
            mytable3 = dataSet14.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable3.Rows)
            {
                chart4.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum3 = 0;
            for (int i = 0; i < dataGridView4.Rows.Count; ++i)
            {
                sum3 += Convert.ToInt32(dataGridView4.Rows[i].Cells[1].Value);
            }
            textBox5.Text = sum3.ToString();
        }

        private void button1_Click(object sender, EventArgs e) // 기간 매출
        {
            chart5.Series[0].Points.Clear();

            string sday = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            string eday = dateTimePicker5.Value.ToString("yyyy-MM-dd");

            // TODO: 이 코드는 데이터를 'dataSet15.DB_ITEM_SUM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEM_SUMTableAdapter4.FillBydayday(this.dataSet15.DB_ITEM_SUM, sday, eday);
            mytable4 = dataSet15.Tables["DB_ITEM_SUM"];
            foreach (DataRow dataRow in mytable4.Rows)
            {
                chart5.Series[0].Points.AddXY(dataRow["악기"], dataRow["매출"]);
            }
            int sum4 = 0;
            for (int i = 0; i < dataGridView5.Rows.Count; ++i)
            {
                sum4 += Convert.ToInt32(dataGridView5.Rows[i].Cells[1].Value);
            }
            textBox6.Text = sum4.ToString();
        }
    }
}
