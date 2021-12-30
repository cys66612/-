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
    public partial class user_select : Form
    {
        public user_select()
        {
            InitializeComponent();
           
        }

        //输出数据库信息--用于显示全部图书
        private void table()
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            Dao d = new Dao();
            string sql = "select * from Book";
            IDataReader table = d.read(sql);
            while (table.Read())
            {
                string[] s1 = new string[] { table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString() };
                string[] s2 = new string[] { table[5].ToString(), table[6].ToString(), table[7].ToString(), table[8].ToString() };
                dataGridView1.Rows.Add(s1[0], s1[1], s1[2], s1[3], s1[4], s2[0], s2[1], s2[2], s2[3]);
            }
            table.Close();
            d.Close();
        }

        //加载时
        private void user_select_Load(object sender, EventArgs e)
        {
            table();
            book_type();
            label_admin_selectbook2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        //用户用书号查询
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
            //admin_selectbook_id.Text = "";
        }

        //用户用书名查询
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

        //点击刷新全部按钮
        private void button2_Click(object sender, EventArgs e)
        {
            table();
        }

        //单击数据库视图时
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label_admin_selectbook2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        //租借事件
        private void button1_Click(object sender, EventArgs e)
        {
            int no = 1;//用户借阅序号

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取书号
            int booknumber = int.Parse (dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            int inventory = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            if ((booknumber-inventory)==0)
            {
                MessageBox.Show("库存不足，请及时联系管理员进行相关处理！");
            }
            else
            {
                Dao da = new Dao();
                string sql2 = $"select no from BookLend where uid='{Date.UID}'; ";
                IDataReader dr = da.read(sql2);
                if(!dr.Read())//当不存在此用户借阅的记录时
                {
                    no = 1;
                }
                else
                {
                    no = 2;
                    while(dr.Read())
                    {
                        no++;
                    }
                    
                }
                //MessageBox.Show(no.ToString()); 查看用户深度是非正确
                string sql3 = $"select bb_number,book_number from ReaderCategory where id='{Date.UID}';";
                dr = da.read(sql3);
                dr.Read();
                int max_book = int.Parse(dr[0].ToString());
                int book_number = int.Parse(dr[1].ToString());

                string sql = $"insert into BookLend(no,uid,bid,datetime,money,isback,renew) values('{no}','{Date.UID}','{id}',getdate(),0,0,0);update Book set inventory=inventory+1 where id='{id}';";
                sql = sql + $"update ReaderCategory set book_number=book_number+1 where id='{Date.UID}';";
                if( (max_book-book_number)>0 && da.Execute(sql) > 1)
                {
                    MessageBox.Show("借书成功");
                    table();
                }
                else
                {
                    MessageBox.Show("图书数量不足或者是达到账号最大借书限制！");
                }

            }

        }
        void book_type()
        {
            comboBox_booktype.Items.Clear();
            string sql = $"select distinct book_type from Book;";
            Dao da = new Dao();
            IDataReader data = da.read(sql);
            while(data.Read())
            {
                comboBox_booktype.Items.Add(data[0].ToString());
            }
        }

        //点击以类型查询图书
        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"select * from Book where book_type='{comboBox_booktype.Text}';";
            Dao da = new Dao();
            IDataReader data = da.read(sql);
            dataGridView1.Rows.Clear();//清空全部行数据
            while(data.Read())
            {
                string[] s1 = new string[] { data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString() };
                string[] s2 = new string[] { data[5].ToString(), data[6].ToString(), data[7].ToString(), data[8].ToString() };
                dataGridView1.Rows.Add(s1[0], s1[1], s1[2], s1[3], s1[4], s2[0], s2[1], s2[2], s2[3]);
            }
            data.Close();
            da.Close();
        }
    }
}
