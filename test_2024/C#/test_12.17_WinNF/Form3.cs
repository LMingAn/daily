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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //为ADO.NET相关对象声明变量
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader dr;

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=货物管理.mdb";
            conn.Open();
            comm.Connection = conn;
        }

        private void btnQGoods_Click(object sender, EventArgs e)
        {
            string strComm, strInfo;
            strComm = "select 名称,价格,产地 from 货物表";
            comm.CommandText = strComm;
            dr = comm.ExecuteReader();
            //读取字段名
            strInfo = "";
            for (int i = 0; i <= dr.FieldCount - 1; i++)
                strInfo += dr.GetName(i) + "\t        ";
            strInfo += "\n";
            //读取字段值
            while (dr.Read())
            {
                for (int i = 0; i <= dr.FieldCount - 1; i++)
                    strInfo += dr[i] + "\t        ";
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
