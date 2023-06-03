using System;
using System.Windows.Forms;

namespace Term
{
    public partial class SetSeatGo : Form
    {
        Button[,] seats = new Button[4, 6];
        public SetSeatGo()
        {
            InitializeComponent();

            int count = 0;
            foreach (Control b in this.Controls)
            {
                if (b is Button)
                {
                    if (b.Text == "O")
                    {
                        seats[count / 4,count%4] = (Button)b;
                    }
                }
            }
        }
    }
}
