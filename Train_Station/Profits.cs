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
namespace Train_Station
{
    public partial class Profits : Form
    {
        OleDbConnection conn = new OleDbConnection();

        public Profits()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FinalTrain.accdb;Persist Security Info=True";
        }

        DataTable dt = new DataTable();
        private void Profits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalTrainDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.finalTrainDataSet.Client);
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
            this.ticketTableAdapter.Fill(this.finalTrainDataSet.Ticket);
            OleDbCommand cmd = new OleDbCommand("select * from Ticket", conn);
            conn.Open();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double sum = 0;
           for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == textBox2.Text)
                {
                    sum += double.Parse(dt.Rows[i][9].ToString());
                }
            }
            textBox1.Text = sum.ToString();
        }
    }
}
