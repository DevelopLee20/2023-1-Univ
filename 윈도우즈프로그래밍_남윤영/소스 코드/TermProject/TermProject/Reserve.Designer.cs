namespace TermProject
{
    partial class Reserve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_time = new System.Windows.Forms.TabPage();
            this.button_next = new System.Windows.Forms.Button();
            this.list_date = new System.Windows.Forms.ListBox();
            this.list_time = new System.Windows.Forms.ListBox();
            this.list_movie = new System.Windows.Forms.ListBox();
            this.list_locate = new System.Windows.Forms.ListBox();
            this.list_si = new System.Windows.Forms.ListBox();
            this.tab_sit = new System.Windows.Forms.TabPage();
            this.accident_num = new System.Windows.Forms.NumericUpDown();
            this.senior_num = new System.Windows.Forms.NumericUpDown();
            this.chung_num = new System.Windows.Forms.NumericUpDown();
            this.adult_num = new System.Windows.Forms.NumericUpDown();
            this.next_4 = new System.Windows.Forms.Button();
            this.df = new System.Windows.Forms.Label();
            this.sdf = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.dsf = new System.Windows.Forms.Label();
            this.J = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_wallet = new System.Windows.Forms.TabPage();
            this.shot = new System.Windows.Forms.Button();
            this.last_output = new System.Windows.Forms.Label();
            this.tab_end = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tab_time.SuspendLayout();
            this.tab_sit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accident_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chung_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adult_num)).BeginInit();
            this.tab_wallet.SuspendLayout();
            this.tab_end.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_time);
            this.tab.Controls.Add(this.tab_sit);
            this.tab.Controls.Add(this.tab_wallet);
            this.tab.Controls.Add(this.tab_end);
            this.tab.Font = new System.Drawing.Font("굴림", 15F);
            this.tab.Location = new System.Drawing.Point(1, 5);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(877, 555);
            this.tab.TabIndex = 0;
            // 
            // tab_time
            // 
            this.tab_time.Controls.Add(this.button_next);
            this.tab_time.Controls.Add(this.list_date);
            this.tab_time.Controls.Add(this.list_time);
            this.tab_time.Controls.Add(this.list_movie);
            this.tab_time.Controls.Add(this.list_locate);
            this.tab_time.Controls.Add(this.list_si);
            this.tab_time.Location = new System.Drawing.Point(4, 30);
            this.tab_time.Name = "tab_time";
            this.tab_time.Padding = new System.Windows.Forms.Padding(3);
            this.tab_time.Size = new System.Drawing.Size(869, 521);
            this.tab_time.TabIndex = 0;
            this.tab_time.Text = "01 상영시간";
            this.tab_time.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(603, 413);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(260, 94);
            this.button_next.TabIndex = 13;
            this.button_next.Text = "좌석 선택하기";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // list_date
            // 
            this.list_date.FormattingEnabled = true;
            this.list_date.ItemHeight = 20;
            this.list_date.Location = new System.Drawing.Point(603, 3);
            this.list_date.Name = "list_date";
            this.list_date.Size = new System.Drawing.Size(260, 104);
            this.list_date.TabIndex = 12;
            this.list_date.SelectedIndexChanged += new System.EventHandler(this.list_date_SelectedIndexChanged);
            // 
            // list_time
            // 
            this.list_time.FormattingEnabled = true;
            this.list_time.ItemHeight = 20;
            this.list_time.Location = new System.Drawing.Point(603, 123);
            this.list_time.Name = "list_time";
            this.list_time.Size = new System.Drawing.Size(260, 284);
            this.list_time.TabIndex = 10;
            // 
            // list_movie
            // 
            this.list_movie.FormattingEnabled = true;
            this.list_movie.ItemHeight = 20;
            this.list_movie.Location = new System.Drawing.Point(371, 3);
            this.list_movie.Name = "list_movie";
            this.list_movie.Size = new System.Drawing.Size(226, 504);
            this.list_movie.TabIndex = 9;
            this.list_movie.SelectedIndexChanged += new System.EventHandler(this.list_movie_SelectedIndexChanged);
            // 
            // list_locate
            // 
            this.list_locate.FormattingEnabled = true;
            this.list_locate.ItemHeight = 20;
            this.list_locate.Items.AddRange(new object[] {
            "서울",
            "경기/인천",
            "제주"});
            this.list_locate.Location = new System.Drawing.Point(7, 3);
            this.list_locate.Name = "list_locate";
            this.list_locate.Size = new System.Drawing.Size(174, 504);
            this.list_locate.TabIndex = 8;
            this.list_locate.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // list_si
            // 
            this.list_si.FormattingEnabled = true;
            this.list_si.ItemHeight = 20;
            this.list_si.Location = new System.Drawing.Point(187, 3);
            this.list_si.Name = "list_si";
            this.list_si.Size = new System.Drawing.Size(178, 504);
            this.list_si.TabIndex = 5;
            this.list_si.SelectedIndexChanged += new System.EventHandler(this.list_si_SelectedIndexChanged);
            // 
            // tab_sit
            // 
            this.tab_sit.Controls.Add(this.accident_num);
            this.tab_sit.Controls.Add(this.senior_num);
            this.tab_sit.Controls.Add(this.chung_num);
            this.tab_sit.Controls.Add(this.adult_num);
            this.tab_sit.Controls.Add(this.next_4);
            this.tab_sit.Controls.Add(this.df);
            this.tab_sit.Controls.Add(this.sdf);
            this.tab_sit.Controls.Add(this.dd);
            this.tab_sit.Controls.Add(this.dsf);
            this.tab_sit.Controls.Add(this.J);
            this.tab_sit.Controls.Add(this.I);
            this.tab_sit.Controls.Add(this.H);
            this.tab_sit.Controls.Add(this.G);
            this.tab_sit.Controls.Add(this.F);
            this.tab_sit.Controls.Add(this.E);
            this.tab_sit.Controls.Add(this.D);
            this.tab_sit.Controls.Add(this.C);
            this.tab_sit.Controls.Add(this.B);
            this.tab_sit.Controls.Add(this.label3);
            this.tab_sit.Controls.Add(this.label1);
            this.tab_sit.Location = new System.Drawing.Point(4, 30);
            this.tab_sit.Name = "tab_sit";
            this.tab_sit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sit.Size = new System.Drawing.Size(869, 521);
            this.tab_sit.TabIndex = 1;
            this.tab_sit.Text = "02 인원/좌석";
            this.tab_sit.UseVisualStyleBackColor = true;
            this.tab_sit.Click += new System.EventHandler(this.tab_sit_Click);
            // 
            // accident_num
            // 
            this.accident_num.Location = new System.Drawing.Point(718, 201);
            this.accident_num.Name = "accident_num";
            this.accident_num.Size = new System.Drawing.Size(120, 30);
            this.accident_num.TabIndex = 126;
            this.accident_num.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // senior_num
            // 
            this.senior_num.Location = new System.Drawing.Point(718, 163);
            this.senior_num.Name = "senior_num";
            this.senior_num.Size = new System.Drawing.Size(120, 30);
            this.senior_num.TabIndex = 125;
            this.senior_num.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // chung_num
            // 
            this.chung_num.Location = new System.Drawing.Point(718, 122);
            this.chung_num.Name = "chung_num";
            this.chung_num.Size = new System.Drawing.Size(120, 30);
            this.chung_num.TabIndex = 124;
            this.chung_num.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // adult_num
            // 
            this.adult_num.Location = new System.Drawing.Point(718, 79);
            this.adult_num.Name = "adult_num";
            this.adult_num.Size = new System.Drawing.Size(120, 30);
            this.adult_num.TabIndex = 123;
            this.adult_num.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // next_4
            // 
            this.next_4.Location = new System.Drawing.Point(733, 455);
            this.next_4.Name = "next_4";
            this.next_4.Size = new System.Drawing.Size(121, 50);
            this.next_4.TabIndex = 122;
            this.next_4.Text = "결제하기";
            this.next_4.UseVisualStyleBackColor = true;
            // 
            // df
            // 
            this.df.AutoSize = true;
            this.df.Location = new System.Drawing.Point(643, 201);
            this.df.Name = "df";
            this.df.Size = new System.Drawing.Size(69, 20);
            this.df.TabIndex = 120;
            this.df.Text = "장애인";
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(643, 165);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(69, 20);
            this.sdf.TabIndex = 118;
            this.sdf.Text = "시니어";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(643, 127);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(69, 20);
            this.dd.TabIndex = 116;
            this.dd.Text = "청소년";
            // 
            // dsf
            // 
            this.dsf.AutoSize = true;
            this.dsf.Location = new System.Drawing.Point(655, 84);
            this.dsf.Name = "dsf";
            this.dsf.Size = new System.Drawing.Size(49, 20);
            this.dsf.TabIndex = 114;
            this.dsf.Text = "성인";
            // 
            // J
            // 
            this.J.AutoSize = true;
            this.J.Location = new System.Drawing.Point(119, 406);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(18, 20);
            this.J.TabIndex = 103;
            this.J.Text = "J";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Location = new System.Drawing.Point(119, 372);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(12, 20);
            this.I.TabIndex = 92;
            this.I.Text = "I";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(119, 336);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(21, 20);
            this.H.TabIndex = 81;
            this.H.Text = "H";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(119, 301);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(23, 20);
            this.G.TabIndex = 70;
            this.G.Text = "G";
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(119, 266);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(19, 20);
            this.F.TabIndex = 59;
            this.F.Text = "F";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(119, 230);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(21, 20);
            this.E.TabIndex = 48;
            this.E.Text = "E";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(119, 195);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(22, 20);
            this.D.TabIndex = 37;
            this.D.Text = "D";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(119, 160);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(22, 20);
            this.C.TabIndex = 26;
            this.C.Text = "C";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(119, 124);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(21, 20);
            this.B.TabIndex = 15;
            this.B.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "S C R E E N";
            // 
            // tab_wallet
            // 
            this.tab_wallet.Controls.Add(this.shot);
            this.tab_wallet.Controls.Add(this.last_output);
            this.tab_wallet.Location = new System.Drawing.Point(4, 30);
            this.tab_wallet.Name = "tab_wallet";
            this.tab_wallet.Size = new System.Drawing.Size(869, 521);
            this.tab_wallet.TabIndex = 2;
            this.tab_wallet.Text = "03 결제";
            this.tab_wallet.UseVisualStyleBackColor = true;
            // 
            // shot
            // 
            this.shot.Location = new System.Drawing.Point(706, 427);
            this.shot.Name = "shot";
            this.shot.Size = new System.Drawing.Size(121, 50);
            this.shot.TabIndex = 1;
            this.shot.Text = "결제하기";
            this.shot.UseVisualStyleBackColor = true;
            this.shot.Click += new System.EventHandler(this.shot_Click);
            // 
            // last_output
            // 
            this.last_output.AutoSize = true;
            this.last_output.Location = new System.Drawing.Point(33, 34);
            this.last_output.Name = "last_output";
            this.last_output.Size = new System.Drawing.Size(89, 20);
            this.last_output.TabIndex = 0;
            this.last_output.Text = "예약정보";
            // 
            // tab_end
            // 
            this.tab_end.Controls.Add(this.label2);
            this.tab_end.Location = new System.Drawing.Point(4, 30);
            this.tab_end.Name = "tab_end";
            this.tab_end.Size = new System.Drawing.Size(869, 521);
            this.tab_end.TabIndex = 3;
            this.tab_end.Text = "04 결제완료";
            this.tab_end.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "결제 완료 되었습니다.\r\n창을 닫아주세요~";
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tab);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.tab.ResumeLayout(false);
            this.tab_time.ResumeLayout(false);
            this.tab_sit.ResumeLayout(false);
            this.tab_sit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accident_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senior_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chung_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adult_num)).EndInit();
            this.tab_wallet.ResumeLayout(false);
            this.tab_wallet.PerformLayout();
            this.tab_end.ResumeLayout(false);
            this.tab_end.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_time;
        private System.Windows.Forms.TabPage tab_sit;
        private System.Windows.Forms.TabPage tab_wallet;
        private System.Windows.Forms.TabPage tab_end;
        private System.Windows.Forms.ListBox list_si;
        private System.Windows.Forms.ListBox list_locate;
        private System.Windows.Forms.ListBox list_movie;
        private System.Windows.Forms.ListBox list_time;
        private System.Windows.Forms.ListBox list_date;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label J;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shot;
        private System.Windows.Forms.Label last_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown accident_num;
        private System.Windows.Forms.NumericUpDown senior_num;
        private System.Windows.Forms.NumericUpDown chung_num;
        private System.Windows.Forms.NumericUpDown adult_num;
        private System.Windows.Forms.Button next_4;
        private System.Windows.Forms.Label df;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label dsf;
    }
}