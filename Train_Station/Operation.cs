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
    public partial class Operations : Form
    {
        string id="";
        public Operations(string clientid)
        {
            InitializeComponent();
            id = clientid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation f3 = new Reservation(id);
            f3.ShowDialog();
        }
        private void formset()
        {
            this.Size = new Size(899, 482);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
        private void Operations_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Canceling f4 = new Canceling();
            f4.ShowDialog();
        }

        private void btninquiry_Click(object sender, EventArgs e)
        {
            Inquiry f = new Inquiry();
            f.ShowDialog();
        }

        private void btnprofit_Click(object sender, EventArgs e)
        {
            Profits f = new Profits();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Operations_Move(object sender, EventArgs e)
        {
            formset();
        }

        private void Operations_Resize(object sender, EventArgs e)
        {
            formset();
        }
    }
}
