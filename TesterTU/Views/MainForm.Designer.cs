﻿
namespace TesterTU.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.settingsPanelMK2 = new TesterTU.Views.SettingsPanel();
            this.settingsPanelMK1 = new TesterTU.Views.SettingsPanel();
            this.panelDevices = new System.Windows.Forms.Panel();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartStop.Location = new System.Drawing.Point(629, 41);
            this.buttonStartStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(177, 66);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "СТАРТ";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.AutoScroll = true;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.settingsPanelMK2);
            this.panelSettings.Controls.Add(this.settingsPanelMK1);
            this.panelSettings.Controls.Add(this.buttonStartStop);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1525, 146);
            this.panelSettings.TabIndex = 7;
            // 
            // settingsPanelMK2
            // 
            this.settingsPanelMK2.Location = new System.Drawing.Point(310, 6);
            this.settingsPanelMK2.Name = "settingsPanelMK2";
            this.settingsPanelMK2.Size = new System.Drawing.Size(298, 130);
            this.settingsPanelMK2.TabIndex = 2;
            this.settingsPanelMK2.TextPanel = "Настройка COM МК2";
            // 
            // settingsPanelMK1
            // 
            this.settingsPanelMK1.Location = new System.Drawing.Point(0, 0);
            this.settingsPanelMK1.Name = "settingsPanelMK1";
            this.settingsPanelMK1.Size = new System.Drawing.Size(298, 135);
            this.settingsPanelMK1.TabIndex = 1;
            this.settingsPanelMK1.TextPanel = "Настройка COM МК1";
            // 
            // panelDevices
            // 
            this.panelDevices.AutoScroll = true;
            this.panelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDevices.Location = new System.Drawing.Point(0, 146);
            this.panelDevices.Name = "panelDevices";
            this.panelDevices.Size = new System.Drawing.Size(1525, 709);
            this.panelDevices.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 855);
            this.Controls.Add(this.panelDevices);
            this.Controls.Add(this.panelSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Тестер ТУ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Panel panelSettings;
        private SettingsPanel settingsPanelMK1;
        private SettingsPanel settingsPanelMK2;
        private System.Windows.Forms.Panel panelDevices;
    }
}
