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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != "" && textBox_psw.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("输入有空项，请输入");
            }
        }

        //登陆验证操作
        public void login()
        {
            //普通用户
            if (radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select * from BookUser where id='{textBox_id.Text}'and psw='{textBox_psw.Text}'";
                IDataReader data = dao.read(sql);//IDataReader可以存储数据库查询出的结果，是一整个集合
                if (data.Read())
                {
                    Date.UID = data["id"].ToString();
                    Date.Uname = data["name"].ToString();
                    MessageBox.Show("登录成功");
                    user user1 = new user();//打开用户窗体
                    this.Hide();
                    user1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.Close();
            }
            //系统管理员
            else if (radioButtonAdmain.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select * from BookAdmin where id='{textBox_id.Text}'and psw='{textBox_psw.Text}'";
                IDataReader data = dao.read(sql);//IDataReader可以存储数据库查询出的结果，是一整个集合
                if (data.Read())
                {
                    Date.UID = data["id"].ToString();
                    Date.Uname = data["name"].ToString();
                    Date.admin_type = data["admin_type"].ToString();
                    MessageBox.Show("登录成功");
                    admin admin1 = new admin();//打开管理员窗体
                    admin1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("登录失败");

                }
                dao.Close();
            }
            else
            {
                MessageBox.Show("可能是登录选择失效或者是不存在此用户");
                return;
            }
        }

        //点击注册账号
        private void button2_Click(object sender, EventArgs e)
        {
            add_user a1 = new add_user();
            a1.ShowDialog();
        }

        //点击查找账号
        private void button3_Click(object sender, EventArgs e)
        {
            find_user find_User = new find_user();
            find_User.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
