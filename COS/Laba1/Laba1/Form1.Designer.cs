namespace Laba1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupF0 = new System.Windows.Forms.GroupBox();
            this.f0ParametrBox = new System.Windows.Forms.TextBox();
            this.f0ParametrLabel = new System.Windows.Forms.Label();
            this.f0MainBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupW0 = new System.Windows.Forms.GroupBox();
            this.w0ParametrBox = new System.Windows.Forms.TextBox();
            this.w0ParametrLabel = new System.Windows.Forms.Label();
            this.w0MainBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupA0 = new System.Windows.Forms.GroupBox();
            this.a0ParametrBox = new System.Windows.Forms.TextBox();
            this.a0ParametrLabel = new System.Windows.Forms.Label();
            this.a0MainBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yDec = new System.Windows.Forms.Button();
            this.yInc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xInc = new System.Windows.Forms.Button();
            this.xDec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupF0.SuspendLayout();
            this.groupW0.SuspendLayout();
            this.groupA0.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphic
            // 
            chartArea6.Name = "ChartArea1";
            this.graphic.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.graphic.Legends.Add(legend6);
            this.graphic.Location = new System.Drawing.Point(531, 12);
            this.graphic.Name = "graphic";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "S1";
            this.graphic.Series.Add(series6);
            this.graphic.Size = new System.Drawing.Size(378, 356);
            this.graphic.TabIndex = 0;
            this.graphic.Text = "graphic";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(281, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 327);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lines";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(7, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 277);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupF0);
            this.groupBox1.Controls.Add(this.groupW0);
            this.groupBox1.Controls.Add(this.groupA0);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 327);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupF0
            // 
            this.groupF0.Controls.Add(this.f0ParametrBox);
            this.groupF0.Controls.Add(this.f0ParametrLabel);
            this.groupF0.Controls.Add(this.f0MainBox);
            this.groupF0.Controls.Add(this.label9);
            this.groupF0.Controls.Add(this.label10);
            this.groupF0.Controls.Add(this.comboBox3);
            this.groupF0.Location = new System.Drawing.Point(5, 211);
            this.groupF0.Name = "groupF0";
            this.groupF0.Size = new System.Drawing.Size(254, 82);
            this.groupF0.TabIndex = 8;
            this.groupF0.TabStop = false;
            this.groupF0.Text = "f0";
            // 
            // f0ParametrBox
            // 
            this.f0ParametrBox.Location = new System.Drawing.Point(185, 47);
            this.f0ParametrBox.Name = "f0ParametrBox";
            this.f0ParametrBox.Size = new System.Drawing.Size(39, 20);
            this.f0ParametrBox.TabIndex = 11;
            this.f0ParametrBox.Visible = false;
            // 
            // f0ParametrLabel
            // 
            this.f0ParametrLabel.AutoSize = true;
            this.f0ParametrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f0ParametrLabel.Location = new System.Drawing.Point(138, 48);
            this.f0ParametrLabel.Name = "f0ParametrLabel";
            this.f0ParametrLabel.Size = new System.Drawing.Size(50, 17);
            this.f0ParametrLabel.TabIndex = 10;
            this.f0ParametrLabel.Text = "* w0 + ";
            this.f0ParametrLabel.Visible = false;
            // 
            // f0MainBox
            // 
            this.f0MainBox.Location = new System.Drawing.Point(94, 47);
            this.f0MainBox.Name = "f0MainBox";
            this.f0MainBox.Size = new System.Drawing.Size(38, 20);
            this.f0MainBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(50, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "f0 = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Depend on";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "no dependenses"});
            this.comboBox3.Location = new System.Drawing.Point(94, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // groupW0
            // 
            this.groupW0.Controls.Add(this.w0ParametrBox);
            this.groupW0.Controls.Add(this.w0ParametrLabel);
            this.groupW0.Controls.Add(this.w0MainBox);
            this.groupW0.Controls.Add(this.label6);
            this.groupW0.Controls.Add(this.label7);
            this.groupW0.Controls.Add(this.comboBox2);
            this.groupW0.Location = new System.Drawing.Point(5, 128);
            this.groupW0.Name = "groupW0";
            this.groupW0.Size = new System.Drawing.Size(254, 82);
            this.groupW0.TabIndex = 7;
            this.groupW0.TabStop = false;
            this.groupW0.Text = "w0";
            // 
            // w0ParametrBox
            // 
            this.w0ParametrBox.Location = new System.Drawing.Point(185, 47);
            this.w0ParametrBox.Name = "w0ParametrBox";
            this.w0ParametrBox.Size = new System.Drawing.Size(39, 20);
            this.w0ParametrBox.TabIndex = 11;
            this.w0ParametrBox.Visible = false;
            // 
            // w0ParametrLabel
            // 
            this.w0ParametrLabel.AutoSize = true;
            this.w0ParametrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w0ParametrLabel.Location = new System.Drawing.Point(138, 48);
            this.w0ParametrLabel.Name = "w0ParametrLabel";
            this.w0ParametrLabel.Size = new System.Drawing.Size(50, 17);
            this.w0ParametrLabel.TabIndex = 10;
            this.w0ParametrLabel.Text = "* w0 + ";
            this.w0ParametrLabel.Visible = false;
            // 
            // w0MainBox
            // 
            this.w0MainBox.Location = new System.Drawing.Point(94, 47);
            this.w0MainBox.Name = "w0MainBox";
            this.w0MainBox.Size = new System.Drawing.Size(38, 20);
            this.w0MainBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(50, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "w0 = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Depend on";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "no dependenses"});
            this.comboBox2.Location = new System.Drawing.Point(94, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // groupA0
            // 
            this.groupA0.Controls.Add(this.a0ParametrBox);
            this.groupA0.Controls.Add(this.a0ParametrLabel);
            this.groupA0.Controls.Add(this.a0MainBox);
            this.groupA0.Controls.Add(this.label3);
            this.groupA0.Controls.Add(this.label2);
            this.groupA0.Controls.Add(this.comboBox1);
            this.groupA0.Location = new System.Drawing.Point(5, 52);
            this.groupA0.Name = "groupA0";
            this.groupA0.Size = new System.Drawing.Size(254, 75);
            this.groupA0.TabIndex = 6;
            this.groupA0.TabStop = false;
            this.groupA0.Text = "A0";
            // 
            // a0ParametrBox
            // 
            this.a0ParametrBox.Location = new System.Drawing.Point(185, 43);
            this.a0ParametrBox.Name = "a0ParametrBox";
            this.a0ParametrBox.Size = new System.Drawing.Size(39, 20);
            this.a0ParametrBox.TabIndex = 5;
            this.a0ParametrBox.Visible = false;
            // 
            // a0ParametrLabel
            // 
            this.a0ParametrLabel.AutoSize = true;
            this.a0ParametrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a0ParametrLabel.Location = new System.Drawing.Point(138, 44);
            this.a0ParametrLabel.Name = "a0ParametrLabel";
            this.a0ParametrLabel.Size = new System.Drawing.Size(50, 17);
            this.a0ParametrLabel.TabIndex = 4;
            this.a0ParametrLabel.Text = "* w0 + ";
            this.a0ParametrLabel.Visible = false;
            // 
            // a0MainBox
            // 
            this.a0MainBox.Location = new System.Drawing.Point(94, 43);
            this.a0MainBox.Name = "a0MainBox";
            this.a0MainBox.Size = new System.Drawing.Size(38, 20);
            this.a0MainBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "A0 = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depend on";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "no dependenses"});
            this.comboBox1.Location = new System.Drawing.Point(94, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "x(t) = A0 * sin( w0 * t + f0)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Draw one line";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(189, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Add line to graphic";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Draw all lines";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.xInc);
            this.groupBox2.Controls.Add(this.xDec);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.yInc);
            this.groupBox2.Controls.Add(this.yDec);
            this.groupBox2.Location = new System.Drawing.Point(823, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scale";
            // 
            // yDec
            // 
            this.yDec.Location = new System.Drawing.Point(26, 22);
            this.yDec.Name = "yDec";
            this.yDec.Size = new System.Drawing.Size(23, 23);
            this.yDec.TabIndex = 0;
            this.yDec.Text = "-";
            this.yDec.UseVisualStyleBackColor = true;
            this.yDec.Click += new System.EventHandler(this.yDec_Click);
            // 
            // yInc
            // 
            this.yInc.Location = new System.Drawing.Point(51, 22);
            this.yInc.Name = "yInc";
            this.yInc.Size = new System.Drawing.Size(23, 23);
            this.yInc.TabIndex = 1;
            this.yInc.Text = "+";
            this.yInc.UseVisualStyleBackColor = true;
            this.yInc.Click += new System.EventHandler(this.yInc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "x";
            // 
            // xInc
            // 
            this.xInc.Location = new System.Drawing.Point(51, 51);
            this.xInc.Name = "xInc";
            this.xInc.Size = new System.Drawing.Size(23, 23);
            this.xInc.TabIndex = 4;
            this.xInc.Text = "+";
            this.xInc.UseVisualStyleBackColor = true;
            this.xInc.Click += new System.EventHandler(this.xInc_Click);
            // 
            // xDec
            // 
            this.xDec.Location = new System.Drawing.Point(26, 51);
            this.xDec.Name = "xDec";
            this.xDec.Size = new System.Drawing.Size(23, 23);
            this.xDec.TabIndex = 3;
            this.xDec.Text = "-";
            this.xDec.UseVisualStyleBackColor = true;
            this.xDec.Click += new System.EventHandler(this.xDec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.graphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laba 1";
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupF0.ResumeLayout(false);
            this.groupF0.PerformLayout();
            this.groupW0.ResumeLayout(false);
            this.groupW0.PerformLayout();
            this.groupA0.ResumeLayout(false);
            this.groupA0.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupF0;
        private System.Windows.Forms.TextBox f0ParametrBox;
        private System.Windows.Forms.Label f0ParametrLabel;
        private System.Windows.Forms.TextBox f0MainBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupW0;
        private System.Windows.Forms.TextBox w0ParametrBox;
        private System.Windows.Forms.Label w0ParametrLabel;
        private System.Windows.Forms.TextBox w0MainBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupA0;
        private System.Windows.Forms.TextBox a0ParametrBox;
        private System.Windows.Forms.Label a0ParametrLabel;
        private System.Windows.Forms.TextBox a0MainBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button xInc;
        private System.Windows.Forms.Button xDec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button yInc;
        private System.Windows.Forms.Button yDec;
    }
}

