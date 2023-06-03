using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = dkdlel.Text;
            String pw = qlalfqjsgh.Text;
            String phone = wjsghkqjsgh.Text;
            bool exist = false;

            if (id == "" || pw == "" || phone == "")
            {
                MessageBox.Show("공백이 있습니다!");
            }
            else
            {
                for(int i=0; i<Form1.userIdx; i++)
                { 
                    if(id == Form1.users[i].id || phone == Form1.users[i].phone)
                    {
                        exist = true;
                        break;
                    }
                }

                if (exist)
                {
                    MessageBox.Show("이미 존재하는 회원입니다.");
                }
                else
                {
                    Form1.users[Form1.userIdx++] = new UserForm(id, pw, phone);
                    MessageBox.Show("회원가입 되었습니다.");

                    try
                    {
                        StreamWriter sw = new StreamWriter("./UserInfo.txt");
                        
                        for(int i=0; i<Form1.userIdx; i++)
                        {
                            String temp = Form1.users[i].id + ";" + Form1.users[i].pw + ";" + Form1.users[i].phone;
                            sw.WriteLine(temp);
                        }
                        sw.Close();
                    }
                    catch(Exception ex){}

                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = dkdlel.Text;
            String pw = qlalfqjsgh.Text;
            String phone = wjsghkqjsgh.Text;
            bool exist = false;

            for (int i = 0; i < Form1.userIdx; i++)
            {
                if (id == Form1.users[i].id && pw == Form1.users[i].pw && phone == Form1.users[i].phone)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                Form1.loginChecker = true;
                MessageBox.Show("로그인 되었습니다!");
                Form1.loginInfo = new UserForm(id, pw, phone);
                this.Close();
            }
            else
            {
                MessageBox.Show("존재하지 않는 회원입니다.");
            }
        }
    }
}
