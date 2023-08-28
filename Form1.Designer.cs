namespace visokoe
{
    partial class Panel
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
            this.clientconected = new System.Windows.Forms.Label();
            this.PLCcon = new System.Windows.Forms.Button();
            this.toPLC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ser_on = new System.Windows.Forms.Label();
            this.ser_cl = new System.Windows.Forms.Label();
            this.text_test = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientconected
            // 
            this.clientconected.AutoSize = true;
            this.clientconected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientconected.Location = new System.Drawing.Point(12, 9);
            this.clientconected.Name = "clientconected";
            this.clientconected.Size = new System.Drawing.Size(237, 29);
            this.clientconected.TabIndex = 4;
            this.clientconected.Text = "Клиент подключен";
            this.clientconected.Visible = false;
            // 
            // PLCcon
            // 
            this.PLCcon.Location = new System.Drawing.Point(34, 77);
            this.PLCcon.Name = "PLCcon";
            this.PLCcon.Size = new System.Drawing.Size(84, 42);
            this.PLCcon.TabIndex = 6;
            this.PLCcon.Text = "СТАРТ";
            this.PLCcon.UseVisualStyleBackColor = true;
            // 
            // toPLC
            // 
            this.toPLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPLC.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toPLC.Location = new System.Drawing.Point(388, 253);
            this.toPLC.Name = "toPLC";
            this.toPLC.Size = new System.Drawing.Size(461, 30);
            this.toPLC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "ToPLC";
            // 
            // ser_on
            // 
            this.ser_on.AutoSize = true;
            this.ser_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser_on.Location = new System.Drawing.Point(763, 9);
            this.ser_on.Name = "ser_on";
            this.ser_on.Size = new System.Drawing.Size(149, 29);
            this.ser_on.TabIndex = 10;
            this.ser_on.Text = "server is on";
            this.ser_on.Visible = false;
            // 
            // ser_cl
            // 
            this.ser_cl.AutoSize = true;
            this.ser_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ser_cl.Location = new System.Drawing.Point(763, 38);
            this.ser_cl.Name = "ser_cl";
            this.ser_cl.Size = new System.Drawing.Size(183, 29);
            this.ser_cl.TabIndex = 11;
            this.ser_cl.Text = "server is close";
            // 
            // text_test
            // 
            this.text_test.AutoSize = true;
            this.text_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_test.Location = new System.Drawing.Point(559, 165);
            this.text_test.Name = "text_test";
            this.text_test.Size = new System.Drawing.Size(27, 29);
            this.text_test.TabIndex = 12;
            this.text_test.Text = "#";
            this.text_test.UseMnemonic = false;
            this.text_test.Click += new System.EventHandler(this.text_test_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "fromPLC";
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(871, 253);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(75, 23);
            this.sendData.TabIndex = 15;
            this.sendData.Text = "send";
            this.sendData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 558);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_test);
            this.Controls.Add(this.ser_cl);
            this.Controls.Add(this.ser_on);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toPLC);
            this.Controls.Add(this.PLCcon);
            this.Controls.Add(this.clientconected);
            this.Name = "Panel";
            this.Text = "Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label clientconected;
        private System.Windows.Forms.Button PLCcon;
        private System.Windows.Forms.TextBox toPLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ser_on;
        private System.Windows.Forms.Label ser_cl;
        private System.Windows.Forms.Label text_test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendData;
    }
}

