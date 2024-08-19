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
    public partial class 회원_마이페이지 : Form
    {
        static public string user_name;
        static public string user_id;

        DataTable mytable1;
        DataTable mytable2;

        DataTable mytable3;

        public 회원_마이페이지()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)  // 회원 홈으로
        {
            회원 window2 = new 회원();
            window2.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void 회원_마이페이지_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet9.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter1.FillBylist(this.dataSet9.DB_RENT,user_id);
            // TODO: 이 코드는 데이터를 'dataSet8.DB_RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_RENTTableAdapter.FillByuserid(this.dataSet8.DB_RENT,user_id);
            this.dB_ITEMPOSTTableAdapter1.FillByorderby(this.dataSet8.DB_ITEMPOST);
            this.dB_ITEMPOSTTableAdapter2.FillByuserpost(this.dataSet71.DB_ITEMPOST, user_id);

            mytable1 = dataSet8.Tables["DB_RENT"];
            mytable2 = dataSet8.Tables["DB_ITEMPOST"];
            mytable3 = dataSet71.Tables["DB_ITEMPOST"];

            textBox2.Text = user_name;
            textBox2.Enabled = false;

            listBox1.Items.Clear();
            foreach (DataRow mydataRow in mytable3.Rows)
            {
                listBox1.Items.Add(mydataRow["POST_NO"].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)  // 등록하기
        {
            mytable1 = dataSet8.Tables["DB_RENT"];
            DataRow foundrow = mytable1.Rows.Find(Convert.ToInt32(textBox5.Text));

            DataRow mynewpost = mytable2.NewRow();
            int flag = 0;
            int num = 1;
            if (textBox3.Text=="" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("작성하지 않은 부분이 있습니다.");
            }
            else
            {
                if (foundrow != null)
                {
                    foreach (DataRow founditem in mytable1.Rows)
                    {
                        if (founditem["RENT_NO"].ToString() == textBox5.Text && founditem["ITEM_NO"].ToString() == textBox6.Text)
                        {
                            flag = 1;
                            foreach (DataRow foundrent in mytable2.Rows)
                            {
                                num = Convert.ToInt32(foundrent["POST_NO"]) + 1;
                            }
                            mynewpost["POST_NO"] = num;
                            mynewpost["MEM_ID"] = user_id;
                            mynewpost["iTEM_NO"] = founditem["ITEM_NO"];
                            mynewpost["POST_제목"] = textBox3.Text;
                            mynewpost["POST_내용"] = textBox4.Text;
                            mynewpost["RENT_NO"] = textBox5.Text;
                            founditem["후기작성여부"] = 't';

                            mytable2.Rows.Add(mynewpost);
                            this.dB_ITEMPOSTTableAdapter1.Update(this.dataSet8.DB_ITEMPOST);
                            this.dB_RENTTableAdapter.Update(this.dataSet8.DB_RENT);
                            MessageBox.Show("후기작성이 완료되었습니다.");
                        }   
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("잘못 입력된 정보가 있습니다.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string select = listBox1.SelectedItem.ToString();
            DataRow foundRows = mytable3.Rows.Find(listBox1.SelectedItem.ToString());
            if (foundRows != null)
            {
                textBox1.Text = "제목 : " + foundRows["POST_제목"] + "\r\n" + "악기번호 : " + foundRows["ITEM_NO"] + "\r\n\r\n" + " " + foundRows["POST_내용"];
            }
        }
    }
}
