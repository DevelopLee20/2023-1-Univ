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
            this.list_time = new System.Windows.Forms.ListBox();
            this.list_movie = new System.Windows.Forms.ListBox();
            this.list_locate = new System.Windows.Forms.ListBox();
            this.list_si = new System.Windows.Forms.ListBox();
            this.tab_sit = new System.Windows.Forms.TabPage();
            this.tab_wallet = new System.Windows.Forms.TabPage();
            this.tab_end = new System.Windows.Forms.TabPage();
            this.list_date = new System.Windows.Forms.ListBox();
            this.tab.SuspendLayout();
            this.tab_time.SuspendLayout();
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
            // list_time
            // 
            this.list_time.FormattingEnabled = true;
            this.list_time.ItemHeight = 20;
            this.list_time.Location = new System.Drawing.Point(603, 123);
            this.list_time.Name = "list_time";
            this.list_time.Size = new System.Drawing.Size(260, 384);
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
            this.tab_sit.Location = new System.Drawing.Point(4, 30);
            this.tab_sit.Name = "tab_sit";
            this.tab_sit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sit.Size = new System.Drawing.Size(869, 521);
            this.tab_sit.TabIndex = 1;
            this.tab_sit.Text = "02 인원/좌석";
            this.tab_sit.UseVisualStyleBackColor = true;
            this.tab_sit.Click += new System.EventHandler(this.tab_sit_Click);
            // 
            // tab_wallet
            // 
            this.tab_wallet.Location = new System.Drawing.Point(4, 30);
            this.tab_wallet.Name = "tab_wallet";
            this.tab_wallet.Size = new System.Drawing.Size(869, 521);
            this.tab_wallet.TabIndex = 2;
            this.tab_wallet.Text = "03 결제";
            this.tab_wallet.UseVisualStyleBackColor = true;
            // 
            // tab_end
            // 
            this.tab_end.Location = new System.Drawing.Point(4, 30);
            this.tab_end.Name = "tab_end";
            this.tab_end.Size = new System.Drawing.Size(869, 521);
            this.tab_end.TabIndex = 3;
            this.tab_end.Text = "04 결제완료";
            this.tab_end.UseVisualStyleBackColor = true;
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
    }
}