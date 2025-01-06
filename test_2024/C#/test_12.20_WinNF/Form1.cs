using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_12._20_WinNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //为ADO.NET相关对象声明变量
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置连接对象，并打开连接
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentRecord.mdb";
            conn.Open();
            //设置命令对象
            comm.Connection = conn;
            comm.CommandText = "select * from studentInfo";
            //设置数据适配器对象
            adapter.SelectCommand = comm;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
        }

        private void btnPad_Click(object sender, EventArgs e)
        {
            ds.Clear();//清除数据集中所有表的所有行
            adapter.Fill(ds, "studentInfo");
            dgvStudent.DataSource = ds.Tables["studentInfo"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "studentInfo");
        }
    }
}