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
    public partial class 회원가입 : Form
    {
        public static int yesno;

        DataTable mytable;
        public 회원가입()
        {
            InitializeComponent();
        }

        private void 회원가입_Load(object sender, EventArgs e)
        {
            dB_MEMBERTableAdapter1.Fill(dataSet11.DB_MEMBER);
            mytable = dataSet11.Tables["DB_MEMBER"];
        }
        private void button2_Click(object sender, EventArgs e)  // 로그인화면으로 넘어가는 버튼
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "") // 빈공백이 있다면
            {
                
                MessageBox.Show("입력하지않은 정보가 있습니다.");
            }
            else
            {
                if (button1.Enabled != false)
                {
                    MessageBox.Show("아이디 중복확인을 해주세요.");
                }
                else
                {
                    DataRow newmemberDataRow = mytable.NewRow();
                    newmemberDataRow["MEM_ID"] = textBox1.Text;
                    newmemberDataRow["MEM_PW"] = textBox2.Text;
                    newmemberDataRow["MEM_NAME"] = textBox3.Text;
                    newmemberDataRow["MEM_PHONE"] = textBox6.Text;
                    newmemberDataRow["MEM_EMAIL"] = textBox5.Text;
                    newmemberDataRow["MEM_TYPE"] = "회원";
                    mytable.Rows.Add(newmemberDataRow);

                    int numOfRows = dB_MEMBERTableAdapter1.Update(dataSet11.DB_MEMBER);

                    MessageBox.Show("환영합니다 :)");
                    시작화면 window2 = new 시작화면();
                    window2.Show();
                    this.Hide();
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)  // ID 중복확인 버튼
        { 
            DataTable mytable = dataSet11.Tables["DB_MEMBER"]; 
            DataRow foundRows = mytable.Rows.Find(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("사용하실 아이디를 입력해주세요.");
            }
            else
            {
                if (foundRows != null)
                {
                    MessageBox.Show("이미 사용중인 아이디입니다.");
                }
                else
                {
                    중복확인 show = new 중복확인();
                    show.ShowDialog();
                    if (yesno == 1)
                    {
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                    }

                }
            }
            
        }

    }
}
