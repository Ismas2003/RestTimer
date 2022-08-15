// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: https://pvs-studio.com

using System;
using System.Windows.Forms;
using RestTimer.Properties;

namespace RestTimer
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            NotificationTextLabel.Text = Settings.Default.NotificationText;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            new MainForm();
            Close();
        }
    }
}