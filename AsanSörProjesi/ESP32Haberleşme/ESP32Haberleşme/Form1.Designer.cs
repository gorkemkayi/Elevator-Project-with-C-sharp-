namespace ESP32Haberleşme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSes = new System.Windows.Forms.Button();
            this.btnSus = new System.Windows.Forms.Button();
            this.lblBuzzer = new System.Windows.Forms.Label();
            this.Dondur = new System.Windows.Forms.Button();
            this.ortaDondur = new System.Windows.Forms.Button();
            this.hizliDondur = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.RevYavasDondur = new System.Windows.Forms.Button();
            this.revOrtaDondur = new System.Windows.Forms.Button();
            this.revHizliDondur = new System.Windows.Forms.Button();
            this.servoBtn = new System.Windows.Forms.Button();
            this.servoGeriBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seri Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.White;
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.ForeColor = System.Drawing.Color.Black;
            this.btnBaglan.Location = new System.Drawing.Point(150, 64);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(111, 34);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "BAŞLAT";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.White;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.ForeColor = System.Drawing.Color.Black;
            this.btnDurdur.Location = new System.Drawing.Point(269, 64);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(111, 34);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 60);
            this.progressBar1.Maximum = 4095;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(138, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Işık Şiddeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(729, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alarm Kontrol Paneli";
            // 
            // btnSes
            // 
            this.btnSes.BackColor = System.Drawing.Color.White;
            this.btnSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSes.ForeColor = System.Drawing.Color.Black;
            this.btnSes.Location = new System.Drawing.Point(-1, 3);
            this.btnSes.Name = "btnSes";
            this.btnSes.Size = new System.Drawing.Size(94, 32);
            this.btnSes.TabIndex = 8;
            this.btnSes.Text = "ÖTTÜR";
            this.btnSes.UseVisualStyleBackColor = false;
            this.btnSes.Click += new System.EventHandler(this.btnSes_Click);
            // 
            // btnSus
            // 
            this.btnSus.BackColor = System.Drawing.Color.White;
            this.btnSus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSus.ForeColor = System.Drawing.Color.Black;
            this.btnSus.Location = new System.Drawing.Point(99, 3);
            this.btnSus.Name = "btnSus";
            this.btnSus.Size = new System.Drawing.Size(109, 32);
            this.btnSus.TabIndex = 9;
            this.btnSus.Text = "SUSTUR";
            this.btnSus.UseVisualStyleBackColor = false;
            this.btnSus.Click += new System.EventHandler(this.btnSus_Click);
            // 
            // lblBuzzer
            // 
            this.lblBuzzer.AutoSize = true;
            this.lblBuzzer.BackColor = System.Drawing.Color.Red;
            this.lblBuzzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuzzer.ForeColor = System.Drawing.Color.White;
            this.lblBuzzer.Location = new System.Drawing.Point(12, 51);
            this.lblBuzzer.Name = "lblBuzzer";
            this.lblBuzzer.Size = new System.Drawing.Size(189, 29);
            this.lblBuzzer.TabIndex = 10;
            this.lblBuzzer.Text = "Buzzer Durumu";
            // 
            // Dondur
            // 
            this.Dondur.BackColor = System.Drawing.Color.White;
            this.Dondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dondur.ForeColor = System.Drawing.Color.Black;
            this.Dondur.Location = new System.Drawing.Point(6, 32);
            this.Dondur.Name = "Dondur";
            this.Dondur.Size = new System.Drawing.Size(257, 34);
            this.Dondur.TabIndex = 16;
            this.Dondur.Text = "Yavaş Hızda Çıakr";
            this.Dondur.UseVisualStyleBackColor = false;
            this.Dondur.Click += new System.EventHandler(this.Dondur_Click);
            // 
            // ortaDondur
            // 
            this.ortaDondur.BackColor = System.Drawing.Color.White;
            this.ortaDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ortaDondur.ForeColor = System.Drawing.Color.Black;
            this.ortaDondur.Location = new System.Drawing.Point(6, 72);
            this.ortaDondur.Name = "ortaDondur";
            this.ortaDondur.Size = new System.Drawing.Size(257, 34);
            this.ortaDondur.TabIndex = 17;
            this.ortaDondur.Text = "Orta Hızda Çıkar\r\n";
            this.ortaDondur.UseVisualStyleBackColor = false;
            this.ortaDondur.Click += new System.EventHandler(this.ortaDondur_Click);
            // 
            // hizliDondur
            // 
            this.hizliDondur.BackColor = System.Drawing.Color.White;
            this.hizliDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hizliDondur.ForeColor = System.Drawing.Color.Black;
            this.hizliDondur.Location = new System.Drawing.Point(6, 111);
            this.hizliDondur.Name = "hizliDondur";
            this.hizliDondur.Size = new System.Drawing.Size(257, 33);
            this.hizliDondur.TabIndex = 18;
            this.hizliDondur.Text = "Hızlı Çıkar";
            this.hizliDondur.UseVisualStyleBackColor = false;
            this.hizliDondur.Click += new System.EventHandler(this.hizliDondur_Click);
            // 
            // durdur
            // 
            this.durdur.BackColor = System.Drawing.Color.White;
            this.durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdur.ForeColor = System.Drawing.Color.Black;
            this.durdur.Location = new System.Drawing.Point(12, 32);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(202, 33);
            this.durdur.TabIndex = 19;
            this.durdur.Text = "Asansörü Durdur";
            this.durdur.UseVisualStyleBackColor = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // RevYavasDondur
            // 
            this.RevYavasDondur.BackColor = System.Drawing.Color.White;
            this.RevYavasDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RevYavasDondur.ForeColor = System.Drawing.Color.Black;
            this.RevYavasDondur.Location = new System.Drawing.Point(13, 32);
            this.RevYavasDondur.Name = "RevYavasDondur";
            this.RevYavasDondur.Size = new System.Drawing.Size(237, 34);
            this.RevYavasDondur.TabIndex = 20;
            this.RevYavasDondur.Text = "Yavaş Hızda İndir";
            this.RevYavasDondur.UseVisualStyleBackColor = false;
            this.RevYavasDondur.Click += new System.EventHandler(this.RevYavasDondur_Click);
            // 
            // revOrtaDondur
            // 
            this.revOrtaDondur.BackColor = System.Drawing.Color.White;
            this.revOrtaDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.revOrtaDondur.ForeColor = System.Drawing.Color.Black;
            this.revOrtaDondur.Location = new System.Drawing.Point(13, 72);
            this.revOrtaDondur.Name = "revOrtaDondur";
            this.revOrtaDondur.Size = new System.Drawing.Size(237, 34);
            this.revOrtaDondur.TabIndex = 21;
            this.revOrtaDondur.Text = "Orta Hızda İndir";
            this.revOrtaDondur.UseVisualStyleBackColor = false;
            this.revOrtaDondur.Click += new System.EventHandler(this.revOrtaDondur_Click);
            // 
            // revHizliDondur
            // 
            this.revHizliDondur.BackColor = System.Drawing.Color.White;
            this.revHizliDondur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.revHizliDondur.ForeColor = System.Drawing.Color.Black;
            this.revHizliDondur.Location = new System.Drawing.Point(13, 111);
            this.revHizliDondur.Name = "revHizliDondur";
            this.revHizliDondur.Size = new System.Drawing.Size(237, 34);
            this.revHizliDondur.TabIndex = 22;
            this.revHizliDondur.Text = "Hızlı İndir";
            this.revHizliDondur.UseVisualStyleBackColor = false;
            this.revHizliDondur.Click += new System.EventHandler(this.revHizliDondur_Click);
            // 
            // servoBtn
            // 
            this.servoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.servoBtn.Location = new System.Drawing.Point(0, 32);
            this.servoBtn.Name = "servoBtn";
            this.servoBtn.Size = new System.Drawing.Size(123, 38);
            this.servoBtn.TabIndex = 23;
            this.servoBtn.Text = "Kapıyı Aç";
            this.servoBtn.UseVisualStyleBackColor = true;
            this.servoBtn.Click += new System.EventHandler(this.servoBtn_Click);
            this.servoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.servoBtn_MouseDown);
            this.servoBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.servoBtn_MouseUp);
            // 
            // servoGeriBtn
            // 
            this.servoGeriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.servoGeriBtn.Location = new System.Drawing.Point(123, 32);
            this.servoGeriBtn.Name = "servoGeriBtn";
            this.servoGeriBtn.Size = new System.Drawing.Size(123, 38);
            this.servoGeriBtn.TabIndex = 24;
            this.servoGeriBtn.Text = "Kapıyı Kapat";
            this.servoGeriBtn.UseVisualStyleBackColor = true;
            this.servoGeriBtn.Click += new System.EventHandler(this.servoGeriBtn_Click);
            this.servoGeriBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.servoGeriBtn_MouseDown);
            this.servoGeriBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.servoGeriBtn_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(101, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Asansör Kontrol Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Dondur);
            this.panel1.Controls.Add(this.hizliDondur);
            this.panel1.Controls.Add(this.ortaDondur);
            this.panel1.Location = new System.Drawing.Point(2, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 152);
            this.panel1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yukarı Yönde Kontrol";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.revHizliDondur);
            this.panel2.Controls.Add(this.RevYavasDondur);
            this.panel2.Controls.Add(this.revOrtaDondur);
            this.panel2.Location = new System.Drawing.Point(284, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 152);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aşağı Yönde Kontrol";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.durdur);
            this.panel3.Location = new System.Drawing.Point(151, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 86);
            this.panel3.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Asansörü Durdur";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(781, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 86);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.btnSes);
            this.panel5.Controls.Add(this.btnSus);
            this.panel5.Controls.Add(this.lblBuzzer);
            this.panel5.Location = new System.Drawing.Point(764, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 80);
            this.panel5.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kapı Kontrol Paneli";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.servoBtn);
            this.panel6.Controls.Add(this.servoGeriBtn);
            this.panel6.Location = new System.Drawing.Point(734, 306);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 74);
            this.panel6.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ESP32Haberleşme.Properties.Resources.cark1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 492);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSes;
        private System.Windows.Forms.Button btnSus;
        private System.Windows.Forms.Label lblBuzzer;
        private System.Windows.Forms.Button Dondur;
        private System.Windows.Forms.Button ortaDondur;
        private System.Windows.Forms.Button hizliDondur;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button RevYavasDondur;
        private System.Windows.Forms.Button revOrtaDondur;
        private System.Windows.Forms.Button revHizliDondur;
        private System.Windows.Forms.Button servoBtn;
        private System.Windows.Forms.Button servoGeriBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
    }
}

