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

                label2.Text = year + "-" + month + "-" + day;

                String output = start + "->" + end + " " + hour + ":" + minute + " " + type + " " + company;
                listBox1.Items.Add(output);
            }
        }
    }
}
