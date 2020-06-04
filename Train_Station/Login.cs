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
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FinalTrain.accdb;Persist Security Info=True";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Input Required Fields!",
                "Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else if (textBox1.Text != textBox1.Text.ToLower() || textBox2.Text != textBox2.Text.ToLower())
            {
                MessageBox.Show("Invalid User Name or Password",
                       "Note",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation,
                       MessageBoxDefaultButton.Button1);
            }
            else
            {
                conn.Open();
                try
                {
                  

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Client where name ='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
                    OleDbDataReader reader = cmd.ExecuteReader();
                    bool k = false;
                    string id = "";// to the second form ^^
                    while (reader.Read()) {
                        id = reader.GetInt32(0).ToString();// someone who login 
                        k = true;
                    }
                    if (k == true) {
                        Operations f2 = new Operations(id.ToString());
                        f2.Show();this.Hide();
                    }
                    else  {
                        MessageBox.Show("Invalid User Name or Password",
                        "Note",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
        }
      
        private void Login_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }
        private void formset()
        {
            this.Size = new Size(772, 431);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
        private void Login_Move(object sender, EventArgs e)
        {
            formset();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            formset();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
