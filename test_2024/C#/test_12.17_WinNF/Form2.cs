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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //为ADO.NET相关对象声明变量
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader dr;


        private void Form2_Load(object sender, EventArgs e)
        {
            conn.StateChange += new System.Data.StateChangeEventHandler(this.conn_StateChange);
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentRecord.mdb";
            conn.Open();
            comm.Connection = conn;
        }

        private void conn_StateChange(object sender, StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case ConnectionState.Open:
                    btnConn.Text = "断开连接";
                    btnQuery.Enabled = true;
                    break;
                case ConnectionState.Closed:
                    btnConn.Text = "打开连接";
                    btnQuery.Enabled = false;
                    break;
                case ConnectionState.Broken:
                    btnConn.Text = "连接中断";
                    break;
                case ConnectionState.Connecting:
                    btnConn.Text = "正在连接";
                    break;
                case ConnectionState.Executing:
                    btnConn.Text = "正在执行命令";
                    break;
                case ConnectionState.Fetching:
                    btnConn.Text = "正在检索数据";
                    break;
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            switch (btnConn.Text)
            {
                case "断开连接":
                    conn.Close();
                    break;
                case "打开连接":
                    conn.Open();
                    break;
                case "连接中断":
                    conn.Close();
                    conn.Open();
                    break;
            }
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

        private void btnQSex_Click(object sender, EventArgs e)
        {
            string strComm, strInfo;
            strComm = "select StuName,speciality,address from studentInfo where sex = '男'";
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

        private void btnQCollege_Click(object sender, EventArgs e)
        {
            string strComm, strInfo;
            strComm = "select StuName,sex,address,hobby from studentInfo where college = '电气学院'";
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
