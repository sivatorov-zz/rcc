namespace rcc
{
    partial class f_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            this.cms_ni_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_primary_internet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_reserve_internet = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_internet = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_close_1c = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_close_monitoring = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_close = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_setting = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_cms_ni_main_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ni_main = new System.Windows.Forms.NotifyIcon(this.components);
            this.tsmi_restart_explorer = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_ni_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms_ni_main
            // 
            this.cms_ni_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_primary_internet,
            this.tsmi_reserve_internet,
            this.tss_internet,
            this.tsmi_close_1c,
            this.tsmi_close_monitoring,
            this.tsmi_restart_explorer,
            this.tss_close,
            this.tsmi_setting,
            this.tss_setting,
            this.tsmi_cms_ni_main_exit});
            this.cms_ni_main.Name = "cms_ni_main";
            this.cms_ni_main.Size = new System.Drawing.Size(296, 176);
            // 
            // tsmi_primary_internet
            // 
            this.tsmi_primary_internet.Checked = true;
            this.tsmi_primary_internet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_primary_internet.Name = "tsmi_primary_internet";
            this.tsmi_primary_internet.Size = new System.Drawing.Size(295, 22);
            this.tsmi_primary_internet.Text = "Основной интернет";
            this.tsmi_primary_internet.Click += new System.EventHandler(this.tsmi_primary_internet_Click);
            // 
            // tsmi_reserve_internet
            // 
            this.tsmi_reserve_internet.Name = "tsmi_reserve_internet";
            this.tsmi_reserve_internet.Size = new System.Drawing.Size(295, 22);
            this.tsmi_reserve_internet.Text = "Резервный интернет";
            this.tsmi_reserve_internet.Click += new System.EventHandler(this.tsmi_reserve_internet_Click);
            // 
            // tss_internet
            // 
            this.tss_internet.Name = "tss_internet";
            this.tss_internet.Size = new System.Drawing.Size(292, 6);
            // 
            // tsmi_close_1c
            // 
            this.tsmi_close_1c.Name = "tsmi_close_1c";
            this.tsmi_close_1c.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.tsmi_close_1c.Size = new System.Drawing.Size(295, 22);
            this.tsmi_close_1c.Text = "Закрыть 1С";
            this.tsmi_close_1c.Visible = false;
            this.tsmi_close_1c.Click += new System.EventHandler(this.tsmi_close_1c_Click);
            // 
            // tsmi_close_monitoring
            // 
            this.tsmi_close_monitoring.Name = "tsmi_close_monitoring";
            this.tsmi_close_monitoring.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.tsmi_close_monitoring.Size = new System.Drawing.Size(295, 22);
            this.tsmi_close_monitoring.Text = "Закрыть мониторинг";
            this.tsmi_close_monitoring.Visible = false;
            this.tsmi_close_monitoring.Click += new System.EventHandler(this.tsmi_close_monitoring_Click);
            // 
            // tss_close
            // 
            this.tss_close.Name = "tss_close";
            this.tss_close.Size = new System.Drawing.Size(292, 6);
            this.tss_close.Visible = false;
            // 
            // tsmi_setting
            // 
            this.tsmi_setting.Name = "tsmi_setting";
            this.tsmi_setting.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmi_setting.Size = new System.Drawing.Size(295, 22);
            this.tsmi_setting.Text = "Настройки";
            this.tsmi_setting.Click += new System.EventHandler(this.tsmi_setting_Click);
            // 
            // tss_setting
            // 
            this.tss_setting.Name = "tss_setting";
            this.tss_setting.Size = new System.Drawing.Size(292, 6);
            // 
            // tsmi_cms_ni_main_exit
            // 
            this.tsmi_cms_ni_main_exit.Name = "tsmi_cms_ni_main_exit";
            this.tsmi_cms_ni_main_exit.Size = new System.Drawing.Size(295, 22);
            this.tsmi_cms_ni_main_exit.Text = "Выход";
            this.tsmi_cms_ni_main_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // ni_main
            // 
            this.ni_main.ContextMenuStrip = this.cms_ni_main;
            this.ni_main.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_main.Icon")));
            this.ni_main.Text = "Remote Control Client";
            this.ni_main.Visible = true;
            // 
            // tsmi_restart_explorer
            // 
            this.tsmi_restart_explorer.Name = "tsmi_restart_explorer";
            this.tsmi_restart_explorer.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.tsmi_restart_explorer.Size = new System.Drawing.Size(295, 22);
            this.tsmi_restart_explorer.Text = "Перезапустить Explorer";
            this.tsmi_restart_explorer.Visible = false;
            this.tsmi_restart_explorer.Click += new System.EventHandler(this.tsmi_restart_explorer_Click);
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_main";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Remote Control Client";
            this.Load += new System.EventHandler(this.f_main_Load);
            this.cms_ni_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cms_ni_main;
        private System.Windows.Forms.NotifyIcon ni_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_primary_internet;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reserve_internet;
        private System.Windows.Forms.ToolStripSeparator tss_internet;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close_monitoring;
        private System.Windows.Forms.ToolStripSeparator tss_close;
        private System.Windows.Forms.ToolStripMenuItem tsmi_setting;
        private System.Windows.Forms.ToolStripSeparator tss_setting;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cms_ni_main_exit;
        private System.Windows.Forms.ToolStripMenuItem tsmi_close_1c;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restart_explorer;
    }
}

