namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.LogText = new System.Windows.Forms.TextBox();
            this.CodeInput = new System.Windows.Forms.TextBox();
            this.EnterTheBank = new System.Windows.Forms.Button();
            this.PersonInfo = new System.Windows.Forms.RichTextBox();
            this.NewClientText = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SumInput = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AddDeposit = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SumBox = new System.Windows.Forms.GroupBox();
            this.TermBox = new System.Windows.Forms.GroupBox();
            this.TwFourMonth = new System.Windows.Forms.RadioButton();
            this.TwelveMonth = new System.Windows.Forms.RadioButton();
            this.SixMonth = new System.Windows.Forms.RadioButton();
            this.AddMBox = new System.Windows.Forms.Button();
            this.DepositAddMenu = new System.Windows.Forms.Button();
            this.AddMBoxMenu = new System.Windows.Forms.Button();
            this.BalanceCheck = new System.Windows.Forms.Button();
            this.Replenish = new System.Windows.Forms.Button();
            this.WithdrawBox = new System.Windows.Forms.GroupBox();
            this.GetFromMBox = new System.Windows.Forms.Button();
            this.StopDeposit = new System.Windows.Forms.Button();
            this.WithdrawSumInput = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.WithdrawSumBox = new System.Windows.Forms.GroupBox();
            this.WithdrawMBoxNum = new System.Windows.Forms.NumericUpDown();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ConfirmMBoxWithdrawal = new System.Windows.Forms.Button();
            this.ToolBarBox = new System.Windows.Forms.GroupBox();
            this.WithdrawMenu = new System.Windows.Forms.Button();
            this.LogInToolBarBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RepenishBox = new System.Windows.Forms.GroupBox();
            this.MBoxNumInput = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ConfirmRepenishment = new System.Windows.Forms.Button();
            this.RepenishInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.StopDepNumBox = new System.Windows.Forms.GroupBox();
            this.ConfirmStopDep = new System.Windows.Forms.Button();
            this.StopDepNum = new System.Windows.Forms.NumericUpDown();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.RefrAccNums = new System.Windows.Forms.Button();
            this.DeleteMBox = new System.Windows.Forms.Button();
            this.SumBox.SuspendLayout();
            this.TermBox.SuspendLayout();
            this.WithdrawBox.SuspendLayout();
            this.WithdrawSumBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WithdrawMBoxNum)).BeginInit();
            this.ToolBarBox.SuspendLayout();
            this.LogInToolBarBox.SuspendLayout();
            this.RepenishBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBoxNumInput)).BeginInit();
            this.StopDepNumBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopDepNum)).BeginInit();
            this.SuspendLayout();
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(6, 9);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(171, 20);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "Увійти за номером рахунку";
            // 
            // CodeInput
            // 
            this.CodeInput.Location = new System.Drawing.Point(6, 35);
            this.CodeInput.Name = "CodeInput";
            this.CodeInput.Size = new System.Drawing.Size(170, 20);
            this.CodeInput.TabIndex = 1;
            this.CodeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeInput_KeyPress);
            // 
            // EnterTheBank
            // 
            this.EnterTheBank.Location = new System.Drawing.Point(183, 35);
            this.EnterTheBank.Name = "EnterTheBank";
            this.EnterTheBank.Size = new System.Drawing.Size(111, 24);
            this.EnterTheBank.TabIndex = 2;
            this.EnterTheBank.Text = "Увійти";
            this.EnterTheBank.UseVisualStyleBackColor = true;
            this.EnterTheBank.Click += new System.EventHandler(this.Enter_Click);
            // 
            // PersonInfo
            // 
            this.PersonInfo.Location = new System.Drawing.Point(352, 12);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.ReadOnly = true;
            this.PersonInfo.Size = new System.Drawing.Size(359, 328);
            this.PersonInfo.TabIndex = 3;
            this.PersonInfo.Text = "";
            // 
            // NewClientText
            // 
            this.NewClientText.Location = new System.Drawing.Point(6, 65);
            this.NewClientText.Name = "NewClientText";
            this.NewClientText.ReadOnly = true;
            this.NewClientText.Size = new System.Drawing.Size(171, 20);
            this.NewClientText.TabIndex = 4;
            this.NewClientText.Text = "Новий клієнт?";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(183, 65);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(111, 24);
            this.Register.TabIndex = 5;
            this.Register.Text = "Зареєструватися";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Сума";
            // 
            // SumInput
            // 
            this.SumInput.Location = new System.Drawing.Point(174, 9);
            this.SumInput.Name = "SumInput";
            this.SumInput.Size = new System.Drawing.Size(116, 20);
            this.SumInput.TabIndex = 8;
            this.SumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumInput_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Термін";
            // 
            // AddDeposit
            // 
            this.AddDeposit.Location = new System.Drawing.Point(21, 413);
            this.AddDeposit.Name = "AddDeposit";
            this.AddDeposit.Size = new System.Drawing.Size(115, 26);
            this.AddDeposit.TabIndex = 11;
            this.AddDeposit.Text = "Додати депозит";
            this.AddDeposit.UseVisualStyleBackColor = true;
            this.AddDeposit.Visible = false;
            this.AddDeposit.Click += new System.EventHandler(this.AddDeposit_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(594, 346);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(117, 31);
            this.LogOut.TabIndex = 12;
            this.LogOut.Text = "Зберегти та вийти";
            this.LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Visible = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // SumBox
            // 
            this.SumBox.Controls.Add(this.textBox3);
            this.SumBox.Controls.Add(this.SumInput);
            this.SumBox.Location = new System.Drawing.Point(22, 325);
            this.SumBox.Name = "SumBox";
            this.SumBox.Size = new System.Drawing.Size(311, 35);
            this.SumBox.TabIndex = 13;
            this.SumBox.TabStop = false;
            this.SumBox.Visible = false;
            // 
            // TermBox
            // 
            this.TermBox.Controls.Add(this.TwFourMonth);
            this.TermBox.Controls.Add(this.TwelveMonth);
            this.TermBox.Controls.Add(this.SixMonth);
            this.TermBox.Controls.Add(this.textBox5);
            this.TermBox.Location = new System.Drawing.Point(21, 366);
            this.TermBox.Name = "TermBox";
            this.TermBox.Size = new System.Drawing.Size(312, 41);
            this.TermBox.TabIndex = 14;
            this.TermBox.TabStop = false;
            this.TermBox.Visible = false;
            // 
            // TwFourMonth
            // 
            this.TwFourMonth.AutoSize = true;
            this.TwFourMonth.Location = new System.Drawing.Point(259, 16);
            this.TwFourMonth.Name = "TwFourMonth";
            this.TwFourMonth.Size = new System.Drawing.Size(56, 17);
            this.TwFourMonth.TabIndex = 12;
            this.TwFourMonth.TabStop = true;
            this.TwFourMonth.Text = "24 міс";
            this.TwFourMonth.UseVisualStyleBackColor = true;
            // 
            // TwelveMonth
            // 
            this.TwelveMonth.AutoSize = true;
            this.TwelveMonth.Location = new System.Drawing.Point(197, 16);
            this.TwelveMonth.Name = "TwelveMonth";
            this.TwelveMonth.Size = new System.Drawing.Size(56, 17);
            this.TwelveMonth.TabIndex = 11;
            this.TwelveMonth.TabStop = true;
            this.TwelveMonth.Text = "12 міс";
            this.TwelveMonth.UseVisualStyleBackColor = true;
            // 
            // SixMonth
            // 
            this.SixMonth.AutoSize = true;
            this.SixMonth.Location = new System.Drawing.Point(141, 16);
            this.SixMonth.Name = "SixMonth";
            this.SixMonth.Size = new System.Drawing.Size(50, 17);
            this.SixMonth.TabIndex = 10;
            this.SixMonth.TabStop = true;
            this.SixMonth.Text = "6 міс";
            this.SixMonth.UseVisualStyleBackColor = true;
            // 
            // AddMBox
            // 
            this.AddMBox.Location = new System.Drawing.Point(204, 413);
            this.AddMBox.Name = "AddMBox";
            this.AddMBox.Size = new System.Drawing.Size(132, 26);
            this.AddMBox.TabIndex = 21;
            this.AddMBox.Text = "Додати скарбничку";
            this.AddMBox.UseVisualStyleBackColor = true;
            this.AddMBox.Visible = false;
            this.AddMBox.Click += new System.EventHandler(this.AddMBox_Click);
            // 
            // DepositAddMenu
            // 
            this.DepositAddMenu.Location = new System.Drawing.Point(0, 8);
            this.DepositAddMenu.Name = "DepositAddMenu";
            this.DepositAddMenu.Size = new System.Drawing.Size(68, 49);
            this.DepositAddMenu.TabIndex = 15;
            this.DepositAddMenu.Text = "Додати депозит";
            this.DepositAddMenu.UseVisualStyleBackColor = true;
            this.DepositAddMenu.Click += new System.EventHandler(this.DepositAddMenu_Click);
            // 
            // AddMBoxMenu
            // 
            this.AddMBoxMenu.Location = new System.Drawing.Point(74, 8);
            this.AddMBoxMenu.Name = "AddMBoxMenu";
            this.AddMBoxMenu.Size = new System.Drawing.Size(76, 49);
            this.AddMBoxMenu.TabIndex = 16;
            this.AddMBoxMenu.Text = "Додати скарбничку";
            this.AddMBoxMenu.UseVisualStyleBackColor = true;
            this.AddMBoxMenu.Click += new System.EventHandler(this.AddMBoxMenu_Click);
            // 
            // BalanceCheck
            // 
            this.BalanceCheck.Location = new System.Drawing.Point(156, 8);
            this.BalanceCheck.Name = "BalanceCheck";
            this.BalanceCheck.Size = new System.Drawing.Size(54, 49);
            this.BalanceCheck.TabIndex = 19;
            this.BalanceCheck.Text = "Баланс";
            this.BalanceCheck.UseVisualStyleBackColor = true;
            this.BalanceCheck.Click += new System.EventHandler(this.BalanceCheck_Click);
            // 
            // Replenish
            // 
            this.Replenish.Location = new System.Drawing.Point(281, 8);
            this.Replenish.Name = "Replenish";
            this.Replenish.Size = new System.Drawing.Size(78, 48);
            this.Replenish.TabIndex = 22;
            this.Replenish.Text = "Поповнити скарбничку";
            this.Replenish.UseVisualStyleBackColor = true;
            this.Replenish.Click += new System.EventHandler(this.Replenish_Click);
            // 
            // WithdrawBox
            // 
            this.WithdrawBox.Controls.Add(this.GetFromMBox);
            this.WithdrawBox.Controls.Add(this.StopDeposit);
            this.WithdrawBox.Location = new System.Drawing.Point(22, 107);
            this.WithdrawBox.Name = "WithdrawBox";
            this.WithdrawBox.Size = new System.Drawing.Size(311, 46);
            this.WithdrawBox.TabIndex = 23;
            this.WithdrawBox.TabStop = false;
            this.WithdrawBox.Visible = false;
            // 
            // GetFromMBox
            // 
            this.GetFromMBox.Location = new System.Drawing.Point(154, 13);
            this.GetFromMBox.Name = "GetFromMBox";
            this.GetFromMBox.Size = new System.Drawing.Size(126, 30);
            this.GetFromMBox.TabIndex = 1;
            this.GetFromMBox.Text = "Зняти зі скарбнички";
            this.GetFromMBox.UseVisualStyleBackColor = true;
            this.GetFromMBox.Click += new System.EventHandler(this.GetFromMBox_Click);
            // 
            // StopDeposit
            // 
            this.StopDeposit.Location = new System.Drawing.Point(6, 13);
            this.StopDeposit.Name = "StopDeposit";
            this.StopDeposit.Size = new System.Drawing.Size(119, 30);
            this.StopDeposit.TabIndex = 0;
            this.StopDeposit.Text = "Розірвати депозит";
            this.StopDeposit.UseVisualStyleBackColor = true;
            this.StopDeposit.Click += new System.EventHandler(this.StopDeposit_Click);
            // 
            // WithdrawSumInput
            // 
            this.WithdrawSumInput.Location = new System.Drawing.Point(131, 9);
            this.WithdrawSumInput.Name = "WithdrawSumInput";
            this.WithdrawSumInput.Size = new System.Drawing.Size(50, 20);
            this.WithdrawSumInput.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 9);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "Сума";
            // 
            // WithdrawSumBox
            // 
            this.WithdrawSumBox.Controls.Add(this.DeleteMBox);
            this.WithdrawSumBox.Controls.Add(this.WithdrawMBoxNum);
            this.WithdrawSumBox.Controls.Add(this.textBox8);
            this.WithdrawSumBox.Controls.Add(this.ConfirmMBoxWithdrawal);
            this.WithdrawSumBox.Controls.Add(this.textBox6);
            this.WithdrawSumBox.Controls.Add(this.WithdrawSumInput);
            this.WithdrawSumBox.Location = new System.Drawing.Point(2, 191);
            this.WithdrawSumBox.Name = "WithdrawSumBox";
            this.WithdrawSumBox.Size = new System.Drawing.Size(344, 35);
            this.WithdrawSumBox.TabIndex = 26;
            this.WithdrawSumBox.TabStop = false;
            this.WithdrawSumBox.Visible = false;
            // 
            // WithdrawMBoxNum
            // 
            this.WithdrawMBoxNum.Location = new System.Drawing.Point(53, 9);
            this.WithdrawMBoxNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.WithdrawMBoxNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WithdrawMBoxNum.Name = "WithdrawMBoxNum";
            this.WithdrawMBoxNum.Size = new System.Drawing.Size(31, 20);
            this.WithdrawMBoxNum.TabIndex = 39;
            this.WithdrawMBoxNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 9);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(43, 20);
            this.textBox8.TabIndex = 38;
            this.textBox8.Text = "Номер";
            // 
            // ConfirmMBoxWithdrawal
            // 
            this.ConfirmMBoxWithdrawal.Location = new System.Drawing.Point(187, 9);
            this.ConfirmMBoxWithdrawal.Name = "ConfirmMBoxWithdrawal";
            this.ConfirmMBoxWithdrawal.Size = new System.Drawing.Size(84, 24);
            this.ConfirmMBoxWithdrawal.TabIndex = 37;
            this.ConfirmMBoxWithdrawal.Text = "Підтвердити";
            this.ConfirmMBoxWithdrawal.UseVisualStyleBackColor = true;
            this.ConfirmMBoxWithdrawal.Click += new System.EventHandler(this.ConfirmMBoxWithdrawal_Click);
            // 
            // ToolBarBox
            // 
            this.ToolBarBox.Controls.Add(this.WithdrawMenu);
            this.ToolBarBox.Controls.Add(this.DepositAddMenu);
            this.ToolBarBox.Controls.Add(this.AddMBoxMenu);
            this.ToolBarBox.Controls.Add(this.BalanceCheck);
            this.ToolBarBox.Controls.Add(this.Replenish);
            this.ToolBarBox.Location = new System.Drawing.Point(352, 383);
            this.ToolBarBox.Name = "ToolBarBox";
            this.ToolBarBox.Size = new System.Drawing.Size(365, 57);
            this.ToolBarBox.TabIndex = 27;
            this.ToolBarBox.TabStop = false;
            this.ToolBarBox.Visible = false;
            // 
            // WithdrawMenu
            // 
            this.WithdrawMenu.Location = new System.Drawing.Point(216, 8);
            this.WithdrawMenu.Name = "WithdrawMenu";
            this.WithdrawMenu.Size = new System.Drawing.Size(54, 49);
            this.WithdrawMenu.TabIndex = 23;
            this.WithdrawMenu.Text = "Зняти гроші";
            this.WithdrawMenu.UseVisualStyleBackColor = true;
            this.WithdrawMenu.Click += new System.EventHandler(this.WithdrawMenu_Click);
            // 
            // LogInToolBarBox
            // 
            this.LogInToolBarBox.Controls.Add(this.RefrAccNums);
            this.LogInToolBarBox.Controls.Add(this.LogText);
            this.LogInToolBarBox.Controls.Add(this.CodeInput);
            this.LogInToolBarBox.Controls.Add(this.EnterTheBank);
            this.LogInToolBarBox.Controls.Add(this.NewClientText);
            this.LogInToolBarBox.Controls.Add(this.Register);
            this.LogInToolBarBox.Location = new System.Drawing.Point(21, 12);
            this.LogInToolBarBox.Name = "LogInToolBarBox";
            this.LogInToolBarBox.Size = new System.Drawing.Size(311, 99);
            this.LogInToolBarBox.TabIndex = 28;
            this.LogInToolBarBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Ви знаходитесь в меню поповнення скарбнички";
            // 
            // RepenishBox
            // 
            this.RepenishBox.Controls.Add(this.MBoxNumInput);
            this.RepenishBox.Controls.Add(this.textBox4);
            this.RepenishBox.Controls.Add(this.ConfirmRepenishment);
            this.RepenishBox.Controls.Add(this.RepenishInput);
            this.RepenishBox.Controls.Add(this.textBox2);
            this.RepenishBox.Controls.Add(this.textBox1);
            this.RepenishBox.Location = new System.Drawing.Point(21, 231);
            this.RepenishBox.Name = "RepenishBox";
            this.RepenishBox.Size = new System.Drawing.Size(310, 88);
            this.RepenishBox.TabIndex = 30;
            this.RepenishBox.TabStop = false;
            this.RepenishBox.Visible = false;
            // 
            // MBoxNumInput
            // 
            this.MBoxNumInput.Location = new System.Drawing.Point(130, 36);
            this.MBoxNumInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MBoxNumInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MBoxNumInput.Name = "MBoxNumInput";
            this.MBoxNumInput.Size = new System.Drawing.Size(41, 20);
            this.MBoxNumInput.TabIndex = 34;
            this.MBoxNumInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "Номер скарбнички";
            // 
            // ConfirmRepenishment
            // 
            this.ConfirmRepenishment.Location = new System.Drawing.Point(201, 58);
            this.ConfirmRepenishment.Name = "ConfirmRepenishment";
            this.ConfirmRepenishment.Size = new System.Drawing.Size(103, 24);
            this.ConfirmRepenishment.TabIndex = 32;
            this.ConfirmRepenishment.Text = "Підтвердити";
            this.ConfirmRepenishment.UseVisualStyleBackColor = true;
            this.ConfirmRepenishment.Click += new System.EventHandler(this.ConfirmRepenishment_Click);
            // 
            // RepenishInput
            // 
            this.RepenishInput.Location = new System.Drawing.Point(93, 62);
            this.RepenishInput.Name = "RepenishInput";
            this.RepenishInput.Size = new System.Drawing.Size(87, 20);
            this.RepenishInput.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(62, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Сума";
            // 
            // StopDepNumBox
            // 
            this.StopDepNumBox.Controls.Add(this.ConfirmStopDep);
            this.StopDepNumBox.Controls.Add(this.StopDepNum);
            this.StopDepNumBox.Controls.Add(this.textBox7);
            this.StopDepNumBox.Location = new System.Drawing.Point(22, 156);
            this.StopDepNumBox.Name = "StopDepNumBox";
            this.StopDepNumBox.Size = new System.Drawing.Size(243, 35);
            this.StopDepNumBox.TabIndex = 31;
            this.StopDepNumBox.TabStop = false;
            this.StopDepNumBox.Visible = false;
            // 
            // ConfirmStopDep
            // 
            this.ConfirmStopDep.Location = new System.Drawing.Point(149, 5);
            this.ConfirmStopDep.Name = "ConfirmStopDep";
            this.ConfirmStopDep.Size = new System.Drawing.Size(88, 24);
            this.ConfirmStopDep.TabIndex = 36;
            this.ConfirmStopDep.Text = "Підтвердити";
            this.ConfirmStopDep.UseVisualStyleBackColor = true;
            this.ConfirmStopDep.Click += new System.EventHandler(this.ConfirmStopDep_Click);
            // 
            // StopDepNum
            // 
            this.StopDepNum.Location = new System.Drawing.Point(111, 9);
            this.StopDepNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.StopDepNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StopDepNum.Name = "StopDepNum";
            this.StopDepNum.Size = new System.Drawing.Size(31, 20);
            this.StopDepNum.TabIndex = 35;
            this.StopDepNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 9);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 26;
            this.textBox7.Text = "Номер депозиту";
            // 
            // RefrAccNums
            // 
            this.RefrAccNums.Location = new System.Drawing.Point(183, 9);
            this.RefrAccNums.Name = "RefrAccNums";
            this.RefrAccNums.Size = new System.Drawing.Size(111, 23);
            this.RefrAccNums.TabIndex = 6;
            this.RefrAccNums.Text = "Оновити";
            this.RefrAccNums.UseVisualStyleBackColor = true;
            this.RefrAccNums.Click += new System.EventHandler(this.RefrAccNums_Click);
            // 
            // DeleteMBox
            // 
            this.DeleteMBox.Location = new System.Drawing.Point(277, 10);
            this.DeleteMBox.Name = "DeleteMBox";
            this.DeleteMBox.Size = new System.Drawing.Size(67, 24);
            this.DeleteMBox.TabIndex = 40;
            this.DeleteMBox.Text = "Видалити";
            this.DeleteMBox.UseVisualStyleBackColor = true;
            this.DeleteMBox.Click += new System.EventHandler(this.DeleteMBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 452);
            this.Controls.Add(this.StopDepNumBox);
            this.Controls.Add(this.RepenishBox);
            this.Controls.Add(this.LogInToolBarBox);
            this.Controls.Add(this.WithdrawSumBox);
            this.Controls.Add(this.ToolBarBox);
            this.Controls.Add(this.WithdrawBox);
            this.Controls.Add(this.AddMBox);
            this.Controls.Add(this.TermBox);
            this.Controls.Add(this.SumBox);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.AddDeposit);
            this.Controls.Add(this.PersonInfo);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SumBox.ResumeLayout(false);
            this.SumBox.PerformLayout();
            this.TermBox.ResumeLayout(false);
            this.TermBox.PerformLayout();
            this.WithdrawBox.ResumeLayout(false);
            this.WithdrawSumBox.ResumeLayout(false);
            this.WithdrawSumBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WithdrawMBoxNum)).EndInit();
            this.ToolBarBox.ResumeLayout(false);
            this.LogInToolBarBox.ResumeLayout(false);
            this.LogInToolBarBox.PerformLayout();
            this.RepenishBox.ResumeLayout(false);
            this.RepenishBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBoxNumInput)).EndInit();
            this.StopDepNumBox.ResumeLayout(false);
            this.StopDepNumBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopDepNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LogText;
        private System.Windows.Forms.TextBox CodeInput;
        private System.Windows.Forms.Button EnterTheBank;
        private System.Windows.Forms.RichTextBox PersonInfo;
        private System.Windows.Forms.TextBox NewClientText;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox SumInput;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button AddDeposit;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.GroupBox SumBox;
        private System.Windows.Forms.GroupBox TermBox;
        private System.Windows.Forms.Button DepositAddMenu;
        private System.Windows.Forms.Button AddMBoxMenu;
        private System.Windows.Forms.Button BalanceCheck;
        private System.Windows.Forms.Button AddMBox;
        private System.Windows.Forms.RadioButton TwFourMonth;
        private System.Windows.Forms.RadioButton TwelveMonth;
        private System.Windows.Forms.RadioButton SixMonth;
        private System.Windows.Forms.Button Replenish;
        private System.Windows.Forms.GroupBox WithdrawBox;
        private System.Windows.Forms.Button GetFromMBox;
        private System.Windows.Forms.Button StopDeposit;
        private System.Windows.Forms.TextBox WithdrawSumInput;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox WithdrawSumBox;
        private System.Windows.Forms.GroupBox ToolBarBox;
        private System.Windows.Forms.GroupBox LogInToolBarBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox RepenishBox;
        private System.Windows.Forms.Button ConfirmRepenishment;
        private System.Windows.Forms.TextBox RepenishInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown MBoxNumInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button WithdrawMenu;
        private System.Windows.Forms.GroupBox StopDepNumBox;
        private System.Windows.Forms.Button ConfirmStopDep;
        private System.Windows.Forms.NumericUpDown StopDepNum;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button ConfirmMBoxWithdrawal;
        private System.Windows.Forms.NumericUpDown WithdrawMBoxNum;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button RefrAccNums;
        private System.Windows.Forms.Button DeleteMBox;
    }
}

