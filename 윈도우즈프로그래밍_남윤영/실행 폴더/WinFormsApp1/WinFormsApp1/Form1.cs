namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbox.Items.Add(cbox.Text);
            Ib_msg.Text = "콤보 박스 아이템 추가, 인덱스:" + cbox.Items.IndexOf(cbox.Text) + " Text:" + cbox.Text;
            cbox.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ibox_1.Items.Add(tbox_1.Text);
            Ib_msg.Text = "리스트 박스 아이템 추가, 인덱스:" + Ibox_1.Items.IndexOf(tbox_1.Text) + " Text:" + tbox_1.Text;
            Ibox_2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ibox_1.Items.Remove(tbox_1.Text);
            Ib_msg.Text = "리스트 박스 아이템 제거, 인덱스:" + Ibox_1.Items.IndexOf(tbox_1.Text) + "Text:" + tbox_1.Text;
            Ibox_2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chbox.Items.Add(tbox_2.Text);
            Ib_msg.Text = "체크 박스 아이템 추가, 인덱스:" + " Text:" + tbox_2.Text;
            tbox_2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chbox.Items.Remove(tbox_2.Text);
            Ib_msg.Text = "체크 박스 아이템 제거, 인덱스:" + " Text:" + tbox_2.Text;
            tbox_2.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;

            if (chbox.SelectedIndex == -1)
            {
                text = string.Format("체크 리스트 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = chbox.SelectedItem as string;
                text = string.Format("체크 리스트 박스 선택 항목 변경, 인덱스:{0} Text:{1}", chbox.SelectedIndex, str);
            }

            Ib_msg.Text = text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg;

            if (Ibox_1.SelectedIndex == -1)
            {
                msg = string.Format("리스트 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = Ibox_1.SelectedItem as string;
                msg = string.Format("리스트 박스 선택 항목 변경, 인덱스:{0} Text:{1}", Ibox_1.SelectedIndex, str);
            }
            Ib_msg.Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;

            if (cbox.SelectedIndex == -1)
            {
                text = string.Format("체크 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = cbox.SelectedItem as string;
                text = string.Format("체크 박스 선택 항목 변경, 인덱스:{0} Text:{1}", cbox.SelectedIndex, str);

            }

            Ib_msg.Text = text;
        }

        private void Ibox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string msg;

            if (Ibox_1.SelectedIndex == -1)
            {
                msg = string.Format("리스트 박스 선택 항목이 없습니다.");
            }
            else
            {
                string str = Ibox_1.SelectedItem as string;
                msg = string.Format("리스트 박스 선택 항목 변경 인덱스:{0} Text:{1}", Ibox_1.SelectedIndex, str);
            }
            Ib_msg.Text = msg;
        }

        private void btn_remove1_Click(object sender, EventArgs e)
        {
            cbox.Items.Remove(cbox.Text);
            Ib_msg.Text = "콤보 박스 아이템 제거, 인덱스:" + cbox.Items.IndexOf(cbox.Text) + " Text:" + cbox.Text;
            cbox.Text = "";
        }

        private void btn_summary_Click(object sender, EventArgs e)
        {
            Ibox_2.Text = "";

            String text = "";
            text = "콤보 박스 항목 개수:" + cbox.Items.Count + "\n";
            Ibox_2.Items.Add(text);
            text = "콤보 박스 선택 항목 :" + cbox.SelectedIndex + "\n";
            Ibox_2.Items.Add(text);
            text = "리스트 박스 항목 개수:" + Ibox_1.Items.Count + "\n";
            Ibox_2.Items.Add(text);
            text = "리스트 박스 선택 항목:" + Ibox_1.SelectedIndex + "\n";
            Ibox_2.Items.Add(text);
            text = "체크 리스트 박스 항목 개수:" + chbox.Items.Count + "\n";
            Ibox_2.Items.Add(text);
            text = "체크 리스트 박스 선택 항목:" + chbox.SelectedIndex + "\n";
            Ibox_2.Items.Add(text);
            text = "체크 리스트 박스 체크 상태 목록:\n";

            foreach (var b in chbox.CheckedItems)
            {
                text += b + " ";
            }
            text += "\n";

            Ibox_2.Items.Add(text);
        }
    }
}