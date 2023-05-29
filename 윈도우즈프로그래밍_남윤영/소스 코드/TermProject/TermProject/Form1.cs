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
    public partial class Form1 : Form
    {

        StreamReader userinfo;
        UserForm[] users = new UserForm[500];
        int user_idx = 0;

        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader sr = new StreamReader("../../Login.txt");
                String line = sr.ReadLine();
                
                if (line != "")
                {
                    link_login.Text = "환영합니다 " + line.Split(';')[0] + "님";
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void link_new_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New new1 = new New();
            new1.Show();
        }

        private void link_pre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reserve resv = new Reserve();
            try
            {
                StreamReader sr = new StreamReader("../../Login.txt");
                String line = sr.ReadLine();
                sr.Close();

                if (line == "")
                {
                    MessageBox.Show("로그인이 필요한 서비스 입니다!", "", MessageBoxButtons.OK);
                }
                else
                {
                    resv.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = 0;

            while (users[idx] != null)
            {
                UserForm userform = users[idx++];

                Console.WriteLine(userform.UserName);
                Console.WriteLine(userform.ID);
                Console.WriteLine(userform.PW);
                Console.WriteLine(userform.UserCode);
            }
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (link_login.Text != "로그인")
            {
                try
                {
                    StreamWriter sw = new StreamWriter("../../Login.txt");
                    sw.WriteLine();
                    sw.Close();

                    link_login.Text = "로그인";
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
            }
            else
            {
                login log = new login();
                log.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class UserForm
    {
        public String UserName;
        public String ID;
        public String PW;
        public int UserCode;

        public UserForm(String UserName, String ID, String PW, int UserCode)
        {
            this.UserName = UserName;
            this.ID = ID;
            this.PW = PW;
            this.UserCode = UserCode;
        }
    }
}
