namespace TermProject
{
    partial class New
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("굴림", 15F);
            this.UserName.Location = new System.Drawing.Point(299, 132);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(69, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "닉네임";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("굴림", 15F);
            this.UserNameBox.Location = new System.Drawing.Point(394, 129);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(170, 30);
            this.UserNameBox.TabIndex = 2;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("굴림", 15F);
            this.label_1.Location = new System.Drawing.Point(375, 40);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(136, 20);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "회원가입 화면";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("굴림", 15F);
            this.Clear.Location = new System.Drawing.Point(445, 399);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 38);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "취소";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("굴림", 15F);
            this.Add.Location = new System.Drawing.Point(318, 399);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 38);
            this.Add.TabIndex = 6;
            this.Add.Text = "가입";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PWBox
            // 
            this.PWBox.Font = new System.Drawing.Font("굴림", 15F);
            this.PWBox.Location = new System.Drawing.Point(394, 264);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(170, 30);
            this.PWBox.TabIndex = 8;
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Font = new System.Drawing.Font("굴림", 15F);
            this.PW.Location = new System.Drawing.Point(290, 267);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(89, 20);
            this.PW.TabIndex = 7;
            this.PW.Text = "비밀번호";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("굴림", 15F);
            this.IDBox.Location = new System.Drawing.Point(394, 194);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(170, 30);
            this.IDBox.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("굴림", 15F);
            this.ID.Location = new System.Drawing.Point(299, 197);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(69, 20);
            this.ID.TabIndex = 9;
            this.ID.Text = "아이디";
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserName);
            this.Name = "New";
            this.Text = "New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label ID;
    }
}