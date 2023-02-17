namespace Weather_2._0
{
    partial class Weather
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.city = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelContry = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelImage = new System.Windows.Forms.PictureBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.Label();
            this.labelFeelsLike = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // city
            // 
            this.city.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.city.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(292, 248);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(483, 33);
            this.city.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(486, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // labelContry
            // 
            this.labelContry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContry.AutoSize = true;
            this.labelContry.BackColor = System.Drawing.Color.Transparent;
            this.labelContry.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelContry.Location = new System.Drawing.Point(521, 108);
            this.labelContry.Name = "labelContry";
            this.labelContry.Size = new System.Drawing.Size(0, 29);
            this.labelContry.TabIndex = 2;
            this.labelContry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSunrise
            // 
            this.labelSunrise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelSunrise.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelSunrise.Location = new System.Drawing.Point(489, 467);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(0, 29);
            this.labelSunrise.TabIndex = 3;
            this.labelSunrise.Click += new System.EventHandler(this.label3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelImage
            // 
            this.labelImage.BackColor = System.Drawing.Color.Transparent;
            this.labelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.labelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelImage.Location = new System.Drawing.Point(0, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(1107, 47);
            this.labelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelImage.TabIndex = 4;
            this.labelImage.TabStop = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEnter.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEnter.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.Location = new System.Drawing.Point(486, 287);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(101, 42);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(389, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sunrise:";
            // 
            // labelSunset
            // 
            this.labelSunset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSunset.AutoSize = true;
            this.labelSunset.BackColor = System.Drawing.Color.Transparent;
            this.labelSunset.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelSunset.Location = new System.Drawing.Point(489, 506);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(0, 29);
            this.labelSunset.TabIndex = 7;
            this.labelSunset.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(389, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sunset:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wind Speed:";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelWindSpeed.Location = new System.Drawing.Point(148, 347);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(0, 29);
            this.labelWindSpeed.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(369, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperature:";
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelTemperature.Location = new System.Drawing.Point(520, 347);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(0, 29);
            this.labelTemperature.TabIndex = 12;
            // 
            // Fee
            // 
            this.Fee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fee.AutoSize = true;
            this.Fee.BackColor = System.Drawing.Color.Transparent;
            this.Fee.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Fee.Location = new System.Drawing.Point(768, 347);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(111, 29);
            this.Fee.TabIndex = 13;
            this.Fee.Text = "Feels Like:";
            // 
            // labelFeelsLike
            // 
            this.labelFeelsLike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFeelsLike.AutoSize = true;
            this.labelFeelsLike.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelsLike.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFeelsLike.Location = new System.Drawing.Point(885, 347);
            this.labelFeelsLike.Name = "labelFeelsLike";
            this.labelFeelsLike.Size = new System.Drawing.Size(0, 29);
            this.labelFeelsLike.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(279, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Humidity:";
            // 
            // labelHumidity
            // 
            this.labelHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelHumidity.Location = new System.Drawing.Point(390, 411);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(0, 29);
            this.labelHumidity.TabIndex = 16;
            this.labelHumidity.Click += new System.EventHandler(this.labelHumidity_Click);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(712, 411);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(0, 29);
            this.labelMain.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(640, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Main:";
            // 
            // Weather
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 641);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFeelsLike);
            this.Controls.Add(this.Fee);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWindSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.labelContry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.city);
            this.Name = "Weather";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labelImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelContry;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox labelImage;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label Fee;
        private System.Windows.Forms.Label labelFeelsLike;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label label8;
    }
}
