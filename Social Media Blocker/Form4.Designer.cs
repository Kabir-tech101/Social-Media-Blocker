namespace Final_Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_seconds = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SetTimer = new System.Windows.Forms.Button();
            this.btn_1hour = new System.Windows.Forms.Button();
            this.btn_2hour = new System.Windows.Forms.Button();
            this.btn_6hour = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_seconds
            // 
            this.lbl_seconds.AutoSize = true;
            this.lbl_seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seconds.Location = new System.Drawing.Point(234, 95);
            this.lbl_seconds.Name = "lbl_seconds";
            this.lbl_seconds.Size = new System.Drawing.Size(242, 46);
            this.lbl_seconds.TabIndex = 0;
            this.lbl_seconds.Text = "60 Seconds";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_start.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(242, 157);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(101, 43);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_reset.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(359, 157);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(97, 43);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Pause.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Location = new System.Drawing.Point(300, 206);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(106, 39);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(212, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 41);
            this.textBox1.TabIndex = 4;
            // 
            // btn_SetTimer
            // 
            this.btn_SetTimer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SetTimer.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetTimer.Location = new System.Drawing.Point(300, 375);
            this.btn_SetTimer.Name = "btn_SetTimer";
            this.btn_SetTimer.Size = new System.Drawing.Size(106, 37);
            this.btn_SetTimer.TabIndex = 5;
            this.btn_SetTimer.Text = "Set Timer";
            this.btn_SetTimer.UseVisualStyleBackColor = false;
            this.btn_SetTimer.Click += new System.EventHandler(this.btn_SetTimer_Click);
            // 
            // btn_1hour
            // 
            this.btn_1hour.BackColor = System.Drawing.Color.Wheat;
            this.btn_1hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1hour.Location = new System.Drawing.Point(619, 95);
            this.btn_1hour.Name = "btn_1hour";
            this.btn_1hour.Size = new System.Drawing.Size(100, 31);
            this.btn_1hour.TabIndex = 6;
            this.btn_1hour.Text = "1 hour";
            this.btn_1hour.UseVisualStyleBackColor = false;
            this.btn_1hour.Click += new System.EventHandler(this.btn_1hour_Click);
            // 
            // btn_2hour
            // 
            this.btn_2hour.BackColor = System.Drawing.Color.Moccasin;
            this.btn_2hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2hour.Location = new System.Drawing.Point(619, 146);
            this.btn_2hour.Name = "btn_2hour";
            this.btn_2hour.Size = new System.Drawing.Size(100, 31);
            this.btn_2hour.TabIndex = 7;
            this.btn_2hour.Text = "2 hour";
            this.btn_2hour.UseVisualStyleBackColor = false;
            this.btn_2hour.Click += new System.EventHandler(this.btn_2hour_Click);
            // 
            // btn_6hour
            // 
            this.btn_6hour.BackColor = System.Drawing.Color.Wheat;
            this.btn_6hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6hour.Location = new System.Drawing.Point(619, 196);
            this.btn_6hour.Name = "btn_6hour";
            this.btn_6hour.Size = new System.Drawing.Size(100, 31);
            this.btn_6hour.TabIndex = 8;
            this.btn_6hour.Text = "6 hour";
            this.btn_6hour.UseVisualStyleBackColor = false;
            this.btn_6hour.Click += new System.EventHandler(this.btn_6hour_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(623, 379);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(96, 33);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type time in seconds and click set timer for the blocker to run";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_6hour);
            this.Controls.Add(this.btn_2hour);
            this.Controls.Add(this.btn_1hour);
            this.Controls.Add(this.btn_SetTimer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_seconds);
            this.Name = "Form4";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_seconds;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SetTimer;
        private System.Windows.Forms.Button btn_1hour;
        private System.Windows.Forms.Button btn_2hour;
        private System.Windows.Forms.Button btn_6hour;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
    }
}