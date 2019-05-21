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
    public partial class UpdateStudent : Form
    {
        public int ID;
        //实例化传递修改的数据的主键
        public UpdateStudent(int Id)
        {
            ID = Id;
            //该方法是由系统生成的
            InitializeComponent();
        }

        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection("server=.;database=itcast;uid=sa;pwd=123456");
            //创建执行对象
            SqlCommand cmd = con.CreateCommand();
            //设置执行的Sql语句，查询数据库表中字段ID的值为传递的值得数据
            cmd.CommandText = "select * from Student where ID=" + ID; 
            //打开连接
            con.Open();
            //执行查询语句，返回查询的SqlDataReader对象
            SqlDataReader dataReader = cmd.ExecuteReader();
            //判断是否查询到数据
            if (dataReader.HasRows)
            { 
                //读取第1条记录，并分别赋值到窗体对应的文本框中
                dataReader.Read();
                lblID.Text = ID.ToString();
                //获取索引为3的列的数据
                txtStuClass.Text = dataReader.GetString(3);
                txtStuName.Text = dataReader.GetString(2);
                txtStuNum.Text = dataReader.GetString(1);
                txtSubject.Text = dataReader.GetString(4);
                txtStuAge.Text = dataReader.GetInt32(5).ToString();
                txtStuPhone.Text = dataReader.GetString(6);
                if (dataReader.GetString(7) == "女")
                {
                    this.radioG.Checked = true;
                }
                else 
                {
                    this.radioB.Checked = true;
                }
            }
        }
    }
}
