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
    public partial class login : Form
    {
        StreamReader sr;
        UserForm[] users = new UserForm[500];
        int users_idxd = 0;
        String line;

        public login()
        {
            InitializeComponent();
            try
            {
                sr = new StreamReader("../../UserInfo.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    String usernamed = line.Split(';')[0];
                    String idd = line.Split(';')[1];
                    String pwd = line.Split(';')[2];
                    int usercoded = Int32.Parse(line.Split(';')[3]);

                    users[users_idxd++] = new UserForm(usernamed, idd, pwd, usercoded);

                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void label_1_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void PWBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PW_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            String id = log_id_box.Text;
            String pw = log_pw_box.Text;
            int usercodeIndex = -1;

            for(int i=0; i<users_idxd; i++)
            {
                if(id == users[i].ID && pw == users[i].PW)
                {
                    usercodeIndex = i;
                }
            }

            if(usercodeIndex == -1)
            {
                MessageBox.Show("회원정보가 없습니다!", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter("../../Login.txt");
                    String temp = users[usercodeIndex].UserName + ";" + users[usercodeIndex].ID + ";" + users[usercodeIndex].PW + ";" + users[usercodeIndex].UserCode;
                    sw.WriteLine(temp);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }

                MessageBox.Show("로그인이 되었습니다!", "", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

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
}
