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
    public partial class reader_type : Form
    {
        public reader_type()
        {
            InitializeComponent();
        }
        
        void table()
        {
            dataGridView1.Rows.Clear();//清空全部行数据
            string sql = $"select name,id from BookUser";
            Dao da = new Dao();
            IDataReader data = da.read(sql);
            while(data.Read())
            {
                string[] s = new string[] {data[0].ToString(),data[1].ToString() };
                string sql2 = $"select user_type from ReaderCategory where id='{s[1].ToString()}';";
               // MessageBox.Show(sql2);
                Dao d2 = new Dao();
                IDataReader data2 = d2.read(sql2);
                data2.Read();
                dataGridView1.Rows.Add(s[0],s[1],data2[0].ToString());
                data2.Close();
                d2.Close();
            }
            data.Close();
            da.Close();

        }

        //点击修改
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update ReaderCategory set user_type='{comboBox1.Text}' where id='{textBox_id.Text}';";
            if(comboBox1.Text=="普通")
            {
                sql = sql + $"update ReaderCategory set bb_number=10,max_datetime=5 where id='{textBox_id.Text}'";
            }

            if(comboBox1.Text=="资深")
            {
                sql=sql+ $"update ReaderCategory set bb_number=20,max_datetime=15 where id='{textBox_id.Text}'";
            }

            if (comboBox1.Text == "终身")
            {
                sql = sql + $"update ReaderCategory set bb_number=50,max_datetime=30 where id='{textBox_id.Text}'";
            }

            MessageBox.Show(sql);
            Dao da = new Dao();
            if (da.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功！");
                table();
            }
            else MessageBox.Show("修改失败！");
        }

       

        private void reader_type_Load(object sender, EventArgs e)
        {
            table();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_grade.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
