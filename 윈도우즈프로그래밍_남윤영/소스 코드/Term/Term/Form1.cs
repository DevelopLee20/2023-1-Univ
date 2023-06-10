using System;
using System.IO;
using System.Windows.Forms;

namespace Term
{
    public partial class Form1 : Form
    {
        static public bool loginChecker = false;
        static public UserForm[] users = new UserForm[100];
        static public int userIdx = 0;
        static public UserForm loginInfo;
        static public BusForm[] buses = new BusForm[500];
        static public int busesIdx = 0;
        static public BusForm selectForm;
        static public BusForm[] Tempbuses = new BusForm[500];
        static public int tempbusidx = 0;
        static public BusForm selectOne;
        static public String people;
        static public ChoiceForm[] seats_list;
        static public int seatsIdx = 0;
        static public String seat_output;
        static public int sum;
        static public BusForm[] reserves = new BusForm[500];
        static public int reservesIdx = 0;

        public Form1()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("./UserInfo.txt");
            String line = sr.ReadLine();

            while (line != null)
            {
                String id = line.Split(';')[0];
                String pw = line.Split(';')[1];
                String phone = line.Split(';')[2];
                String name = line.Split(';')[3];
                int discount = Int32.Parse(line.Split(';')[4]);
                int pay = Int32.Parse(line.Split(';')[5]);

                users[userIdx++] = new UserForm(id, pw, phone, name, discount, pay, userIdx - 1);
                line = sr.ReadLine();
            }
            sr.Close();

            sr = new StreamReader("./BusInfo.txt");
            line = sr.ReadLine();

            while (line != null)
            {
                String start = line.Split(';')[0];
                String end = line.Split(';')[1];
                String year = line.Split(';')[2];
                String month = line.Split(';')[3];
                String day = line.Split(';')[4];
                String hour = line.Split(';')[5];
                String minute = line.Split(';')[6];
                String type = line.Split(';')[7];
                String company = line.Split(';')[8];
                String distance = line.Split(';')[9];
                String times = line.Split(';')[10];
                int charge = Int32.Parse(line.Split(';')[11]);
                int[,] temp = new int[6, 4];
                int seatNum = Int32.Parse(line.Split(';')[12]);
                String seats = line.Split(';')[13];

                for(int i=0; i<6; i++)
                {
                    for(int j=0; j<4; j++)
                    {
                        temp[i,j] = 0;
                    }
                }

                for(int i=0; i<seatNum*2; i+=2)
                {
                    int row = seats[i] - '0';
                    int col = seats[i+1] - '0';
                    temp[row,col] = 1;
                }

                buses[busesIdx++] = new BusForm(start, end, year, month, day, hour, minute, type, company, distance, times, charge, seatNum, temp, busesIdx-1);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e) // 로그인
        {
            if (loginChecker)
            {
                MessageBox.Show("로그인 되어있습니다.");
            }
            else
            {
                Login login = new Login();
                login.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) // 예매 확인
        {
            ReserveShow reserveShow = new ReserveShow();
            reserveShow.Show();
        }

        private void button1_Click(object sender, EventArgs e) // 고속 버스 예매
        {
            Search search = new Search();
            search.Show();
        }
    }

    public class ChoiceForm
    {
        public int x;
        public int y;

        public ChoiceForm(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class UserForm
    {
        public String id;
        public String pw;
        public String phone;
        public String name;
        public int discount;
        public int pay;
        public int idx;

        public UserForm(String id, String pw, String phone, string name, int discount, int pay, int idx)
        {
            this.id = id;
            this.pw = pw;
            this.phone = phone;
            this.name = name;
            this.discount = discount;
            this.pay = pay;
            this.idx = idx;
        }
    }

    public class BusForm
    {
        public String start;
        public String end;
        public String year;
        public String month;
        public String day;
        public String hour;
        public String minute;
        public String type;
        public String company;
        public int seatNum;
        public int[,] seat_state;
        public String distance;
        public String times;
        public int charge;
        public int idx;

        public BusForm(string start, string end, string year, string month, string day, string hour, string minute, string type, string company, String distance, String times, int charge, int seatNum, int[,] seat_state, int idx)
        {
            this.start = start;
            this.end = end;
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
            this.type = type;
            this.company = company;
            this.distance = distance;
            this.times = times;
            this.charge = charge;
            this.seatNum = seatNum;
            this.seat_state = seat_state;
            this.idx = idx;
        }
    }
}