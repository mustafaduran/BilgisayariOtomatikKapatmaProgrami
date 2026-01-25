namespace BilgisayariOtomatikKapatmaProgrami
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            shutdown_btn = new Button();
            restart_btn = new Button();
            singout_btn = new Button();
            lock_btn = new Button();
            sleep_btn = new Button();
            alarm_btn = new Button();
            selectTimeGB = new GroupBox();
            secondLbl = new Label();
            minuteLbl = new Label();
            hourLbl = new Label();
            dayLbl = new Label();
            day_input = new NumericUpDown();
            second_input = new NumericUpDown();
            minute_input = new NumericUpDown();
            clock_input = new NumericUpDown();
            selectModeGB = new GroupBox();
            time_lbl = new Label();
            progressBar = new ProgressBar();
            stop_start_btn = new Button();
            cancel_btn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            countDownGB = new GroupBox();
            setting_btn = new Button();
            selectTimeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)day_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)second_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minute_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clock_input).BeginInit();
            selectModeGB.SuspendLayout();
            countDownGB.SuspendLayout();
            SuspendLayout();
            // 
            // shutdown_btn
            // 
            shutdown_btn.Location = new Point(7, 16);
            shutdown_btn.Name = "shutdown_btn";
            shutdown_btn.Size = new Size(100, 100);
            shutdown_btn.TabIndex = 0;
            shutdown_btn.Text = "Kapat";
            shutdown_btn.UseVisualStyleBackColor = true;
            shutdown_btn.Click += shutdown_btn_Click;
            // 
            // restart_btn
            // 
            restart_btn.Location = new Point(113, 16);
            restart_btn.Name = "restart_btn";
            restart_btn.Size = new Size(100, 100);
            restart_btn.TabIndex = 1;
            restart_btn.Text = "Yeniden Başlat";
            restart_btn.UseVisualStyleBackColor = true;
            restart_btn.Click += restart_btn_Click;
            // 
            // singout_btn
            // 
            singout_btn.Location = new Point(6, 122);
            singout_btn.Name = "singout_btn";
            singout_btn.Size = new Size(100, 100);
            singout_btn.TabIndex = 2;
            singout_btn.Text = "Oturumu Kapat";
            singout_btn.UseVisualStyleBackColor = true;
            singout_btn.Click += singout_btn_Click;
            // 
            // lock_btn
            // 
            lock_btn.Location = new Point(112, 122);
            lock_btn.Name = "lock_btn";
            lock_btn.Size = new Size(100, 100);
            lock_btn.TabIndex = 3;
            lock_btn.Text = "Oturumu Kilitle";
            lock_btn.UseVisualStyleBackColor = true;
            lock_btn.Click += lock_btn_Click;
            // 
            // sleep_btn
            // 
            sleep_btn.Location = new Point(219, 16);
            sleep_btn.Name = "sleep_btn";
            sleep_btn.Size = new Size(100, 100);
            sleep_btn.TabIndex = 4;
            sleep_btn.Text = "Uyku";
            sleep_btn.UseVisualStyleBackColor = true;
            sleep_btn.Click += sleep_btn_Click;
            // 
            // alarm_btn
            // 
            alarm_btn.Location = new Point(219, 122);
            alarm_btn.Name = "alarm_btn";
            alarm_btn.Size = new Size(100, 100);
            alarm_btn.TabIndex = 5;
            alarm_btn.Text = "Alarm Kur";
            alarm_btn.UseVisualStyleBackColor = true;
            alarm_btn.Click += alarm_btn_Click;
            // 
            // selectTimeGB
            // 
            selectTimeGB.Controls.Add(secondLbl);
            selectTimeGB.Controls.Add(minuteLbl);
            selectTimeGB.Controls.Add(hourLbl);
            selectTimeGB.Controls.Add(dayLbl);
            selectTimeGB.Controls.Add(day_input);
            selectTimeGB.Controls.Add(second_input);
            selectTimeGB.Controls.Add(minute_input);
            selectTimeGB.Controls.Add(clock_input);
            selectTimeGB.Location = new Point(6, 32);
            selectTimeGB.Name = "selectTimeGB";
            selectTimeGB.Size = new Size(325, 87);
            selectTimeGB.TabIndex = 6;
            selectTimeGB.TabStop = false;
            selectTimeGB.Text = "Süre Ayarla";
            // 
            // secondLbl
            // 
            secondLbl.Location = new Point(253, 22);
            secondLbl.Name = "secondLbl";
            secondLbl.Size = new Size(66, 15);
            secondLbl.TabIndex = 7;
            secondLbl.Text = "Saniye";
            secondLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // minuteLbl
            // 
            minuteLbl.Location = new Point(170, 22);
            minuteLbl.Name = "minuteLbl";
            minuteLbl.Size = new Size(66, 15);
            minuteLbl.TabIndex = 6;
            minuteLbl.Text = "Dakika";
            minuteLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // hourLbl
            // 
            hourLbl.Location = new Point(89, 22);
            hourLbl.Name = "hourLbl";
            hourLbl.Size = new Size(66, 15);
            hourLbl.TabIndex = 5;
            hourLbl.Text = "Saat";
            hourLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // dayLbl
            // 
            dayLbl.Location = new Point(6, 22);
            dayLbl.Name = "dayLbl";
            dayLbl.Size = new Size(66, 15);
            dayLbl.TabIndex = 4;
            dayLbl.Text = "Gün";
            dayLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // day_input
            // 
            day_input.Font = new Font("Segoe UI", 15F);
            day_input.Location = new Point(7, 40);
            day_input.Name = "day_input";
            day_input.Size = new Size(65, 34);
            day_input.TabIndex = 3;
            // 
            // second_input
            // 
            second_input.Font = new Font("Segoe UI", 15F);
            second_input.Location = new Point(253, 40);
            second_input.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            second_input.Name = "second_input";
            second_input.Size = new Size(65, 34);
            second_input.TabIndex = 2;
            // 
            // minute_input
            // 
            minute_input.Font = new Font("Segoe UI", 15F);
            minute_input.Location = new Point(171, 40);
            minute_input.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minute_input.Name = "minute_input";
            minute_input.Size = new Size(65, 34);
            minute_input.TabIndex = 1;
            // 
            // clock_input
            // 
            clock_input.Font = new Font("Segoe UI", 15F);
            clock_input.Location = new Point(89, 40);
            clock_input.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            clock_input.Name = "clock_input";
            clock_input.Size = new Size(65, 34);
            clock_input.TabIndex = 0;
            // 
            // selectModeGB
            // 
            selectModeGB.Controls.Add(shutdown_btn);
            selectModeGB.Controls.Add(lock_btn);
            selectModeGB.Controls.Add(restart_btn);
            selectModeGB.Controls.Add(singout_btn);
            selectModeGB.Controls.Add(alarm_btn);
            selectModeGB.Controls.Add(sleep_btn);
            selectModeGB.Location = new Point(6, 122);
            selectModeGB.Name = "selectModeGB";
            selectModeGB.Size = new Size(325, 231);
            selectModeGB.TabIndex = 7;
            selectModeGB.TabStop = false;
            selectModeGB.Text = "İşlevler";
            // 
            // time_lbl
            // 
            time_lbl.BackColor = Color.Silver;
            time_lbl.Font = new Font("Segoe UI", 30F);
            time_lbl.Location = new Point(5, 17);
            time_lbl.Name = "time_lbl";
            time_lbl.Size = new Size(270, 60);
            time_lbl.TabIndex = 8;
            time_lbl.Text = "0 00:00:00";
            time_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(5, 75);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(270, 1);
            progressBar.TabIndex = 9;
            // 
            // stop_start_btn
            // 
            stop_start_btn.FlatStyle = FlatStyle.Flat;
            stop_start_btn.Font = new Font("Segoe UI", 11F);
            stop_start_btn.Location = new Point(280, 16);
            stop_start_btn.Name = "stop_start_btn";
            stop_start_btn.Size = new Size(30, 30);
            stop_start_btn.TabIndex = 11;
            stop_start_btn.Text = "⏸";
            stop_start_btn.UseVisualStyleBackColor = true;
            stop_start_btn.Click += stop_start_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Segoe UI", 11F);
            cancel_btn.Location = new Point(280, 47);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(30, 30);
            cancel_btn.TabIndex = 12;
            cancel_btn.Text = "⏹";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // countDownGB
            // 
            countDownGB.Controls.Add(cancel_btn);
            countDownGB.Controls.Add(progressBar);
            countDownGB.Controls.Add(stop_start_btn);
            countDownGB.Controls.Add(time_lbl);
            countDownGB.Enabled = false;
            countDownGB.Location = new Point(6, 359);
            countDownGB.Name = "countDownGB";
            countDownGB.Size = new Size(318, 81);
            countDownGB.TabIndex = 13;
            countDownGB.TabStop = false;
            countDownGB.Text = "Geri Sayım";
            // 
            // setting_btn
            // 
            setting_btn.FlatAppearance.BorderSize = 0;
            setting_btn.FlatStyle = FlatStyle.Flat;
            setting_btn.Font = new Font("Segoe UI", 12F);
            setting_btn.Location = new Point(6, 1);
            setting_btn.Name = "setting_btn";
            setting_btn.Size = new Size(30, 30);
            setting_btn.TabIndex = 14;
            setting_btn.Text = "⚙";
            setting_btn.UseVisualStyleBackColor = true;
            setting_btn.Click += setting_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 440);
            Controls.Add(setting_btn);
            Controls.Add(countDownGB);
            Controls.Add(selectModeGB);
            Controls.Add(selectTimeGB);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgisayarı Otomatik Kapatma Programı V3";
            selectTimeGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)day_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)second_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)minute_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)clock_input).EndInit();
            selectModeGB.ResumeLayout(false);
            countDownGB.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label time_lbl;
        private ProgressBar progressBar;
        private Button stop_start_btn;
        private Button cancel_btn;
        private System.Windows.Forms.Timer timer1;
        public NumericUpDown day_input;
        public NumericUpDown second_input;
        public NumericUpDown minute_input;
        public NumericUpDown clock_input;
        private Button setting_btn;
        public Button shutdown_btn;
        public Button restart_btn;
        public Button singout_btn;
        public Button lock_btn;
        public Button sleep_btn;
        public Button alarm_btn;
        public GroupBox selectTimeGB;
        public GroupBox selectModeGB;
        public Label minuteLbl;
        public Label hourLbl;
        public Label dayLbl;
        public Label secondLbl;
        public GroupBox countDownGB;
    }
}
