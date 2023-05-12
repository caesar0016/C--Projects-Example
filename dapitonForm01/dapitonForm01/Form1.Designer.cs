namespace dapitonForm01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lastNameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            firstNameBox = new TextBox();
            label4 = new Label();
            middleNameBox = new TextBox();
            maleRadio = new RadioButton();
            femaleRadio = new RadioButton();
            label5 = new Label();
            dayCombo = new ComboBox();
            monthCombo = new ComboBox();
            yearCombo = new ComboBox();
            programsCombo = new ComboBox();
            registerBttn = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 27);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(36, 102);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(196, 23);
            lastNameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 161);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 84);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(36, 192);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(196, 23);
            firstNameBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 243);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Middle Name";
            // 
            // middleNameBox
            // 
            middleNameBox.Location = new Point(36, 274);
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(196, 23);
            middleNameBox.TabIndex = 5;
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Location = new Point(48, 352);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(51, 19);
            maleRadio.TabIndex = 7;
            maleRadio.TabStop = true;
            maleRadio.Text = "Male";
            maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(105, 352);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(63, 19);
            femaleRadio.TabIndex = 8;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "Female";
            femaleRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 319);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // dayCombo
            // 
            dayCombo.FormattingEnabled = true;
            dayCombo.Location = new Point(303, 102);
            dayCombo.Name = "dayCombo";
            dayCombo.Size = new Size(121, 23);
            dayCombo.TabIndex = 10;
            dayCombo.Text = "-Day-";
            // 
            // monthCombo
            // 
            monthCombo.FormattingEnabled = true;
            monthCombo.Location = new Point(303, 153);
            monthCombo.Name = "monthCombo";
            monthCombo.Size = new Size(121, 23);
            monthCombo.TabIndex = 11;
            monthCombo.Text = "-Month-";
            // 
            // yearCombo
            // 
            yearCombo.FormattingEnabled = true;
            yearCombo.Location = new Point(303, 192);
            yearCombo.Name = "yearCombo";
            yearCombo.Size = new Size(121, 23);
            yearCombo.TabIndex = 12;
            yearCombo.Text = "-Year-";
            // 
            // programsCombo
            // 
            programsCombo.FormattingEnabled = true;
            programsCombo.Location = new Point(244, 319);
            programsCombo.Name = "programsCombo";
            programsCombo.Size = new Size(281, 23);
            programsCombo.TabIndex = 13;
            programsCombo.Text = "-Select Program -";
            // 
            // registerBttn
            // 
            registerBttn.Location = new Point(303, 362);
            registerBttn.Name = "registerBttn";
            registerBttn.Size = new Size(106, 25);
            registerBttn.TabIndex = 14;
            registerBttn.Text = "Register";
            registerBttn.UseVisualStyleBackColor = true;
            registerBttn.Click += registerBttn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 73);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 15;
            label6.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 282);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 16;
            label7.Text = "Program to Apply";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(558, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 174);
            panel1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(registerBttn);
            Controls.Add(programsCombo);
            Controls.Add(yearCombo);
            Controls.Add(monthCombo);
            Controls.Add(dayCombo);
            Controls.Add(label5);
            Controls.Add(femaleRadio);
            Controls.Add(maleRadio);
            Controls.Add(label4);
            Controls.Add(middleNameBox);
            Controls.Add(label3);
            Controls.Add(firstNameBox);
            Controls.Add(label2);
            Controls.Add(lastNameBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lastNameBox;
        private Label label2;
        private Label label3;
        private TextBox firstNameBox;
        private Label label4;
        private TextBox middleNameBox;
        private RadioButton maleRadio;
        private RadioButton femaleRadio;
        private Label label5;
        private ComboBox dayCombo;
        private ComboBox monthCombo;
        private ComboBox yearCombo;
        private ComboBox programsCombo;
        private Button registerBttn;
        private Label label6;
        private Label label7;
        private Panel panel1;
    }
}