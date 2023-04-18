namespace WeatherApp
{
    partial class ForecastScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentTemp = new System.Windows.Forms.Label();
            this.weatherImage = new System.Windows.Forms.PictureBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.celciusLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Ivory;
            this.cityOutput.Location = new System.Drawing.Point(8, 58);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(203, 40);
            this.cityOutput.TabIndex = 1;
            this.cityOutput.Text = "City";
            // 
            // currentTemp
            // 
            this.currentTemp.BackColor = System.Drawing.Color.Transparent;
            this.currentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemp.ForeColor = System.Drawing.Color.Ivory;
            this.currentTemp.Location = new System.Drawing.Point(-4, 127);
            this.currentTemp.Name = "currentTemp";
            this.currentTemp.Size = new System.Drawing.Size(163, 143);
            this.currentTemp.TabIndex = 2;
            this.currentTemp.Text = "11";
            // 
            // weatherImage
            // 
            this.weatherImage.BackColor = System.Drawing.Color.Transparent;
            this.weatherImage.InitialImage = null;
            this.weatherImage.Location = new System.Drawing.Point(224, 20);
            this.weatherImage.Name = "weatherImage";
            this.weatherImage.Size = new System.Drawing.Size(250, 250);
            this.weatherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherImage.TabIndex = 3;
            this.weatherImage.TabStop = false;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.Ivory;
            this.maxLabel.Location = new System.Drawing.Point(122, 374);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(48, 40);
            this.maxLabel.TabIndex = 37;
            this.maxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Ivory;
            this.minLabel.Location = new System.Drawing.Point(122, 435);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(50, 40);
            this.minLabel.TabIndex = 35;
            this.minLabel.Text = "min";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(8, 15);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(193, 43);
            this.dateLabel.TabIndex = 45;
            this.dateLabel.Text = "Date";
            // 
            // highLabel
            // 
            this.highLabel.BackColor = System.Drawing.Color.Transparent;
            this.highLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLabel.ForeColor = System.Drawing.Color.Ivory;
            this.highLabel.Location = new System.Drawing.Point(7, 363);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(108, 64);
            this.highLabel.TabIndex = 46;
            this.highLabel.Text = "High";
            // 
            // degreeLabel
            // 
            this.degreeLabel.BackColor = System.Drawing.Color.Transparent;
            this.degreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeLabel.ForeColor = System.Drawing.Color.Ivory;
            this.degreeLabel.Location = new System.Drawing.Point(114, 122);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(41, 39);
            this.degreeLabel.TabIndex = 47;
            this.degreeLabel.Text = "°";
            this.degreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // celciusLabel
            // 
            this.celciusLabel.BackColor = System.Drawing.Color.Transparent;
            this.celciusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celciusLabel.ForeColor = System.Drawing.Color.Ivory;
            this.celciusLabel.Location = new System.Drawing.Point(144, 135);
            this.celciusLabel.Name = "celciusLabel";
            this.celciusLabel.Size = new System.Drawing.Size(74, 100);
            this.celciusLabel.TabIndex = 48;
            this.celciusLabel.Text = "C";
            this.celciusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.Ivory;
            this.conditionLabel.Location = new System.Drawing.Point(6, 287);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(466, 60);
            this.conditionLabel.TabIndex = 49;
            this.conditionLabel.Text = "Condition";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lowLabel
            // 
            this.lowLabel.BackColor = System.Drawing.Color.Transparent;
            this.lowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowLabel.ForeColor = System.Drawing.Color.Ivory;
            this.lowLabel.Location = new System.Drawing.Point(7, 424);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(108, 64);
            this.lowLabel.TabIndex = 50;
            this.lowLabel.Text = "Low";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.celciusLabel);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.weatherImage);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.currentTemp);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(500, 600);
            ((System.ComponentModel.ISupportInitialize)(this.weatherImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentTemp;
        private System.Windows.Forms.PictureBox weatherImage;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label degreeLabel;
        private System.Windows.Forms.Label celciusLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label lowLabel;
    }
}
