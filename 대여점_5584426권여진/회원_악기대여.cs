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
    public partial class 회원_악기대여 : Form
    {
        static public string user_name;
        static public string user_id;

        DataTable mytable1;
        DataTable mytable2;
        DataTable mytable3;
        DataTable mytable4;

        public 회원_악기대여()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 회원 홈으로
        {
            회원 window2 = new 회원();
            window2.Show();
            this.Hide();
        }

        private void 회원_악기대여_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet91.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter.FillByid(this.dataSet91.DB_RENT,user_id);

            // TODO: 이 코드는 데이터를 'dataSet8.DB_ITEMPOST' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMPOSTTableAdapter.FillByorderby(this.dataSet8.DB_ITEMPOST);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter1.FillByorderby(this.dataSet8.DB_ITEM);
            // TODO: 이 코드는 데이터를 'dataSet41.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter.FillByorderbyy(this.dataSet41.DB_ITEM);
            this.dB_RENTTableAdapter2.FillByorderby(this.dataSet71.DB_RENT);

            textBox2.Text = user_name;
            textBox2.Enabled = false;

            // 후기보기
            mytable1 = dataSet41.Tables["DB_ITEMTYPE"];
            mytable2 = dataSet71.Tables["DB_RENT"];
            mytable3 = dataSet41.Tables["DB_ITEM"];
            mytable4 = dataSet8.Tables["DB_ITEMPOST"];

            dateTimePicker1.Value = DateTime.Now.AddDays(+0);
            dateTimePicker2.Value = DateTime.Now.AddDays(+1);
            dateTimePicker3.Value = DateTime.Now.AddDays(+0);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  // 대여
        {
            int num = 0;

            DataRow mynewlent = mytable2.NewRow();

            if (textBox4.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("대여하고자하는 물품의 정보를 정확히 입력해 주세요.");
            }
            else
            {
                DataRow foundRows = mytable3.Rows.Find(Convert.ToInt32(textBox4.Text));
                if (foundRows != null)
                {
                    foreach (DataRow foundrent in mytable2.Rows)
                    {
                        num = Convert.ToInt32(foundrent["RENT_NO"]) + 1;
                    }
                    mynewlent["RENT_NO"] = num;
                    mynewlent["ITEM_NO"] = textBox4.Text;
                    mynewlent["대여수량"] = textBox6.Text;
                    mynewlent["대여날짜"] = dateTimePicker1.Text;
                    mynewlent["반납날짜"] = dateTimePicker2.Text;
                    mynewlent["회원_ID"] = user_id;
                    mynewlent["연체벌금"] = 0;
                    mynewlent["후기작성여부"] = "f";

                    mytable2.Rows.Add(mynewlent);
                    this.dB_RENTTableAdapter2.Update(this.dataSet71.DB_RENT);
                    MessageBox.Show("대여신청이 완료되었습니다.");
                }
                else  
                    MessageBox.Show("악기번호가 잘못되었습니다.");

                
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // 반납신청
        {
            this.dB_RENTTableAdapter.Update(this.dataSet91.DB_RENT);
            MessageBox.Show("반납 신청이 완료되었습니다.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
