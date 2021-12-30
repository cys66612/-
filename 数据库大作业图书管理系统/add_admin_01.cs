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
    public partial class add_admin_01 : Form
    {
        public add_admin_01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"insert into BookAdmin values('{add_admin_id.Text}','{add_admin_psw.Text}','{add_admin_name.Text}','{comboBox1.Text}')";
            Dao da = new Dao();
            if(da.Execute(sql)>0)
            {
                MessageBox.Show("添加成功！");
            }
            else{
                MessageBox.Show("添加失败！");
            }
        }

        private void add_admin_01_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("图书管理员");
            comboBox1.Items.Add("读者管理员");
            comboBox1.Items.Add("系统管理员");
        }
    }
}
