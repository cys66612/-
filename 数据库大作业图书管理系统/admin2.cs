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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();

        }

        private void admin2_Load(object sender, EventArgs e)
        {
            //在加载的时候输出全部的信息
            table();
            //在加载的时候默认选择第一项 控件显示第一个的书名
            label_admin_selectbook2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        
        //显示图书信息
        private void table()
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            Dao d = new Dao();
            string sql = "select * from Book";
            IDataReader table = d.read(sql);
            while(table.Read())
            {
                //通过2个数组来存储数据 
                string[] s1 = new string[] { table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString()};
                string[] s2 = new string[] { table[5].ToString(), table[6].ToString(), table[7].ToString(), table[8].ToString() };
                dataGridView1.Rows.Add(s1[0],s1[1],s1[2],s1[3],s1[4],s2[0],s2[1],s2[2],s2[3]);
            }
            table.Close();
            d.Close();
        }

        //点击管理界面中的添加图书按钮
        private void button1_Click(object sender, EventArgs e)
        {
            add_book add = new add_book();
            add.ShowDialog();
        }

        //删除图书操作
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               //获取点击的书号
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //获取当前点击的书名
                label_admin_selectbook2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认是否删除", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr==DialogResult.OK)
                {
                    string sql = $"delete from Book where id='{id}'";
                    Dao da = new Dao();
                    if(da.Execute(sql)>0)
                    {
                        MessageBox.Show("删除成功");
                        table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch
           {
                MessageBox.Show("请先在表格中选中要删除的图书", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //点击数据表 显示书名控件获取信息
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label_admin_selectbook2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        //修改图书
        private void button2_Click(object sender, EventArgs e)
        {
            //异常处理
            try
            {
                //重构了窗体构造函数
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string booknumber = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string book_type = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string price = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string bool1 = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                update up = new update(id, name, author, press,booknumber,book_type,price,bool1);
                up.ShowDialog();
                table();
            }
            catch
            {
                MessageBox.Show("出现了不知道的错误！");
            }
        }

        //刷新操作
        private void button4_Click(object sender, EventArgs e)
        {
            table();
        }

        //书号查询
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            string sql = $"select * from Book where id like'%'+'{admin_selectbook_id.Text}'+'%'";
            Dao da = new Dao();
            IDataReader table = da.read(sql);
            while (table.Read())
            {
                dataGridView1.Rows.Add(table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString());
            }
            table.Close();
            da.Close();
            //置为空值
           admin_selectbook_id.Text = "";
        }

        //书名查询
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            string sql = $"select * from Book where name like'%'+'{admin_selectbook_name.Text}'+'%'";
            Dao da = new Dao();
            IDataReader table = da.read(sql);
            while (table.Read())
            {
                dataGridView1.Rows.Add(table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString());
            }
            table.Close();
            da.Close();
            //同样也置为空值
            admin_selectbook_name.Text = "";
        }
    }
}
