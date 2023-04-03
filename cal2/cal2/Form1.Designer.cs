namespace cal2
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
            this.ProcessBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnCal1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnCal2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCal3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnCal4 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessBox
            // 
            this.ProcessBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProcessBox.Location = new System.Drawing.Point(35, 82);
            this.ProcessBox.Name = "ProcessBox";
            this.ProcessBox.Size = new System.Drawing.Size(359, 32);
            this.ProcessBox.TabIndex = 0;
            this.ProcessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultBox.Location = new System.Drawing.Point(35, 120);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(359, 32);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCal4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCal3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCal2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCal1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 278);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 63);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2.Location = new System.Drawing.Point(71, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 63);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(139, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 63);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btnCal1
            // 
            this.btnCal1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCal1.Location = new System.Drawing.Point(207, 3);
            this.btnCal1.Name = "btnCal1";
            this.btnCal1.Size = new System.Drawing.Size(62, 63);
            this.btnCal1.TabIndex = 3;
            this.btnCal1.Text = "+";
            this.btnCal1.UseVisualStyleBackColor = true;
            this.btnCal1.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn4.Location = new System.Drawing.Point(3, 72);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 63);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn5.Location = new System.Drawing.Point(71, 72);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 63);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn6.Location = new System.Drawing.Point(139, 72);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 63);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btnCal2
            // 
            this.btnCal2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCal2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCal2.Location = new System.Drawing.Point(207, 72);
            this.btnCal2.Name = "btnCal2";
            this.btnCal2.Size = new System.Drawing.Size(62, 63);
            this.btnCal2.TabIndex = 7;
            this.btnCal2.Text = "-";
            this.btnCal2.UseVisualStyleBackColor = true;
            this.btnCal2.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn7.Location = new System.Drawing.Point(3, 141);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 63);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn8.Location = new System.Drawing.Point(71, 141);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 63);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn9.Location = new System.Drawing.Point(139, 141);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 63);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // btnCal3
            // 
            this.btnCal3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCal3.Location = new System.Drawing.Point(207, 141);
            this.btnCal3.Name = "btnCal3";
            this.btnCal3.Size = new System.Drawing.Size(64, 63);
            this.btnCal3.TabIndex = 11;
            this.btnCal3.Text = "*";
            this.btnCal3.UseVisualStyleBackColor = true;
            this.btnCal3.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // btn0
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn0, 2);
            this.btn0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn0.Location = new System.Drawing.Point(3, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(130, 63);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumBtn_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(139, 210);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(62, 63);
            this.button13.TabIndex = 13;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // btnCal4
            // 
            this.btnCal4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCal4.Location = new System.Drawing.Point(207, 210);
            this.btnCal4.Name = "btnCal4";
            this.btnCal4.Size = new System.Drawing.Size(62, 63);
            this.btnCal4.TabIndex = 14;
            this.btnCal4.Text = "/";
            this.btnCal4.UseVisualStyleBackColor = true;
            this.btnCal4.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(315, 162);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 61);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(315, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 61);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(315, 302);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(79, 129);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 472);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ProcessBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProcessBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCal4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCal3;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCal2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnCal1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResult;
    }
}

