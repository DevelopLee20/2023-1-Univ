using System;
using System.Windows.Forms;

namespace Term
{
    public partial class SetSeatGo : Form
    {
        Button[,] seats = new Button[6, 4];
        int sum = 0;
        int number = 0;
        int clicked = 0;
        ChoiceForm[] choices = new ChoiceForm[24];
        int choiceidx = 0;

        public SetSeatGo()
        {
            InitializeComponent();

            label6.Text = "";
            int count = 23;
            foreach (Control b in this.Controls)
            {
                if (b is Button)
                {
                    if (b.Text == "O" || b.Text == "X")
                    {
                        seats[count/4, count%4] = (Button)b;
                        seats[count/4, count%4].Click += MyNewButton_Click;
                        count--;
                    }
                }
            }

            label7.Text = "요금 " + sum + "원\n" + "일반 1명 " + Form1.selectOne.charge + "원\n초등생 1명 " + Form1.selectOne.charge * 0.9 + "원\n중고생 1명 " + Form1.selectOne.charge * 0.8 + "원" + "\n보훈 1명 " + Form1.selectOne.charge * 0.7 + "원";

            for(int i=0; i<6; i++)
            {
                for(int j=0; j<4; j++)
                {
                    if (Form1.selectOne.seat_state[i,j] == 1)
                    {
                        seats[i, j].Enabled = false;
                        seats[i, j].Text = "X";
                    }
                }
            }
        }

        private void MyNewButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            
            if(clicked < number)
            {
                for(int i=0; i<6; i++)
                {
                    for(int j=0; j<4; j++)
                    {
                        if (seats[i,j] == clickedButton)
                        {
                            choices[choiceidx++] = new ChoiceForm(i, j);
                            label6.Text += "(" + i + "," + j + ") ";
                        }
                    }
                }
                clickedButton.Enabled = false;
                clicked += 1;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            number = Int32.Parse(numericUpDown1.Value.ToString());
            number += Int32.Parse(numericUpDown2.Value.ToString());
            number += Int32.Parse(numericUpDown3.Value.ToString());
            number += Int32.Parse(numericUpDown4.Value.ToString());

            int sum1 = Int32.Parse(numericUpDown1.Value.ToString()) * Form1.selectOne.charge;
            int sum2 = Int32.Parse(numericUpDown2.Value.ToString()) * Form1.selectOne.charge;
            int sum3 = Int32.Parse(numericUpDown3.Value.ToString()) * Form1.selectOne.charge;
            int sum4 = Int32.Parse(numericUpDown4.Value.ToString()) * Form1.selectOne.charge;

            sum = sum1 + (int)(sum2 * 0.9) + (int)(sum3 * 0.8) + (int)(sum4 * 0.7);

            label7.Text = "요금 " + sum + "원\n" + "일반 1명 " + Form1.selectOne.charge + "원\n초등생 1명 " + Form1.selectOne.charge * 0.9 + "원\n중고생 1명 " + Form1.selectOne.charge * 0.8 + "원" + "\n보훈 1명 " + Form1.selectOne.charge * 0.7 + "원";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            number = Int32.Parse(numericUpDown1.Value.ToString());
            number += Int32.Parse(numericUpDown2.Value.ToString());
            number += Int32.Parse(numericUpDown3.Value.ToString());
            number += Int32.Parse(numericUpDown4.Value.ToString());

            int sum1 = Int32.Parse(numericUpDown1.Value.ToString()) * Form1.selectOne.charge;
            int sum2 = Int32.Parse(numericUpDown2.Value.ToString()) * Form1.selectOne.charge;
            int sum3 = Int32.Parse(numericUpDown3.Value.ToString()) * Form1.selectOne.charge;
            int sum4 = Int32.Parse(numericUpDown4.Value.ToString()) * Form1.selectOne.charge;

            sum = sum1 + (int)(sum2 * 0.9) + (int)(sum3 * 0.8) + (int)(sum4 * 0.7);

            label7.Text = "요금 " + sum + "원\n" + "일반 1명 " + Form1.selectOne.charge + "원\n초등생 1명 " + Form1.selectOne.charge * 0.9 + "원\n중고생 1명 " + Form1.selectOne.charge * 0.8 + "원" + "\n보훈 1명 " + Form1.selectOne.charge * 0.7 + "원";
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            number = Int32.Parse(numericUpDown1.Value.ToString());
            number += Int32.Parse(numericUpDown2.Value.ToString());
            number += Int32.Parse(numericUpDown3.Value.ToString());
            number += Int32.Parse(numericUpDown4.Value.ToString());

            int sum1 = Int32.Parse(numericUpDown1.Value.ToString()) * Form1.selectOne.charge;
            int sum2 = Int32.Parse(numericUpDown2.Value.ToString()) * Form1.selectOne.charge;
            int sum3 = Int32.Parse(numericUpDown3.Value.ToString()) * Form1.selectOne.charge;
            int sum4 = Int32.Parse(numericUpDown4.Value.ToString()) * Form1.selectOne.charge;

            sum = sum1 + (int)(sum2 * 0.9) + (int)(sum3 * 0.8) + (int)(sum4 * 0.7);

            label7.Text = "요금 " + sum + "원\n" + "일반 1명 " + Form1.selectOne.charge + "원\n초등생 1명 " + Form1.selectOne.charge * 0.9 + "원\n중고생 1명 " + Form1.selectOne.charge * 0.8 + "원" + "\n보훈 1명 " + Form1.selectOne.charge * 0.7 + "원";
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            number = Int32.Parse(numericUpDown1.Value.ToString());
            number += Int32.Parse(numericUpDown2.Value.ToString());
            number += Int32.Parse(numericUpDown3.Value.ToString());
            number += Int32.Parse(numericUpDown4.Value.ToString());

            int sum1 = Int32.Parse(numericUpDown1.Value.ToString()) * Form1.selectOne.charge;
            int sum2 = Int32.Parse(numericUpDown2.Value.ToString()) * Form1.selectOne.charge;
            int sum3 = Int32.Parse(numericUpDown3.Value.ToString()) * Form1.selectOne.charge;
            int sum4 = Int32.Parse(numericUpDown4.Value.ToString()) * Form1.selectOne.charge;

            sum = sum1 + (int)(sum2 * 0.9) + (int)(sum3 * 0.8) + (int)(sum4 * 0.7);

            label7.Text = "요금 " + sum + "원\n" + "일반 1명 " + Form1.selectOne.charge + "원\n초등생 1명 " + Form1.selectOne.charge * 0.9 + "원\n중고생 1명 " + Form1.selectOne.charge * 0.8 + "원" + "\n보훈 1명 " + Form1.selectOne.charge * 0.7 + "원";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if(clicked == number){
                Form1.people = "일반 " + Int32.Parse(numericUpDown1.Value.ToString()) + "명\n";
                Form1.people += "초등생 " + Int32.Parse(numericUpDown2.Value.ToString()) + "명\n";
                Form1.people += "중등생 " + Int32.Parse(numericUpDown3.Value.ToString()) + "명\n";
                Form1.people += "보훈 " + Int32.Parse(numericUpDown4.Value.ToString()) + "명";

                Form1.seat_output = label6.Text;
                Form1.seats_list = choices;
                Form1.seatsIdx = choiceidx;
                Form1.sum = sum;

                if (Form1.loginChecker)
                {
                    Summary summary = new Summary();
                    summary.Show();
                }
                else
                {
                    MessageBox.Show("로그인이 필요한 서비스입니다.");
                    Login login = new Login();
                    login.Show();
                }
            }
            else
            {
                MessageBox.Show("선택한 좌석과 인원이 맞지 않습니다.\n다시 확인해주세요.");
            }
        }
    }
}
