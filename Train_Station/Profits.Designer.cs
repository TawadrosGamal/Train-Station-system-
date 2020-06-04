namespace Train_Station
{
    partial class Profits
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
            this.finalTrainDataSet = new Train_Station.FinalTrainDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Train_Station.FinalTrainDataSetTableAdapters.TicketTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buytimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startstationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endstationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaltimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbluserid = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Train_Station.FinalTrainDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.finalTrainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // finalTrainDataSet
            // 
            this.finalTrainDataSet.DataSetName = "FinalTrainDataSet";
            this.finalTrainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.finalTrainDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.trainidDataGridViewTextBoxColumn,
            this.seatidDataGridViewTextBoxColumn,
            this.buytimeDataGridViewTextBoxColumn,
            this.startstationidDataGridViewTextBoxColumn,
            this.endstationidDataGridViewTextBoxColumn,
            this.departuretimeDataGridViewTextBoxColumn,
            this.arrivaltimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(997, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // trainidDataGridViewTextBoxColumn
            // 
            this.trainidDataGridViewTextBoxColumn.DataPropertyName = "train_id";
            this.trainidDataGridViewTextBoxColumn.HeaderText = "train_id";
            this.trainidDataGridViewTextBoxColumn.Name = "trainidDataGridViewTextBoxColumn";
            // 
            // seatidDataGridViewTextBoxColumn
            // 
            this.seatidDataGridViewTextBoxColumn.DataPropertyName = "seat_id";
            this.seatidDataGridViewTextBoxColumn.HeaderText = "seat_id";
            this.seatidDataGridViewTextBoxColumn.Name = "seatidDataGridViewTextBoxColumn";
            // 
            // buytimeDataGridViewTextBoxColumn
            // 
            this.buytimeDataGridViewTextBoxColumn.DataPropertyName = "buy_time";
            this.buytimeDataGridViewTextBoxColumn.HeaderText = "buy_time";
            this.buytimeDataGridViewTextBoxColumn.Name = "buytimeDataGridViewTextBoxColumn";
            // 
            // startstationidDataGridViewTextBoxColumn
            // 
            this.startstationidDataGridViewTextBoxColumn.DataPropertyName = "start_station_id";
            this.startstationidDataGridViewTextBoxColumn.HeaderText = "start_station_id";
            this.startstationidDataGridViewTextBoxColumn.Name = "startstationidDataGridViewTextBoxColumn";
            // 
            // endstationidDataGridViewTextBoxColumn
            // 
            this.endstationidDataGridViewTextBoxColumn.DataPropertyName = "end_station_id";
            this.endstationidDataGridViewTextBoxColumn.HeaderText = "end_station_id";
            this.endstationidDataGridViewTextBoxColumn.Name = "endstationidDataGridViewTextBoxColumn";
            // 
            // departuretimeDataGridViewTextBoxColumn
            // 
            this.departuretimeDataGridViewTextBoxColumn.DataPropertyName = "departure_time";
            this.departuretimeDataGridViewTextBoxColumn.HeaderText = "departure_time";
            this.departuretimeDataGridViewTextBoxColumn.Name = "departuretimeDataGridViewTextBoxColumn";
            // 
            // arrivaltimeDataGridViewTextBoxColumn
            // 
            this.arrivaltimeDataGridViewTextBoxColumn.DataPropertyName = "arrival_time";
            this.arrivaltimeDataGridViewTextBoxColumn.HeaderText = "arrival_time";
            this.arrivaltimeDataGridViewTextBoxColumn.Name = "arrivaltimeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reserved Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(562, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(685, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 29);
            this.textBox1.TabIndex = 4;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.BackColor = System.Drawing.Color.Transparent;
            this.lbluserid.ForeColor = System.Drawing.Color.White;
            this.lbluserid.Location = new System.Drawing.Point(62, 100);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(90, 24);
            this.lbluserid.TabIndex = 5;
            this.lbluserid.Text = "User ID :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 29);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(351, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.finalTrainDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train_Station.Properties.Resources._1027238984;
            this.ClientSize = new System.Drawing.Size(1121, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profits";
            this.Text = "Profits";
            this.Load += new System.EventHandler(this.Profits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalTrainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FinalTrainDataSet finalTrainDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private FinalTrainDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buytimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startstationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endstationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private FinalTrainDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}