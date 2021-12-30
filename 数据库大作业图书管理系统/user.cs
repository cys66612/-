using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库大作业图书管理系统
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        //点击图书查看和借阅
        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_select user_Select = new user_select();
          //  this.Hide();
            user_Select.Show();
            user_Select.MdiParent = this;
        }

        //点击租借
        private void 当前租借图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lease lease = new lease();
           // this.Hide();
            lease.Show();
            lease.MdiParent = this;
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        //点击读者等级
        private void 读者等级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader_grade r1 = new reader_grade();
            r1.Show();
            r1.MdiParent = this;
        }

        private void 图书续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renew_book r1 = new renew_book();
            r1.Show();
            r1.MdiParent = this;
        }

        private void 图书热度统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top_book top_Book = new top_book();
            top_Book.Show();
            top_Book.MdiParent = this;
        }

    }
}
