using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term
{


    public partial class Summary : Form
    {
        int sum = Form1.sum;
        double discount = 0;
        BusForm one = Form1.selectOne;

        public Summary()
        {
            InitializeComponent();

            label1.Text = one.year + ". " + one.month + ". "  + one.day + ". " + one.hour + ":" + one.minute;
            label2.Text = "출발: " + one.start;
            label3.Text = "도착: " + one.end;
            label4.Text = "고속사: " + one.company;
            label5.Text = "등급: " + one.type;
            label6.Text = "매수: " + Form1.people;
            label7.Text = "좌석: " + Form1.seat_output;
            checkBox1.Text = "멤버쉽 여부";
            checkBox2.Text = "할인쿠폰 여부 (" + Form1.loginInfo.discount + "장 보유)";
            label8.Text = "예매 금액: " + sum + "원";
            label9.Text = "할인 금액: 0원";
            label10.Text = "총 결제 금액: ";
            button1.Text = "결제하기";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.0;

            if (checkBox1.Checked)
            {
                discount += 0.1;
            }
            if (checkBox2.Checked && Form1.loginInfo.discount > 0)
            {
                discount += 0.1;
            }

            label9.Text = "할인 금액: " + (sum * discount) + "원";
            label10.Text = "총 결제 금액: " + (sum - (sum * discount)) + "원";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.0;

            if (checkBox1.Checked)
            {
                discount += 0.1;
            }
            if (checkBox2.Checked && Form1.loginInfo.discount > 0)
            {
                discount += 0.1;
            }

            label9.Text = "할인 금액: " + (sum * discount) + "원";
            label10.Text = "총 결제 금액: " + (sum - (sum * discount)) + "원";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String start = one.start;
            String end = one.end;
            String hour = one.hour;
            String minute = one.minute;
            String month = one.month;
            String day = one.day;
            ChoiceForm[] seats = Form1.seats_list; // Form1.seatsIdx 같이 있음
            String phone = Form1.loginInfo.phone;
            int pay = (int)(sum - (sum * discount));
        }
    }
}
