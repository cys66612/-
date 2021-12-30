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
    public partial class update : Form
    {
        //用于存储t_book的主键
        string ID;

        public update(string id,string name,string author,string press,string booknumber,string book_type,string price,string bool1)
        {
            InitializeComponent();
            ID = textBox_update_id.Text = id;
            textBox_update_bookname.Text = name;
            textBox_update_athour.Text = author;
            textBox_update_press.Text = press;
            textBox_update_booknumber.Text = booknumber;
            textBox_update_type.Text = book_type;
            textBox_update_price.Text = price;
            textBox_update_bool.Text = bool1;
        }

        //点击修改图书按钮
        private void button1_Click(object sender, EventArgs e)
        {
           
            //创建一个string池，本质上还是string
            StringBuilder strBd = new StringBuilder();
            strBd.Append($"update Book set ");
            strBd.Append($"id='{textBox_update_id.Text}',");
            strBd.Append($"name='{textBox_update_bookname.Text}',");
            strBd.Append($"author='{textBox_update_athour.Text}',");
            strBd.Append($"press='{textBox_update_press.Text}',");
            strBd.Append($"book_number='{textBox_update_booknumber.Text}',");
            strBd.Append($"book_type='{textBox_update_type.Text}',");
            strBd.Append($"price={int.Parse(textBox_update_price.Text)},");
            strBd.Append($"bookstate={int.Parse(textBox_update_bool.Text)}");
            strBd.Append($" where id='{ID}'");
            string sql = strBd.ToString();
            Dao da = new Dao();
            if(da.Execute(sql)>0)
            {
                MessageBox.Show("修改成功");
                
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

    }
}
