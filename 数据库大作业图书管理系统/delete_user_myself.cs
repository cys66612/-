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
    public partial class delete_user_myself : Form
    {
        public delete_user_myself()
        {
            InitializeComponent();
        }

        private void delete_user_myself_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“book2DataSet.user_01”中。您可以根据需要移动或删除它。
            this.user_01TableAdapter.Fill(this.book2DataSet.user_01);

        }

        void table()
        {
            this.book2DataSet.Tables["user_01"].BeginLoadData();
            this.user_01TableAdapter.Fill(this.book2DataSet.user_01);
        }

        private void user_01DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = user_01DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = user_01DataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = $"delete from BookUser where id='{textBox3.Text}' and name='{textBox4.Text}'";
            Dao da = new Dao();
            if(da.Execute(sql)>0)
            {
                MessageBox.Show("此用户注销成功!");
            }
            else
            {
                MessageBox.Show("注销失败!");
            }
            table();
        }
    }
}
