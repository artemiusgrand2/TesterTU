
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
            this.labelParametr2 = new System.Windows.Forms.Label();
            this.labelParametr1 = new System.Windows.Forms.Label();
            this.comboBoxTypeChannel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.numericUpDownPort);
            this.groupBoxSettings.Controls.Add(this.textBoxIp);
            this.groupBoxSettings.Controls.Add(this.comboBoxTypeChannel);
            this.groupBoxSettings.Controls.Add(this.label3);
            this.groupBoxSettings.Controls.Add(this.comboBoxNamePort);
            this.groupBoxSettings.Controls.Add(this.comboBoxBoudRoute);
            this.groupBoxSettings.Controls.Add(this.labelParametr2);
            this.groupBoxSettings.Controls.Add(this.labelParametr1);
            this.groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSettings.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSettings.Size = new System.Drawing.Size(224, 146);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "groupBox1";
            // 
            // comboBoxNamePort
            // 
            this.comboBoxNamePort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNamePort.FormattingEnabled = true;
            this.comboBoxNamePort.Location = new System.Drawing.Point(104, 39);
            this.comboBoxNamePort.Name = "comboBoxNamePort";
            this.comboBoxNamePort.Size = new System.Drawing.Size(90, 24);
            this.comboBoxNamePort.TabIndex = 6;
            // 
            // comboBoxBoudRoute
            // 
            this.comboBoxBoudRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoudRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBoudRoute.FormattingEnabled = true;
            this.comboBoxBoudRoute.Location = new System.Drawing.Point(104, 70);
            this.comboBoxBoudRoute.Name = "comboBoxBoudRoute";
            this.comboBoxBoudRoute.Size = new System.Drawing.Size(92, 24);
            this.comboBoxBoudRoute.TabIndex = 8;
            // 
            // labelParametr2
            // 
            this.labelParametr2.AutoSize = true;
            this.labelParametr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParametr2.Location = new System.Drawing.Point(14, 72);
            this.labelParametr2.Name = "labelParametr2";
            this.labelParametr2.Size = new System.Drawing.Size(72, 16);
            this.labelParametr2.TabIndex = 7;
            this.labelParametr2.Text = "Скорость:";
            // 
            // labelParametr1
            // 
            this.labelParametr1.AutoSize = true;
            this.labelParametr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParametr1.Location = new System.Drawing.Point(14, 39);
            this.labelParametr1.Name = "labelParametr1";
            this.labelParametr1.Size = new System.Drawing.Size(75, 16);
            this.labelParametr1.TabIndex = 5;
            this.labelParametr1.Text = "COM порт:";
            // 
            // comboBoxTypeChannel
            // 
            this.comboBoxTypeChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeChannel.FormattingEnabled = true;
            this.comboBoxTypeChannel.Location = new System.Drawing.Point(104, 100);
            this.comboBoxTypeChannel.Name = "comboBoxTypeChannel";
            this.comboBoxTypeChannel.Size = new System.Drawing.Size(92, 24);
            this.comboBoxTypeChannel.TabIndex = 10;
            this.comboBoxTypeChannel.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeChannel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип канала:";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIp.Location = new System.Drawing.Point(104, 40);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(90, 21);
            this.textBoxIp.TabIndex = 11;
            this.textBoxIp.Visible = false;
            this.textBoxIp.TextChanged += new System.EventHandler(this.textBoxIp_TextChanged);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPort.Location = new System.Drawing.Point(104, 70);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(92, 24);
            this.numericUpDownPort.TabIndex = 12;
            this.numericUpDownPort.TabStop = false;
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSettings);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(224, 146);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.ComboBox comboBoxNamePort;
        private System.Windows.Forms.ComboBox comboBoxBoudRoute;
        private System.Windows.Forms.Label labelParametr2;
        private System.Windows.Forms.Label labelParametr1;
        private System.Windows.Forms.ComboBox comboBoxTypeChannel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.TextBox textBoxIp;
    }
}
