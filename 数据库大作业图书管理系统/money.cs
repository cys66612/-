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
    public partial class money : Form
    {
        int n;//保存用户应该缴纳的金额
        string bookid;
        int no1;//当前记录的编号

        public money(int money,string bid,string no)//加载用户当前还书所需要缴纳的罚金
        {
            InitializeComponent();
            textBox_user_money.Text = money.ToString();
            n = money;
            bookid = bid;
            no1 =int.Parse(no);
        }

        //点击缴纳金额
        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox_user_givemoney.Text);
            if (m < n)
            {
                MessageBox.Show("缴纳金额不够！，请一次性缴纳完！");
                textBox_user_givemoney.Text = "";
            }

            if (m > n) 
            { 
                MessageBox.Show("缴纳金额超出所应缴纳的金额!");
                textBox_user_givemoney.Text = "";
            }

            if (m == n)
            {
                string sql = $"update BookLend set money=0 where uid='{Date.UID}' and bid='{bookid}' and no={no1}";
                Dao da = new Dao();
                if (da.Execute(sql)>0)
                {
                    MessageBox.Show("缴纳成功");
                    
                }
                else
                {
                    MessageBox.Show("缴纳失败");
                }
            }

        }
    }
}
