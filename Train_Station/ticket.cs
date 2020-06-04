using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Train_Station
{
    public partial class ticket : Form
    {
        string details;
        public ticket(string s)
        {
            InitializeComponent();
            details = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ticket_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

            string[] ticket_details = details.Split('*');
            textBox1.Text = ticket_details[0];
            lbltrain.Text = ticket_details[2];
            lblseat.Text = ticket_details[3];
            lbldate.Text = ticket_details[4];
            lblsrc.Text = ticket_details[5];
            lbldes.Text = ticket_details[6];
            lblResidingTime.Text = ticket_details[7];
            lblarrive.Text = ticket_details[8];
            lblprice.Text = ticket_details[9];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void lblarrive_Click(object sender, EventArgs e)
        {

        }
    }
}
