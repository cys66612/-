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
    public partial class add_book : Form
    {
        public add_book()
        {
            InitializeComponent();
        }

        //点击添加图书事件
        private void button1_Click(object sender, EventArgs e)
        {
            Dao d = new Dao();
           // string sql = $"insert into Book values('{textBox_add_id.Text}','{textBox_add_bookname.Text}','{textBox_add_athour.Text}','{textBox_add_press.Text}',{textBox_add_inventory.Text})";
            //创建一个string池，本质上还是string
            StringBuilder strBd = new StringBuilder();
            strBd.Append($"insert into Book values('{textBox_add_id.Text}',");
            strBd.Append($"'{textBox_add_bookname.Text}',");
            strBd.Append($"'{textBox_add_athour.Text}',");
            strBd.Append($"'{textBox_add_press.Text}',");
            strBd.Append($"0,");
            strBd.Append($"'{textBox_add_booknumber.Text}',");
            strBd.Append($"'{textBox_add_type.Text}',");
            strBd.Append($"{int.Parse(textBox_add_price.Text)},");
            strBd.Append($"1);");
            string sql = strBd.ToString();
            if (d.Execute(sql) > 0)//返回受影响的行数
            {
                MessageBox.Show("添加成功");
                //重新赋为空值
                textBox_add_id.Text = "";
                textBox_add_bookname.Text = "";
                textBox_add_athour.Text = "";
                textBox_add_booknumber.Text = "";
                textBox_add_press.Text = "";
                textBox_add_type.Text = "";
                textBox_add_price.Text = "";
            }
            else MessageBox.Show("添加失败");
        }

        private void add_book_Load(object sender, EventArgs e)
        {

        }
    }
}

