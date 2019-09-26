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
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.Num7Button = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.Num0Button = new System.Windows.Forms.Button();
            this.ResultScreen = new System.Windows.Forms.Label();
            this.SUMButton = new System.Windows.Forms.Button();
            this.SUBButton = new System.Windows.Forms.Button();
            this.MULButton = new System.Windows.Forms.Button();
            this.DIVButton = new System.Windows.Forms.Button();
            this.EQUButton = new System.Windows.Forms.Button();
            this.CelarButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1Button
            // 
            this.Num1Button.Location = new System.Drawing.Point(12, 107);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(75, 47);
            this.Num1Button.TabIndex = 0;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            this.Num1Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num2Button
            // 
            this.Num2Button.Location = new System.Drawing.Point(93, 107);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(75, 47);
            this.Num2Button.TabIndex = 1;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            this.Num2Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num3Button
            // 
            this.Num3Button.Location = new System.Drawing.Point(174, 107);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(75, 47);
            this.Num3Button.TabIndex = 2;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            this.Num3Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num4Button
            // 
            this.Num4Button.Location = new System.Drawing.Point(12, 160);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(75, 47);
            this.Num4Button.TabIndex = 3;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            this.Num4Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num5Button
            // 
            this.Num5Button.Location = new System.Drawing.Point(93, 160);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(75, 47);
            this.Num5Button.TabIndex = 4;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            this.Num5Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num6Button
            // 
            this.Num6Button.Location = new System.Drawing.Point(174, 160);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(75, 47);
            this.Num6Button.TabIndex = 5;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            this.Num6Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num7Button
            // 
            this.Num7Button.Location = new System.Drawing.Point(12, 213);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(75, 47);
            this.Num7Button.TabIndex = 7;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            this.Num7Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num8Button
            // 
            this.Num8Button.Location = new System.Drawing.Point(93, 213);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(75, 47);
            this.Num8Button.TabIndex = 8;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            this.Num8Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num9Button
            // 
            this.Num9Button.Location = new System.Drawing.Point(174, 213);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(75, 47);
            this.Num9Button.TabIndex = 9;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Num0Button
            // 
            this.Num0Button.Location = new System.Drawing.Point(93, 266);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(75, 47);
            this.Num0Button.TabIndex = 6;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            this.Num0Button.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // ResultScreen
            // 
            this.ResultScreen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResultScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultScreen.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultScreen.Location = new System.Drawing.Point(10, 9);
            this.ResultScreen.Name = "ResultScreen";
            this.ResultScreen.Size = new System.Drawing.Size(432, 62);
            this.ResultScreen.TabIndex = 10;
            this.ResultScreen.Text = "0";
            this.ResultScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SUMButton
            // 
            this.SUMButton.Location = new System.Drawing.Point(403, 213);
            this.SUMButton.Name = "SUMButton";
            this.SUMButton.Size = new System.Drawing.Size(49, 47);
            this.SUMButton.TabIndex = 11;
            this.SUMButton.Text = "+";
            this.SUMButton.UseVisualStyleBackColor = true;
            this.SUMButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // SUBButton
            // 
            this.SUBButton.Location = new System.Drawing.Point(403, 160);
            this.SUBButton.Name = "SUBButton";
            this.SUBButton.Size = new System.Drawing.Size(49, 47);
            this.SUBButton.TabIndex = 12;
            this.SUBButton.Text = "-";
            this.SUBButton.UseVisualStyleBackColor = true;
            this.SUBButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // MULButton
            // 
            this.MULButton.Location = new System.Drawing.Point(348, 213);
            this.MULButton.Name = "MULButton";
            this.MULButton.Size = new System.Drawing.Size(49, 47);
            this.MULButton.TabIndex = 13;
            this.MULButton.Text = "X";
            this.MULButton.UseVisualStyleBackColor = true;
            this.MULButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // DIVButton
            // 
            this.DIVButton.Location = new System.Drawing.Point(348, 160);
            this.DIVButton.Name = "DIVButton";
            this.DIVButton.Size = new System.Drawing.Size(49, 47);
            this.DIVButton.TabIndex = 14;
            this.DIVButton.Text = "/";
            this.DIVButton.UseVisualStyleBackColor = true;
            this.DIVButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // EQUButton
            // 
            this.EQUButton.Location = new System.Drawing.Point(403, 266);
            this.EQUButton.Name = "EQUButton";
            this.EQUButton.Size = new System.Drawing.Size(49, 47);
            this.EQUButton.TabIndex = 15;
            this.EQUButton.Text = "=";
            this.EQUButton.UseVisualStyleBackColor = true;
            this.EQUButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // CelarButton
            // 
            this.CelarButton.Location = new System.Drawing.Point(403, 107);
            this.CelarButton.Name = "CelarButton";
            this.CelarButton.Size = new System.Drawing.Size(49, 47);
            this.CelarButton.TabIndex = 16;
            this.CelarButton.Text = "C";
            this.CelarButton.UseVisualStyleBackColor = true;
            this.CelarButton.Click += new System.EventHandler(this.CelarButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(174, 266);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(75, 47);
            this.DotButton.TabIndex = 17;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 315);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.CelarButton);
            this.Controls.Add(this.EQUButton);
            this.Controls.Add(this.DIVButton);
            this.Controls.Add(this.MULButton);
            this.Controls.Add(this.SUBButton);
            this.Controls.Add(this.SUMButton);
            this.Controls.Add(this.ResultScreen);
            this.Controls.Add(this.Num0Button);
            this.Controls.Add(this.Num9Button);
            this.Controls.Add(this.Num8Button);
            this.Controls.Add(this.Num7Button);
            this.Controls.Add(this.Num6Button);
            this.Controls.Add(this.Num5Button);
            this.Controls.Add(this.Num4Button);
            this.Controls.Add(this.Num3Button);
            this.Controls.Add(this.Num2Button);
            this.Controls.Add(this.Num1Button);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num7Button;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Label ResultScreen;
        private System.Windows.Forms.Button SUMButton;
        private System.Windows.Forms.Button SUBButton;
        private System.Windows.Forms.Button MULButton;
        private System.Windows.Forms.Button DIVButton;
        private System.Windows.Forms.Button EQUButton;
        private System.Windows.Forms.Button CelarButton;
        private System.Windows.Forms.Button DotButton;
    }
}

