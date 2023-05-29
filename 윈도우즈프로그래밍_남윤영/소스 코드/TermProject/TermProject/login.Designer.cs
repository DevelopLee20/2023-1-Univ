namespace TermProject
{
    partial class login
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
            this.log_id_box = new System.Windows.Forms.TextBox();
            this.log_id = new System.Windows.Forms.Label();
            this.log_pw_box = new System.Windows.Forms.TextBox();
            this.log_pw = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.Clear_1 = new System.Windows.Forms.Button();
            this.label_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_id_box
            // 
            this.log_id_box.Font = new System.Drawing.Font("굴림", 15F);
            this.log_id_box.Location = new System.Drawing.Point(404, 147);
            this.log_id_box.Name = "log_id_box";
            this.log_id_box.Size = new System.Drawing.Size(170, 30);
            this.log_id_box.TabIndex = 19;
            this.log_id_box.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.Font = new System.Drawing.Font("굴림", 15F);
            this.log_id.Location = new System.Drawing.Point(309, 150);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(69, 20);
            this.log_id.TabIndex = 18;
            this.log_id.Text = "아이디";
            this.log_id.Click += new System.EventHandler(this.ID_Click);
            // 
            // log_pw_box
            // 
            this.log_pw_box.Font = new System.Drawing.Font("굴림", 15F);
            this.log_pw_box.Location = new System.Drawing.Point(404, 217);
            this.log_pw_box.Name = "log_pw_box";
            this.log_pw_box.Size = new System.Drawing.Size(170, 30);
            this.log_pw_box.TabIndex = 17;
            this.log_pw_box.TextChanged += new System.EventHandler(this.PWBox_TextChanged);
            // 
            // log_pw
            // 
            this.log_pw.AutoSize = true;
            this.log_pw.Font = new System.Drawing.Font("굴림", 15F);
            this.log_pw.Location = new System.Drawing.Point(300, 220);
            this.log_pw.Name = "log_pw";
            this.log_pw.Size = new System.Drawing.Size(89, 20);
            this.log_pw.TabIndex = 16;
            this.log_pw.Text = "비밀번호";
            this.log_pw.Click += new System.EventHandler(this.PW_Click);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("굴림", 15F);
            this.login_btn.Location = new System.Drawing.Point(324, 359);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(89, 38);
            this.login_btn.TabIndex = 14;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear_1
            // 
            this.Clear_1.Font = new System.Drawing.Font("굴림", 15F);
            this.Clear_1.Location = new System.Drawing.Point(451, 359);
            this.Clear_1.Name = "Clear_1";
            this.Clear_1.Size = new System.Drawing.Size(89, 38);
            this.Clear_1.TabIndex = 15;
            this.Clear_1.Text = "취소";
            this.Clear_1.UseVisualStyleBackColor = true;
            this.Clear_1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("굴림", 15F);
            this.label_2.Location = new System.Drawing.Point(385, 57);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(116, 20);
            this.label_2.TabIndex = 13;
            this.label_2.Text = "로그인 화면";
            this.label_2.Click += new System.EventHandler(this.label_1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.log_id_box);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_pw_box);
            this.Controls.Add(this.log_pw);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Clear_1);
            this.Controls.Add(this.label_2);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_id_box;
        private System.Windows.Forms.Label log_id;
        private System.Windows.Forms.Label log_pw;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button Clear_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.TextBox log_pw_box;
    }
}