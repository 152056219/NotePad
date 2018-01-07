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
    public partial class notemanage : Form
    {
        public notemanage()
        {
            InitializeComponent();
        }

        private void notemanage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“noteDataSet1.NoteInfo”中。您可以根据需要移动或删除它。
            this.noteInfoTableAdapter.Fill(this.noteDataSet1.NoteInfo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dt = SQLHelper.GetDataSet("select * from NoteInfo ", null);
            string conn = "Data Source=.;Initial Catalog=Note;Integrated Security=True";
            SqlConnection mycon = new SqlConnection(conn);
            string classi, tit, not;
            classi = textBox1.Text;
            tit = textBox2.Text;
            not = textBox3.Text;
            mycon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = "UPDATE [Note].[dbo].[NoteInfo]   SET [note] = '" + not + "'WHERE Classify='" + classi + "' and Title='" + tit + "'";
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
    }
}
