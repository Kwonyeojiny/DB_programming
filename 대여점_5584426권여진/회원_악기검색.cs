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
    public partial class 회원_악기검색 : Form
    {
        static public string user_name;
        static public string user_id;

        DataTable mytable1;
        public 회원_악기검색()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)  // 회원 홈으로
        {
            회원 window2 = new 회원();
            window2.Show();
            this.Hide();

            
        }

        private void 회원_악기검색_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet11.DB_ITEMTYPE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTYPETableAdapter.Fill(this.dataSet11.DB_ITEMTYPE);
            

            textBox2.Text = user_name;
            textBox2.Enabled = false;

            // TODO: 이 코드는 데이터를 'dataSet11.DB_ITEM' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.dB_ITEMTableAdapter1.FillBySEARCH(this.dataSet11.DB_ITEM);


            mytable1 = dataSet11.Tables["DB_ITEMTYPE"];     // 리스트박스에 아이템 타입

            listBox1.Items.Clear();
            foreach (DataRow mydataRow in mytable1.Rows)
            {
                listBox1.Items.Add(mydataRow["ITEM_TYPE"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)  // 검색버튼
        {
            if (dBITEMBindingSource1.Filter != null)
            {
                dBITEMBindingSource1.RemoveFilter();
                button1.Text = "검색";
                textBox1.Clear();
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("검색어를 입력해 주세요");
                }
                else
                {
                    dBITEMBindingSource1.Filter = "ITEM_NAME = '" + textBox1.Text + "'";
                    button1.Text = "검색해제";
                }
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string select = listBox1.SelectedItem.ToString();
            dBITEMBindingSource.Filter = "ITEM_TYPENO = '" + select + "'";*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
