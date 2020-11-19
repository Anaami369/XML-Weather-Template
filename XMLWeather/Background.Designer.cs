namespace XMLWeather
{
    partial class Background
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
            this.forecastButton = new System.Windows.Forms.Button();
            this.currentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastButton
            // 
            this.forecastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.forecastButton.Location = new System.Drawing.Point(43, 278);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(107, 53);
            this.forecastButton.TabIndex = 0;
            this.forecastButton.Text = "Forecast";
            this.forecastButton.UseVisualStyleBackColor = true;
            this.forecastButton.Click += new System.EventHandler(this.forecastButton_Click);
            // 
            // currentButton
            // 
            this.currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.currentButton.Location = new System.Drawing.Point(267, 278);
            this.currentButton.Name = "currentButton";
            this.currentButton.Size = new System.Drawing.Size(107, 53);
            this.currentButton.TabIndex = 1;
            this.currentButton.Text = "Current";
            this.currentButton.UseVisualStyleBackColor = true;
            this.currentButton.Click += new System.EventHandler(this.currentButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the Tsunami network";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.sunny;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentButton);
            this.Controls.Add(this.forecastButton);
            this.Name = "Background";
            this.Size = new System.Drawing.Size(410, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forecastButton;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Label label1;
    }
}
