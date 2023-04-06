namespace if_switch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.btnIfResult = new System.Windows.Forms.Button();
            this.lblIfResult = new System.Windows.Forms.Label();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblswitchResult = new System.Windows.Forms.Label();
            this.btnswitchResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2)";
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(177, 124);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(120, 25);
            this.nNumber2.TabIndex = 2;
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(28, 124);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(120, 25);
            this.nNumber1.TabIndex = 3;
            // 
            // btnIfResult
            // 
            this.btnIfResult.Location = new System.Drawing.Point(344, 112);
            this.btnIfResult.Name = "btnIfResult";
            this.btnIfResult.Size = new System.Drawing.Size(131, 42);
            this.btnIfResult.TabIndex = 4;
            this.btnIfResult.Text = "Number 비교";
            this.btnIfResult.UseVisualStyleBackColor = true;
            this.btnIfResult.Click += new System.EventHandler(this.btnIfResult_Click);
            // 
            // lblIfResult
            // 
            this.lblIfResult.AutoSize = true;
            this.lblIfResult.Location = new System.Drawing.Point(36, 186);
            this.lblIfResult.Name = "lblIfResult";
            this.lblIfResult.Size = new System.Drawing.Size(15, 15);
            this.lblIfResult.TabIndex = 5;
            this.lblIfResult.Text = "-";
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(28, 251);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 23);
            this.cboxDay.TabIndex = 6;
            this.cboxDay.Text = "월";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "요일선택)";
            // 
            // lblswitchResult
            // 
            this.lblswitchResult.AutoSize = true;
            this.lblswitchResult.Location = new System.Drawing.Point(36, 331);
            this.lblswitchResult.Name = "lblswitchResult";
            this.lblswitchResult.Size = new System.Drawing.Size(15, 15);
            this.lblswitchResult.TabIndex = 8;
            this.lblswitchResult.Text = "-";
            // 
            // btnswitchResult
            // 
            this.btnswitchResult.Location = new System.Drawing.Point(344, 240);
            this.btnswitchResult.Name = "btnswitchResult";
            this.btnswitchResult.Size = new System.Drawing.Size(131, 42);
            this.btnswitchResult.TabIndex = 9;
            this.btnswitchResult.Text = "선택요일화인";
            this.btnswitchResult.UseVisualStyleBackColor = true;
            this.btnswitchResult.Click += new System.EventHandler(this.btnswitchResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnswitchResult);
            this.Controls.Add(this.lblswitchResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.lblIfResult);
            this.Controls.Add(this.btnIfResult);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.Button btnIfResult;
        private System.Windows.Forms.Label lblIfResult;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblswitchResult;
        private System.Windows.Forms.Button btnswitchResult;
    }
}

