namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 127);
            this.label1.TabIndex = 22;
            this.label1.Text = "°";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.todayLabel.ForeColor = System.Drawing.Color.Orange;
            this.todayLabel.Location = new System.Drawing.Point(16, 11);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(122, 48);
            this.todayLabel.TabIndex = 21;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysLabel
            // 
            this.daysLabel.BackColor = System.Drawing.Color.Transparent;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.daysLabel.ForeColor = System.Drawing.Color.Orange;
            this.daysLabel.Location = new System.Drawing.Point(269, 11);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(122, 48);
            this.daysLabel.TabIndex = 20;
            this.daysLabel.Text = "7 Day";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.daysLabel.Click += new System.EventHandler(this.daysLabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "___________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.min.ForeColor = System.Drawing.Color.Aqua;
            this.min.Location = new System.Drawing.Point(90, 237);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(34, 25);
            this.min.TabIndex = 17;
            this.min.Text = "99.";
            this.min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.max.ForeColor = System.Drawing.Color.Red;
            this.max.Location = new System.Drawing.Point(90, 174);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(34, 27);
            this.max.TabIndex = 18;
            this.max.Text = "99.";
            this.max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp
            // 
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F);
            this.temp.ForeColor = System.Drawing.Color.White;
            this.temp.Location = new System.Drawing.Point(109, 149);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(199, 127);
            this.temp.TabIndex = 16;
            this.temp.Text = "99°";
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cityOutput.Location = new System.Drawing.Point(111, 59);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(181, 45);
            this.cityOutput.TabIndex = 15;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.LimeGreen;
            this.date.Location = new System.Drawing.Point(117, 313);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(175, 23);
            this.date.TabIndex = 14;
            this.date.Text = "10-10-2020";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.date);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(410, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label date;
    }
}
