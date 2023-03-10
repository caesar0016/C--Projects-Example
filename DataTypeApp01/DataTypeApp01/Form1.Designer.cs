namespace DataTypeApp01
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getShort = new System.Windows.Forms.TextBox();
            this.getInt = new System.Windows.Forms.TextBox();
            this.getLong = new System.Windows.Forms.TextBox();
            this.getDouble = new System.Windows.Forms.TextBox();
            this.getChar = new System.Windows.Forms.TextBox();
            this.nextForm01 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(25, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(741, 400);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter short";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Char";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter int";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Long";
            // 
            // getShort
            // 
            this.getShort.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getShort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getShort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getShort.Location = new System.Drawing.Point(171, 68);
            this.getShort.Multiline = true;
            this.getShort.Name = "getShort";
            this.getShort.Size = new System.Drawing.Size(220, 21);
            this.getShort.TabIndex = 11;
            // 
            // getInt
            // 
            this.getInt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getInt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getInt.Location = new System.Drawing.Point(171, 132);
            this.getInt.Multiline = true;
            this.getInt.Name = "getInt";
            this.getInt.Size = new System.Drawing.Size(220, 21);
            this.getInt.TabIndex = 12;
            this.getInt.TextChanged += new System.EventHandler(this.getInt_TextChanged);
            // 
            // getLong
            // 
            this.getLong.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getLong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getLong.Location = new System.Drawing.Point(171, 204);
            this.getLong.Multiline = true;
            this.getLong.Name = "getLong";
            this.getLong.Size = new System.Drawing.Size(220, 21);
            this.getLong.TabIndex = 13;
            // 
            // getDouble
            // 
            this.getDouble.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getDouble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getDouble.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getDouble.Location = new System.Drawing.Point(171, 272);
            this.getDouble.Multiline = true;
            this.getDouble.Name = "getDouble";
            this.getDouble.Size = new System.Drawing.Size(220, 21);
            this.getDouble.TabIndex = 14;
            // 
            // getChar
            // 
            this.getChar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.getChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getChar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getChar.Location = new System.Drawing.Point(171, 349);
            this.getChar.Multiline = true;
            this.getChar.Name = "getChar";
            this.getChar.Size = new System.Drawing.Size(220, 21);
            this.getChar.TabIndex = 15;
            // 
            // nextForm01
            // 
            this.nextForm01.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nextForm01.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextForm01.FlatAppearance.BorderSize = 4;
            this.nextForm01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextForm01.Location = new System.Drawing.Point(620, 349);
            this.nextForm01.Name = "nextForm01";
            this.nextForm01.Size = new System.Drawing.Size(112, 39);
            this.nextForm01.TabIndex = 16;
            this.nextForm01.Text = "Print";
            this.nextForm01.UseVisualStyleBackColor = false;
            this.nextForm01.Click += new System.EventHandler(this.nextForm01_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(35, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 48);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(35, 118);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(376, 48);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(35, 191);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(376, 48);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(35, 259);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(376, 48);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(35, 340);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(376, 48);
            this.textBox6.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.getDouble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.getLong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.getInt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getShort);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nextForm01);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox getShort;
        private TextBox getInt;
        private TextBox getLong;
        private TextBox getDouble;
        private TextBox getChar;
        private Button nextForm01;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}