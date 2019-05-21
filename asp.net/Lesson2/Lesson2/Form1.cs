using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //为DataGridView控件加载数据
            DataGridViewDataLoad();
            //为ComBoxDataLoad()加载数据
            ComboBoxDataLoad();

        }
        private void DataGridViewDataLoad(string sql = "select * from Student")
        {
            //创建数据库连接
            SqlConnection con = new SqlConnection("server=.;Initial Catalog=itcast;Integrated Security=true;");
            //创建一个SqlDataAdapter的对象适配器，用于检索和保存数据
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            //创建一个存放在内存中的数据缓存
            DataSet ds = new DataSet();
            //打开数据库连接
            con.Open();
            //将适配器检索到的数据填充到本地数据库中。
            adapter.Fill(ds);
            //关闭数据库连接
            con.Close();
            //将本地数据库中的数据表设置为dataGridView1控件的数据源
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void ComboBoxDataLoad()
        {
            //将ComboBox中的所有原始项清空，防止重复绑定
            cmdString.Items.Clear();
            cmdString.Items.Add("全部");
            cmdString.SelectedIndex = 0;

            SqlConnection con = new SqlConnection("server=.;database=itcast;uid=sa;pwd=123456");

            //sql语句
            string sql = "select distinct subject from Student";
            //创建执行sql命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            //打开连接
            con.Open();
            //通过命令对象返回一个SqlDataReader的对象
            SqlDataReader reader = cmd.ExecuteReader();
            //reader的HasRows属性表示是否有返回数据
            if (reader.HasRows)
            {
                //通过Read()方法循环记录
                while (reader.Read())
                {
                    //将读取道德第一列添加到下拉列表项中
                    cmdString.Items.Add(reader[0]);
                }
            }
            //关闭reader对象
            reader.Close();
            //关闭数据库连接
            con.Close();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //获取所有需查询的字段值
            string stuNum = txtStuNum.Text.Trim();
            string stuName = txtStuName.Text.Trim();
            string stuClass = txtStuClass.Text.Trim();
            string subject = cmdString.Text.Trim();
            //拼接Sql查询语句
            StringBuilder sql = new StringBuilder("select * from Student where 1=1");
            //查询的学号不为空时，就在原始的sql语句后加一个查询条件
            if (!String.IsNullOrEmpty(stuNum))
            {
                sql.Append(" and stuNum="+stuNum);
            }
            //查询的姓名，班级或学科不为空时，就在sql语句后加一个模糊匹配查询条件
            if (!String.IsNullOrEmpty(stuName))
            {
                sql.Append(" and stuName like '%"+stuName+"%'");
            }
            if (!String.IsNullOrEmpty(stuClass))
            {
                sql.Append(" and stuClass like '%"+stuClass+"%'");
            }
            if (!String.IsNullOrEmpty(subject))
            {
                sql.Append(" and subject like '%"+subject+"%'");
            }
            //重新加载DateGridView中的数据
            DataGridViewDataLoad(sql.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个AddStudent类型的窗体实例
            AddStudent addStudent = new AddStudent();
            //将窗体使用对话框的形式弹出
            addStudent.ShowDialog();
            //添加数据框关闭后重新加载ComboBox控件和DataGridView控件中的数据
            ComboBoxDataLoad();
            DataGridViewDataLoad();
        }
    }
}
