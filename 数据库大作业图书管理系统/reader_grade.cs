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
    public partial class reader_grade : Form
    {
        public reader_grade()
        {
            InitializeComponent();
        }

        //加载时
        private void reader_grade_Load(object sender, EventArgs e)
        {
            string s1 = "读者等级分为：一般读者、资深读者、终身读者   借书数量受等级限制，有10、20、50本图书的区别!等级可以找管理员进行升级！";
            textBox_reader01.Text =s1;

            string sql = $"select user_type,bb_number,max_datetime from ReaderCategory where id='{Date.UID}'; ";
            Dao da = new Dao();
            IDataReader table = da.read(sql);
            table.Read();
            textBox_reader_grade.Text = table[0].ToString();
            textBox_reader_booknumber.Text = table[1].ToString();
            textBox_reader_time.Text = table[2].ToString();
        }
    }
}
