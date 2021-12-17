
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
            this.labelMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGyga = new System.Windows.Forms.Label();
            this.labelSMS = new System.Windows.Forms.Label();
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
            this.labelGygaValue = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelSMSValue = new System.Windows.Forms.Label();
            this.buttonChooseRightTariff = new System.Windows.Forms.Button();
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
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(237, 221);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(46, 13);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "Минуты";
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
            // labelGyga
            // 
            this.labelGyga.AutoSize = true;
            this.labelGyga.Location = new System.Drawing.Point(222, 174);
            this.labelGyga.Name = "labelGyga";
            this.labelGyga.Size = new System.Drawing.Size(61, 13);
            this.labelGyga.TabIndex = 2;
            this.labelGyga.Text = "Гигабайты";
            // 
            // labelSMS
            // 
            this.labelSMS.AutoSize = true;
            this.labelSMS.Location = new System.Drawing.Point(253, 274);
            this.labelSMS.Name = "labelSMS";
            this.labelSMS.Size = new System.Drawing.Size(30, 13);
            this.labelSMS.TabIndex = 2;
            this.labelSMS.Text = "SMS";
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
            this.trackBarMessages.Maximum = 10000;
            this.trackBarMessages.Name = "trackBarMessages";
            this.trackBarMessages.Size = new System.Drawing.Size(205, 45);
            this.trackBarMessages.TabIndex = 4;
            this.trackBarMessages.Scroll += new System.EventHandler(this.trackBarMessages_Scroll);
            // 
            // trackBarMinutes
            // 
            this.trackBarMinutes.Location = new System.Drawing.Point(289, 209);
            this.trackBarMinutes.Maximum = 10000;
            this.trackBarMinutes.Name = "trackBarMinutes";
            this.trackBarMinutes.Size = new System.Drawing.Size(205, 45);
            this.trackBarMinutes.TabIndex = 4;
            this.trackBarMinutes.Scroll += new System.EventHandler(this.trackBarMinutes_Scroll);
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
            this.trackBarGygabytes.Maximum = 1000;
            this.trackBarGygabytes.Name = "trackBarGygabytes";
            this.trackBarGygabytes.Size = new System.Drawing.Size(205, 45);
            this.trackBarGygabytes.TabIndex = 4;
            this.trackBarGygabytes.Scroll += new System.EventHandler(this.trackBarGygabytes_Scroll);
            // 
            // textBoxGygabytes
            // 
            this.textBoxGygabytes.Location = new System.Drawing.Point(288, 22);
            this.textBoxGygabytes.Name = "textBoxGygabytes";
            this.textBoxGygabytes.ReadOnly = true;
            this.textBoxGygabytes.Size = new System.Drawing.Size(206, 20);
            this.textBoxGygabytes.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(288, 106);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(206, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(288, 51);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.ReadOnly = true;
            this.textBoxMinutes.Size = new System.Drawing.Size(206, 20);
            this.textBoxMinutes.TabIndex = 3;
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(288, 78);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(206, 20);
            this.textBoxMessages.TabIndex = 3;
            // 
            // labelGygaValue
            // 
            this.labelGygaValue.AutoSize = true;
            this.labelGygaValue.Location = new System.Drawing.Point(490, 174);
            this.labelGygaValue.Name = "labelGygaValue";
            this.labelGygaValue.Size = new System.Drawing.Size(13, 13);
            this.labelGygaValue.TabIndex = 18;
            this.labelGygaValue.Text = "0";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(490, 221);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(13, 13);
            this.labelMinValue.TabIndex = 19;
            this.labelMinValue.Text = "0";
            // 
            // labelSMSValue
            // 
            this.labelSMSValue.AutoSize = true;
            this.labelSMSValue.Location = new System.Drawing.Point(490, 274);
            this.labelSMSValue.Name = "labelSMSValue";
            this.labelSMSValue.Size = new System.Drawing.Size(13, 13);
            this.labelSMSValue.TabIndex = 20;
            this.labelSMSValue.Text = "0";
            // 
            // buttonChooseRightTariff
            // 
            this.buttonChooseRightTariff.Location = new System.Drawing.Point(526, 15);
            this.buttonChooseRightTariff.Name = "buttonChooseRightTariff";
            this.buttonChooseRightTariff.Size = new System.Drawing.Size(165, 287);
            this.buttonChooseRightTariff.TabIndex = 24;
            this.buttonChooseRightTariff.Text = "Подходящий тариф ";
            this.buttonChooseRightTariff.UseVisualStyleBackColor = true;
            this.buttonChooseRightTariff.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTariffAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 316);
            this.Controls.Add(this.buttonChooseRightTariff);
            this.Controls.Add(this.labelSMSValue);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.labelGygaValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxTariffs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.labelGyga);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelSMS);
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
            this.Load += new System.EventHandler(this.FormTariffAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGygabytes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxTariffs;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGyga;
        private System.Windows.Forms.Label labelSMS;
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
        private System.Windows.Forms.Label labelGygaValue;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelSMSValue;
        private System.Windows.Forms.Button buttonChooseRightTariff;
    }
}

