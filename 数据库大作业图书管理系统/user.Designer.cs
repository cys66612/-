
namespace 数据库大作业图书管理系统
{
    partial class user
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书查看和借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前租借图书和归还ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者等级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书续借ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书热度统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书查看和借阅ToolStripMenuItem,
            this.当前租借图书和归还ToolStripMenuItem,
            this.读者等级ToolStripMenuItem,
            this.图书续借ToolStripMenuItem,
            this.图书热度统计ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书查看和借阅ToolStripMenuItem
            // 
            this.图书查看和借阅ToolStripMenuItem.Name = "图书查看和借阅ToolStripMenuItem";
            this.图书查看和借阅ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.图书查看和借阅ToolStripMenuItem.Text = "图书查看和借阅";
            this.图书查看和借阅ToolStripMenuItem.Click += new System.EventHandler(this.图书查看和借阅ToolStripMenuItem_Click);
            // 
            // 当前租借图书和归还ToolStripMenuItem
            // 
            this.当前租借图书和归还ToolStripMenuItem.Name = "当前租借图书和归还ToolStripMenuItem";
            this.当前租借图书和归还ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.当前租借图书和归还ToolStripMenuItem.Text = "租借图书、罚款";
            this.当前租借图书和归还ToolStripMenuItem.Click += new System.EventHandler(this.当前租借图书和归还ToolStripMenuItem_Click);
            // 
            // 读者等级ToolStripMenuItem
            // 
            this.读者等级ToolStripMenuItem.Name = "读者等级ToolStripMenuItem";
            this.读者等级ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.读者等级ToolStripMenuItem.Text = "读者等级";
            this.读者等级ToolStripMenuItem.Click += new System.EventHandler(this.读者等级ToolStripMenuItem_Click);
            // 
            // 图书续借ToolStripMenuItem
            // 
            this.图书续借ToolStripMenuItem.Name = "图书续借ToolStripMenuItem";
            this.图书续借ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.图书续借ToolStripMenuItem.Text = "图书续借";
            this.图书续借ToolStripMenuItem.Click += new System.EventHandler(this.图书续借ToolStripMenuItem_Click);
            // 
            // 图书热度统计ToolStripMenuItem
            // 
            this.图书热度统计ToolStripMenuItem.Name = "图书热度统计ToolStripMenuItem";
            this.图书热度统计ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.图书热度统计ToolStripMenuItem.Text = "图书热度统计";
            this.图书热度统计ToolStripMenuItem.Click += new System.EventHandler(this.图书热度统计ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 371);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user";
            this.Text = "读者使用系统";
            this.Load += new System.EventHandler(this.user_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书查看和借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前租借图书和归还ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 读者等级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书续借ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书热度统计ToolStripMenuItem;
    }
}