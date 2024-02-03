namespace RomPackMidi
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(507, 509);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1098, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(572, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(666, 509);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(963, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 565);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "LineUp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(868, 574);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Note";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(778, 574);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 22);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Code";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(497, 565);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Auto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1098, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Setting";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(652, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 25);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(346, 574);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 22);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Auto Play";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 26);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 14;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(955, 12);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 22);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Auto Cange";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "FileName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = ".mid";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(363, 8);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(156, 22);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Fast Conversion";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 565);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 38);
            this.button6.TabIndex = 19;
            this.button6.Text = "All Convert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(652, 574);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(87, 22);
            this.checkBox6.TabIndex = 20;
            this.checkBox6.Text = "Reverb";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 615);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ROM to Midi Conbert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

