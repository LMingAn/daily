using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace test_12._20_WinNF
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
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=货物管理.mdb";
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from 货物表";
            adapter.SelectCommand = comm;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            ds.Clear();
            adapter.Fill(ds, "货物表");
            dgvGoods.DataSource = ds.Tables["货物表"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "货物表");
        }
    }
}
