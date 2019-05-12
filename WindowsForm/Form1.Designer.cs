namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonResult = new System.Windows.Forms.Button();
            this.comboBoxCurrencyIN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCurrencyOut = new System.Windows.Forms.ComboBox();
            this.labelSumm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(15, 328);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonResult.Size = new System.Drawing.Size(140, 43);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.Text = "Купить";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // comboBoxCurrencyIN
            // 
            this.comboBoxCurrencyIN.FormattingEnabled = true;
            this.comboBoxCurrencyIN.Location = new System.Drawing.Point(15, 159);
            this.comboBoxCurrencyIN.Name = "comboBoxCurrencyIN";
            this.comboBoxCurrencyIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCurrencyIN.Size = new System.Drawing.Size(216, 24);
            this.comboBoxCurrencyIN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите сумму:";
            // 
            // textBoxAmound
            // 
            this.textBoxAmound.Location = new System.Drawing.Point(15, 85);
            this.textBoxAmound.Name = "textBoxAmound";
            this.textBoxAmound.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAmound.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmound.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имеющаяся валюта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нужная валюта:";
            // 
            // comboBoxCurrencyOut
            // 
            this.comboBoxCurrencyOut.FormattingEnabled = true;
            this.comboBoxCurrencyOut.Location = new System.Drawing.Point(15, 235);
            this.comboBoxCurrencyOut.Name = "comboBoxCurrencyOut";
            this.comboBoxCurrencyOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCurrencyOut.Size = new System.Drawing.Size(216, 24);
            this.comboBoxCurrencyOut.TabIndex = 5;
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(12, 281);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSumm.Size = new System.Drawing.Size(54, 17);
            this.labelSumm.TabIndex = 7;
            this.labelSumm.Text = "Сумма:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 428);
            this.Controls.Add(this.labelSumm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCurrencyOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCurrencyIN);
            this.Controls.Add(this.buttonResult);
            this.Name = "Form1";
            this.Text = "Конвертер валюты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.ComboBox comboBoxCurrencyIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCurrencyOut;
        private System.Windows.Forms.Label labelSumm;
    }
}

