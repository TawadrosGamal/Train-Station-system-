namespace Train_Station
{
    partial class Inquiry
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.finalTrainDataSet = new Train_Station.FinalTrainDataSet();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new Train_Station.FinalTrainDataSetTableAdapters.StationTableAdapter();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new Train_Station.FinalTrainDataSetTableAdapters.ScheduleTableAdapter();
            this.Train_Schedule = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTrainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.trainidDataGridViewTextBoxColumn,
            this.stationidDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.scheduleBindingSource;
            this.dgv.Location = new System.Drawing.Point(100, 68);
            this.dgv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(669, 380);
            this.dgv.TabIndex = 0;
            // 
            // finalTrainDataSet
            // 
            this.finalTrainDataSet.DataSetName = "FinalTrainDataSet";
            this.finalTrainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "Station";
            this.stationBindingSource.DataSource = this.finalTrainDataSet;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.finalTrainDataSet;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // Train_Schedule
            // 
            this.Train_Schedule.AutoSize = true;
            this.Train_Schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train_Schedule.Location = new System.Drawing.Point(320, 20);
            this.Train_Schedule.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Train_Schedule.Name = "Train_Schedule";
            this.Train_Schedule.Size = new System.Drawing.Size(210, 31);
            this.Train_Schedule.TabIndex = 1;
            this.Train_Schedule.Text = "Train Schedule";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 54;
            // 
            // trainidDataGridViewTextBoxColumn
            // 
            this.trainidDataGridViewTextBoxColumn.DataPropertyName = "train_id";
            this.trainidDataGridViewTextBoxColumn.HeaderText = "train_id";
            this.trainidDataGridViewTextBoxColumn.Name = "trainidDataGridViewTextBoxColumn";
            this.trainidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationidDataGridViewTextBoxColumn
            // 
            this.stationidDataGridViewTextBoxColumn.DataPropertyName = "station_id";
            this.stationidDataGridViewTextBoxColumn.HeaderText = "station_id";
            this.stationidDataGridViewTextBoxColumn.Name = "stationidDataGridViewTextBoxColumn";
            this.stationidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stationidDataGridViewTextBoxColumn.Width = 170;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 200;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 476);
            this.Controls.Add(this.Train_Schedule);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Inquiry";
            this.Text = "Inquery";
            this.Load += new System.EventHandler(this.Inquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTrainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private FinalTrainDataSet finalTrainDataSet;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private FinalTrainDataSetTableAdapters.StationTableAdapter stationTableAdapter;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private FinalTrainDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.Label Train_Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
    }
}