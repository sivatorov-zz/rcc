using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Management;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Utilities;

namespace rcc
{
    public partial class f_main : Form
    {

        globalKeyboardHook gkh = new globalKeyboardHook();

        public f_main()
        {
            InitializeComponent();

            //  при загрузке включаем основной интернет

            func_turn_primary_internet();

            //  проверка отображать ли пункты "Закрыть 1С" и "Закрыть мониторинг"

            if (Properties.Settings.Default.close_1c || Properties.Settings.Default.close_monitoring || Properties.Settings.Default.restart_explorer)
            {
                if (Properties.Settings.Default.close_1c)
                    tsmi_close_1c.Visible = true;
                if (Properties.Settings.Default.close_monitoring)
                    tsmi_close_monitoring.Visible = true;
                if (Properties.Settings.Default.restart_explorer)
                    tsmi_restart_explorer.Visible = true;
                tss_close.Visible = true;
            }
        }



        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            //  закрываем приложение

            this.Close();
        }

        public static void SetGateway(string gateway)
        {

            //!++     как именно работает данный участок кода я не знаю,
            //!++    но знаю, что он успешно переключает основной шлюз сетевого подключения

            //!++    начало кода покрытого мраком

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setGateway;
                        ManagementBaseObject newGateway =
                            objMO.GetMethodParameters("SetGateways");

                        newGateway["DefaultIPGateway"] = new string[] { gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            //!++   конец кода покрытого мраком!
        }


        //      при нажатии кнопки "основной интернет"

        private void tsmi_primary_internet_Click(object sender, EventArgs e)
        {
            //      переключаем шлюз сетевого подключения

            func_turn_primary_internet();
        }


        //  при нажатии кнопки "резервный интернет"

        private void tsmi_reserve_internet_Click(object sender, EventArgs e)
        {
            //  переключаем шлюз сетевого подключения

            func_turn_reserve_internet();
        }

        //      функция включения "основоного интернета"
        public void func_turn_primary_internet()
        {  
            //      переключаем основной шлюз сетевого подключения

            SetGateway(Properties.Settings.Default.primary_internet);

            //      ставим галочку напротив "Основной интернет"

            tsmi_primary_internet.Checked = true;

            //      убираем галочку напротив "Резервный интернет"

            tsmi_reserve_internet.Checked = false;
        }

        //      функция включения "резервного интернета"

        public void func_turn_reserve_internet()
        {
            //      переключаем основной шлюз сетевого подключения

            SetGateway(Properties.Settings.Default.reserve_internet);

            //      ставим глаочку напротив "Резервный интернет"

            tsmi_reserve_internet.Checked = true;

            //      убираем галочку напротив "Основной интернет"

            tsmi_primary_internet.Checked = false;
        }

        //      Настройки программы
        private void tsmi_setting_Click(object sender, EventArgs e)
        {
            //      создаем новую форму

            f_setting fsetting = new f_setting();

            //      открываем форму

            fsetting.ShowDialog();
        }

        private void tsmi_close_1c_Click(object sender, EventArgs e)
        {
            func_close_programm("1cv8", false);
        }

        private void tsmi_close_monitoring_Click(object sender, EventArgs e)
        {
            func_close_programm("1cv8s", false);
        }

        public void func_close_programm(string s_prog_name, bool b_prog_restart)
        {
            Process[] ps = Process.GetProcessesByName(s_prog_name);
            foreach (Process p in ps)
                p.Kill();
            if (b_prog_restart)
            {
                Process pn = new Process();
                pn.StartInfo.FileName = s_prog_name;
                pn.Start();
            }
        }

        private void tsmi_restart_explorer_Click(object sender, EventArgs e)
        {
            func_close_programm("explorer", true);
        }

        private void f_main_Load(object sender, EventArgs e)
        {

            gkh.HookedKeys.Add(Keys.LControlKey);
            gkh.HookedKeys.Add(Keys.E);
            //  gkh.HookedKeys.Add(Keys.Shift);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            //  lstLog.Items.Add("Down\t" + e.KeyCode.ToString());
            if (e.KeyData == (Keys.LControlKey | Keys.E))
                func_close_programm("explorer", true);
            e.Handled = true;
        }
    }
}
