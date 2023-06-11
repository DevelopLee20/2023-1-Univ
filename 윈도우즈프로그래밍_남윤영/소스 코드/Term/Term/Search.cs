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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                String goLocate = comboBox1.SelectedItem.ToString();
                String endLocate = comboBox2.SelectedItem.ToString();
                String date = dateTimePicker1.Value.ToString("yyyy;MM;dd");
                String grade;

                String year = date.Split(';')[0];
                String month = date.Split(';')[1];
                String day = date.Split(';')[2];

                if (radioButton4.Checked)
                {
                    grade = radioButton4.Text;
                }
                else if (radioButton2.Checked)
                {
                    grade = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    grade = radioButton3.Text;
                }
                else
                {
                    grade = radioButton1.Text;
                }

                Form1.tempbusidx = 0;

                for (int i = 0; i < Form1.busesIdx; i++)
                {
                    bool one = goLocate == Form1.buses[i].start;
                    bool two = endLocate == Form1.buses[i].end;
                    bool three = year == Form1.buses[i].year;
                    bool four = month == Form1.buses[i].month;
                    bool five = day == Form1.buses[i].day;
                    bool six = grade == Form1.buses[i].type;

                    Console.WriteLine(grade);

                    if (grade == "전체")
                    {
                        six = true;
                    }

                    if (one && two && three && four && five && six)
                    {
                        Form1.Tempbuses[Form1.tempbusidx++] = new BusForm(goLocate, endLocate, year, month, day, Form1.buses[i].hour, Form1.buses[i].minute, Form1.buses[i].type, Form1.buses[i].company, Form1.buses[i].distance, Form1.buses[i].times, Form1.buses[i].charge, Form1.buses[i].seatNum, Form1.buses[i].seat_state, Form1.tempbusidx - 1);
                    }
                }

                this.Visible = false;
                ChoiceTimeGo choicetimego = new ChoiceTimeGo();
                choicetimego.Show();
            }
            else
            {
                if(Form1.loginInfo.name == "admin")
                {
                    this.Visible = false;
                    ChoiceTimeGo choicetimego = new ChoiceTimeGo();
                    choicetimego.Show();
                }
                else
                {
                    MessageBox.Show("공백이 있습니다!");
                }
            }
        }
    }
}
