namespace Train_Station
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trainIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivingTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavingTimeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpentPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.trainScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.trainScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cmbto = new System.Windows.Forms.ComboBox();
            this.cnbfrom = new System.Windows.Forms.ComboBox();
            this.dgvv = new System.Windows.Forms.DataGridView();
            this.gbreserve = new System.Windows.Forms.GroupBox();
            this.btnreserve = new System.Windows.Forms.Button();
            this.comseat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comtrain = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residing_station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvv)).BeginInit();
            this.gbreserve.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainIDDataGridViewTextBoxColumn
            // 
            this.trainIDDataGridViewTextBoxColumn.DataPropertyName = "trainID";
            this.trainIDDataGridViewTextBoxColumn.HeaderText = "trainID";
            this.trainIDDataGridViewTextBoxColumn.Name = "trainIDDataGridViewTextBoxColumn";
            // 
            // stationIDDataGridViewTextBoxColumn
            // 
            this.stationIDDataGridViewTextBoxColumn.DataPropertyName = "stationID";
            this.stationIDDataGridViewTextBoxColumn.HeaderText = "stationID";
            this.stationIDDataGridViewTextBoxColumn.Name = "stationIDDataGridViewTextBoxColumn";
            this.stationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrivingTimeDateDataGridViewTextBoxColumn
            // 
            this.arrivingTimeDateDataGridViewTextBoxColumn.DataPropertyName = "arriving time/Date";
            this.arrivingTimeDateDataGridViewTextBoxColumn.HeaderText = "arriving time/Date";
            this.arrivingTimeDateDataGridViewTextBoxColumn.Name = "arrivingTimeDateDataGridViewTextBoxColumn";
            this.arrivingTimeDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // leavingTimeDateDataGridViewTextBoxColumn
            // 
            this.leavingTimeDateDataGridViewTextBoxColumn.DataPropertyName = "leaving time/Date";
            this.leavingTimeDateDataGridViewTextBoxColumn.HeaderText = "leaving time/Date";
            this.leavingTimeDateDataGridViewTextBoxColumn.Name = "leavingTimeDateDataGridViewTextBoxColumn";
            this.leavingTimeDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeSpentPerHourDataGridViewTextBoxColumn
            // 
            this.timeSpentPerHourDataGridViewTextBoxColumn.DataPropertyName = "timeSpentPerHour";
            this.timeSpentPerHourDataGridViewTextBoxColumn.HeaderText = "timeSpentPerHour";
            this.timeSpentPerHourDataGridViewTextBoxColumn.Name = "timeSpentPerHourDataGridViewTextBoxColumn";
            this.timeSpentPerHourDataGridViewTextBoxColumn.Width = 200;
            // 
            // trainBindingSource6
            // 
            this.trainBindingSource6.DataMember = "Train";
            // 
            // trainScheduleBindingSource
            // 
            this.trainScheduleBindingSource.DataMember = "TrainSchedule";
            this.trainScheduleBindingSource.DataSource = this.trainBindingSource4;
            // 
            // trainScheduleBindingSource1
            // 
            this.trainScheduleBindingSource1.DataMember = "TrainSchedule";
            this.trainScheduleBindingSource1.DataSource = this.trainBindingSource4;
            // 
            // trainTicketBindingSource
            // 
            this.trainTicketBindingSource.DataMember = "TrainTicket";
            this.trainTicketBindingSource.DataSource = this.trainBindingSource4;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            // 
            // trainBindingSource3
            // 
            this.trainBindingSource3.DataMember = "Train";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(169, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(741, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(330, 180);
            this.txtdate.Margin = new System.Windows.Forms.Padding(6);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(356, 29);
            this.txtdate.TabIndex = 4;
            this.txtdate.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(260, 184);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 24);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsearch.BackColor = System.Drawing.Color.Gray;
            this.btnsearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnsearch.Location = new System.Drawing.Point(395, 221);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(196, 42);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbto
            // 
            this.cmbto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbto.FormattingEnabled = true;
            this.cmbto.Items.AddRange(new object[] {
            "Alexandria",
            "Damanhour",
            "Tanta",
            "Banha",
            "Cairo",
            "El Geza",
            "Beni Suef",
            "Minya",
            "Asyut",
            "Sohag",
            "Qena",
            "Luxor",
            "Aswan"});
            this.cmbto.Location = new System.Drawing.Point(603, 82);
            this.cmbto.Margin = new System.Windows.Forms.Padding(6);
            this.cmbto.Name = "cmbto";
            this.cmbto.Size = new System.Drawing.Size(310, 32);
            this.cmbto.TabIndex = 8;
            this.cmbto.SelectedIndexChanged += new System.EventHandler(this.cmbto_SelectedIndexChanged);
            // 
            // cnbfrom
            // 
            this.cnbfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnbfrom.FormattingEnabled = true;
            this.cnbfrom.Items.AddRange(new object[] {
            "Alexandria",
            "Damanhour",
            "Tanta",
            "Banha",
            "Cairo",
            "El Geza",
            "Beni Suef",
            "Minya",
            "Asyut",
            "Sohag",
            "Qena",
            "Luxor",
            "Aswan"});
            this.cnbfrom.Location = new System.Drawing.Point(43, 82);
            this.cnbfrom.Margin = new System.Windows.Forms.Padding(6);
            this.cnbfrom.Name = "cnbfrom";
            this.cnbfrom.Size = new System.Drawing.Size(310, 32);
            this.cnbfrom.TabIndex = 9;
            this.cnbfrom.SelectedIndexChanged += new System.EventHandler(this.cnbfrom_SelectedIndexChanged);
            // 
            // dgvv
            // 
            this.dgvv.AutoGenerateColumns = false;
            this.dgvv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Residing_station,
            this.departure_time});
            this.dgvv.DataSource = this.trainBindingSource6;
            this.dgvv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvv.Location = new System.Drawing.Point(28, 330);
            this.dgvv.Name = "dgvv";
            this.dgvv.Size = new System.Drawing.Size(525, 243);
            this.dgvv.TabIndex = 10;
            this.dgvv.Visible = false;
            this.dgvv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvv_CellContentClick);
            // 
            // gbreserve
            // 
            this.gbreserve.BackColor = System.Drawing.Color.Transparent;
            this.gbreserve.Controls.Add(this.btnreserve);
            this.gbreserve.Controls.Add(this.comseat);
            this.gbreserve.Controls.Add(this.label4);
            this.gbreserve.Controls.Add(this.comtrain);
            this.gbreserve.Controls.Add(this.label3);
            this.gbreserve.Location = new System.Drawing.Point(634, 330);
            this.gbreserve.Name = "gbreserve";
            this.gbreserve.Size = new System.Drawing.Size(341, 243);
            this.gbreserve.TabIndex = 16;
            this.gbreserve.TabStop = false;
            this.gbreserve.Text = "Reservation";
            this.gbreserve.Visible = false;
            // 
            // btnreserve
            // 
            this.btnreserve.BackColor = System.Drawing.Color.Gray;
            this.btnreserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreserve.Location = new System.Drawing.Point(101, 181);
            this.btnreserve.Margin = new System.Windows.Forms.Padding(6);
            this.btnreserve.Name = "btnreserve";
            this.btnreserve.Size = new System.Drawing.Size(163, 42);
            this.btnreserve.TabIndex = 15;
            this.btnreserve.Text = "Reserve Ticket";
            this.btnreserve.UseVisualStyleBackColor = false;
            this.btnreserve.Click += new System.EventHandler(this.btnreserve_Click);
            // 
            // comseat
            // 
            this.comseat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comseat.FormattingEnabled = true;
            this.comseat.Location = new System.Drawing.Point(149, 125);
            this.comseat.Margin = new System.Windows.Forms.Padding(6);
            this.comseat.Name = "comseat";
            this.comseat.Size = new System.Drawing.Size(102, 32);
            this.comseat.TabIndex = 14;
            this.comseat.SelectedIndexChanged += new System.EventHandler(this.comseat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seat No";
            // 
            // comtrain
            // 
            this.comtrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtrain.FormattingEnabled = true;
            this.comtrain.Location = new System.Drawing.Point(149, 49);
            this.comtrain.Margin = new System.Windows.Forms.Padding(6);
            this.comtrain.Name = "comtrain";
            this.comtrain.Size = new System.Drawing.Size(102, 32);
            this.comtrain.TabIndex = 12;
            this.comtrain.SelectedIndexChanged += new System.EventHandler(this.comtrain_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Train ID";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // Residing_station
            // 
            this.Residing_station.DataPropertyName = "Residing_station";
            this.Residing_station.HeaderText = "Residing Station";
            this.Residing_station.Name = "Residing_station";
            this.Residing_station.Width = 200;
            // 
            // departure_time
            // 
            this.departure_time.DataPropertyName = "departure_time";
            this.departure_time.HeaderText = "Residing Time";
            this.departure_time.Name = "departure_time";
            this.departure_time.Width = 180;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train_Station.Properties.Resources._1027238984;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 637);
            this.Controls.Add(this.gbreserve);
            this.Controls.Add(this.dgvv);
            this.Controls.Add(this.cnbfrom);
            this.Controls.Add(this.cmbto);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realway Station";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainScheduleBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.trainBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvv)).EndInit();
            this.gbreserve.ResumeLayout(false);
            this.gbreserve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn trainIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivingTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavingTimeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpentPerHourDataGridViewTextBoxColumn;
      //  private FinalTrainDataSet finalTrainDataSet;
        private System.Windows.Forms.BindingSource trainBindingSource;
       // private FinalTrainDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource trainBindingSource1;
        private System.Windows.Forms.BindingSource trainBindingSource4;
        private System.Windows.Forms.BindingSource trainBindingSource2;
        private System.Windows.Forms.BindingSource trainBindingSource3;
        private System.Windows.Forms.BindingSource trainScheduleBindingSource;
      //  private FinalTrainDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.BindingSource trainScheduleBindingSource1;
        private System.Windows.Forms.BindingSource trainTicketBindingSource;
    //    private FinalTrainDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
     //   private FinalTrainDataSet2 finalTrainDataSet2;
        private System.Windows.Forms.BindingSource trainBindingSource5;
       // private FinalTrainDataSet2TableAdapters.TrainTableAdapter trainTableAdapter1;
       // private FinalTrainDataSet3 finalTrainDataSet3;
        private System.Windows.Forms.BindingSource trainBindingSource6;
       // private FinalTrainDataSet3TableAdapters.TrainTableAdapter trainTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cmbto;
        private System.Windows.Forms.ComboBox cnbfrom;
        private System.Windows.Forms.DataGridView dgvv;
        private System.Windows.Forms.GroupBox gbreserve;
        private System.Windows.Forms.Button btnreserve;
        private System.Windows.Forms.ComboBox comseat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comtrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residing_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_time;
    }
}