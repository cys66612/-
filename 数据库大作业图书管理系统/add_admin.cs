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
    public partial class add_admin : Form
    {
        public add_admin()
        {
            InitializeComponent();
        }

        private void add_admin_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“book2DataSet1.admin_01”中。您可以根据需要移动或删除它。
            this.admin_01TableAdapter.Fill(this.book2DataSet1.admin_01);
            comboBox1.Items.Add("图书管理员");
            comboBox1.Items.Add("读者管理员");
            comboBox1.Items.Add("系统管理员");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_admin_01 add_Admin_01 = new add_admin_01();
            add_Admin_01.Show();
        }

        private void admin_01DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = admin_01DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text= admin_01DataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            string id = admin_01DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string name = admin_01DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete from BookAdmin where id='{id}' and name='{name}'";
            Dao da = new Dao();
            if(da.Execute(sql)>0)
            {
                MessageBox.Show($"删除用户{name}成功！");
            }
            else
            {
                MessageBox.Show($"删除用户{name}失败！");
            }
            table();
        }

        void table()
        {
            this.book2DataSet1.Tables["admin_01"].BeginLoadData();
            this.admin_01TableAdapter.Fill(this.book2DataSet1.admin_01);

        }

        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            string id = admin_01DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string name = admin_01DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string type = comboBox1.Text;
            if (type != "")
            {
               string sql = $"update BookAdmin set admin_type='{comboBox1.Text}' where id='{id}' and name='{name}'";
                Dao da = new Dao();
                if (da.Execute(sql) > 0)
                {
                    MessageBox.Show("修改类型成功!");

                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            else
            {
                MessageBox.Show("请选择管理员类型!");
            }
            table();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table();
        }
    }
}
