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

                users[userIdx++] = new UserForm(id, pw, phone, name);
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
                int[,] temp = new int[4, 6];
                int seatNum = Int32.Parse(line.Split(';')[9]);
                String seats = line.Split(';')[10];

                for(int i=0; i<4; i++)
                {
                    for(int j=0; j<6; j++)
                    {
                        temp[i,j] = 0;
                    }
                }

                for(int i=0; i<seatNum; i+=2)
                {
                    int row = seats[i] - '0';
                    int col = seats[i+1] - '0';
                    temp[row,col] = 1;
                }

                buses[busesIdx++] = new BusForm(start, end, year, month,day, hour, minute, type, company, seatNum, temp);
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
            if (loginChecker)
            {
                Search search = new Search();
                search.Show();
            }
            else
            {
                MessageBox.Show("로그인이 필요한 서비스입니다!");
            }
        }
    }

    public class UserForm
    {
        public String id;
        public String pw;
        public String phone;
        public String name;

        public UserForm(String id, String pw, String phone, string name)
        {
            this.id = id;
            this.pw = pw;
            this.phone = phone;
            this.name = name;
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

        public BusForm(string start, string end, string year, string month, string day, string hour, string minute, string type, string company, int seatNum, int[,] seat_state)
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
            this.seatNum = seatNum;
            this.seat_state = seat_state;
        }
    }
}