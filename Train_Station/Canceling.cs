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
    public partial class Canceling : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Canceling()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FinalTrain.accdb;Persist Security Info=True";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtt = new DataTable();
            OleDbCommand cmd = new OleDbCommand("select *from Ticket", conn);
            conn.Open();
            dtt.Load(cmd.ExecuteReader());
            conn.Close();
            bool okk = false;//there is no ticket 

            for(int i = 0; i < dtt.Rows.Count; i++)
            {
                if(dtt.Rows[i][0].ToString()== txttain.Text)
                {
                    okk = true;break;
                }
            }
          
            if (okk==false)
            {
                MessageBox.Show("There Is No Ticket With This ID",
                "Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                conn.Open();
                cmd = new OleDbCommand("delete from Ticket where ID ='"+ txttain.Text + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ticket Deleted","Deleted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                this.Close();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Canceling_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

        }
    }
}
