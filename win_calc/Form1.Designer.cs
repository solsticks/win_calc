﻿namespace win_calc
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
            this.result = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(12, 27);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(402, 97);
            this.result.TabIndex = 0;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(11, 252);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(97, 69);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(317, 252);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(97, 69);
            this.times.TabIndex = 1;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(215, 252);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(97, 69);
            this.nine.TabIndex = 1;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(113, 252);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(97, 69);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(11, 327);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(97, 69);
            this.four.TabIndex = 1;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(113, 327);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(97, 69);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(215, 327);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(97, 69);
            this.six.TabIndex = 1;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(317, 327);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(97, 69);
            this.sub.TabIndex = 1;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(11, 402);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(97, 69);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(113, 402);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(97, 69);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(215, 402);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(97, 69);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(317, 402);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 69);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(317, 477);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(97, 69);
            this.equal.TabIndex = 1;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.operators_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(215, 477);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(97, 69);
            this.button14.TabIndex = 1;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(113, 477);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(97, 69);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(11, 477);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(97, 69);
            this.button16.TabIndex = 1;
            this.button16.Text = "+/-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(11, 177);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(97, 69);
            this.button17.TabIndex = 1;
            this.button17.Text = "←";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.buttonBS_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(113, 177);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(97, 69);
            this.button18.TabIndex = 1;
            this.button18.Text = "CE";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(215, 177);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(97, 69);
            this.button19.TabIndex = 1;
            this.button19.Text = "C";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.buttonCC_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(317, 177);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(97, 69);
            this.div.TabIndex = 1;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 552);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.times);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.result);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(443, 599);
            this.MinimumSize = new System.Drawing.Size(443, 599);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button zero;
    }
}

