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
    public partial class Inquiry : Form
    {
            OleDbConnection conn = new OleDbConnection();
        public Inquiry()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FinalTrain.accdb;Persist Security Info=True";
        }

        private void Inquiry_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

            DataTable dt = new DataTable();
            DataTable dtrain = new DataTable();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select *from Schedule", conn);
            dt.Load(cmd.ExecuteReader());
            OleDbCommand cmdtrain = new OleDbCommand("select *from Train", conn);
            dtrain.Load(cmdtrain.ExecuteReader());
            conn.Close();
       
            // id -> name
            Dictionary<string, string> id_name=new Dictionary<string, string>();

            //id ->time
            Dictionary<string, string> id_time=new Dictionary<string, string>();

            for(int i = 0; i < dtrain.Rows.Count; i++)
            {
                id_name[dtrain.Rows[i][0].ToString()] = dtrain.Rows[i][1].ToString();

                id_time[dtrain.Rows[i][0].ToString()] = dtrain.Rows[i][2].ToString();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string add = dt.Rows[i][3].ToString();//time -> form schedule
                                                      //dic       //train_id -> time
                DateTime residing = Convert.ToDateTime(id_time[dt.Rows[i][1].ToString()]);

                DateTime timee = residing.AddMinutes(int.Parse(add));

                dt.Rows[i][3] = string.Format("{0:hh:mm:ss tt}", timee);

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][1] = id_name[dt.Rows[i][1].ToString()];
            }
            dgv.DataSource = dt;


        }
    }
}
