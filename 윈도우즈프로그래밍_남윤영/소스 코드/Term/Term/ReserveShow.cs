using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Term
{
    public partial class ReserveShow : Form
    {
        public ReserveShow()
        {
            InitializeComponent();

            button1.Text = "번호로 검색";

            if(Form1.loginInfo.name == "admin")
            {
                listBox1.Items.Clear();

                int pays = 0;

                for (int i = 0; i < Form1.reserveListIdx; i++)
                {
                    ReserveForm rform = Form1.reserveList[i];
                    String start = rform.start;
                    String end = rform.end;
                    String hour = rform.hour;
                    String minute = rform.minute;
                    String month = rform.month;
                    String day = rform.day;
                    String seat_output = "";
                    String phones = rform.phone;
                    int idx = rform.idx;

                    pays += rform.pay;

                    for (int j = 0; j < Form1.seatsIdx; j++)
                    {
                        seat_output += "(" + Form1.reserveList[i].seats[j].x + "," + Form1.reserveList[i].seats[j].y + ") ";
                    }
                    String adds = idx + "|출발: " + start + " 도착: " + end + " " + hour + ":" + minute + " " + month + "/" + day + " " + seat_output;
                    listBox1.Items.Add(adds);
                }

                textBox1.Text = "현재 판매 금액: " + pays;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String phone = textBox1.Text;
            listBox1.Items.Clear();

            for(int i=0; i<Form1.reserveListIdx; i++)
            {
                ReserveForm rform = Form1.reserveList[i];
                String start = rform.start;
                String end = rform.end;
                String hour = rform.hour;
                String minute = rform.minute;
                String month = rform.month;
                String day = rform.day;
                String seat_output = "";
                String phones = rform.phone;
                int idx = rform.idx;

                for(int j=0; j<Form1.seatsIdx; j++)
                {
                    seat_output += "(" + Form1.reserveList[i].seats[j].x + "," + Form1.reserveList[i].seats[j].y + ") ";
                }

                if(phone == phones)
                {
                    String adds = idx + "|출발: " + start + " 도착: " + end + " " + hour + ":" + minute + " " + month + "/" + day + " " + seat_output;
                    listBox1.Items.Add(adds);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                String choice = listBox1.SelectedItem.ToString().Split('|')[0];
                int idx = Int32.Parse(choice);

                ReserveForm temp = Form1.reserveList[idx];
                Form1.reserveList[idx] = Form1.reserveList[Form1.reserveListIdx];
                Form1.reserveList[Form1.reservesIdx] = temp;
                Form1.reserveListIdx = Form1.reserveListIdx - 1;

                MessageBox.Show("예약 취소 되었습니다.");

                this.Close();
            }
            else
            {
                MessageBox.Show("예약 취소할 항목을 골라주세요.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
