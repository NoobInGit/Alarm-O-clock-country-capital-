namespace Alarm_O_clock
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TimeNow = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.on = new System.Windows.Forms.Button();
            this.off = new System.Windows.Forms.Button();
            this.AlarmTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeNow
            // 
            this.TimeNow.AutoSize = true;
            this.TimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TimeNow.Location = new System.Drawing.Point(72, 33);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(145, 55);
            this.TimeNow.TabIndex = 0;
            this.TimeNow.Text = "00:00";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.maskedTextBox1.Location = new System.Drawing.Point(22, 115);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(98, 50);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // on
            // 
            this.on.Location = new System.Drawing.Point(22, 171);
            this.on.Name = "on";
            this.on.Size = new System.Drawing.Size(98, 31);
            this.on.TabIndex = 2;
            this.on.Text = "Завести";
            this.on.UseVisualStyleBackColor = true;
            this.on.Click += new System.EventHandler(this.on_Click);
            // 
            // off
            // 
            this.off.Location = new System.Drawing.Point(159, 143);
            this.off.Name = "off";
            this.off.Size = new System.Drawing.Size(119, 59);
            this.off.TabIndex = 3;
            this.off.Text = "Отключить";
            this.off.UseVisualStyleBackColor = true;
            this.off.Click += new System.EventHandler(this.off_Click);
            // 
            // AlarmTime
            // 
            this.AlarmTime.AutoSize = true;
            this.AlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AlarmTime.Location = new System.Drawing.Point(29, 127);
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.Size = new System.Drawing.Size(82, 31);
            this.AlarmTime.TabIndex = 4;
            this.AlarmTime.Text = "00:00";
            this.AlarmTime.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlarmTime);
            this.Controls.Add(this.off);
            this.Controls.Add(this.on);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.TimeNow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeNow;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button on;
        private System.Windows.Forms.Button off;
        private System.Windows.Forms.Label AlarmTime;
        private System.Windows.Forms.Button button1;
    }
}

