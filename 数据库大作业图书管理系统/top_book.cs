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
    public partial class top_book : Form
    {
        public top_book()
        {
            InitializeComponent();
        }

        //点击查询
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            string sql=$"select * from Book where book_type='{comboBox1.Text}'order by inventory desc";
            Dao da = new Dao();
            IDataReader table = da.read(sql);
            while(table.Read())
            {
                string[] s1 = new string[] { table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString() };
                string[] s2 = new string[] { table[5].ToString(), table[6].ToString(), table[7].ToString(), table[8].ToString() };
                dataGridView1.Rows.Add(s1[0], s1[1], s1[2], s1[3], s1[4], s2[0], s2[1], s2[2]);
            }
            table.Close();
            da.Close();
        }

        //加载时
        private void top_book_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string sql = $"select distinct book_type from Book;";
            Dao da = new Dao();
            IDataReader data = da.read(sql);
            while (data.Read())
            {
                comboBox1.Items.Add(data[0].ToString());
            }
        }
    }
}
