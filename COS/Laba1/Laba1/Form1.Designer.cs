﻿namespace Laba1
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
            this.components = new System.ComponentModel.Container();
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
            this.oneLineButton = new System.Windows.Forms.Button();
            this.addLineButton = new System.Windows.Forms.Button();
            this.allLinesButton = new System.Windows.Forms.Button();
            this.polyharmonicButton = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupF0.SuspendLayout();
            this.groupW0.SuspendLayout();
            this.groupA0.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(542, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 282);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lines";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 246);
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
            this.listBox1.Size = new System.Drawing.Size(231, 225);
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
            this.groupBox1.Size = new System.Drawing.Size(524, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(522, 23);
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
            this.groupF0.Location = new System.Drawing.Point(142, 126);
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
            this.comboBox3.Location = new System.Drawing.Point(94, 18);
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
            this.groupW0.Location = new System.Drawing.Point(265, 52);
            this.groupW0.Name = "groupW0";
            this.groupW0.Size = new System.Drawing.Size(254, 75);
            this.groupW0.TabIndex = 7;
            this.groupW0.TabStop = false;
            this.groupW0.Text = "w0";
            // 
            // w0ParametrBox
            // 
            this.w0ParametrBox.Location = new System.Drawing.Point(184, 42);
            this.w0ParametrBox.Name = "w0ParametrBox";
            this.w0ParametrBox.Size = new System.Drawing.Size(39, 20);
            this.w0ParametrBox.TabIndex = 11;
            this.w0ParametrBox.Visible = false;
            // 
            // w0ParametrLabel
            // 
            this.w0ParametrLabel.AutoSize = true;
            this.w0ParametrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.w0ParametrLabel.Location = new System.Drawing.Point(137, 43);
            this.w0ParametrLabel.Name = "w0ParametrLabel";
            this.w0ParametrLabel.Size = new System.Drawing.Size(50, 17);
            this.w0ParametrLabel.TabIndex = 10;
            this.w0ParametrLabel.Text = "* w0 + ";
            this.w0ParametrLabel.Visible = false;
            // 
            // w0MainBox
            // 
            this.w0MainBox.Location = new System.Drawing.Point(93, 42);
            this.w0MainBox.Name = "w0MainBox";
            this.w0MainBox.Size = new System.Drawing.Size(38, 20);
            this.w0MainBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(49, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "w0 = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 15);
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
            this.comboBox2.Location = new System.Drawing.Point(92, 12);
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
            // oneLineButton
            // 
            this.oneLineButton.Enabled = false;
            this.oneLineButton.Location = new System.Drawing.Point(21, 252);
            this.oneLineButton.Name = "oneLineButton";
            this.oneLineButton.Size = new System.Drawing.Size(128, 23);
            this.oneLineButton.TabIndex = 6;
            this.oneLineButton.Text = "Draw one line";
            this.oneLineButton.UseVisualStyleBackColor = true;
            this.oneLineButton.Click += new System.EventHandler(this.oneLineButton_Click);
            // 
            // addLineButton
            // 
            this.addLineButton.Enabled = false;
            this.addLineButton.Location = new System.Drawing.Point(155, 252);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(125, 23);
            this.addLineButton.TabIndex = 7;
            this.addLineButton.Text = "Add line to graphic";
            this.addLineButton.UseVisualStyleBackColor = true;
            this.addLineButton.Click += new System.EventHandler(this.addLineButton_Click);
            // 
            // allLinesButton
            // 
            this.allLinesButton.Enabled = false;
            this.allLinesButton.Location = new System.Drawing.Point(297, 252);
            this.allLinesButton.Name = "allLinesButton";
            this.allLinesButton.Size = new System.Drawing.Size(111, 23);
            this.allLinesButton.TabIndex = 8;
            this.allLinesButton.Text = "Draw all lines";
            this.allLinesButton.UseVisualStyleBackColor = true;
            this.allLinesButton.Click += new System.EventHandler(this.allLinesButton_Click);
            // 
            // polyharmonicButton
            // 
            this.polyharmonicButton.Enabled = false;
            this.polyharmonicButton.Location = new System.Drawing.Point(414, 252);
            this.polyharmonicButton.Name = "polyharmonicButton";
            this.polyharmonicButton.Size = new System.Drawing.Size(114, 23);
            this.polyharmonicButton.TabIndex = 10;
            this.polyharmonicButton.Text = "Draw polyharmonic";
            this.polyharmonicButton.UseVisualStyleBackColor = true;
            this.polyharmonicButton.Click += new System.EventHandler(this.polyharmonicButton_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(12, 293);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(774, 404);
            this.zedGraph.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 703);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.polyharmonicButton);
            this.Controls.Add(this.allLinesButton);
            this.Controls.Add(this.addLineButton);
            this.Controls.Add(this.oneLineButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laba 1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupF0.ResumeLayout(false);
            this.groupF0.PerformLayout();
            this.groupW0.ResumeLayout(false);
            this.groupW0.PerformLayout();
            this.groupA0.ResumeLayout(false);
            this.groupA0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button oneLineButton;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.Button allLinesButton;
        private System.Windows.Forms.Button polyharmonicButton;
        private ZedGraph.ZedGraphControl zedGraph;
    }
}

