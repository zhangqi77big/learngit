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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //添加页面{提交}按钮的单机时间
        private void button1_Click(object sender, EventArgs e)
        {
            string StuName = txtStuName.Text.Trim();
            string StuNum = txtStuNum.Text.Trim();
            string StuClass = txtStuClass.Text.Trim();
            string subject = txtsubject.Text.Trim();
            string StuPhone = txtStuPhone.Text.Trim();
            //获取单选按钮中被选中的按钮的值
            string StuGender = radioB.Checked ? "男" : "女";
            int StuAge;
            //获取输入的年龄，如果输入为“”或不是整数的时候默认为0
            Int32.TryParse(txtStuAge.Text.Trim(),out StuAge);
            //判断姓名，学号，班级，学科是否为空
            if (String.IsNullOrEmpty(StuName) || String.IsNullOrEmpty(StuNum)
                || String.IsNullOrEmpty(StuClass) || String.IsNullOrEmpty(subject))
            {
                MessageBox.Show("姓名，学号，班级，学科都不能为空");
            }
            else
            { 
                //创建连接对象
                SqlConnection con = new SqlConnection("server=.;database=itcast;uid=sa;pwd=123456");
                string sql = string.Format("insert into Student values('{0}','{1}', '{2}','{3}','{4}','{5}','{6}')",StuNum,StuName,StuClass,subject,StuAge,StuPhone,StuGender);
                //创建执行命令对象
                SqlCommand cmd = new SqlCommand(sql, con);
                //打开连接
                con.Open();
                //返回执行影响的行数
                int count = cmd.ExecuteNonQuery();
                //关闭连接
                con.Close();
                //当返回的影响条数大于0时，弹出“添加成功”
                if (count > 0)
                {
                    MessageBox.Show("添加成功");
                }
                //关闭当前对话框
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtStuAge.Text = "";
            txtStuClass.Text = "";
            txtStuName.Text = "";
            txtStuNum.Text = "";
            txtStuPhone.Text = "";
            txtsubject.Text = "";
        }
    }
}
