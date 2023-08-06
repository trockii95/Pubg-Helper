namespace HelperLooT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_logOut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_defTimezone = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_defLang = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio_net = new System.Windows.Forms.RadioButton();
            this.radio_da = new System.Windows.Forms.RadioButton();
            this.button_defSett = new System.Windows.Forms.Button();
            this.button_reboot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_chinaEvent = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_deinstallCN = new System.Windows.Forms.Button();
            this.button_installCN = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_logOut
            // 
            this.button_logOut.Location = new System.Drawing.Point(12, 630);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(200, 23);
            this.button_logOut.TabIndex = 9;
            this.button_logOut.Text = "Выход из системы";
            this.button_logOut.UseVisualStyleBackColor = true;
            this.button_logOut.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_defTimezone);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 52);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Часовой пояс";
            // 
            // comboBox_defTimezone
            // 
            this.comboBox_defTimezone.FormattingEnabled = true;
            this.comboBox_defTimezone.Location = new System.Drawing.Point(6, 20);
            this.comboBox_defTimezone.Name = "comboBox_defTimezone";
            this.comboBox_defTimezone.Size = new System.Drawing.Size(165, 21);
            this.comboBox_defTimezone.TabIndex = 0;
            this.comboBox_defTimezone.SelectedIndexChanged += new System.EventHandler(this.comboBox_defTimezone_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_defLang);
            this.groupBox4.Location = new System.Drawing.Point(6, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 51);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Язык системы";
            // 
            // comboBox_defLang
            // 
            this.comboBox_defLang.FormattingEnabled = true;
            this.comboBox_defLang.Items.AddRange(new object[] {
            "ru-RU",
            "en-US",
            "zh-CN"});
            this.comboBox_defLang.Location = new System.Drawing.Point(7, 20);
            this.comboBox_defLang.Name = "comboBox_defLang";
            this.comboBox_defLang.Size = new System.Drawing.Size(164, 21);
            this.comboBox_defLang.TabIndex = 0;
            this.comboBox_defLang.SelectedIndexChanged += new System.EventHandler(this.comboBox_defLang_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radio_net);
            this.groupBox5.Controls.Add(this.radio_da);
            this.groupBox5.Location = new System.Drawing.Point(6, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 56);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Удалить китайскую раскладку клавиатуры?";
            // 
            // radio_net
            // 
            this.radio_net.AutoSize = true;
            this.radio_net.Location = new System.Drawing.Point(50, 30);
            this.radio_net.Name = "radio_net";
            this.radio_net.Size = new System.Drawing.Size(44, 17);
            this.radio_net.TabIndex = 1;
            this.radio_net.TabStop = true;
            this.radio_net.Text = "Нет";
            this.radio_net.UseVisualStyleBackColor = true;
            this.radio_net.CheckedChanged += new System.EventHandler(this.radio_net_CheckedChanged);
            // 
            // radio_da
            // 
            this.radio_da.AutoSize = true;
            this.radio_da.Location = new System.Drawing.Point(6, 30);
            this.radio_da.Name = "radio_da";
            this.radio_da.Size = new System.Drawing.Size(37, 17);
            this.radio_da.TabIndex = 0;
            this.radio_da.TabStop = true;
            this.radio_da.Text = "да";
            this.radio_da.UseVisualStyleBackColor = true;
            this.radio_da.CheckedChanged += new System.EventHandler(this.radio_da_CheckedChanged);
            // 
            // button_defSett
            // 
            this.button_defSett.Location = new System.Drawing.Point(6, 196);
            this.button_defSett.Name = "button_defSett";
            this.button_defSett.Size = new System.Drawing.Size(185, 27);
            this.button_defSett.TabIndex = 13;
            this.button_defSett.Text = "Применить настройку";
            this.button_defSett.UseVisualStyleBackColor = true;
            this.button_defSett.Click += new System.EventHandler(this.button_defSett_Click);
            // 
            // button_reboot
            // 
            this.button_reboot.Location = new System.Drawing.Point(12, 660);
            this.button_reboot.Name = "button_reboot";
            this.button_reboot.Size = new System.Drawing.Size(200, 23);
            this.button_reboot.TabIndex = 17;
            this.button_reboot.Text = "Перезагрузка компа";
            this.button_reboot.UseVisualStyleBackColor = true;
            this.button_reboot.Click += new System.EventHandler(this.button_reboot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 96);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Русский шаблон системы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Системный язык русский\r\nЧасовой пояс (UTC+3) Москва\r\nКитайская раскладка удаляетс" +
    "я";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_chinaEvent);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 96);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Китайский шаблон системы";
            // 
            // btn_chinaEvent
            // 
            this.btn_chinaEvent.Location = new System.Drawing.Point(6, 19);
            this.btn_chinaEvent.Name = "btn_chinaEvent";
            this.btn_chinaEvent.Size = new System.Drawing.Size(185, 70);
            this.btn_chinaEvent.TabIndex = 0;
            this.btn_chinaEvent.Text = "Системный язык китайский\r\nЧасовой пояс (UTC+8) Гонг-Конг\r\nКитайская раскладка++";
            this.btn_chinaEvent.UseVisualStyleBackColor = true;
            this.btn_chinaEvent.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button_defSett);
            this.groupBox8.Controls.Add(this.groupBox3);
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Location = new System.Drawing.Point(12, 217);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 231);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Персональные настройки";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_deinstallCN);
            this.groupBox9.Controls.Add(this.button_installCN);
            this.groupBox9.Location = new System.Drawing.Point(12, 454);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(200, 54);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Китайский языковой пакет";
            // 
            // button_deinstallCN
            // 
            this.button_deinstallCN.Location = new System.Drawing.Point(99, 20);
            this.button_deinstallCN.Name = "button_deinstallCN";
            this.button_deinstallCN.Size = new System.Drawing.Size(92, 23);
            this.button_deinstallCN.TabIndex = 1;
            this.button_deinstallCN.Text = "Удалить";
            this.button_deinstallCN.UseVisualStyleBackColor = true;
            this.button_deinstallCN.Click += new System.EventHandler(this.button_deinstallCN_Click);
            // 
            // button_installCN
            // 
            this.button_installCN.Location = new System.Drawing.Point(6, 20);
            this.button_installCN.Name = "button_installCN";
            this.button_installCN.Size = new System.Drawing.Size(87, 23);
            this.button_installCN.TabIndex = 0;
            this.button_installCN.Text = "Установить";
            this.button_installCN.UseVisualStyleBackColor = true;
            this.button_installCN.Click += new System.EventHandler(this.button_installCN_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.button7);
            this.groupBox10.Controls.Add(this.button6);
            this.groupBox10.Controls.Add(this.button5);
            this.groupBox10.Location = new System.Drawing.Point(12, 515);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 109);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Нас можно найти здесь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сбер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2202 2063 1958 3923";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Создателю на печеньки:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(134, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Баха";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(75, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "GitHub";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Discord";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 696);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_reboot);
            this.Controls.Add(this.button_logOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(236, 735);
            this.MinimumSize = new System.Drawing.Size(236, 735);
            this.Name = "Form1";
            this.Text = "Helper Loot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_defTimezone;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_defLang;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio_net;
        private System.Windows.Forms.RadioButton radio_da;
        private System.Windows.Forms.Button button_defSett;
        private System.Windows.Forms.Button button_reboot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_chinaEvent;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button_deinstallCN;
        private System.Windows.Forms.Button button_installCN;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

