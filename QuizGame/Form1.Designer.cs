namespace QuizGame
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
            this.tName = new System.Windows.Forms.TextBox();
            this.btn001 = new System.Windows.Forms.Button();
            this.btn002 = new System.Windows.Forms.Button();
            this.btn003 = new System.Windows.Forms.Button();
            this.btn004 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tName.Location = new System.Drawing.Point(0, 0);
            this.tName.Multiline = true;
            this.tName.Name = "tName";
            this.tName.ReadOnly = true;
            this.tName.Size = new System.Drawing.Size(800, 129);
            this.tName.TabIndex = 0;
            // 
            // btn001
            // 
            this.btn001.Location = new System.Drawing.Point(12, 178);
            this.btn001.Name = "btn001";
            this.btn001.Size = new System.Drawing.Size(248, 42);
            this.btn001.TabIndex = 1;
            this.btn001.Text = "button1";
            this.btn001.UseVisualStyleBackColor = true;
            this.btn001.Click += new System.EventHandler(this.btn001_Click);
            // 
            // btn002
            // 
            this.btn002.Location = new System.Drawing.Point(12, 226);
            this.btn002.Name = "btn002";
            this.btn002.Size = new System.Drawing.Size(248, 45);
            this.btn002.TabIndex = 2;
            this.btn002.Text = "button2";
            this.btn002.UseVisualStyleBackColor = true;
            this.btn002.Click += new System.EventHandler(this.btn002_Click);
            // 
            // btn003
            // 
            this.btn003.Location = new System.Drawing.Point(12, 277);
            this.btn003.Name = "btn003";
            this.btn003.Size = new System.Drawing.Size(248, 44);
            this.btn003.TabIndex = 3;
            this.btn003.Text = "button3";
            this.btn003.UseVisualStyleBackColor = true;
            this.btn003.Click += new System.EventHandler(this.btn003_Click);
            // 
            // btn004
            // 
            this.btn004.Location = new System.Drawing.Point(12, 327);
            this.btn004.Name = "btn004";
            this.btn004.Size = new System.Drawing.Size(248, 39);
            this.btn004.TabIndex = 4;
            this.btn004.Text = "button4";
            this.btn004.UseVisualStyleBackColor = true;
            this.btn004.Click += new System.EventHandler(this.btn004_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn004);
            this.Controls.Add(this.btn003);
            this.Controls.Add(this.btn002);
            this.Controls.Add(this.btn001);
            this.Controls.Add(this.tName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Button btn001;
        private System.Windows.Forms.Button btn002;
        private System.Windows.Forms.Button btn003;
        private System.Windows.Forms.Button btn004;
    }
}

