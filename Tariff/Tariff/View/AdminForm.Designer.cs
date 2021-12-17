
namespace Tariff
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTariffs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxGygabytes = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMinutes = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMessages = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // listBoxTariffs
            // 
            this.listBoxTariffs.FormattingEnabled = true;
            this.listBoxTariffs.Location = new System.Drawing.Point(15, 25);
            this.listBoxTariffs.Name = "listBoxTariffs";
            this.listBoxTariffs.Size = new System.Drawing.Size(199, 199);
            this.listBoxTariffs.TabIndex = 15;
            this.listBoxTariffs.SelectedIndexChanged += new System.EventHandler(this.listBoxTariffs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тарифы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Минуты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Гигабайты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SMS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цена";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(288, 165);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(140, 23);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(288, 194);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(140, 23);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(288, 223);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(288, 132);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // maskedTextBoxGygabytes
            // 
            this.maskedTextBoxGygabytes.Location = new System.Drawing.Point(289, 18);
            this.maskedTextBoxGygabytes.Mask = "000";
            this.maskedTextBoxGygabytes.Name = "maskedTextBoxGygabytes";
            this.maskedTextBoxGygabytes.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBoxGygabytes.TabIndex = 17;
            // 
            // maskedTextBoxMinutes
            // 
            this.maskedTextBoxMinutes.Location = new System.Drawing.Point(288, 48);
            this.maskedTextBoxMinutes.Mask = "0000";
            this.maskedTextBoxMinutes.Name = "maskedTextBoxMinutes";
            this.maskedTextBoxMinutes.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxMinutes.TabIndex = 17;
            // 
            // maskedTextBoxMessages
            // 
            this.maskedTextBoxMessages.Location = new System.Drawing.Point(288, 75);
            this.maskedTextBoxMessages.Mask = "0000";
            this.maskedTextBoxMessages.Name = "maskedTextBoxMessages";
            this.maskedTextBoxMessages.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxMessages.TabIndex = 17;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(288, 103);
            this.maskedTextBoxPrice.Mask = "00000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxPrice.TabIndex = 17;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 285);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.maskedTextBoxMessages);
            this.Controls.Add(this.maskedTextBoxMinutes);
            this.Controls.Add(this.maskedTextBoxGygabytes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxTariffs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTariffs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGygabytes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMinutes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMessages;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
    }
}