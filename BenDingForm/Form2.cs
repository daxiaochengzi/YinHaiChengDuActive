using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BenDingActive.Help;

namespace BenDingForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateDataBase_Click(object sender, EventArgs e)
        {
            SqLiteHelper.CreateDataBase();

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            //SqLiteHelper.NewTableData();
            SqLiteHelper.NewTableDataError();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=" + @"C:\Program Files (x86)\Microsoft\本鼎医保插件\logData.db; Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
          
            string sql = $@"INSERT INTO Data (OperatorId, JoinJson, ReturnJson,TransactionCode,CreateTime)
                 VALUES ('E075AC49FCE443778F897CF839F3B924', '123', '123','11','2020-06-03 10:03:19.697')";
            var ddd= SqLiteHelper.ExecuteNonQuery(CommonHelp.GetConnStr(), sql, CommandType.Text);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
           

            //string connStr = @"Data Source=" + @"C:\Program Files (x86)\Microsoft\本鼎医保插件\logData.db; Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
            string sql = @"SELECT OperatorId as 操作人员, JoinJson as 入参, ReturnJson as 出参,CreateTime as 创建时间,TransactionCode as 交易编码 FROM Data where OperatorId<>''";
            if (!string.IsNullOrWhiteSpace(txtStartTime.Text) == true && !string.IsNullOrWhiteSpace(txtEndTime.Text) == true)
            {
                sql += $" and  CreateTime >='{txtStartTime.Text}' and CreateTime <='{txtEndTime.Text}'";
            }
            if (!string.IsNullOrWhiteSpace(txtTransactionCode.Text)) sql += $" and  TransactionCode ='{txtTransactionCode.Text}'";


            var dataSet = SqLiteHelper.ExecuteDataSet(CommonHelp.GetConnStr(), sql, CommandType.Text);
            DataTable dt = dataSet.Tables[0];
            dataGridView1.DataSource = dt;
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string sql = @"SELECT OperatorId as 操作人员, JoinJson as 入参, ReturnJson as 出参,CreateTime as 创建时间,TransactionCode as 交易编码 FROM DataError where OperatorId<>''";
            if (!string.IsNullOrWhiteSpace(txtStartTime.Text) == true && !string.IsNullOrWhiteSpace(txtEndTime.Text) == true)
            {
                sql +=$"  and CreateTime >='{txtStartTime.Text}' and CreateTime <='{txtEndTime.Text}'";
            }
            if (!string.IsNullOrWhiteSpace(txtTransactionCode.Text)) sql += $" and  TransactionCode ='{txtTransactionCode.Text}'";
            var dataSet = SqLiteHelper.ExecuteDataSet(CommonHelp.GetConnStr(), sql, CommandType.Text);
            DataTable dt = dataSet.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
