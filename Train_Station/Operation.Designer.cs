namespace Train_Station
{
    partial class Operations
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
            this.btnreservation = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnprofit = new System.Windows.Forms.Button();
            this.btninquiry = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreservation
            // 
            this.btnreservation.BackColor = System.Drawing.Color.Transparent;
            this.btnreservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreservation.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservation.ForeColor = System.Drawing.Color.White;
            this.btnreservation.Location = new System.Drawing.Point(15, 34);
            this.btnreservation.Margin = new System.Windows.Forms.Padding(6);
            this.btnreservation.Name = "btnreservation";
            this.btnreservation.Size = new System.Drawing.Size(222, 45);
            this.btnreservation.TabIndex = 0;
            this.btnreservation.Text = "Reservation";
            this.btnreservation.UseVisualStyleBackColor = false;
            this.btnreservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(678, 34);
            this.btncancel.Margin = new System.Windows.Forms.Padding(6);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(190, 45);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnprofit
            // 
            this.btnprofit.BackColor = System.Drawing.Color.Transparent;
            this.btnprofit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprofit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprofit.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofit.ForeColor = System.Drawing.Color.White;
            this.btnprofit.Location = new System.Drawing.Point(453, 34);
            this.btnprofit.Margin = new System.Windows.Forms.Padding(6);
            this.btnprofit.Name = "btnprofit";
            this.btnprofit.Size = new System.Drawing.Size(207, 45);
            this.btnprofit.TabIndex = 3;
            this.btnprofit.TabStop = false;
            this.btnprofit.Text = "Profits";
            this.btnprofit.UseVisualStyleBackColor = false;
            this.btnprofit.Click += new System.EventHandler(this.btnprofit_Click);
            // 
            // btninquiry
            // 
            this.btninquiry.BackColor = System.Drawing.Color.Transparent;
            this.btninquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninquiry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninquiry.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninquiry.ForeColor = System.Drawing.Color.White;
            this.btninquiry.Location = new System.Drawing.Point(249, 34);
            this.btninquiry.Margin = new System.Windows.Forms.Padding(6);
            this.btninquiry.Name = "btninquiry";
            this.btninquiry.Size = new System.Drawing.Size(192, 45);
            this.btninquiry.TabIndex = 2;
            this.btninquiry.Text = "Inquiry";
            this.btninquiry.UseVisualStyleBackColor = false;
            this.btninquiry.Click += new System.EventHandler(this.btninquiry_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(751, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Train_Station.Properties.Resources._1027238984;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnprofit);
            this.Controls.Add(this.btninquiry);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnreservation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Railway Station";
            this.Load += new System.EventHandler(this.Operations_Load);
            this.Move += new System.EventHandler(this.Operations_Move);
            this.Resize += new System.EventHandler(this.Operations_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnreservation;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnprofit;
        private System.Windows.Forms.Button btninquiry;
        private System.Windows.Forms.Button button1;
    }
}