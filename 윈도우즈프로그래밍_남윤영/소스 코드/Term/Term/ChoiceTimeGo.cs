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
    public partial class ChoiceTimeGo : Form
    {
        public ChoiceTimeGo()
        {
            InitializeComponent();

            if(Form1.loginInfo.name == "admin")
            {
                for (int i = 0; i < Form1.busesIdx; i++)
                {
                    String start = Form1.buses[i].start;
                    String end = Form1.buses[i].end;
                    String year = Form1.buses[i].year;
                    String month = Form1.buses[i].month;
                    String day = Form1.buses[i].day;
                    String hour = Form1.buses[i].hour;
                    String minute = Form1.buses[i].minute;
                    String type = Form1.buses[i].type;
                    String company = Form1.buses[i].company;
                    String seats = " 잔여: " + (24 - Form1.buses[i].seatNum) + "/24";
                    String charge = "일반요금:" + Form1.buses[i].charge.ToString() + "원";
                    String distance = "거리: " + Form1.buses[i].distance.ToString();
                    String times = Form1.buses[i].times;

                    label2.Text = year + "-" + month + "-" + day + " " + charge + " " + distance + " " + times;

                    String output = start + "->" + end + " " + hour + ":" + minute + " " + type + " " + company + seats;
                    listBox1.Items.Add(output);
                }
            }
            else
            {
                if(Form1.tempbusidx == 0)
                {
                    MessageBox.Show("해당되는 차편이 없습니다.\n다시 검색해주세요.");
                }

                for (int i = 0; i < Form1.tempbusidx; i++)
                {
                    String start = Form1.Tempbuses[i].start;
                    String end = Form1.Tempbuses[i].end;
                    String year = Form1.Tempbuses[i].year;
                    String month = Form1.Tempbuses[i].month;
                    String day = Form1.Tempbuses[i].day;
                    String hour = Form1.Tempbuses[i].hour;
                    String minute = Form1.Tempbuses[i].minute;
                    String type = Form1.Tempbuses[i].type;
                    String company = Form1.Tempbuses[i].company;
                    String seats = " 잔여: " + (24 - Form1.Tempbuses[i].seatNum) + "/24";
                    String charge = "일반요금:" + Form1.Tempbuses[i].charge.ToString() + "원";
                    String distance = "거리: " + Form1.Tempbuses[i].distance.ToString();
                    String times = Form1.Tempbuses[i].times;

                    label2.Text = year + "-" + month + "-" + day + " " + charge + " " + distance + " " + times;

                    String output = start + "->" + end + " " + hour + ":" + minute + " " + type + " " + company + seats;
                    listBox1.Items.Add(output);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                Form1.selectOne = Form1.Tempbuses[listBox1.SelectedIndex];
                this.Visible = false;
                SetSeatGo setseatgo = new SetSeatGo();
                setseatgo.Show();
            }
            else
            {
                MessageBox.Show("원하시는 차편을 선택해주세요.");
            }
        }
    }
}
