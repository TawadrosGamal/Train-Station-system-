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
    public partial class Reservation : Form
    {
        string id="";
        public Reservation(string client)
        {
            InitializeComponent();
            id = client;
        }
        public DataTable traintable = new DataTable();//pubbbbbbbbbbbbblic  why??
        //need connection string ^^
        private void button1_Click(object sender, EventArgs e)
        {
            //testing
            if (cnbfrom.Text == "" || cmbto.Text == "")
            {
                MessageBox.Show("Please Select Stations");

            }
            else
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = FinalTrain.accdb; Persist Security Info = True";
                //check_date
                DateTime x = txtdate.Value.Date;//input
                DateTime y = DateTime.Now.Date;//current date
                double days = (x - y).TotalDays;
                if (days > 15.0) MessageBox.Show("Not Allow More Than 15 Days");
                else if (days < 0) MessageBox.Show("Are You Jokiing me ^^");
                else
                {
                    // select direction
                    comseat.Items.Clear();
                    Dictionary<string, int> direction = new Dictionary<string, int>();
                    direction.Add("Alexandria", 1);
                    direction.Add("Damanhour", 2);
                    direction.Add("Tanta", 3);
                    direction.Add("Banha", 4);
                    direction.Add("Cairo", 5);
                    direction.Add("El Geza", 6);
                    direction.Add("Beni Suef", 7);
                    direction.Add("Minya", 8);
                    direction.Add("Asyut", 9);
                    direction.Add("Sohag", 10);
                    direction.Add("Qena", 11);
                    direction.Add("Luxor", 12);
                    direction.Add("Aswan", 13);
                    string from = cnbfrom.Text;
                    string too = cmbto.Text;
                    int dir = 0;//direction ^^ 
               
                    //J8W31666
                    dir = direction[from] - direction[too]; // calc direction 
                    // if + aswan - > alex 
                    // esle alex ->aswan 
                    
                    if (dir > 0)//N aswan ->alex
                    {

                        DataTable dtt = new DataTable();
                        try
                        {
                            //fill data gride view
                            string query = "select *from Train where Direction = 'N'";
                            OleDbCommand cmd = new OleDbCommand(query, conn);

                            conn.Open();
                            dtt.Load(cmd.ExecuteReader());
                            conn.Close();
                            traintable = dtt;//N
                            dgvv.DataSource = dtt;
                            dgvv.Visible = true;
                            gbreserve.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                        comtrain.Text = "";
                        FillComboBox("select *from Train where Direction = 'N'", comtrain);
                        int seat = 1;
                        string trainid = comtrain.SelectedValue.ToString();
                        char ch = (char)(int.Parse(trainid) - 1);
                        ch += 'A';
                        trainid = ""; trainid += ch;
                        for (int i = 0; i < 13 - direction[too]; i++)
                        {
                            comseat.Items.Add(trainid + seat.ToString());
                            seat++;
                            comseat.Items.Add(trainid + seat.ToString());
                            seat++;
                            comseat.Items.Add(trainid + seat.ToString());
                            seat++;
                        }
                        string query2 = "select * from Ticket";
                        string trainid2 = comtrain.Text;
                        string datee = txtdate.Text;
                        string seatid = comseat.Text;
                        OleDbCommand cmd2 = new OleDbCommand(query2, conn);
                        DataTable dtt2 = new DataTable();
                        conn.Open();
                        dtt2.Load(cmd2.ExecuteReader());
                        conn.Close();
                        for (int i = 0; i <= dtt2.Rows.Count - 1; i++)
                        {
                            var curtid = dtt2.Rows[i][2];
                            var curdate = dtt2.Rows[i][4];
                            var curseat = dtt2.Rows[i][3];
                            if (comseat.Items.Contains(curseat.ToString()) && curdate.ToString() == datee && trainid2 == curtid.ToString())
                            {
                                comseat.Items.Remove(curseat.ToString());
                            }
                        }
                    }
                    else if (dir < 0)
                    {
                        try
                        {
                            //fill data gride view
                            string query = "select *from Train where Direction = 'S'"; ;
                            OleDbCommand cmd = new OleDbCommand(query, conn);
                            DataTable dtt = new DataTable();
                            conn.Open();
                            dtt.Load(cmd.ExecuteReader());
                            conn.Close();
                            traintable = dtt;
                            dgvv.DataSource = dtt;
                            dgvv.Visible = true;
                            gbreserve.Visible = true;
                            comtrain.Text = "";
                            FillComboBox("select *from Train where Direction = 'S'", comtrain);
                            int seat = 1;
                            string trainid = comtrain.SelectedValue.ToString();
                            char ch = (char)(int.Parse(trainid) - 1);
                            ch += 'A';
                            trainid = ""; trainid += ch;
                            for (int i = 0; i < direction[too]; i++)
                            {
                                comseat.Items.Add(trainid + seat.ToString());
                                seat++;
                                comseat.Items.Add(trainid + seat.ToString());
                                seat++;
                                comseat.Items.Add(trainid + seat.ToString());
                                seat++;
                            }
                            // Seats
                            string query2 = "select * from Ticket";
                            string trainid2 = comtrain.Text;
                            string datee = txtdate.Text;
                            string seatid = comseat.Text;
                            OleDbCommand cmd2 = new OleDbCommand(query2, conn);
                            DataTable dtt2 = new DataTable();
                            conn.Open();
                            dtt2.Load(cmd2.ExecuteReader());
                            conn.Close();
                            for (int i = 0; i <= dtt2.Rows.Count - 1; i++)
                            {
                                var curtid = dtt2.Rows[i][2];
                                var curdate = dtt2.Rows[i][4];
                                var curseat = dtt2.Rows[i][3];

                                if (comseat.Items.Contains(curseat.ToString()) && curdate.ToString() == datee && trainid2 == curtid.ToString())
                                {
                                    comseat.Items.Remove(curseat.ToString());
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                    else { MessageBox.Show("Are You Joking ^^"); }

                }
            }

           
        }





        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listofavetrains_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void dgvv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comtrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            comtrain.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void FillComboBox(string Query, System.Windows.Forms.ComboBox LoggedByBox)
        {
            using (var CONN = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = FinalTrain.accdb; Persist Security Info = True"))
            {
                CONN.Open();
                DataTable dt = new DataTable();
                try
                {
                    OleDbCommand cmd = new OleDbCommand(Query, CONN);
                    OleDbDataReader myReader = cmd.ExecuteReader();
                    dt.Load(myReader);
                }
                catch (OleDbException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();

                    return;
                }
                LoggedByBox.DataSource = dt;
                LoggedByBox.ValueMember = "ID";
                LoggedByBox.DisplayMember = "Initials";
                CONN.Close();
            }
        }

        private void btnreserve_Click(object sender, EventArgs e)
        {
            
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = FinalTrain.accdb; Persist Security Info = True";
            string trainid = comtrain.Text;
            string datee = txtdate.Text;
            string seatid = comseat.Text;
            if (seatid == "") MessageBox.Show("Please Selcet Seat Number");
            else if (seatid.Count() == 0) MessageBox.Show("There Is No Seats Available");
            else{
                OleDbCommand cmd = conn.CreateCommand();
                DataTable dtt = new DataTable();
                OleDbCommand cmd2 = new OleDbCommand("select *from Schedule",conn);
                int  timesrc=0, moneysrc=0;
                int  timedes=0, moneydes=0;
                string residing_time = "";
                conn.Open();
                dtt.Load(cmd2.ExecuteReader());
                for(int i = 0; i < dtt.Rows.Count; i++)
                {
                    if (dtt.Rows[i][1].ToString() == trainid &&dtt.Rows[i][2].ToString()== cnbfrom.Text)
                    {
                        timesrc = int.Parse(dtt.Rows[i][3].ToString());
                        moneysrc = int.Parse(dtt.Rows[i][4].ToString());
                    }
                    if (dtt.Rows[i][1].ToString() == trainid && dtt.Rows[i][2].ToString() == cmbto.Text)
                    {
                        timedes = int.Parse(dtt.Rows[i][3].ToString());
                        moneydes = int.Parse(dtt.Rows[i][4].ToString());
                    }
                }
                for (int i = 0; i < traintable.Rows.Count; i++)
                {
                    if (traintable.Rows[i][0].ToString() == comtrain.Text)
                    {
                        residing_time = traintable.Rows[i][2].ToString();
                        break;
                    }
                }
                string details = "";          //min  +    ticket date
                DateTime residing_time1 = Convert.ToDateTime(residing_time);// train residing
                DateTime residing_time2 = Convert.ToDateTime(txtdate.Text);//cur date
                DateTime residing_time3 = residing_time1.AddMinutes(residing_time2.Minute);//+
                DateTime residing_time4 = residing_time3.AddMinutes(timesrc);//reach to src
                residing_time2 = residing_time4;
                                                // residingT + time form src->dest
                DateTime arrivalT = residing_time2.AddMinutes(timedes - timesrc);
                cmd.Connection = conn;
                // to convert the date formate ^^ 
                DateTime aDate = Convert.ToDateTime(txtdate.Text);
                cmd.CommandText = "INSERT into Ticket (ID,client_id , train_id , seat_id , buy_time , start_station_id , end_station_id , departure_time ,arrival_time, price) values ('"+ id + comtrain.Text+ comseat.Text + aDate.ToString("MM/dd/yyyy") + "','" + id + "' , '" + comtrain.Text + "','" + comseat.Text + "','" + txtdate.Text + "','" + cnbfrom.Text + "','" + cmbto.Text + "','" + residing_time2.ToString() + "','" + arrivalT.ToString() + "','" + (moneydes-moneysrc).ToString() + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your Ticket Is Reserved Successfully");
                details = id + comtrain.Text + comseat.Text + aDate.ToString("MM/dd/yyyy") + '*' + id + '*' + comtrain.Text + '*' + comseat.Text + '*' + txtdate.Text + '*' + cnbfrom.Text + '*' + cmbto.Text + '*' + residing_time2.ToString() + '*' + arrivalT.ToString() + '*' + (moneydes - moneysrc).ToString();
                ticket f = new ticket(details);
                this.Close();
                f.Show();

            }

        }

        private void comseat_SelectedIndexChanged(object sender, EventArgs e)
        {
            comseat.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cnbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnbfrom.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cmbto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbto.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

