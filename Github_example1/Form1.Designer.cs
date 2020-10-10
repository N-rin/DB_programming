namespace Github_example1
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
            this.textBox_birth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_push = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_birth
            // 
            this.textBox_birth.Location = new System.Drawing.Point(55, 121);
            this.textBox_birth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_birth.Name = "textBox_birth";
            this.textBox_birth.Size = new System.Drawing.Size(178, 28);
            this.textBox_birth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름입력";
            // 
            // button_push
            // 
            this.button_push.Location = new System.Drawing.Point(89, 175);
            this.button_push.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_push.Name = "button_push";
            this.button_push.Size = new System.Drawing.Size(94, 28);
            this.button_push.TabIndex = 4;
            this.button_push.Text = "입력";
            this.button_push.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 429);
            this.Controls.Add(this.button_push);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_birth);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_birth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_push;
    }
}

