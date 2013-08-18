namespace rcc
{
    partial class f_setting
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
            this.b_setting_ok = new System.Windows.Forms.Button();
            this.b_setting_cancel = new System.Windows.Forms.Button();
            this.tc_setting = new System.Windows.Forms.TabControl();
            this.tp_internet = new System.Windows.Forms.TabPage();
            this.tb_reserve_internet = new System.Windows.Forms.TextBox();
            this.l_reserve_internet = new System.Windows.Forms.Label();
            this.tb_primary_internet = new System.Windows.Forms.TextBox();
            this.l_primary_internet = new System.Windows.Forms.Label();
            this.tp_1c = new System.Windows.Forms.TabPage();
            this.cb_close_monitoring = new System.Windows.Forms.CheckBox();
            this.cb_close_1c = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_restart_explorer = new System.Windows.Forms.CheckBox();
            this.tc_setting.SuspendLayout();
            this.tp_internet.SuspendLayout();
            this.tp_1c.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_setting_ok
            // 
            this.b_setting_ok.Location = new System.Drawing.Point(416, 327);
            this.b_setting_ok.Name = "b_setting_ok";
            this.b_setting_ok.Size = new System.Drawing.Size(75, 23);
            this.b_setting_ok.TabIndex = 0;
            this.b_setting_ok.Text = "ОК";
            this.b_setting_ok.UseVisualStyleBackColor = true;
            this.b_setting_ok.Click += new System.EventHandler(this.b_setting_ok_Click);
            // 
            // b_setting_cancel
            // 
            this.b_setting_cancel.Location = new System.Drawing.Point(497, 327);
            this.b_setting_cancel.Name = "b_setting_cancel";
            this.b_setting_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_setting_cancel.TabIndex = 1;
            this.b_setting_cancel.Text = "Отмена";
            this.b_setting_cancel.UseVisualStyleBackColor = true;
            this.b_setting_cancel.Click += new System.EventHandler(this.b_setting_cancel_Click);
            // 
            // tc_setting
            // 
            this.tc_setting.Controls.Add(this.tp_internet);
            this.tc_setting.Controls.Add(this.tp_1c);
            this.tc_setting.Controls.Add(this.tabPage3);
            this.tc_setting.Location = new System.Drawing.Point(12, 12);
            this.tc_setting.Name = "tc_setting";
            this.tc_setting.SelectedIndex = 0;
            this.tc_setting.Size = new System.Drawing.Size(560, 309);
            this.tc_setting.TabIndex = 2;
            // 
            // tp_internet
            // 
            this.tp_internet.Controls.Add(this.tb_reserve_internet);
            this.tp_internet.Controls.Add(this.l_reserve_internet);
            this.tp_internet.Controls.Add(this.tb_primary_internet);
            this.tp_internet.Controls.Add(this.l_primary_internet);
            this.tp_internet.Location = new System.Drawing.Point(4, 22);
            this.tp_internet.Name = "tp_internet";
            this.tp_internet.Padding = new System.Windows.Forms.Padding(3);
            this.tp_internet.Size = new System.Drawing.Size(552, 283);
            this.tp_internet.TabIndex = 0;
            this.tp_internet.Text = "Интернет";
            this.tp_internet.UseVisualStyleBackColor = true;
            // 
            // tb_reserve_internet
            // 
            this.tb_reserve_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_reserve_internet.Location = new System.Drawing.Point(11, 95);
            this.tb_reserve_internet.Name = "tb_reserve_internet";
            this.tb_reserve_internet.Size = new System.Drawing.Size(535, 29);
            this.tb_reserve_internet.TabIndex = 3;
            // 
            // l_reserve_internet
            // 
            this.l_reserve_internet.AutoSize = true;
            this.l_reserve_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_reserve_internet.Location = new System.Drawing.Point(7, 67);
            this.l_reserve_internet.Name = "l_reserve_internet";
            this.l_reserve_internet.Size = new System.Drawing.Size(207, 24);
            this.l_reserve_internet.TabIndex = 2;
            this.l_reserve_internet.Text = "Резервный интернет:";
            // 
            // tb_primary_internet
            // 
            this.tb_primary_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_primary_internet.Location = new System.Drawing.Point(11, 35);
            this.tb_primary_internet.Name = "tb_primary_internet";
            this.tb_primary_internet.Size = new System.Drawing.Size(535, 29);
            this.tb_primary_internet.TabIndex = 1;
            // 
            // l_primary_internet
            // 
            this.l_primary_internet.AutoSize = true;
            this.l_primary_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_primary_internet.Location = new System.Drawing.Point(7, 7);
            this.l_primary_internet.Name = "l_primary_internet";
            this.l_primary_internet.Size = new System.Drawing.Size(197, 24);
            this.l_primary_internet.TabIndex = 0;
            this.l_primary_internet.Text = "Основной интернет:";
            // 
            // tp_1c
            // 
            this.tp_1c.Controls.Add(this.cb_restart_explorer);
            this.tp_1c.Controls.Add(this.cb_close_monitoring);
            this.tp_1c.Controls.Add(this.cb_close_1c);
            this.tp_1c.Location = new System.Drawing.Point(4, 22);
            this.tp_1c.Name = "tp_1c";
            this.tp_1c.Padding = new System.Windows.Forms.Padding(3);
            this.tp_1c.Size = new System.Drawing.Size(552, 283);
            this.tp_1c.TabIndex = 1;
            this.tp_1c.Text = "1C";
            this.tp_1c.UseVisualStyleBackColor = true;
            // 
            // cb_close_monitoring
            // 
            this.cb_close_monitoring.AutoSize = true;
            this.cb_close_monitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_close_monitoring.Location = new System.Drawing.Point(7, 41);
            this.cb_close_monitoring.Name = "cb_close_monitoring";
            this.cb_close_monitoring.Size = new System.Drawing.Size(234, 28);
            this.cb_close_monitoring.TabIndex = 1;
            this.cb_close_monitoring.Text = "\"Закрыть мониторинг\"";
            this.cb_close_monitoring.UseVisualStyleBackColor = true;
            // 
            // cb_close_1c
            // 
            this.cb_close_1c.AutoSize = true;
            this.cb_close_1c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_close_1c.Location = new System.Drawing.Point(7, 7);
            this.cb_close_1c.Name = "cb_close_1c";
            this.cb_close_1c.Size = new System.Drawing.Size(148, 28);
            this.cb_close_1c.TabIndex = 0;
            this.cb_close_1c.Text = "\"Закрыть 1C\"";
            this.cb_close_1c.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 283);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_restart_explorer
            // 
            this.cb_restart_explorer.AutoSize = true;
            this.cb_restart_explorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_restart_explorer.Location = new System.Drawing.Point(7, 75);
            this.cb_restart_explorer.Name = "cb_restart_explorer";
            this.cb_restart_explorer.Size = new System.Drawing.Size(258, 28);
            this.cb_restart_explorer.TabIndex = 2;
            this.cb_restart_explorer.Text = "\"Перезапустить Explorer\"";
            this.cb_restart_explorer.UseVisualStyleBackColor = true;
            // 
            // f_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tc_setting);
            this.Controls.Add(this.b_setting_cancel);
            this.Controls.Add(this.b_setting_ok);
            this.Name = "f_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.tc_setting.ResumeLayout(false);
            this.tp_internet.ResumeLayout(false);
            this.tp_internet.PerformLayout();
            this.tp_1c.ResumeLayout(false);
            this.tp_1c.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_setting_ok;
        private System.Windows.Forms.Button b_setting_cancel;
        private System.Windows.Forms.TabControl tc_setting;
        private System.Windows.Forms.TabPage tp_internet;
        private System.Windows.Forms.TabPage tp_1c;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label l_primary_internet;
        private System.Windows.Forms.TextBox tb_reserve_internet;
        private System.Windows.Forms.Label l_reserve_internet;
        private System.Windows.Forms.TextBox tb_primary_internet;
        private System.Windows.Forms.CheckBox cb_close_monitoring;
        private System.Windows.Forms.CheckBox cb_close_1c;
        private System.Windows.Forms.CheckBox cb_restart_explorer;
    }
}