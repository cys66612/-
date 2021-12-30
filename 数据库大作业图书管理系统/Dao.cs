using System.Data.SqlClient;

//用于和数据库进行连接
namespace 数据库大作业图书管理系统
{
    class Dao
    {
        SqlConnection s;
        public SqlConnection connect()//连接数据库
        {
            string str = "Server=CYS666;Database=book2;uid=sa;pwd=as7737009";
            s = new SqlConnection(str);
            s.Open();
            return s;
        }

        public SqlCommand command(string sql)//对数据库进行操作函数
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)//应该是用于修改
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)//读取数据库信息操作
        {
            return command(sql).ExecuteReader();
        }

        public void Close()//关闭数据库连接
        {
            s.Close();
        }
    }
}
