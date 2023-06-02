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

    public partial class Reserve : Form
    {
        StreamReader userinfo;
        MovieForm[] movies = new MovieForm[500];
        int movie_idx = 0;

        Button[,] btns = new Button[10,10];
        int margin = 0;
        int width = 15;
        int height = 15;

        public Reserve()
        {
            InitializeComponent();
            try
            {
                for(int i= 0; i < 10; i++)
                {
                    for(int j=0; j < 10; j++)
                    {
                        btns[i,j] = new Button();
                        btns[i,j].Size = new Size(width, height);
                        btns[i,j].Location= new Point(160+(i*width),90+(j*height));
                        char alpha = Convert.ToChar((65 + i).ToString());
                        btns[i,j].Text = alpha.ToString() + (j+1).ToString();
                    }
                }

                userinfo = new StreamReader("../../MovieList.txt");

                String line = userinfo.ReadLine();
                while (line != null)
                {
                    String loc = line.Split(';')[0];
                    String sii = line.Split(';')[1];
                    String movi = line.Split(';')[2];
                    String tim = line.Split(';')[3];
                    String theate = line.Split(';')[4];
                    int maxs = Int32.Parse(line.Split(';')[5]);
                    int mins = Int32.Parse(line.Split(';')[6]);
                    String dat = line.Split(';')[7];

                    movies[movie_idx++] = new MovieForm(loc, sii, movi, tim, theate, maxs, mins, dat);

                    line = userinfo.ReadLine();
                }
                userinfo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void list_si_SelectedIndexChanged(object sender, EventArgs e)
        {
            String si = list_si.SelectedItem as String;

            list_movie.Items.Clear();

            for (int i = 0; i < movie_idx; i++)
            {
                if (movies[i].si == si)
                {
                    if (!list_movie.Items.Contains(movies[i].moive))
                    {
                        list_movie.Items.Add(movies[i].moive);
                    }
                }
            }
        }

        class MovieForm
        {
            public String locate;
            public String si;
            public String moive;
            public String time;
            public String theater;
            public int maxSit;
            public int nowSit;
            public String date;

            public MovieForm(string locate, string si, string moive, string time, string theater, int maxSit, int nowSit, String date)
            {
                this.locate = locate;
                this.si = si;
                this.moive = moive;
                this.time = time;
                this.theater = theater;
                this.maxSit = maxSit;
                this.nowSit = nowSit;
                this.date = date;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String locate = list_locate.SelectedItem as String;

            list_si.Items.Clear();

            for (int i = 0; i < movie_idx; i++)
            {
                if (movies[i].locate == locate)
                {
                    if (!list_si.Items.Contains(movies[i].si))
                    {
                        list_si.Items.Add(movies[i].si);
                    }
                }
            }
        }

        private void list_movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            String movie = list_movie.SelectedItem as String;
            String si = list_si.SelectedItem as String;

            list_date.Items.Clear();

            for(int i=0; i<movie_idx; i++)
            {
                if (movies[i].moive == movie && movies[i].si == si)
                {
                    if (!list_date.Items.Contains(movies[i].date))
                    {
                        list_date.Items.Add(movies[i].date);
                    }
                }
            }
        }

        private void tab_sit_Click(object sender, EventArgs e)
        {
            if(!(list_locate.SelectedIndex != -1 && list_si.SelectedIndex != -1 && list_movie.SelectedIndex != -1 && list_time.SelectedIndex != -1))
            {
                // 탭을 다시 원래의 곳으로 돌려놓는 코드 작성
            }
        }

        private void list_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            String date = list_date.SelectedItem as String;
            String movie = list_movie.SelectedItem as String;
            String si = list_si.SelectedItem as String;

            list_time.Items.Clear();

            for (int i = 0; i < movie_idx; i++)
            {
                if (movies[i].date == date && movies[i].moive == movie && movies[i].si == si)
                {
                    if (!list_time.Items.Contains(movies[i].time))
                    {
                        String p_theater = movies[i].theater;
                        String p_time = movies[i].time;
                        int p_nowSit = movies[i].nowSit;
                        int p_maxSit = movies[i].maxSit;

                        String output = p_theater + "관 " + p_time + " 좌석;" + p_nowSit + "/" + p_maxSit;

                        list_time.Items.Add(output);
                    }
                }
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            String locate, si, movie, date, time;

            if (list_locate.SelectedItem != null && list_si.SelectedItem != null && list_movie.SelectedItem != null && list_date.SelectedItem != null && list_time.SelectedItem != null)
            {
                locate = list_locate.SelectedItem.ToString();
                si = list_si.SelectedItem.ToString();
                movie = list_movie.SelectedItem.ToString();
                date = list_date.SelectedItem.ToString();
                time = list_time.SelectedItem.ToString();

                int number = Int32.Parse(time.Split(';')[1].Split('/')[0]);

                Console.WriteLine(number);

                Random random = new Random();
                List<int> list = new List<int>();

                for(int i=0; i<number; i++)
                {
                    int randoms = random.Next(100);

                    if (!list.Contains(randoms))
                    {
                        list.Add(randoms);
                    }
                }

                if (list.Contains(0))
                {

                }

                tab.SelectedTab = tab.TabPages[1];
            }
            else
            {
                // 메시지 박스 생성 (모든게 선택되지 않았습니다!)
            }
        }

        private void shot_Click(object sender, EventArgs e)
        {
            // 다음 단계(4단계 결제완료) 창으로 이동
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
