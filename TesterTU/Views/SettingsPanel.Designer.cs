
namespace TesterTU.Views
{
    partial class SettingsPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxNamePort = new System.Windows.Forms.ComboBox();
            this.comboBoxBoudRoute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.comboBoxNamePort);
            this.groupBoxSettings.Controls.Add(this.comboBoxBoudRoute);
            this.groupBoxSettings.Controls.Add(this.label2);
            this.groupBoxSettings.Controls.Add(this.label1);
            this.groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSettings.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(298, 130);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "groupBox1";
            // 
            // comboBoxNamePort
            // 
            this.comboBoxNamePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNamePort.FormattingEnabled = true;
            this.comboBoxNamePort.Location = new System.Drawing.Point(139, 40);
            this.comboBoxNamePort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNamePort.Name = "comboBoxNamePort";
            this.comboBoxNamePort.Size = new System.Drawing.Size(119, 28);
            this.comboBoxNamePort.TabIndex = 6;
            // 
            // comboBoxBoudRoute
            // 
            this.comboBoxBoudRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoudRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBoudRoute.FormattingEnabled = true;
            this.comboBoxBoudRoute.Location = new System.Drawing.Point(139, 77);
            this.comboBoxBoudRoute.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBoudRoute.Name = "comboBoxBoudRoute";
            this.comboBoxBoudRoute.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBoudRoute.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Скорость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM порт:";
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(298, 130);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.ComboBox comboBoxNamePort;
        private System.Windows.Forms.ComboBox comboBoxBoudRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
