namespace BilgisayariOtomatikKapatmaProgrami
{
    partial class SettingsForm
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
            languageGB = new GroupBox();
            languageCmbBox = new ComboBox();
            alarmGB = new GroupBox();
            playBtn = new Button();
            alarmCmbBox = new ComboBox();
            saveBtn = new Button();
            checkBox1 = new CheckBox();
            languageGB.SuspendLayout();
            alarmGB.SuspendLayout();
            SuspendLayout();
            // 
            // languageGB
            // 
            languageGB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            languageGB.Controls.Add(languageCmbBox);
            languageGB.Location = new Point(4, 3);
            languageGB.Name = "languageGB";
            languageGB.Size = new Size(180, 44);
            languageGB.TabIndex = 0;
            languageGB.TabStop = false;
            languageGB.Text = "Dil";
            // 
            // languageCmbBox
            // 
            languageCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            languageCmbBox.FormattingEnabled = true;
            languageCmbBox.Items.AddRange(new object[] { "TR", "EN", "DE" });
            languageCmbBox.Location = new Point(0, 17);
            languageCmbBox.Name = "languageCmbBox";
            languageCmbBox.Size = new Size(179, 23);
            languageCmbBox.TabIndex = 1;
            // 
            // alarmGB
            // 
            alarmGB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            alarmGB.Controls.Add(playBtn);
            alarmGB.Controls.Add(alarmCmbBox);
            alarmGB.Location = new Point(4, 49);
            alarmGB.Name = "alarmGB";
            alarmGB.Size = new Size(180, 44);
            alarmGB.TabIndex = 2;
            alarmGB.TabStop = false;
            alarmGB.Text = "Alarm";
            // 
            // playBtn
            // 
            playBtn.FlatStyle = FlatStyle.Flat;
            playBtn.Location = new Point(150, 17);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(29, 23);
            playBtn.TabIndex = 2;
            playBtn.Text = "▶";
            playBtn.UseVisualStyleBackColor = true;
            playBtn.Click += playBtn_Click;
            // 
            // alarmCmbBox
            // 
            alarmCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            alarmCmbBox.FormattingEnabled = true;
            alarmCmbBox.Location = new Point(0, 17);
            alarmCmbBox.Name = "alarmCmbBox";
            alarmCmbBox.Size = new Size(148, 23);
            alarmCmbBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(4, 120);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(180, 40);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Kaydet";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Zaman ayarlarını kaydet";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 163);
            Controls.Add(checkBox1);
            Controls.Add(saveBtn);
            Controls.Add(alarmGB);
            Controls.Add(languageGB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ayalar";
            Load += SettingsForm_Load;
            languageGB.ResumeLayout(false);
            alarmGB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox languageCmbBox;
        private ComboBox alarmCmbBox;
        private Button playBtn;
        public GroupBox languageGB;
        public GroupBox alarmGB;
        public Button saveBtn;
        public CheckBox checkBox1;
    }
}