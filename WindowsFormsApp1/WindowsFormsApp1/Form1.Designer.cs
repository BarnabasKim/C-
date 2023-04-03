namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonAllClear = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonRecord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnback = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(3, 46);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(682, 49);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonResult, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonAllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSubtract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMultiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSeven, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 150);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 438);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAdd.Location = new System.Drawing.Point(510, 329);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(162, 104);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.Text = "＋";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonResult.Location = new System.Drawing.Point(341, 329);
            this.ButtonResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(162, 104);
            this.ButtonResult.TabIndex = 4;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click_1);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonZero.Location = new System.Drawing.Point(172, 329);
            this.ButtonZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(162, 104);
            this.ButtonZero.TabIndex = 13;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonAllClear
            // 
            this.ButtonAllClear.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAllClear.Location = new System.Drawing.Point(3, 329);
            this.ButtonAllClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAllClear.Name = "ButtonAllClear";
            this.ButtonAllClear.Size = new System.Drawing.Size(162, 104);
            this.ButtonAllClear.TabIndex = 12;
            this.ButtonAllClear.Text = "AC";
            this.ButtonAllClear.UseVisualStyleBackColor = true;
            this.ButtonAllClear.Click += new System.EventHandler(this.ButtonAllClear_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSubtract.Location = new System.Drawing.Point(510, 220);
            this.ButtonSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(162, 102);
            this.ButtonSubtract.TabIndex = 11;
            this.ButtonSubtract.Text = "－";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonThree.Location = new System.Drawing.Point(341, 220);
            this.ButtonThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(162, 102);
            this.ButtonThree.TabIndex = 10;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonTwo.Location = new System.Drawing.Point(172, 220);
            this.ButtonTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(162, 102);
            this.ButtonTwo.TabIndex = 9;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonOne.Location = new System.Drawing.Point(3, 220);
            this.ButtonOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(162, 102);
            this.ButtonOne.TabIndex = 8;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMultiply.Location = new System.Drawing.Point(510, 111);
            this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(162, 102);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "×";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSix.Location = new System.Drawing.Point(341, 111);
            this.ButtonSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(162, 102);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFive.Location = new System.Drawing.Point(172, 111);
            this.ButtonFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(162, 102);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFour.Location = new System.Drawing.Point(3, 111);
            this.ButtonFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(162, 102);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonDivide.Location = new System.Drawing.Point(510, 2);
            this.ButtonDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(162, 102);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "÷";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonNine.Location = new System.Drawing.Point(341, 2);
            this.ButtonNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(162, 102);
            this.ButtonNine.TabIndex = 2;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonEight.Location = new System.Drawing.Point(172, 2);
            this.ButtonEight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(162, 102);
            this.ButtonEight.TabIndex = 1;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSeven.Location = new System.Drawing.Point(3, 2);
            this.ButtonSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(162, 102);
            this.ButtonSeven.TabIndex = 0;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonRecord
            // 
            this.ButtonRecord.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonRecord.Location = new System.Drawing.Point(517, 98);
            this.ButtonRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRecord.Name = "ButtonRecord";
            this.ButtonRecord.Size = new System.Drawing.Size(166, 49);
            this.ButtonRecord.TabIndex = 5;
            this.ButtonRecord.Text = "RECORD";
            this.ButtonRecord.UseVisualStyleBackColor = true;
            this.ButtonRecord.Click += new System.EventHandler(this.ButtonRecord_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(347, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 38);
            this.textBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnback.Location = new System.Drawing.Point(347, 98);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(170, 49);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "Delete";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 590);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonRecord);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonAllClear;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.Button ButtonRecord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnback;
    }
}

