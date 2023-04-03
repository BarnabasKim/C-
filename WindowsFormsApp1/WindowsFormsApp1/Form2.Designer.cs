namespace WindowsFormsApp1
{
    partial class ChildForm
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
            this.display2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display2
            // 
            this.display2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.display2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display2.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display2.Location = new System.Drawing.Point(0, 0);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(700, 302);
            this.display2.TabIndex = 0;
            this.display2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 302);
            this.Controls.Add(this.display2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display2;
    }
}