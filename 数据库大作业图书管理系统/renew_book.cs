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
    public partial class renew_book : Form
    {
        public renew_book()
        {
            InitializeComponent();
        }

        private void renew_book_Load(object sender, EventArgs e)
        {
            table();
        }

        void table()
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            Dao d = new Dao();
            string sql = $"select no,uid,bid,datetime,renew  from BookLend where uid='{Date.UID}'";
            IDataReader table = d.read(sql);
            while (table.Read())
            {
                //通过2个数组来存储数据 
                string[] s1 = new string[] { table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString() };
                dataGridView1.Rows.Add(s1[0].ToString(), s1[1].ToString(), s1[2].ToString(), s1[3].ToString(), s1[4].ToString());
            }
            table.Close();
            d.Close();
            
        }

        //点击续借按钮
        private void button1_Click(object sender, EventArgs e)
        {
            int no = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string bid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            string sql = $"update BookLend set renew=renew+1 where no={no} and uid='{Date.UID}' and bid='{bid}';";
            Dao da = new Dao();
            if(da.Execute(sql)>0)
            {
                MessageBox.Show("续借成功!");
                table();
            }
            else
            {
                MessageBox.Show("续借失败!");
            }

        }
        
        //点击
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table();
            textBox_renew.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
