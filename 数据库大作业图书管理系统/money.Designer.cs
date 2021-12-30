
namespace 数据库大作业图书管理系统
{
    partial class money
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_admin_selectbook1 = new System.Windows.Forms.Label();
            this.textBox_user_money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_user_givemoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(222, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "缴纳罚款";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_admin_selectbook1
            // 
            this.label_admin_selectbook1.AutoSize = true;
            this.label_admin_selectbook1.Location = new System.Drawing.Point(29, 35);
            this.label_admin_selectbook1.Name = "label_admin_selectbook1";
            this.label_admin_selectbook1.Size = new System.Drawing.Size(172, 15);
            this.label_admin_selectbook1.TabIndex = 11;
            this.label_admin_selectbook1.Text = "目前所需缴纳的金额是：";
            // 
            // textBox_user_money
            // 
            this.textBox_user_money.Location = new System.Drawing.Point(207, 32);
            this.textBox_user_money.Name = "textBox_user_money";
            this.textBox_user_money.ReadOnly = true;
            this.textBox_user_money.Size = new System.Drawing.Size(189, 25);
            this.textBox_user_money.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "你缴纳的罚款金额是：";
            // 
            // textBox_user_givemoney
            // 
            this.textBox_user_givemoney.Location = new System.Drawing.Point(207, 97);
            this.textBox_user_givemoney.Name = "textBox_user_givemoney";
            this.textBox_user_givemoney.Size = new System.Drawing.Size(189, 25);
            this.textBox_user_givemoney.TabIndex = 14;
            // 
            // money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 229);
            this.Controls.Add(this.textBox_user_givemoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_user_money);
            this.Controls.Add(this.label_admin_selectbook1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "money";
            this.Text = "缴纳罚款界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_admin_selectbook1;
        private System.Windows.Forms.TextBox textBox_user_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_user_givemoney;
    }
}