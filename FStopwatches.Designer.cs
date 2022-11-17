namespace Stopwatches
{
    partial class FStopwatches
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnToggleTopMost = new System.Windows.Forms.Button();
            this.btnChangeOpacity = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 27);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(389, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Tag = "1";
            this.button1.Text = "s";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startStop);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(427, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Tag = "1";
            this.button2.Text = "r";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reset);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(299, 12);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.Text = "000000";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 257;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnToggleTopMost
            // 
            this.btnToggleTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleTopMost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnToggleTopMost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggleTopMost.Location = new System.Drawing.Point(463, -3);
            this.btnToggleTopMost.Name = "btnToggleTopMost";
            this.btnToggleTopMost.Size = new System.Drawing.Size(32, 32);
            this.btnToggleTopMost.TabIndex = 10;
            this.btnToggleTopMost.TabStop = false;
            this.btnToggleTopMost.Text = "p";
            this.btnToggleTopMost.UseVisualStyleBackColor = true;
            this.btnToggleTopMost.Click += new System.EventHandler(this.btnToggleTopMost_Click);
            // 
            // btnChangeOpacity
            // 
            this.btnChangeOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeOpacity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeOpacity.Location = new System.Drawing.Point(463, 25);
            this.btnChangeOpacity.Name = "btnChangeOpacity";
            this.btnChangeOpacity.Size = new System.Drawing.Size(32, 32);
            this.btnChangeOpacity.TabIndex = 11;
            this.btnChangeOpacity.TabStop = false;
            this.btnChangeOpacity.Text = ".";
            this.btnChangeOpacity.UseVisualStyleBackColor = true;
            this.btnChangeOpacity.Click += new System.EventHandler(this.btnChangeOpacity_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.Location = new System.Drawing.Point(299, 45);
            this.maskedTextBox2.Mask = "00:00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox2.TabIndex = 15;
            this.maskedTextBox2.Text = "000000";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 27);
            this.textBox2.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(427, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 14;
            this.button4.TabStop = false;
            this.button4.Tag = "2";
            this.button4.Text = "r";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.reset);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(389, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 13;
            this.button5.TabStop = false;
            this.button5.Tag = "2";
            this.button5.Text = "s";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox3.Location = new System.Drawing.Point(299, 78);
            this.maskedTextBox3.Mask = "00:00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox3.TabIndex = 19;
            this.maskedTextBox3.Text = "000000";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(12, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 27);
            this.textBox3.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(427, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 18;
            this.button6.TabStop = false;
            this.button6.Tag = "3";
            this.button6.Text = "r";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.reset);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(389, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 17;
            this.button7.TabStop = false;
            this.button7.Tag = "3";
            this.button7.Text = "s";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox4.Location = new System.Drawing.Point(299, 111);
            this.maskedTextBox4.Mask = "00:00:00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox4.TabIndex = 23;
            this.maskedTextBox4.Text = "000000";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox4.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(12, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(281, 27);
            this.textBox4.TabIndex = 20;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(427, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 22;
            this.button8.TabStop = false;
            this.button8.Tag = "4";
            this.button8.Text = "r";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.reset);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Location = new System.Drawing.Point(389, 108);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 32);
            this.button9.TabIndex = 21;
            this.button9.TabStop = false;
            this.button9.Tag = "4";
            this.button9.Text = "s";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox5.Location = new System.Drawing.Point(299, 144);
            this.maskedTextBox5.Mask = "00:00:00";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox5.TabIndex = 27;
            this.maskedTextBox5.Text = "000000";
            this.maskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox5.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(12, 144);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(281, 27);
            this.textBox5.TabIndex = 24;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.Location = new System.Drawing.Point(427, 141);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 32);
            this.button10.TabIndex = 26;
            this.button10.TabStop = false;
            this.button10.Tag = "5";
            this.button10.Text = "r";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.reset);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Location = new System.Drawing.Point(389, 141);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 32);
            this.button11.TabIndex = 25;
            this.button11.TabStop = false;
            this.button11.Tag = "5";
            this.button11.Text = "s";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox6.Location = new System.Drawing.Point(299, 177);
            this.maskedTextBox6.Mask = "00:00:00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox6.TabIndex = 31;
            this.maskedTextBox6.Text = "000000";
            this.maskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox6.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(12, 177);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(281, 27);
            this.textBox6.TabIndex = 28;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button12.Location = new System.Drawing.Point(427, 174);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 32);
            this.button12.TabIndex = 30;
            this.button12.TabStop = false;
            this.button12.Tag = "6";
            this.button12.Text = "r";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.reset);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button13.Location = new System.Drawing.Point(389, 174);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 32);
            this.button13.TabIndex = 29;
            this.button13.TabStop = false;
            this.button13.Tag = "6";
            this.button13.Text = "s";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox7.Location = new System.Drawing.Point(299, 210);
            this.maskedTextBox7.Mask = "00:00:00";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox7.TabIndex = 35;
            this.maskedTextBox7.Text = "000000";
            this.maskedTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox7.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(12, 210);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(281, 27);
            this.textBox7.TabIndex = 32;
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button14.Location = new System.Drawing.Point(427, 207);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(32, 32);
            this.button14.TabIndex = 34;
            this.button14.TabStop = false;
            this.button14.Tag = "7";
            this.button14.Text = "r";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.reset);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button15.Location = new System.Drawing.Point(389, 207);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(32, 32);
            this.button15.TabIndex = 33;
            this.button15.TabStop = false;
            this.button15.Tag = "7";
            this.button15.Text = "s";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox8.Location = new System.Drawing.Point(299, 243);
            this.maskedTextBox8.Mask = "00:00:00";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox8.TabIndex = 39;
            this.maskedTextBox8.Text = "000000";
            this.maskedTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox8.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(12, 243);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(281, 27);
            this.textBox8.TabIndex = 36;
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button16.Location = new System.Drawing.Point(427, 240);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(32, 32);
            this.button16.TabIndex = 38;
            this.button16.TabStop = false;
            this.button16.Tag = "8";
            this.button16.Text = "r";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.reset);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button17.Location = new System.Drawing.Point(389, 240);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(32, 32);
            this.button17.TabIndex = 37;
            this.button17.TabStop = false;
            this.button17.Tag = "8";
            this.button17.Text = "s";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox9.Location = new System.Drawing.Point(299, 276);
            this.maskedTextBox9.Mask = "00:00:00";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox9.TabIndex = 43;
            this.maskedTextBox9.Text = "000000";
            this.maskedTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox9.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(12, 276);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(281, 27);
            this.textBox9.TabIndex = 40;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button18.Location = new System.Drawing.Point(427, 273);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(32, 32);
            this.button18.TabIndex = 42;
            this.button18.TabStop = false;
            this.button18.Tag = "9";
            this.button18.Text = "r";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.reset);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button19.Location = new System.Drawing.Point(389, 273);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(32, 32);
            this.button19.TabIndex = 41;
            this.button19.TabStop = false;
            this.button19.Tag = "9";
            this.button19.Text = "s";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.startStop);
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox10.Location = new System.Drawing.Point(299, 309);
            this.maskedTextBox10.Mask = "00:00:00";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(84, 27);
            this.maskedTextBox10.TabIndex = 47;
            this.maskedTextBox10.Text = "000000";
            this.maskedTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox10.TextChanged += new System.EventHandler(this.calcTotal);
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(12, 309);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(281, 27);
            this.textBox10.TabIndex = 44;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button20.Location = new System.Drawing.Point(427, 306);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(32, 32);
            this.button20.TabIndex = 46;
            this.button20.TabStop = false;
            this.button20.Tag = "10";
            this.button20.Text = "r";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.reset);
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button21.Location = new System.Drawing.Point(389, 306);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(32, 32);
            this.button21.TabIndex = 45;
            this.button21.TabStop = false;
            this.button21.Tag = "10";
            this.button21.Text = "s";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.startStop);
            // 
            // FStopwatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(496, 358);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnChangeOpacity);
            this.Controls.Add(this.btnToggleTopMost);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(295, 88);
            this.Name = "FStopwatches";
            this.Text = "Stopwatches";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FStopwatches_FormClosing);
            this.Load += new System.EventHandler(this.FStopwatches_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnToggleTopMost;
        private Button btnChangeOpacity;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox3;
        private Button button6;
        private Button button7;
        private MaskedTextBox maskedTextBox4;
        private TextBox textBox4;
        private Button button8;
        private Button button9;
        private MaskedTextBox maskedTextBox5;
        private TextBox textBox5;
        private Button button10;
        private Button button11;
        private MaskedTextBox maskedTextBox6;
        private TextBox textBox6;
        private Button button12;
        private Button button13;
        private MaskedTextBox maskedTextBox7;
        private TextBox textBox7;
        private Button button14;
        private Button button15;
        private MaskedTextBox maskedTextBox8;
        private TextBox textBox8;
        private Button button16;
        private Button button17;
        private MaskedTextBox maskedTextBox9;
        private TextBox textBox9;
        private Button button18;
        private Button button19;
        private MaskedTextBox maskedTextBox10;
        private TextBox textBox10;
        private Button button20;
        private Button button21;
    }
}