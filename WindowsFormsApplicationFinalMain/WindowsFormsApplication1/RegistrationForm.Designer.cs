namespace WindowsFormsApplication1
{
    partial class RegistrationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.SerialInput = new System.Windows.Forms.TextBox();
            this.BYearInput = new System.Windows.Forms.TextBox();
            this.BMonthInput = new System.Windows.Forms.TextBox();
            this.BDayInput = new System.Windows.Forms.TextBox();
            this.SerialNumInput = new System.Windows.Forms.TextBox();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.FNameInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Серія ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Номер";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Прізвище";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Введіть ваші паспортні дані:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(259, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Ви перейшли в форму реєстрації нового клієнта.";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(21, 189);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(119, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Ім\'я";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(21, 215);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(119, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "По-батькові";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(21, 241);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(119, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Дата народження:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(175, 263);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(28, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "РР";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(233, 263);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(31, 20);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "ММ";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(297, 263);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(31, 20);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "ДД";
            // 
            // SerialInput
            // 
            this.SerialInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SerialInput.Location = new System.Drawing.Point(175, 100);
            this.SerialInput.MaxLength = 2;
            this.SerialInput.Name = "SerialInput";
            this.SerialInput.Size = new System.Drawing.Size(119, 20);
            this.SerialInput.TabIndex = 11;
            this.SerialInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialInput_KeyPress);
            // 
            // BYearInput
            // 
            this.BYearInput.Location = new System.Drawing.Point(175, 241);
            this.BYearInput.MaxLength = 4;
            this.BYearInput.Name = "BYearInput";
            this.BYearInput.Size = new System.Drawing.Size(31, 20);
            this.BYearInput.TabIndex = 12;
            this.BYearInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BYearInput_KeyPress);
            // 
            // BMonthInput
            // 
            this.BMonthInput.Location = new System.Drawing.Point(233, 241);
            this.BMonthInput.MaxLength = 2;
            this.BMonthInput.Name = "BMonthInput";
            this.BMonthInput.Size = new System.Drawing.Size(31, 20);
            this.BMonthInput.TabIndex = 13;
            this.BMonthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BMonthInput_KeyPress);
            // 
            // BDayInput
            // 
            this.BDayInput.Location = new System.Drawing.Point(297, 241);
            this.BDayInput.MaxLength = 2;
            this.BDayInput.Name = "BDayInput";
            this.BDayInput.Size = new System.Drawing.Size(31, 20);
            this.BDayInput.TabIndex = 14;
            this.BDayInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BDayInput_KeyPress);
            // 
            // SerialNumInput
            // 
            this.SerialNumInput.Location = new System.Drawing.Point(175, 126);
            this.SerialNumInput.MaxLength = 6;
            this.SerialNumInput.Name = "SerialNumInput";
            this.SerialNumInput.Size = new System.Drawing.Size(119, 20);
            this.SerialNumInput.TabIndex = 15;
            this.SerialNumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialNumInput_KeyPress);
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(175, 163);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(119, 20);
            this.SurnameInput.TabIndex = 16;
            this.SurnameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameInput_KeyPress);
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(175, 189);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(119, 20);
            this.NameInput.TabIndex = 17;
            this.NameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameInput_KeyPress);
            // 
            // FNameInput
            // 
            this.FNameInput.Location = new System.Drawing.Point(175, 215);
            this.FNameInput.Name = "FNameInput";
            this.FNameInput.Size = new System.Drawing.Size(119, 20);
            this.FNameInput.TabIndex = 18;
            this.FNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FNameInput_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(175, 317);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(119, 25);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 354);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FNameInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.SurnameInput);
            this.Controls.Add(this.SerialNumInput);
            this.Controls.Add(this.BDayInput);
            this.Controls.Add(this.BMonthInput);
            this.Controls.Add(this.BYearInput);
            this.Controls.Add(this.SerialInput);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(506, 392);
            this.MinimumSize = new System.Drawing.Size(506, 392);
            this.Name = "RegistrationForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox SerialInput;
        private System.Windows.Forms.TextBox BYearInput;
        private System.Windows.Forms.TextBox BMonthInput;
        private System.Windows.Forms.TextBox BDayInput;
        private System.Windows.Forms.TextBox SerialNumInput;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox FNameInput;
        private System.Windows.Forms.Button AddButton;
    }
}