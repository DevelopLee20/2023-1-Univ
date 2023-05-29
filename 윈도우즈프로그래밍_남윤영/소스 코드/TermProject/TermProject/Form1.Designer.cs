namespace TermProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.link_facebook = new System.Windows.Forms.LinkLabel();
            this.link_youtube = new System.Windows.Forms.LinkLabel();
            this.link_instagram = new System.Windows.Forms.LinkLabel();
            this.link_login = new System.Windows.Forms.LinkLabel();
            this.link_question = new System.Windows.Forms.LinkLabel();
            this.link_help = new System.Windows.Forms.LinkLabel();
            this.link_membership = new System.Windows.Forms.LinkLabel();
            this.link_locate = new System.Windows.Forms.LinkLabel();
            this.link_movie = new System.Windows.Forms.LinkLabel();
            this.link_pre = new System.Windows.Forms.LinkLabel();
            this.link_event = new System.Windows.Forms.LinkLabel();
            this.link_store = new System.Windows.Forms.LinkLabel();
            this.link_now_pre = new System.Windows.Forms.LinkLabel();
            this.link_new = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // link_facebook
            // 
            this.link_facebook.AutoSize = true;
            this.link_facebook.Font = new System.Drawing.Font("굴림", 15F);
            this.link_facebook.Location = new System.Drawing.Point(12, 9);
            this.link_facebook.Name = "link_facebook";
            this.link_facebook.Size = new System.Drawing.Size(89, 20);
            this.link_facebook.TabIndex = 0;
            this.link_facebook.TabStop = true;
            this.link_facebook.Text = "페이스북";
            // 
            // link_youtube
            // 
            this.link_youtube.AutoSize = true;
            this.link_youtube.Font = new System.Drawing.Font("굴림", 15F);
            this.link_youtube.Location = new System.Drawing.Point(107, 9);
            this.link_youtube.Name = "link_youtube";
            this.link_youtube.Size = new System.Drawing.Size(69, 20);
            this.link_youtube.TabIndex = 1;
            this.link_youtube.TabStop = true;
            this.link_youtube.Text = "유튜브";
            // 
            // link_instagram
            // 
            this.link_instagram.AutoSize = true;
            this.link_instagram.Font = new System.Drawing.Font("굴림", 15F);
            this.link_instagram.Location = new System.Drawing.Point(182, 9);
            this.link_instagram.Name = "link_instagram";
            this.link_instagram.Size = new System.Drawing.Size(109, 20);
            this.link_instagram.TabIndex = 2;
            this.link_instagram.TabStop = true;
            this.link_instagram.Text = "인스타그램";
            // 
            // link_login
            // 
            this.link_login.AutoSize = true;
            this.link_login.Font = new System.Drawing.Font("굴림", 15F);
            this.link_login.Location = new System.Drawing.Point(669, 9);
            this.link_login.Name = "link_login";
            this.link_login.Size = new System.Drawing.Size(69, 20);
            this.link_login.TabIndex = 5;
            this.link_login.TabStop = true;
            this.link_login.Text = "로그인";
            this.link_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_login_LinkClicked);
            // 
            // link_question
            // 
            this.link_question.AutoSize = true;
            this.link_question.Font = new System.Drawing.Font("굴림", 15F);
            this.link_question.Location = new System.Drawing.Point(467, 9);
            this.link_question.Name = "link_question";
            this.link_question.Size = new System.Drawing.Size(178, 20);
            this.link_question.TabIndex = 4;
            this.link_question.TabStop = true;
            this.link_question.Text = "단체관람/대관문의";
            // 
            // link_help
            // 
            this.link_help.AutoSize = true;
            this.link_help.Font = new System.Drawing.Font("굴림", 15F);
            this.link_help.Location = new System.Drawing.Point(372, 9);
            this.link_help.Name = "link_help";
            this.link_help.Size = new System.Drawing.Size(89, 20);
            this.link_help.TabIndex = 3;
            this.link_help.TabStop = true;
            this.link_help.Text = "고객센터";
            // 
            // link_membership
            // 
            this.link_membership.AutoSize = true;
            this.link_membership.Font = new System.Drawing.Font("굴림", 15F);
            this.link_membership.Location = new System.Drawing.Point(297, 9);
            this.link_membership.Name = "link_membership";
            this.link_membership.Size = new System.Drawing.Size(69, 20);
            this.link_membership.TabIndex = 6;
            this.link_membership.TabStop = true;
            this.link_membership.Text = "멤버십";
            // 
            // link_locate
            // 
            this.link_locate.AutoSize = true;
            this.link_locate.Font = new System.Drawing.Font("굴림", 15F);
            this.link_locate.Location = new System.Drawing.Point(352, 65);
            this.link_locate.Name = "link_locate";
            this.link_locate.Size = new System.Drawing.Size(69, 20);
            this.link_locate.TabIndex = 9;
            this.link_locate.TabStop = true;
            this.link_locate.Text = "영화관";
            // 
            // link_movie
            // 
            this.link_movie.AutoSize = true;
            this.link_movie.Font = new System.Drawing.Font("굴림", 15F);
            this.link_movie.Location = new System.Drawing.Point(297, 65);
            this.link_movie.Name = "link_movie";
            this.link_movie.Size = new System.Drawing.Size(49, 20);
            this.link_movie.TabIndex = 8;
            this.link_movie.TabStop = true;
            this.link_movie.Text = "영화";
            // 
            // link_pre
            // 
            this.link_pre.AutoSize = true;
            this.link_pre.Font = new System.Drawing.Font("굴림", 15F);
            this.link_pre.Location = new System.Drawing.Point(242, 65);
            this.link_pre.Name = "link_pre";
            this.link_pre.Size = new System.Drawing.Size(49, 20);
            this.link_pre.TabIndex = 7;
            this.link_pre.TabStop = true;
            this.link_pre.Text = "예매";
            this.link_pre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pre_LinkClicked);
            // 
            // link_event
            // 
            this.link_event.AutoSize = true;
            this.link_event.Font = new System.Drawing.Font("굴림", 15F);
            this.link_event.Location = new System.Drawing.Point(427, 65);
            this.link_event.Name = "link_event";
            this.link_event.Size = new System.Drawing.Size(69, 20);
            this.link_event.TabIndex = 10;
            this.link_event.TabStop = true;
            this.link_event.Text = "이벤트";
            // 
            // link_store
            // 
            this.link_store.AutoSize = true;
            this.link_store.Font = new System.Drawing.Font("굴림", 15F);
            this.link_store.Location = new System.Drawing.Point(502, 65);
            this.link_store.Name = "link_store";
            this.link_store.Size = new System.Drawing.Size(69, 20);
            this.link_store.TabIndex = 11;
            this.link_store.TabStop = true;
            this.link_store.Text = "스토어";
            // 
            // link_now_pre
            // 
            this.link_now_pre.AutoSize = true;
            this.link_now_pre.Font = new System.Drawing.Font("굴림", 15F);
            this.link_now_pre.Location = new System.Drawing.Point(744, 53);
            this.link_now_pre.Name = "link_now_pre";
            this.link_now_pre.Size = new System.Drawing.Size(96, 20);
            this.link_now_pre.TabIndex = 13;
            this.link_now_pre.TabStop = true;
            this.link_now_pre.Text = "바로 예매";
            // 
            // link_new
            // 
            this.link_new.AutoSize = true;
            this.link_new.Font = new System.Drawing.Font("굴림", 15F);
            this.link_new.Location = new System.Drawing.Point(649, 53);
            this.link_new.Name = "link_new";
            this.link_new.Size = new System.Drawing.Size(89, 20);
            this.link_new.TabIndex = 12;
            this.link_new.TabStop = true;
            this.link_new.Text = "회원가입";
            this.link_new.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_new_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.link_now_pre);
            this.Controls.Add(this.link_new);
            this.Controls.Add(this.link_store);
            this.Controls.Add(this.link_event);
            this.Controls.Add(this.link_locate);
            this.Controls.Add(this.link_movie);
            this.Controls.Add(this.link_pre);
            this.Controls.Add(this.link_membership);
            this.Controls.Add(this.link_login);
            this.Controls.Add(this.link_question);
            this.Controls.Add(this.link_help);
            this.Controls.Add(this.link_instagram);
            this.Controls.Add(this.link_youtube);
            this.Controls.Add(this.link_facebook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_facebook;
        private System.Windows.Forms.LinkLabel link_youtube;
        private System.Windows.Forms.LinkLabel link_instagram;
        private System.Windows.Forms.LinkLabel link_login;
        private System.Windows.Forms.LinkLabel link_question;
        private System.Windows.Forms.LinkLabel link_help;
        private System.Windows.Forms.LinkLabel link_membership;
        private System.Windows.Forms.LinkLabel link_locate;
        private System.Windows.Forms.LinkLabel link_movie;
        private System.Windows.Forms.LinkLabel link_pre;
        private System.Windows.Forms.LinkLabel link_event;
        private System.Windows.Forms.LinkLabel link_store;
        private System.Windows.Forms.LinkLabel link_now_pre;
        private System.Windows.Forms.LinkLabel link_new;
    }
}

