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
    public partial class 시작화면 : Form
    {
        DataTable mytable;

        static public string user_name;
        static public string user_id;

        public 시작화면()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dB_MEMBERTableAdapter2.Fill(dataSet11.DB_MEMBER);
            mytable = dataSet11.Tables["DB_MEMBER"];
        }

        private void button1_Click(object sender, EventArgs e)  // 회원, 관리자, 직원 화면 넘어가는 버튼
        {
            string ID = textBox1.Text;
            string PW = textBox2.Text;
            int flag = 0;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("아이디 비밀번호를 입력해주세요.");
            }
            else
            {
                foreach (DataRow mydataRow in mytable.Rows)
                {
                    if (mydataRow["MEM_ID"].ToString() == ID && mydataRow["MEM_PW"].ToString() == PW)
                    {
                        flag = 1;
                        this.Visible = false;

                        관리자.user_id = mydataRow["MEM_ID"].ToString();
                        관리자.user_name = mydataRow["MEM_NAME"].ToString();
                        관리자_대여현황.user_id = mydataRow["MEM_ID"].ToString();
                        관리자_대여현황.user_name = mydataRow["MEM_NAME"].ToString();
                        관리자_매출.user_id = mydataRow["MEM_ID"].ToString();
                        관리자_매출.user_name = mydataRow["MEM_NAME"].ToString();
                        직원_블랙리스트.user_id = mydataRow["MEM_ID"].ToString();
                        직원_블랙리스트.user_name = mydataRow["MEM_NAME"].ToString();
                        관리자_용품관리.user_id = mydataRow["MEM_ID"].ToString();
                        관리자_용품관리.user_name = mydataRow["MEM_NAME"].ToString();

                        직원.user_id = mydataRow["MEM_ID"].ToString();
                        직원.user_name = mydataRow["MEM_NAME"].ToString();
                        직원_대여반납현황.user_id = mydataRow["MEM_ID"].ToString();
                        직원_대여반납현황.user_name = mydataRow["MEM_NAME"].ToString();
                        직원_용품위치.user_id = mydataRow["MEM_ID"].ToString();
                        직원_용품위치.user_name = mydataRow["MEM_NAME"].ToString();

                        회원.user_id = mydataRow["MEM_ID"].ToString();
                        회원.user_name = mydataRow["MEM_NAME"].ToString();
                        회원_BESTT.user_id = mydataRow["MEM_ID"].ToString();
                        회원_BESTT.user_name = mydataRow["MEM_NAME"].ToString();
                        회원_마이페이지.user_id = mydataRow["MEM_ID"].ToString();
                        회원_마이페이지.user_name = mydataRow["MEM_NAME"].ToString();
                        회원_악기검색.user_id = mydataRow["MEM_ID"].ToString();
                        회원_악기검색.user_name = mydataRow["MEM_NAME"].ToString();
                        회원_악기대여.user_id = mydataRow["MEM_ID"].ToString();
                        회원_악기대여.user_name = mydataRow["MEM_NAME"].ToString();

                        if (mydataRow["MEM_TYPE"].ToString() == "관리자")
                        {
                            MessageBox.Show("관리자님 반갑습니다!");

                            관리자 window2 = new 관리자();
                            window2.Owner = this;
                            window2.Show();
                        }
                        else if (mydataRow["MEM_TYPE"].ToString() == "직원")
                        {
                            MessageBox.Show("직원님 반갑습니다!");

                            직원 window2 = new 직원();
                            window2.Owner = this;
                            window2.Show();
                        }
                        else if (mydataRow["MEM_TYPE"].ToString() == "회원")
                        {
                            MessageBox.Show("회원님 반갑습니다!");

                            회원 window2 = new 회원();
                            window2.Owner = this;
                            window2.Show();
                        }
                    }
                }
                if (flag == 0)
                {
                    MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 회원가입 버튼
        {
            회원가입 window2 = new 회원가입();
            window2.Show();
            this.Hide();
        }
    }
}
