namespace _45_WFControls
{
    partial class Form2
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            resultL = new Label();
            button2 = new Button();
            areaRB = new RadioButton();
            perimeterRB = new RadioButton();
            label4 = new Label();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            textBox5 = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 1;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 3;
            label2.Text = "G";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(70, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(70, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(26, 112);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 6;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(55, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(124, 140);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form Color";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultL);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(areaRB);
            groupBox2.Controls.Add(perimeterRB);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(272, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 135);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Circle";
            // 
            // resultL
            // 
            resultL.AutoSize = true;
            resultL.Location = new Point(135, 98);
            resultL.Name = "resultL";
            resultL.Size = new Size(39, 15);
            resultL.TabIndex = 10;
            resultL.Text = "Result";
            // 
            // button2
            // 
            button2.Location = new Point(54, 94);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // areaRB
            // 
            areaRB.AutoSize = true;
            areaRB.Location = new Point(54, 69);
            areaRB.Name = "areaRB";
            areaRB.Size = new Size(49, 19);
            areaRB.TabIndex = 3;
            areaRB.Text = "Area";
            areaRB.UseVisualStyleBackColor = true;
            // 
            // perimeterRB
            // 
            perimeterRB.AutoSize = true;
            perimeterRB.Checked = true;
            perimeterRB.Location = new Point(54, 44);
            perimeterRB.Name = "perimeterRB";
            perimeterRB.Size = new Size(76, 19);
            perimeterRB.TabIndex = 2;
            perimeterRB.TabStop = true;
            perimeterRB.Text = "Perimeter";
            perimeterRB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 1;
            label4.Text = "Radius";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(54, 16);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Red", "Green", "Blue", "Orange", "Yellow" });
            listBox1.Location = new Point(55, 216);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(133, 184);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(220, 216);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(386, 216);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton perimeterRB;
        private Label label4;
        private TextBox textBox4;
        private Label resultL;
        private Button button2;
        private RadioButton areaRB;
        private ListBox listBox1;
        private TextBox textBox5;
        private Button button3;
    }
}