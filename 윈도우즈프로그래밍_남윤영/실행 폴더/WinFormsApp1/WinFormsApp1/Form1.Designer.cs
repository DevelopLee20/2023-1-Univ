namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add1 = new System.Windows.Forms.Button();
            this.btn_remove1 = new System.Windows.Forms.Button();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.btn_remove3 = new System.Windows.Forms.Button();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.Ibox_1 = new System.Windows.Forms.ListBox();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.tbox_1 = new System.Windows.Forms.TextBox();
            this.tbox_2 = new System.Windows.Forms.TextBox();
            this.chbox = new System.Windows.Forms.CheckedListBox();
            this.btn_summary = new System.Windows.Forms.Button();
            this.Ib_msg = new System.Windows.Forms.Label();
            this.Ibox_2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_add1
            // 
            this.btn_add1.Location = new System.Drawing.Point(274, 58);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(75, 23);
            this.btn_add1.TabIndex = 0;
            this.btn_add1.Text = "추가";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_remove1
            // 
            this.btn_remove1.Location = new System.Drawing.Point(274, 102);
            this.btn_remove1.Name = "btn_remove1";
            this.btn_remove1.Size = new System.Drawing.Size(75, 23);
            this.btn_remove1.TabIndex = 1;
            this.btn_remove1.Text = "삭제";
            this.btn_remove1.UseVisualStyleBackColor = true;
            this.btn_remove1.Click += new System.EventHandler(this.btn_remove1_Click);
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(135, 59);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(121, 23);
            this.cbox.TabIndex = 2;
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // btn_remove3
            // 
            this.btn_remove3.Location = new System.Drawing.Point(535, 102);
            this.btn_remove3.Name = "btn_remove3";
            this.btn_remove3.Size = new System.Drawing.Size(75, 23);
            this.btn_remove3.TabIndex = 4;
            this.btn_remove3.Text = "삭제";
            this.btn_remove3.UseVisualStyleBackColor = true;
            this.btn_remove3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_add3
            // 
            this.btn_add3.Location = new System.Drawing.Point(535, 58);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(75, 23);
            this.btn_add3.TabIndex = 3;
            this.btn_add3.Text = "추가";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ibox_1
            // 
            this.Ibox_1.FormattingEnabled = true;
            this.Ibox_1.ItemHeight = 15;
            this.Ibox_1.Location = new System.Drawing.Point(136, 219);
            this.Ibox_1.Name = "Ibox_1";
            this.Ibox_1.Size = new System.Drawing.Size(120, 94);
            this.Ibox_1.TabIndex = 5;
            this.Ibox_1.SelectedIndexChanged += new System.EventHandler(this.Ibox_1_SelectedIndexChanged);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Location = new System.Drawing.Point(274, 219);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(75, 23);
            this.btn_remove2.TabIndex = 7;
            this.btn_remove2.Text = "삭제";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Location = new System.Drawing.Point(274, 175);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(75, 23);
            this.btn_add2.TabIndex = 6;
            this.btn_add2.Text = "추가";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbox_1
            // 
            this.tbox_1.Location = new System.Drawing.Point(135, 176);
            this.tbox_1.Name = "tbox_1";
            this.tbox_1.Size = new System.Drawing.Size(121, 23);
            this.tbox_1.TabIndex = 8;
            // 
            // tbox_2
            // 
            this.tbox_2.Location = new System.Drawing.Point(408, 58);
            this.tbox_2.Name = "tbox_2";
            this.tbox_2.Size = new System.Drawing.Size(121, 23);
            this.tbox_2.TabIndex = 9;
            this.tbox_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chbox
            // 
            this.chbox.FormattingEnabled = true;
            this.chbox.Location = new System.Drawing.Point(409, 102);
            this.chbox.Name = "chbox";
            this.chbox.Size = new System.Drawing.Size(120, 94);
            this.chbox.TabIndex = 10;
            this.chbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_summary
            // 
            this.btn_summary.Location = new System.Drawing.Point(393, 219);
            this.btn_summary.Name = "btn_summary";
            this.btn_summary.Size = new System.Drawing.Size(75, 23);
            this.btn_summary.TabIndex = 11;
            this.btn_summary.Text = "요약";
            this.btn_summary.UseVisualStyleBackColor = true;
            this.btn_summary.Click += new System.EventHandler(this.btn_summary_Click);
            // 
            // Ib_msg
            // 
            this.Ib_msg.AutoSize = true;
            this.Ib_msg.Location = new System.Drawing.Point(43, 409);
            this.Ib_msg.Name = "Ib_msg";
            this.Ib_msg.Size = new System.Drawing.Size(38, 15);
            this.Ib_msg.TabIndex = 12;
            this.Ib_msg.Text = "[msg]";
            // 
            // Ibox_2
            // 
            this.Ibox_2.FormattingEnabled = true;
            this.Ibox_2.ItemHeight = 15;
            this.Ibox_2.Location = new System.Drawing.Point(393, 258);
            this.Ibox_2.Name = "Ibox_2";
            this.Ibox_2.Size = new System.Drawing.Size(259, 124);
            this.Ibox_2.TabIndex = 13;
            this.Ibox_2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ibox_2);
            this.Controls.Add(this.Ib_msg);
            this.Controls.Add(this.btn_summary);
            this.Controls.Add(this.chbox);
            this.Controls.Add(this.tbox_2);
            this.Controls.Add(this.tbox_1);
            this.Controls.Add(this.btn_remove2);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.Ibox_1);
            this.Controls.Add(this.btn_remove3);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.btn_remove1);
            this.Controls.Add(this.btn_add1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_add1;
        private Button btn_remove1;
        private ComboBox cbox;
        private Button btn_remove3;
        private Button btn_add3;
        private ListBox Ibox_1;
        private Button btn_remove2;
        private Button btn_add2;
        private TextBox tbox_1;
        private TextBox tbox_2;
        private CheckedListBox chbox;
        private Button btn_summary;
        private Label Ib_msg;
        private ListBox Ibox_2;
    }
}