
namespace Tariff
{
    partial class FormTariffAssistant
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
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxTariffs = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarMessages = new System.Windows.Forms.TrackBar();
            this.trackBarMinutes = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarGygabytes = new System.Windows.Forms.TrackBar();
            this.textBoxGygabytes = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGygabytes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Выберите то, что подходит вам";
            // 
            // listBoxTariffs
            // 
            this.listBoxTariffs.FormattingEnabled = true;
            this.listBoxTariffs.Location = new System.Drawing.Point(15, 25);
            this.listBoxTariffs.Name = "listBoxTariffs";
            this.listBoxTariffs.Size = new System.Drawing.Size(199, 277);
            this.listBoxTariffs.TabIndex = 5;
            this.listBoxTariffs.SelectedIndexChanged += new System.EventHandler(this.listBoxTariffs_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Минуты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Минуты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тарифы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Гигабайты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "SMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Гигабайты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SMS";
            // 
            // trackBarMessages
            // 
            this.trackBarMessages.Location = new System.Drawing.Point(289, 260);
            this.trackBarMessages.Name = "trackBarMessages";
            this.trackBarMessages.Size = new System.Drawing.Size(205, 45);
            this.trackBarMessages.TabIndex = 4;
            // 
            // trackBarMinutes
            // 
            this.trackBarMinutes.Location = new System.Drawing.Point(289, 209);
            this.trackBarMinutes.Name = "trackBarMinutes";
            this.trackBarMinutes.Size = new System.Drawing.Size(205, 45);
            this.trackBarMinutes.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Цена";
            // 
            // trackBarGygabytes
            // 
            this.trackBarGygabytes.Location = new System.Drawing.Point(289, 158);
            this.trackBarGygabytes.Name = "trackBarGygabytes";
            this.trackBarGygabytes.Size = new System.Drawing.Size(205, 45);
            this.trackBarGygabytes.TabIndex = 4;
            // 
            // textBoxGygabytes
            // 
            this.textBoxGygabytes.Location = new System.Drawing.Point(288, 22);
            this.textBoxGygabytes.Name = "textBoxGygabytes";
            this.textBoxGygabytes.Size = new System.Drawing.Size(206, 20);
            this.textBoxGygabytes.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(288, 106);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(206, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(288, 51);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(206, 20);
            this.textBoxMinutes.TabIndex = 3;
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(288, 78);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.Size = new System.Drawing.Size(206, 20);
            this.textBoxMessages.TabIndex = 3;
            // 
            // FormTariffAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 316);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxTariffs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGygabytes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarGygabytes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarMessages);
            this.Controls.Add(this.trackBarMinutes);
            this.Name = "FormTariffAssistant";
            this.Text = "Тарифы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTariffAssistant_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGygabytes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxTariffs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarMessages;
        private System.Windows.Forms.TrackBar trackBarMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarGygabytes;
        private System.Windows.Forms.TextBox textBoxGygabytes;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.Label label10;
    }
}

