
namespace 数据库大作业图书管理系统
{
    partial class find_user
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
            this.find_name = new System.Windows.Forms.TextBox();
            this.find_user_name = new System.Windows.Forms.TextBox();
            this.find_psw = new System.Windows.Forms.TextBox();
            this.find_user_psw = new System.Windows.Forms.TextBox();
            this.find_user_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // find_name
            // 
            this.find_name.BackColor = System.Drawing.SystemColors.Control;
            this.find_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_name.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.find_name.Location = new System.Drawing.Point(29, 39);
            this.find_name.Name = "find_name";
            this.find_name.ShortcutsEnabled = false;
            this.find_name.Size = new System.Drawing.Size(130, 22);
            this.find_name.TabIndex = 5;
            this.find_name.TabStop = false;
            this.find_name.Text = "姓名：";
            // 
            // find_user_name
            // 
            this.find_user_name.Location = new System.Drawing.Point(165, 36);
            this.find_user_name.Name = "find_user_name";
            this.find_user_name.Size = new System.Drawing.Size(245, 25);
            this.find_user_name.TabIndex = 6;
            // 
            // find_psw
            // 
            this.find_psw.BackColor = System.Drawing.SystemColors.Control;
            this.find_psw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.find_psw.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.find_psw.Location = new System.Drawing.Point(29, 107);
            this.find_psw.Name = "find_psw";
            this.find_psw.ShortcutsEnabled = false;
            this.find_psw.Size = new System.Drawing.Size(130, 22);
            this.find_psw.TabIndex = 7;
            this.find_psw.TabStop = false;
            this.find_psw.Text = "账号密码：";
            // 
            // find_user_psw
            // 
            this.find_user_psw.Location = new System.Drawing.Point(165, 104);
            this.find_user_psw.Name = "find_user_psw";
            this.find_user_psw.Size = new System.Drawing.Size(245, 25);
            this.find_user_psw.TabIndex = 8;
            this.find_user_psw.UseSystemPasswordChar = true;
            // 
            // find_user_button
            // 
            this.find_user_button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.find_user_button.Location = new System.Drawing.Point(127, 195);
            this.find_user_button.Name = "find_user_button";
            this.find_user_button.Size = new System.Drawing.Size(187, 54);
            this.find_user_button.TabIndex = 9;
            this.find_user_button.Text = "查找";
            this.find_user_button.UseVisualStyleBackColor = true;
            this.find_user_button.Click += new System.EventHandler(this.find_user_button_Click);
            // 
            // find_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 289);
            this.Controls.Add(this.find_user_button);
            this.Controls.Add(this.find_user_psw);
            this.Controls.Add(this.find_psw);
            this.Controls.Add(this.find_user_name);
            this.Controls.Add(this.find_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "find_user";
            this.Text = "找回账号";
            this.Load += new System.EventHandler(this.find_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox find_name;
        private System.Windows.Forms.TextBox find_user_name;
        private System.Windows.Forms.TextBox find_psw;
        private System.Windows.Forms.TextBox find_user_psw;
        private System.Windows.Forms.Button find_user_button;
    }
}