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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //为ADO.NET相关对象声明变量
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();


        private void Form2_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentRecord.mdb";
            conn.Open();
            comm.Connection = conn;
            comm.CommandText = "select * from studentInfo";
            adapter.SelectCommand = comm;
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            ds.Clear();
            adapter.Fill(ds, "studentInfo");
            dgvStudent.DataSource = ds.Tables["studentInfo"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(ds, "studentInfo");
        }
    }
}
