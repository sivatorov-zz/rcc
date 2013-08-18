using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rcc
{
    public partial class f_setting : Form
    {
        public f_setting()
        {
            InitializeComponent();

            //      получаем настройки шлюза основного интернета

            tb_primary_internet.Text = Properties.Settings.Default.primary_internet;

            //      получаем настройки шлюза резервного интернета

            tb_reserve_internet.Text = Properties.Settings.Default.reserve_internet;

            //      проверяем доступна ли кнопка "Закрыть 1С"

            cb_close_1c.Checked = Properties.Settings.Default.close_1c;

            //      проверяем доступна ли кнопка "Закрыть мониторинг"

            cb_close_monitoring.Checked = Properties.Settings.Default.close_monitoring;

            cb_restart_explorer.Checked = Properties.Settings.Default.restart_explorer;
        }

        private void b_setting_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_setting_ok_Click(object sender, EventArgs e)
        {

            //  Сохраняем настройки программы

            Properties.Settings.Default.primary_internet = tb_primary_internet.Text;
            Properties.Settings.Default.reserve_internet = tb_reserve_internet.Text;
            Properties.Settings.Default.close_1c = cb_close_1c.Checked;
            Properties.Settings.Default.close_monitoring = cb_close_monitoring.Checked;
            Properties.Settings.Default.restart_explorer = cb_restart_explorer.Checked;
            Properties.Settings.Default.Save();

            //  выводим предупреждение о необходимой перезагруки программы

            if (MessageBox.Show("Были изменены настройки!\nДля корректной работы необходимо перезапустить программу!\nПерезапустить сейчас?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Application.Restart();
        }
    }
}
