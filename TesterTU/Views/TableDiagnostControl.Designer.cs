
namespace TesterTU.Views
{
    partial class TableDiagnostControl
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
            this.labelMK2 = new System.Windows.Forms.Label();
            this.labelMK1 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMK2
            // 
            this.labelMK2.AutoSize = true;
            this.labelMK2.Location = new System.Drawing.Point(21, 83);
            this.labelMK2.Name = "labelMK2";
            this.labelMK2.Size = new System.Drawing.Size(46, 17);
            this.labelMK2.TabIndex = 11;
            this.labelMK2.Text = "label5";
            // 
            // labelMK1
            // 
            this.labelMK1.AutoSize = true;
            this.labelMK1.Location = new System.Drawing.Point(21, 30);
            this.labelMK1.Name = "labelMK1";
            this.labelMK1.Size = new System.Drawing.Size(46, 17);
            this.labelMK1.TabIndex = 10;
            this.labelMK1.Text = "label4";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(12, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(66, 17);
            this.labelHeader.TabIndex = 9;
            this.labelHeader.Text = "Попытки";
            // 
            // TableDiagnostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelMK2);
            this.Controls.Add(this.labelMK1);
            this.Controls.Add(this.labelHeader);
            this.Name = "TableDiagnostControl";
            this.Size = new System.Drawing.Size(91, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMK2;
        private System.Windows.Forms.Label labelMK1;
        private System.Windows.Forms.Label labelHeader;
    }
}
