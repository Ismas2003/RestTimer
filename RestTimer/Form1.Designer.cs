
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RestTimer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblNotificationText = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtNotificationText = new System.Windows.Forms.RichTextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ExitMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoStart = new System.Windows.Forms.Button();
            this.btnRunAsAdmin = new System.Windows.Forms.Button();
            this.ExitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInterval.Location = new System.Drawing.Point(12, 9);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInterval.Size = new System.Drawing.Size(261, 24);
            this.lblInterval.TabIndex = 0;
            this.lblInterval.Text = "Интервал времени (мин):";
            // 
            // lblNotificationText
            // 
            this.lblNotificationText.AutoSize = true;
            this.lblNotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotificationText.Location = new System.Drawing.Point(12, 50);
            this.lblNotificationText.Name = "lblNotificationText";
            this.lblNotificationText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotificationText.Size = new System.Drawing.Size(396, 24);
            this.lblNotificationText.TabIndex = 1;
            this.lblNotificationText.Text = "Текст напоминания (до 300 символов):";
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInterval.Location = new System.Drawing.Point(279, 9);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(118, 29);
            this.txtInterval.TabIndex = 2;
            // 
            // txtNotificationText
            // 
            this.txtNotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNotificationText.Location = new System.Drawing.Point(16, 89);
            this.txtNotificationText.Name = "txtNotificationText";
            this.txtNotificationText.Size = new System.Drawing.Size(381, 264);
            this.txtNotificationText.TabIndex = 3;
            this.txtNotificationText.Text = "";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(12, 359);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(148, 44);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.ExitMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Rest Timer";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuStrip});
            this.ExitMenu.Name = "ExitMenuStrip";
            this.ExitMenu.Size = new System.Drawing.Size(110, 26);
            // 
            // ExitMenuStrip
            // 
            this.ExitMenuStrip.Name = "ExitMenuStrip";
            this.ExitMenuStrip.Size = new System.Drawing.Size(109, 22);
            this.ExitMenuStrip.Text = "Выйти";
            this.ExitMenuStrip.Click += new System.EventHandler(this.ExitMenuStrip_Click);
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.AutoSize = true;
            this.btnAutoStart.Enabled = false;
            this.btnAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAutoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAutoStart.Location = new System.Drawing.Point(206, 359);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(191, 30);
            this.btnAutoStart.TabIndex = 5;
            this.btnAutoStart.Text = "Добавить в автозагрузку";
            this.btnAutoStart.UseVisualStyleBackColor = true;
            this.btnAutoStart.Click += new System.EventHandler(this.BtnAutoRun_Click);
            // 
            // btnRunAsAdmin
            // 
            this.btnRunAsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnRunAsAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnRunAsAdmin.Image = global::RestTimer.Properties.Resources.Admin;
            this.btnRunAsAdmin.Location = new System.Drawing.Point(170, 359);
            this.btnRunAsAdmin.Name = "btnRunAsAdmin";
            this.btnRunAsAdmin.Size = new System.Drawing.Size(30, 30);
            this.btnRunAsAdmin.TabIndex = 6;
            this.btnRunAsAdmin.UseVisualStyleBackColor = false;
            this.btnRunAsAdmin.Click += new System.EventHandler(this.BtnRunAsAdmin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.Controls.Add(this.btnRunAsAdmin);
            this.Controls.Add(this.btnAutoStart);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtNotificationText);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblNotificationText);
            this.Controls.Add(this.lblInterval);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 450);
            this.MinimumSize = new System.Drawing.Size(425, 450);
            this.Name = "MainForm";
            this.Text = "Rest Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ExitMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInterval;
        private Label lblNotificationText;
        private TextBox txtInterval;
        private RichTextBox txtNotificationText;
        private Button btnApply;
        private NotifyIcon TrayIcon;
        private ContextMenuStrip ExitMenu;
        private ToolStripMenuItem ExitMenuStrip;
        private Button btnAutoStart;
        internal Timer timer;
        private Button btnRunAsAdmin;
    }
}

