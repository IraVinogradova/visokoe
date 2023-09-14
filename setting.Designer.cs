namespace visokoe
{
    partial class setting
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
            this.set_port = new System.Windows.Forms.Label();
            this.set_port_box = new System.Windows.Forms.NumericUpDown();
            this.setting_save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.set_port_box)).BeginInit();
            this.SuspendLayout();
            // 
            // set_port
            // 
            this.set_port.AutoSize = true;
            this.set_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_port.Location = new System.Drawing.Point(258, 79);
            this.set_port.Name = "set_port";
            this.set_port.Size = new System.Drawing.Size(79, 32);
            this.set_port.TabIndex = 1;
            this.set_port.Text = "Порт";
            // 
            // set_port_box
            // 
            this.set_port_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_port_box.Location = new System.Drawing.Point(388, 79);
            this.set_port_box.Name = "set_port_box";
            this.set_port_box.Size = new System.Drawing.Size(173, 38);
            this.set_port_box.TabIndex = 2;
            this.set_port_box.ValueChanged += new System.EventHandler(this.set_port_box_ValueChanged);
            // 
            // setting_save_button
            // 
            this.setting_save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setting_save_button.Location = new System.Drawing.Point(308, 340);
            this.setting_save_button.Name = "setting_save_button";
            this.setting_save_button.Size = new System.Drawing.Size(145, 58);
            this.setting_save_button.TabIndex = 3;
            this.setting_save_button.Text = "SAVE";
            this.setting_save_button.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setting_save_button);
            this.Controls.Add(this.set_port_box);
            this.Controls.Add(this.set_port);
            this.Name = "setting";
            this.Text = "setting";
            ((System.ComponentModel.ISupportInitialize)(this.set_port_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label set_port;
        private System.Windows.Forms.NumericUpDown set_port_box;
        private System.Windows.Forms.Button setting_save_button;
    }
}