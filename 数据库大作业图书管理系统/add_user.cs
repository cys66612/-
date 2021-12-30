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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        //点击注册按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (add_user_id.Text != "" & add_user_name.Text != "" & add_user_sex.Text != "" & add_user_psw.Text != "" & check_psw.Text != "")
            {
                if (add_user_psw.Text != check_psw.Text)
                {
                    MessageBox.Show("两次输入的密码不同,请重新输入");
                    add_user_psw.Text = "";
                    check_psw.Text = "";
                }
                else
                {
                    string sql = $"insert into BookUser values('{add_user_id.Text}','{add_user_name.Text}','{add_user_sex.Text}','{add_user_psw.Text}');insert into ReaderCategory values('{add_user_id.Text}','普通',10,0,5)";
                    Dao da = new Dao();
                    if(da.Execute(sql)>0)
                    {
                        MessageBox.Show("注册成功");
                        add_user_id.Text = "";
                        add_user_name.Text = "";
                        add_user_sex.Text = "";
                        add_user_psw.Text="";
                        check_psw.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                    }
                }
            }
        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }
    }
}
