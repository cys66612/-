using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 数据库大作业图书管理系统
{
    public partial class find_user : Form
    {
        public find_user()
        {
            InitializeComponent();
        }

        //点击查找
        private void find_user_button_Click(object sender, EventArgs e)
        {
            string sql = $"select id from BookUser where name='{find_user_name.Text}'and psw='{find_user_psw.Text}'";
            Dao da = new Dao();
            SqlDataReader reader=da.read(sql);
            if (reader.Read())
            {
                MessageBox.Show($"所查找的账号ID是:'{reader.GetString(0)}'");
            }
            else
            {
                MessageBox.Show("不存在所要查找账号ID");
                find_user_name.Text = "";
                find_user_psw.Text = "";
            }
        }

        private void find_user_Load(object sender, EventArgs e)
        {

        }
    }
}
