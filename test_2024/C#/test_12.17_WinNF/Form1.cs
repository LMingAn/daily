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

namespace test_12._17_WinNF
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
        OleDbDataReader dr;


        private void Form1_Load(object sender, EventArgs e)
        {
            //设置连接字符串，并打开连接
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentRecord.mdb";
            conn.Open();
            comm.Connection = conn;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strComm, strInfo;
            if (radName.Checked)
                strComm = "select StuName,sex,StuNo,speciality,class,hobby from studentInfo where StuName like '%" + txtQuery.Text.Trim() + "%'";
            else
                strComm = "select StuName,sex,StuNo,speciality,class,hobby from studentInfo where StuNo like '%" + txtQuery.Text.Trim() + "%'";
            comm.CommandText = strComm;
            dr = comm.ExecuteReader();
            //读取字段名
            strInfo = "";
            for (int i = 0; i <= dr.FieldCount - 1; i++)
                strInfo += dr.GetName(i) + "\t";
            strInfo += "\n";
            //读取字段值
            while (dr.Read())
            {
                for (int i = 0; i <= dr.FieldCount - 1; i++)
                    strInfo += dr[i] + "\t";
                //dr[i]是在给定列序号的情况下，获取指定列的以本机格式表示的值
                strInfo += "\n";
            }
            //输出查询结果
            if (dr.HasRows)
                MessageBox.Show(strInfo, "查询结果");
            else
                MessageBox.Show("无匹配记录！", "查询结果");
            //关闭数据阅读器
            dr.Close();
        }
    }
}
