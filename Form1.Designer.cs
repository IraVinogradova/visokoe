namespace visokoe
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
            this.button1 = new System.Windows.Forms.Button();
            this.serverison = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(118, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "PLC connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverison
            // 
            this.serverison.AutoSize = true;
            this.serverison.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverison.Location = new System.Drawing.Point(12, 9);
            this.serverison.Name = "serverison";
            this.serverison.Size = new System.Drawing.Size(519, 29);
            this.serverison.TabIndex = 4;
            this.serverison.Text = "Сервер запущен.Ожидание подключения...";
            this.serverison.Visible = false;
            this.serverison.Click += new System.EventHandler(this.serverison_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 91);
            this.button3.TabIndex = 6;
            this.button3.Text = "PLC connect2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.serverison);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label serverison;
        private System.Windows.Forms.Button button3;
    }
}

