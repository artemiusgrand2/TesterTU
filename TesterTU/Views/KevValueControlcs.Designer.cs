
namespace TesterTU.Views
{
    partial class KevValueControlcs
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
            this.labelValue = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(41, 11);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(53, 20);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "value";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(0, 11);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(34, 20);
            this.labelKey.TabIndex = 3;
            this.labelKey.Text = "key";
            // 
            // KevValueControlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelKey);
            this.Name = "KevValueControlcs";
            this.Size = new System.Drawing.Size(110, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelKey;
    }
}
