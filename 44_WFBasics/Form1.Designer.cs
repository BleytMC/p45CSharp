namespace _44_WFBasics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Segoe UI", 20F);
            textLabel.Location = new Point(83, 81);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(80, 37);
            textLabel.TabIndex = 0;
            textLabel.Text = "Hello";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(249, 81);
            button1.Name = "button1";
            button1.Size = new Size(99, 62);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(392, 81);
            button2.Name = "button2";
            button2.Size = new Size(93, 62);
            button2.TabIndex = 2;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseMove += button2_MouseMove;
            // 
            // button3
            // 
            button3.Location = new Point(531, 81);
            button3.Name = "button3";
            button3.Size = new Size(93, 62);
            button3.TabIndex = 3;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 18F);
            timeLabel.Location = new Point(83, 215);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(67, 32);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 250);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer2;
        private Label timeLabel;
        private Label label1;
    }
}
