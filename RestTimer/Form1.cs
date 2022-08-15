// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using Microsoft.Win32;
using RestTimer.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace RestTimer
{
    public partial class MainForm : Form
    {
        private readonly NotificationForm _notificationForm = new NotificationForm();

        public MainForm()
        {
            InitializeComponent();

            txtInterval.Text = Settings.Default.Interval.ToString();
            txtNotificationText.Text = Settings.Default.NotificationText;

            timer.Interval = (int)Settings.Default.Interval * 60000;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;

            TrayIcon.Visible = false;

            btnAutoStart.Enabled = IsAdmin();
        }

        public int NotificationTextMaxLength { get; } = 300;

        private void Timer_Tick(object sender, EventArgs e)
        {
            _notificationForm.Show();
            timer.Enabled = false;
            Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Interval = Convert.ToUInt32(txtInterval.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Значением интервала может быть только положительное целое число");
            }

            if (txtNotificationText.Text == "" || txtNotificationText.Text.Length > NotificationTextMaxLength)
                MessageBox.Show(
                    $"Текст напонимания не может быть пустым или содержать более {NotificationTextMaxLength} символов");
            else
                Settings.Default.NotificationText = txtNotificationText.Text;

            Settings.Default.Save();

            Process.Start(Application.ExecutablePath);
            Environment.Exit(0);
        }

        private void ShowTrayIcon()
        {
            Hide();
            TrayIcon.Visible = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) ShowTrayIcon();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ShowTrayIcon();
        }

        private void ExitMenuStrip_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            TrayIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void BtnRunAsAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(Application.ExecutablePath)
                {
                    UseShellExecute = true,
                    Verb = "runas"
                });
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Для добавления программы в автозагрузку требуются права администратора");
            }

            Environment.Exit(0);
        }

        public static bool IsAdmin()
        {
            var id = WindowsIdentity.GetCurrent();
            var p = new WindowsPrincipal(id);

            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void BtnAutoRun_Click(object sender, EventArgs e)
        {
            var key = Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            key?.SetValue("Rest Timer", Application.ExecutablePath);
            key?.Close();

            MessageBox.Show("Программа успешно добавлена в автозагрузку");
        }
    }
}