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
    public partial class Forget : Form
    {
        public Forget()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dt = SQLHelper.GetDataSet("select * from UsersInfo ", null);
            string conn = "Data Source=.;Initial Catalog=Note;Integrated Security=True";
            SqlConnection mycon = new SqlConnection(conn);
            string name, realname,password;
            name = txtUserName.Text;
            realname = txtRealName.Text;
            password = txtNewPassword.Text;
            mycon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = "UPDATE [Note].[dbo].[UsersInfo]   SET [Password] = '" +password+ "'WHERE UserName='"+ name +"' and Name='" + realname + "'";
            cmd.ExecuteNonQuery();
            if (dt.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("修改成功！");
                return;
            }
            else
            {
                MessageBox.Show("修改失败！");
                return;
            }

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

  
