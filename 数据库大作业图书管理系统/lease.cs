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
    public partial class lease : Form
    {
        public lease()
        {
            InitializeComponent();
            table();
        }

        int money1;
        string no;
        string bid;
        int renew;

        private void table()
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            Dao d = new Dao();
            string sql = $"select *  from BookLend where uid='{Date.UID}'";
            IDataReader table = d.read(sql);
            while (table.Read())
            {
                //通过2个数组来存储数据 
                string[] s1 = new string[] { table[0].ToString(), table[1].ToString(), table[2].ToString(), table[3].ToString(), table[4].ToString() };
                string[] s2 = new string[] { table[5].ToString(), table[6].ToString(), table[7].ToString() };
                dataGridView1.Rows.Add(s1[0].ToString(),s1[1].ToString(),s1[2].ToString(),s1[3].ToString(),s1[4].ToString(),s2[0].ToString(),s2[1].ToString(),s2[2].ToString());
            }
            table.Close();
            d.Close();
        }

        //点击归还按钮
        private void button1_Click(object sender, EventArgs e)
        {
            money1 = int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());//当前图书的罚款金额
            no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//当前图书编号
            bid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//图书id
            renew = int.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            
                string sql = $"update Book set inventory=inventory-1 where id='{bid}';update BookLend set isback=1 where no={no} and uid='{Date.UID}';update ReaderCategory set book_number=book_number-1 where id='{Date.UID}';";
                Dao da = new Dao();

                if (da.Execute(sql) > 1)
                {
                    MessageBox.Show("归还成功");
                    table();
                }
                else
                {
                    MessageBox.Show("归还失败");
                }
          

        }

        
        private void lease_Load(object sender, EventArgs e)
        {
            string sql = $"select max_datetime from ReaderCategory where id='{Date.UID}'; ";
            Dao da = new Dao();
            IDataReader table = da.read(sql);
            table.Read();
            textBox_maxtime.Text = table[0].ToString();
            textBox_message.Text = "超时一天，每天10元";
        }

        //检查罚款
        private void button2_Click(object sender, EventArgs e)
        {
             money1 = int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());//当前图书的罚款金额
             no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//当前图书编号
             bid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//图书id

            //超时罚款计费 图书5天借阅免费，超时一天10元
            string sql3 = $"update BookLend set lbook_time=dateadd(dd,7,getdate()) where no='{no}' and  uid='{Date.UID}' and bid='{bid}';";
            string sql2 = $"update BookLend set money=10*(datediff(dd,datetime,lbook_time)-5*{renew}) where no={no} and uid='{Date.UID}'and datediff(dd,datetime,lbook_time)>=5;";
            Dao da = new Dao();
            da.Execute(sql3);
            da.Execute(sql2);

            table();
            
        }

        //缴纳罚款
        private void button3_Click(object sender, EventArgs e)
        {
            money1 = int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());//当前图书的罚款金额
            no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//当前图书编号
            bid = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//图书id
            money m1 = new money(money1, bid, no);
           m1.Show();
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table();
        }
    }
}
