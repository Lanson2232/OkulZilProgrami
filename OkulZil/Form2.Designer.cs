namespace OkulZil
{
    partial class generalSettings
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
            this.studentAlertChoose = new System.Windows.Forms.Button();
            this.studentAlert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherAlert = new System.Windows.Forms.TextBox();
            this.teacherAlertChoose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exitAlert = new System.Windows.Forms.TextBox();
            this.exitAlertChoose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.marchAlert = new System.Windows.Forms.TextBox();
            this.marchAlertChoose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.respectAlert = new System.Windows.Forms.TextBox();
            this.respectAlertChoose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sirenAlert = new System.Windows.Forms.TextBox();
            this.sirenAlertChoose = new System.Windows.Forms.Button();
            this.sirenVolume = new System.Windows.Forms.NumericUpDown();
            this.respectVolume = new System.Windows.Forms.NumericUpDown();
            this.marchVolume = new System.Windows.Forms.NumericUpDown();
            this.exitVolume = new System.Windows.Forms.NumericUpDown();
            this.teacherVolume = new System.Windows.Forms.NumericUpDown();
            this.studentVolume = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sirenVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.respectVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // studentAlertChoose
            // 
            this.studentAlertChoose.Location = new System.Drawing.Point(12, 12);
            this.studentAlertChoose.Name = "studentAlertChoose";
            this.studentAlertChoose.Size = new System.Drawing.Size(103, 23);
            this.studentAlertChoose.TabIndex = 0;
            this.studentAlertChoose.Text = "Öğrenci Zil Sesi";
            this.studentAlertChoose.UseVisualStyleBackColor = true;
            this.studentAlertChoose.Click += new System.EventHandler(this.studentAlertChoose_Click);
            // 
            // studentAlert
            // 
            this.studentAlert.Enabled = false;
            this.studentAlert.Location = new System.Drawing.Point(122, 13);
            this.studentAlert.Name = "studentAlert";
            this.studentAlert.Size = new System.Drawing.Size(204, 20);
            this.studentAlert.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ses Düzeyi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(445, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(445, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ses Düzeyi :";
            // 
            // teacherAlert
            // 
            this.teacherAlert.Enabled = false;
            this.teacherAlert.Location = new System.Drawing.Point(122, 42);
            this.teacherAlert.Name = "teacherAlert";
            this.teacherAlert.Size = new System.Drawing.Size(204, 20);
            this.teacherAlert.TabIndex = 7;
            this.teacherAlert.TextChanged += new System.EventHandler(this.teacherAlert_TextChanged);
            // 
            // teacherAlertChoose
            // 
            this.teacherAlertChoose.Location = new System.Drawing.Point(12, 41);
            this.teacherAlertChoose.Name = "teacherAlertChoose";
            this.teacherAlertChoose.Size = new System.Drawing.Size(103, 23);
            this.teacherAlertChoose.TabIndex = 6;
            this.teacherAlertChoose.Text = "Öğretmen Zil Sesi";
            this.teacherAlertChoose.UseVisualStyleBackColor = true;
            this.teacherAlertChoose.Click += new System.EventHandler(this.teacherAlertChoose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(445, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ses Düzeyi :";
            // 
            // exitAlert
            // 
            this.exitAlert.Enabled = false;
            this.exitAlert.Location = new System.Drawing.Point(122, 71);
            this.exitAlert.Name = "exitAlert";
            this.exitAlert.Size = new System.Drawing.Size(204, 20);
            this.exitAlert.TabIndex = 13;
            // 
            // exitAlertChoose
            // 
            this.exitAlertChoose.Location = new System.Drawing.Point(12, 70);
            this.exitAlertChoose.Name = "exitAlertChoose";
            this.exitAlertChoose.Size = new System.Drawing.Size(103, 23);
            this.exitAlertChoose.TabIndex = 12;
            this.exitAlertChoose.Text = "Çıkış Zil Sesi";
            this.exitAlertChoose.UseVisualStyleBackColor = true;
            this.exitAlertChoose.Click += new System.EventHandler(this.exitAlertChoose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(445, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ses Düzeyi :";
            // 
            // marchAlert
            // 
            this.marchAlert.Enabled = false;
            this.marchAlert.Location = new System.Drawing.Point(122, 135);
            this.marchAlert.Name = "marchAlert";
            this.marchAlert.Size = new System.Drawing.Size(204, 20);
            this.marchAlert.TabIndex = 19;
            // 
            // marchAlertChoose
            // 
            this.marchAlertChoose.Location = new System.Drawing.Point(12, 134);
            this.marchAlertChoose.Name = "marchAlertChoose";
            this.marchAlertChoose.Size = new System.Drawing.Size(103, 23);
            this.marchAlertChoose.TabIndex = 18;
            this.marchAlertChoose.Text = "İstiklal Marşı";
            this.marchAlertChoose.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(445, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ses Düzeyi :";
            // 
            // respectAlert
            // 
            this.respectAlert.Enabled = false;
            this.respectAlert.Location = new System.Drawing.Point(122, 164);
            this.respectAlert.Name = "respectAlert";
            this.respectAlert.Size = new System.Drawing.Size(204, 20);
            this.respectAlert.TabIndex = 25;
            // 
            // respectAlertChoose
            // 
            this.respectAlertChoose.Location = new System.Drawing.Point(12, 163);
            this.respectAlertChoose.Name = "respectAlertChoose";
            this.respectAlertChoose.Size = new System.Drawing.Size(103, 23);
            this.respectAlertChoose.TabIndex = 24;
            this.respectAlertChoose.Text = "Saygı Duruşu";
            this.respectAlertChoose.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(445, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ses Düzeyi :";
            // 
            // sirenAlert
            // 
            this.sirenAlert.Enabled = false;
            this.sirenAlert.Location = new System.Drawing.Point(122, 193);
            this.sirenAlert.Name = "sirenAlert";
            this.sirenAlert.Size = new System.Drawing.Size(204, 20);
            this.sirenAlert.TabIndex = 31;
            // 
            // sirenAlertChoose
            // 
            this.sirenAlertChoose.Location = new System.Drawing.Point(12, 192);
            this.sirenAlertChoose.Name = "sirenAlertChoose";
            this.sirenAlertChoose.Size = new System.Drawing.Size(103, 23);
            this.sirenAlertChoose.TabIndex = 30;
            this.sirenAlertChoose.Text = "Siren";
            this.sirenAlertChoose.UseVisualStyleBackColor = true;
            this.sirenAlertChoose.Click += new System.EventHandler(this.sirenAlertChoose_Click);
            // 
            // sirenVolume
            // 
            this.sirenVolume.Location = new System.Drawing.Point(400, 194);
            this.sirenVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sirenVolume.Name = "sirenVolume";
            this.sirenVolume.Size = new System.Drawing.Size(39, 20);
            this.sirenVolume.TabIndex = 36;
            this.sirenVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // respectVolume
            // 
            this.respectVolume.Location = new System.Drawing.Point(400, 165);
            this.respectVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.respectVolume.Name = "respectVolume";
            this.respectVolume.Size = new System.Drawing.Size(39, 20);
            this.respectVolume.TabIndex = 37;
            this.respectVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // marchVolume
            // 
            this.marchVolume.Location = new System.Drawing.Point(400, 135);
            this.marchVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.marchVolume.Name = "marchVolume";
            this.marchVolume.Size = new System.Drawing.Size(39, 20);
            this.marchVolume.TabIndex = 38;
            this.marchVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // exitVolume
            // 
            this.exitVolume.Location = new System.Drawing.Point(400, 70);
            this.exitVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.exitVolume.Name = "exitVolume";
            this.exitVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitVolume.Size = new System.Drawing.Size(39, 20);
            this.exitVolume.TabIndex = 39;
            this.exitVolume.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.exitVolume.ValueChanged += new System.EventHandler(this.exitVolume_ValueChanged);
            // 
            // teacherVolume
            // 
            this.teacherVolume.Location = new System.Drawing.Point(400, 43);
            this.teacherVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.teacherVolume.Name = "teacherVolume";
            this.teacherVolume.Size = new System.Drawing.Size(39, 20);
            this.teacherVolume.TabIndex = 40;
            this.teacherVolume.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.teacherVolume.ValueChanged += new System.EventHandler(this.teacherVolume_ValueChanged);
            // 
            // studentVolume
            // 
            this.studentVolume.Location = new System.Drawing.Point(400, 14);
            this.studentVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.studentVolume.Name = "studentVolume";
            this.studentVolume.Size = new System.Drawing.Size(39, 20);
            this.studentVolume.TabIndex = 41;
            this.studentVolume.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.studentVolume.ValueChanged += new System.EventHandler(this.studentVolume_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(284, 26);
            this.label13.TabIndex = 42;
            this.label13.Text = "Ses düzeyi değişikliğinden sonra lütfen ayarları kaydediniz.\r\nSes dosyası değişik" +
    "likleri otomatik olarak kayıt edilmektedir.";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(335, 329);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 23);
            this.saveButton.TabIndex = 43;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generalSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 361);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.studentVolume);
            this.Controls.Add(this.teacherVolume);
            this.Controls.Add(this.exitVolume);
            this.Controls.Add(this.marchVolume);
            this.Controls.Add(this.respectVolume);
            this.Controls.Add(this.sirenVolume);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sirenAlert);
            this.Controls.Add(this.sirenAlertChoose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.respectAlert);
            this.Controls.Add(this.respectAlertChoose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.marchAlert);
            this.Controls.Add(this.marchAlertChoose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitAlert);
            this.Controls.Add(this.exitAlertChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherAlert);
            this.Controls.Add(this.teacherAlertChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentAlert);
            this.Controls.Add(this.studentAlertChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "generalSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.audioSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sirenVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.respectVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentAlertChoose;
        private System.Windows.Forms.TextBox studentAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherAlert;
        private System.Windows.Forms.Button teacherAlertChoose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox exitAlert;
        private System.Windows.Forms.Button exitAlertChoose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox marchAlert;
        private System.Windows.Forms.Button marchAlertChoose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox respectAlert;
        private System.Windows.Forms.Button respectAlertChoose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sirenAlert;
        private System.Windows.Forms.Button sirenAlertChoose;
        private System.Windows.Forms.NumericUpDown sirenVolume;
        private System.Windows.Forms.NumericUpDown respectVolume;
        private System.Windows.Forms.NumericUpDown marchVolume;
        private System.Windows.Forms.NumericUpDown exitVolume;
        private System.Windows.Forms.NumericUpDown teacherVolume;
        private System.Windows.Forms.NumericUpDown studentVolume;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button saveButton;
    }
}