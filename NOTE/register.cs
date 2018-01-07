using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using JKLibrary;

namespace NOTE
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_rigister(object sender, EventArgs e)
        {

            if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
             
                string conn = "Data Source=.;Initial Catalog=Note;Integrated Security=True";
                SqlConnection mycon = new SqlConnection(conn);
                mycon.Open();
                string sql = "insert into UsersInfo(UserName,Password,QQ,Name) values('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtQQ.Text + "','" + txtRealName.Text + "')";
                SqlCommand mycom = new SqlCommand(sql, mycon);           //定义对象并连接数据库
                mycom.ExecuteNonQuery();                           //执行插入语句
                mycon.Close();                //关闭对象并释放所占内存空间    
                mycon.Dispose();
                MessageBox.Show("注册成功");
                return;
            }
            else
            {
                MessageBox.Show("用户名已被占用！");
                return;
            }
                  
            }
            
        
        private void button2_exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
