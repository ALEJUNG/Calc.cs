namespace HelloCSharpWin
{
    partial class Calculator
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.Sum1 = new System.Windows.Forms.TextBox();
            this.Sum2 = new System.Windows.Forms.TextBox();
            this.SumButon = new System.Windows.Forms.Button();
            this.SumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Location = new System.Drawing.Point(13, 13);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(57, 12);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Click here";
            this.HelloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sum1
            // 
            this.Sum1.Location = new System.Drawing.Point(15, 49);
            this.Sum1.Name = "Sum1";
            this.Sum1.Size = new System.Drawing.Size(100, 19);
            this.Sum1.TabIndex = 1;
            // 
            // Sum2
            // 
            this.Sum2.Location = new System.Drawing.Point(138, 49);
            this.Sum2.Name = "Sum2";
            this.Sum2.Size = new System.Drawing.Size(100, 19);
            this.Sum2.TabIndex = 2;
            this.Sum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SumButon
            // 
            this.SumButon.Location = new System.Drawing.Point(255, 47);
            this.SumButon.Name = "SumButon";
            this.SumButon.Size = new System.Drawing.Size(75, 23);
            this.SumButon.TabIndex = 3;
            this.SumButon.Text = "SUM";
            this.SumButon.UseVisualStyleBackColor = true;
            this.SumButon.Click += new System.EventHandler(this.SumButon_Click);
            // 
            // SumResult
            // 
            this.SumResult.Location = new System.Drawing.Point(342, 49);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(100, 19);
            this.SumResult.TabIndex = 4;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 315);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.SumButon);
            this.Controls.Add(this.Sum2);
            this.Controls.Add(this.Sum1);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox Sum1;
        private System.Windows.Forms.TextBox Sum2;
        private System.Windows.Forms.Button SumButon;
        private System.Windows.Forms.TextBox SumResult;
    }
}

