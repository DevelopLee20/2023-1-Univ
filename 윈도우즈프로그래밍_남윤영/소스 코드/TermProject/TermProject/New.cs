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

namespace TermProject
{
    public partial class New : Form
    {
        StreamReader userinfo;
        UserForm[] users = new UserForm[500];
        int user_idx = 0;

        public New()
        {
            InitializeComponent();
            try
            {
                userinfo = new StreamReader("../../UserInfo.txt");
                String line = userinfo.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);

                    String username = line.Split(';')[0];
                    String id = line.Split(';')[1];
                    String pw = line.Split(';')[2];
                    int usercode = Int32.Parse(line.Split(';')[3]);

                    users[user_idx++] = new UserForm(username, id, pw, usercode);

                    line = userinfo.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            userinfo.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            String username = UserNameBox.Text;
            String id = IDBox.Text;
            String pw = PWBox.Text;
            int check = 0;
            int i;

            if (username == "")
            {
                MessageBox.Show("닉네임을 적어주세요.", "", MessageBoxButtons.OK);
            }
            else if(id == "")
            {
                MessageBox.Show("아이디를 적어주세요..", "", MessageBoxButtons.OK);
            }
            else
            {
                for (i=0; i<user_idx; i++)
                {
                    if(username == users[i].UserName)
                    {
                        check = 1;
                        break;
                    }
                    if(id == users[i].ID)
                    {
                        check = 2;
                        break;
                    }
                }

                if (check == 0)
                {
                    users[user_idx] = new UserForm(username, id, pw, user_idx++);
                    MessageBox.Show("회원가입이 되었습니다!", "", MessageBoxButtons.OK);

                    try
                    {
                        StreamWriter sw = new StreamWriter("../../UserInfo.txt");

                        for(i=0; i<user_idx; i++)
                        {
                            String write = users[i].UserName + ";" + users[i].ID + ";" + users[i].PW + ";" + users[i].UserCode;
                            Console.WriteLine(write);
                            sw.WriteLine(write);
                        }
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                    }
                    this.Close();
                }
                else if(check == 1)
                {
                    MessageBox.Show("닉네임이 중복되었습니다.", "" ,MessageBoxButtons.OK);
                }
                else if(check == 2)
                {
                    MessageBox.Show("아이디가 중복되었습니다.", "", MessageBoxButtons.OK);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
