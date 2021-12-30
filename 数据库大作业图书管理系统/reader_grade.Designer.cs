
namespace 数据库大作业图书管理系统
{
    partial class reader_grade
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
            this.textBox_reader01 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_reader_grade = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_reader_booknumber = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox_reader_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_reader01
            // 
            this.textBox_reader01.Location = new System.Drawing.Point(12, 12);
            this.textBox_reader01.Multiline = true;
            this.textBox_reader01.Name = "textBox_reader01";
            this.textBox_reader01.ReadOnly = true;
            this.textBox_reader01.Size = new System.Drawing.Size(205, 211);
            this.textBox_reader01.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "你当前的等级：";
            // 
            // textBox_reader_grade
            // 
            this.textBox_reader_grade.Location = new System.Drawing.Point(393, 49);
            this.textBox_reader_grade.Name = "textBox_reader_grade";
            this.textBox_reader_grade.ReadOnly = true;
            this.textBox_reader_grade.Size = new System.Drawing.Size(72, 25);
            this.textBox_reader_grade.TabIndex = 2;
            this.textBox_reader_grade.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(136, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "最大借书数量:";
            // 
            // textBox_reader_booknumber
            // 
            this.textBox_reader_booknumber.Location = new System.Drawing.Point(393, 110);
            this.textBox_reader_booknumber.Name = "textBox_reader_booknumber";
            this.textBox_reader_booknumber.ReadOnly = true;
            this.textBox_reader_booknumber.Size = new System.Drawing.Size(72, 25);
            this.textBox_reader_booknumber.TabIndex = 4;
            this.textBox_reader_booknumber.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(136, 25);
            this.textBox4.TabIndex = 5;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "最大借书时间:";
            // 
            // textBox_reader_time
            // 
            this.textBox_reader_time.Location = new System.Drawing.Point(393, 175);
            this.textBox_reader_time.Name = "textBox_reader_time";
            this.textBox_reader_time.ReadOnly = true;
            this.textBox_reader_time.Size = new System.Drawing.Size(72, 25);
            this.textBox_reader_time.TabIndex = 6;
            this.textBox_reader_time.TabStop = false;
            // 
            // reader_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 266);
            this.Controls.Add(this.textBox_reader_time);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox_reader_booknumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_reader_grade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_reader01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "reader_grade";
            this.Text = "读者等级";
            this.Load += new System.EventHandler(this.reader_grade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_reader01;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_reader_grade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_reader_booknumber;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox_reader_time;
    }
}