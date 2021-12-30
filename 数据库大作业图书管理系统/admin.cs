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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转到管理员操作界面
            if (Date.admin_type == "图书管理员"|| Date.admin_type=="系统管理员")
            {
                admin2 a2 = new admin2();
                a2.ShowDialog();
            }
            else
            {
                MessageBox.Show("无相关权限进行此操作!"); 
            }
        }
        
        //加载事件
        private void admin_Load(object sender, EventArgs e)
        {
            admin_show.Text = "管理员类型为：" + Date.admin_type;
        }


        //读者等级管理
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Date.admin_type == "读者管理员" || Date.admin_type == "系统管理员")
            {
                reader_type r1 = new reader_type();
                r1.Show();
            }
            else
            {
                MessageBox.Show("无相关权限进行此操作!");
            }
        }

        private void 图书热度统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top_book top_Book = new top_book();
            top_Book.Show();
        }

        private void 用户注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Date.admin_type == "读者管理员"|| Date.admin_type == "系统管理员")
            {
                delete_user_myself delete = new delete_user_myself();
                delete.Show();
            }
            else
            {
                MessageBox.Show("无相关权限进行此操作!");
            }
        }

        private void 添加管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Date.admin_type == "系统管理员")
            {
                add_admin add = new add_admin();
                add.Show();
            }
            else
            {
                MessageBox.Show("无相关权限进行此操作!");
            }
        }
    }
}
