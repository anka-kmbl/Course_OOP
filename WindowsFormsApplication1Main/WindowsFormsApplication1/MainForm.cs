using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApplication1.ClientModel;
using WindowsFormsApplication1.ClientModel.DepositModel;

namespace WindowsFormsApplication1
{
    [Serializable]
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            CallBackNewClient.callbackEventHandler = new CallBackNewClient.callbackEvent(this.AddNewClient);
            



        }


        private Person CurrentClient { get; set; }
        ClientDataBase clientData = new ClientDataBase();
        private void Enter_Click(object sender, EventArgs e)
        {
            
            if (CodeInput.Text == "")
            {
                MessageBox.Show("Будь ласка, введіть номер Вашого рахунку.");
            }
            else
            {
                int num = Convert.ToInt32(CodeInput.Text);
                bool check = false;
                foreach (var person in clientData.Clients)
                {
                    if (num == person.AccountNum)
                    {
                        CurrentClient = person;
                        check = true;
                        CodeInput.Clear();
                        ShowInfo();
                        break;
                    }
                }


                if (!check)
                {
                    MessageBox.Show("Такого клієнта не існує.");
                }
                else
                {
                    LogInToolBarBox.Visible = false;
                    ToolBarBox.Visible = true;
                    LogOut.Visible = true;
                }

                CodeInput.Clear();

            }



        }

        private void AddNewClient(Person person)
        {
            clientData.Clients.Add(person);
            
        }
        private void ShowInfo()
        {
            PersonInfo.Clear();
            PersonInfo.AppendText("Шановний клієнте! Ви знаходитесь в приватному кабінеті." + Environment.NewLine + "Номер особового рахунку: " + CurrentClient.AccountNum + Environment.NewLine + 
                "Паспортні дані:" + Environment.NewLine + "Прізвище: " + CurrentClient.PassportInfo.Surname  + Environment.NewLine + "Ім'я: " + CurrentClient.PassportInfo.Name + Environment.NewLine + "По-батькові: " + CurrentClient.PassportInfo.FName + Environment.NewLine);

           
            if (CurrentClient.Holdings.Count != 0)
            {
                DateTime temp = CurrentClient.Holdings[0].LastOperationDate;
                
                PersonInfo.AppendText("Поточні вклади:" + Environment.NewLine);
                int count = 0;
                foreach (var deposit in CurrentClient.Holdings)
                {
                    if (deposit.DepositName == 1)
                    {
                        if (deposit.CalcNumMonthLeft(DateTime.Now) >= 1)
                        {
                            PersonInfo.AppendText("Термін депозиту: " + deposit.DepositTerm + " міс." + "," + " сума вкладу: " + deposit.StartAmount + " грн." + Environment.NewLine + "Дата вкладу: " + deposit.StartDate + Environment.NewLine);
                            
                        }
                        else
                        {
                            CurrentClient.Holdings.Remove(CurrentClient.Holdings[count]);
                        }
                        count++;

                    }
                    else if(deposit.DepositName == 2)
                    {
                        PersonInfo.AppendText("Скарбничка. Сума вкладу: " + deposit.StartAmount + " грн." + Environment.NewLine + "Дата вкладу: " + deposit.StartDate + Environment.NewLine);
                    }

                    if (deposit.LastOperationDate > temp)
                    {
                        temp = deposit.LastOperationDate;

                    }
                }

                
               PersonInfo.AppendText("Дата останньої операції: " + temp   + Environment.NewLine);
            }


        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Owner = this;
            regForm.Show();

        }



       

        private void AddDeposit_Click(object sender, EventArgs e)
        {
            

            if (SumInput.Text == "")
            {
                MessageBox.Show("Будь ласка, ведіть коректну суму (від 500 до 100000 грн)");
            }
            else if (!SixMonth.Checked && !TwelveMonth.Checked && !TwFourMonth.Checked )
            {
                MessageBox.Show("Будь ласка, оберіть термін депозиту.");
            }
            else if (Convert.ToInt32(SumInput.Text) >= 500 && Convert.ToInt32(SumInput.Text) <= 100000)
            {
                if (SixMonth.Checked)
                {
                    CurrentClient.Holdings.Add(new DepositWithTerm(6, DateTime.Now, Convert.ToInt32(SumInput.Text)));

                }
                else if (TwelveMonth.Checked)
                {
                    CurrentClient.Holdings.Add(new DepositWithTerm(12, DateTime.Now, Convert.ToInt32(SumInput.Text)));

                }
                else if (TwFourMonth.Checked)
                {
                    CurrentClient.Holdings.Add(new DepositWithTerm(24, DateTime.Now, Convert.ToInt32(SumInput.Text)));

                }
                SumInput.Clear();

                ShowInfo();
            }
            else
            {
                MessageBox.Show("Будь ласка, ведіть коректну суму (від 500 до 100000 грн)");
            }


        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            PersonInfo.Clear();
           

           
            LogInToolBarBox.Visible = true;
            LogOut.Visible = false;
            AddDeposit.Visible = false;
            AddMBox.Visible = false;
            SumBox.Visible = false;
            TermBox.Visible = false;
            RepenishBox.Visible = false;
            WithdrawSumBox.Visible = false;
            ToolBarBox.Visible = false;
            StopDepNumBox.Visible = false;
            WithdrawBox.Visible = false;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clientData.Clients);
            }

            if (clientData.Clients.Count != 0)
            {
                PersonInfo.AppendText("Перелік існуючих номерів акаунтів: " + Environment.NewLine);
                for (int i = 0; i < clientData.Clients.Count; i++)
                {
                    PersonInfo.AppendText(Convert.ToString(clientData.Clients[i].AccountNum) + Environment.NewLine);
                }
            }


        }

        private void DepositAddMenu_Click(object sender, EventArgs e)
        {
            if (PersonInfo.Text != "")
            {
                LogInToolBarBox.Visible = false;
                LogOut.Visible = true;
                AddDeposit.Visible = true;
                AddMBox.Visible = false;
                SumBox.Visible = true;
                TermBox.Visible = true;
                RepenishBox.Visible = false;
                WithdrawSumBox.Visible = false;
                ToolBarBox.Visible = true;
                StopDepNumBox.Visible = false;
                WithdrawBox.Visible = false;
            }

        }

        private void AddMBoxMenu_Click(object sender, EventArgs e)
        {
            if (PersonInfo.Text != "")
            {
                LogInToolBarBox.Visible = false;
                LogOut.Visible = true;
                AddDeposit.Visible = false;
                SumBox.Visible = true;
                TermBox.Visible = false;
                RepenishBox.Visible = false;
                WithdrawSumBox.Visible = false;
                ToolBarBox.Visible = true;
                StopDepNumBox.Visible = false;
                WithdrawBox.Visible = false;
                AddMBox.Visible = true;

            }
        }

        private void SumInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddMBox_Click(object sender, EventArgs e)
        {
            if(SumInput.Text == "")
            {
                MessageBox.Show("Будь ласка, ведіть коректну суму (від 10 до 500 грн)");
            }
            else if (Convert.ToInt32(SumInput.Text) >= 10 && Convert.ToInt32(SumInput.Text) <= 500)
            {
                CurrentClient.Holdings.Add(new MoneyBox(DateTime.Now, Convert.ToInt32(SumInput.Text)));
                SumInput.Clear();
                ShowInfo();
            }
            
            else
            {
                MessageBox.Show("Будь ласка, ведіть коректну суму (від 10 до 500 грн)");
            }

            
            
            
        }

        private void BalanceCheck_Click(object sender, EventArgs e)
        {
            LogInToolBarBox.Visible = false;
            LogOut.Visible = true;
            AddDeposit.Visible = false;
            AddMBox.Visible = false;
            SumBox.Visible = false;
            TermBox.Visible = false;
            RepenishBox.Visible = false;
            WithdrawSumBox.Visible = false;
            ToolBarBox.Visible = true;
            StopDepNumBox.Visible = false;
            WithdrawBox.Visible = false;

            for (int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if (CurrentClient.Holdings[i].DepositName == 1)
                {
                    if (CurrentClient.Holdings[i].CalcNumMonthLeft(DateTime.Now) <= 0)
                    {
                       

                        MessageBox.Show("Термін депозита вичерпано. Суму у розмірі: " + CurrentClient.Holdings[i].CalcFinalSum(DateTime.Now) + " повернуто." + Environment.NewLine);
                        CurrentClient.Holdings.Remove(CurrentClient.Holdings[i]);
                        i--;
                    }
                    


                }
            }


            int count = 1;
            for (int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if (CurrentClient.Holdings[i].DepositName == 1)
                {
                    PersonInfo.AppendText("Строкові депозити:" + Environment.NewLine);
                    break;
                }
            }
            
            
            foreach (var holding in CurrentClient.Holdings)
            {
                if (holding.DepositName == 1)
                {
                    
                    PersonInfo.AppendText(count + ". " + " Термін депозиту: " + holding.DepositTerm + " міс., дата вкладу " + holding.StartDate +  Environment.NewLine + "Поточна сума: " + holding.CalcSum(DateTime.Now) + Environment.NewLine);
                    count++;

                } 
            }
            count = 1;

            for (int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if (CurrentClient.Holdings[i].DepositName == 2)
                {
                    PersonInfo.AppendText("Скарбнички:" + Environment.NewLine);
                    break;
                }
            }

            
            foreach (var holding in CurrentClient.Holdings)
            {
                if (holding.DepositName == 2)
                {

                    PersonInfo.AppendText(count + ". " + "дата вкладу " + holding.StartDate + Environment.NewLine + "Поточна сума: " + holding.CalcSum(DateTime.Now) + Environment.NewLine);
                    count++;

                }
            }
        }

        

        private void Replenish_Click(object sender, EventArgs e)
        {
            
            bool check = false;
            for(int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if(CurrentClient.Holdings[i].DepositName == 2)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                WithdrawBox.Visible = false;
                LogInToolBarBox.Visible = false;
                LogOut.Visible = true;
                AddDeposit.Visible = false;
                AddMBox.Visible = false;
                SumBox.Visible = false;
                TermBox.Visible = false;
                RepenishBox.Visible = true;
                WithdrawSumBox.Visible = false;
                StopDepNumBox.Visible = false;
                ToolBarBox.Visible = true;

                int count = 1;
                PersonInfo.AppendText("Перелік Ваших скарбничок. Оберіть потрібний номер для поповнення." + Environment.NewLine);
                foreach (var holding in CurrentClient.Holdings)
                {

                    if (holding.DepositName == 2)
                    {

                        PersonInfo.AppendText(count + ". " + "Поточна сума: " + holding.CalcSum(DateTime.Now) + Environment.NewLine);
                        count++;

                    }
                }
            }
            else
            {
                MessageBox.Show("У Вас немає скарбничок." + Environment.NewLine + "Для створення натисність кнопку \"Додати скарбничку\"");
            }

        }

        private void ConfirmRepenishment_Click(object sender, EventArgs e)
        {
            if (RepenishInput.Text == "")
            {
                MessageBox.Show("Ви не ввели суму поповнення. Будь ласка, заповніть поле.");
            }
            else
            {
                bool check = false;
                int count = 1;


                foreach (var holding in CurrentClient.Holdings)
                {
                    if (holding.DepositName == 2)
                    {
                        if (MBoxNumInput.Value == count)
                        {
                            check = true;
                            if (Convert.ToInt32(RepenishInput.Text) > 0 && Convert.ToInt32(RepenishInput.Text) <= 500)
                            {
                                holding.PlusMoney(Convert.ToDouble(RepenishInput.Text), DateTime.Now);
                                PersonInfo.AppendText("Сума після поповнення: " + holding.FinalAmount + Environment.NewLine);

                            }
                            else
                            {
                                MessageBox.Show("Будь ласка, ведіть коректну суму поповнення (від 1 до 500 грн)");
                            }
                        }
                        count++;
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Скарбнички під таким номером не існує, будь ласка, оберіть іншу.");
                }
                else
                {
                    RepenishInput.Clear();
                }
            }
            
        }

        private void WithdrawMenu_Click(object sender, EventArgs e)
        {
            if (CurrentClient.Holdings.Count != 0)
            {
                LogInToolBarBox.Visible = false;
                LogOut.Visible = true;
                AddDeposit.Visible = false;
                AddMBox.Visible = false;
                SumBox.Visible = false;
                TermBox.Visible = false;
                RepenishBox.Visible = false;
                WithdrawSumBox.Visible = false;
                ToolBarBox.Visible = true;
                StopDepNumBox.Visible = false;
                WithdrawBox.Visible = true;
            }
            else
            {
                MessageBox.Show("У Вас ще немає депозитів або скарбничок." + Environment.NewLine + "Ви можете створити їх за допомогою відповідних кнопок.");
            }

        }

        private void StopDeposit_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if (CurrentClient.Holdings[i].DepositName == 1)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                LogInToolBarBox.Visible = false;
                LogOut.Visible = true;
                AddDeposit.Visible = false;
                AddMBox.Visible = false;
                SumBox.Visible = false;
                TermBox.Visible = false;
                RepenishBox.Visible = false;
                WithdrawSumBox.Visible = false;
                ToolBarBox.Visible = true;
                StopDepNumBox.Visible = true;
                WithdrawBox.Visible = true;

                int count = 1;
                PersonInfo.AppendText("Перелік Ваших депозитів. Оберіть потрібний номер для розірвання контракту." + Environment.NewLine);
                foreach (var holding in CurrentClient.Holdings)
                {

                    if (holding.DepositName == 1)
                    {

                        PersonInfo.AppendText(count + ". " + "Поточна сума: " + holding.CalcSum(DateTime.Now) + ", загальний термін: " + holding.DepositTerm + Environment.NewLine + "Строк, який залишився: " + holding.CalcNumMonthLeft(DateTime.Now) + Environment.NewLine);
                        count++;

                    }
                }

            }
            else
            {
                MessageBox.Show("У Вас немає депозитів. Операція зняття коштів неможлива.");
            }


        }

        private void ConfirmStopDep_Click(object sender, EventArgs e)
        {
            int count = 1;
            bool check = false;
            for(int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if(CurrentClient.Holdings[i].DepositName == 1)
                {
                    if (StopDepNum.Value == count)
                    {

                        check = true;
                        MessageBox.Show("Контракт за депозитом " + count + " розірвано." + Environment.NewLine + "Суму у розмірі: " + CurrentClient.Holdings[i].FinalAmount + " повернено.");
                        CurrentClient.Holdings.Remove(CurrentClient.Holdings[i]);
                        i--;
                    }
                    count++;
                    
                    
                }
            }

            if (!check)
            {
                MessageBox.Show("Депозита під таким номером не існує. Будь ласка, оберіть інший номер.");
            }
            else
            {
                //StopDepNumBox.Visible = false;


                ShowInfo();
            }
        }

        private void GetFromMBox_Click(object sender, EventArgs e)
        {
           

                bool check = false;
                for (int i = 0; i < CurrentClient.Holdings.Count; i++)
                {
                    if (CurrentClient.Holdings[i].DepositName == 2)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {

                    WithdrawBox.Visible = true;
                    LogInToolBarBox.Visible = false;
                    LogOut.Visible = true;
                    AddDeposit.Visible = false;
                    AddMBox.Visible = false;
                    SumBox.Visible = false;
                    TermBox.Visible = false;
                    RepenishBox.Visible = false;
                    WithdrawSumBox.Visible = true;
                    StopDepNumBox.Visible = false;
                    ToolBarBox.Visible = true;

                    int count = 1;
                    PersonInfo.AppendText("Перелік Ваших скарбничок. Оберіть потрібний номер для зняття грошей." + Environment.NewLine);
                    foreach (var holding in CurrentClient.Holdings)
                    {

                        if (holding.DepositName == 2)
                        {

                            PersonInfo.AppendText(count + ". " + "Поточна сума: " + holding.CalcSum(DateTime.Now) + Environment.NewLine);
                            count++;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("У Вас немає скарбничок. Операція зняття коштів неможлива.");
                }
            
        }

        private void ConfirmMBoxWithdrawal_Click(object sender, EventArgs e)
        {
            if (WithdrawSumInput.Text == "")
            {
                MessageBox.Show("Ви не ввели суму поповнення. Будь ласка, заповніть поле.");
            }
            else
            {

                bool check = false;
                int count = 1;
                for (int i = 0; i < CurrentClient.Holdings.Count; i++)
                {
                    if (CurrentClient.Holdings[i].DepositName == 2)
                    {
                        if (WithdrawMBoxNum.Value == count)
                        {
                            
                            check = true;
                            if (Convert.ToInt32(WithdrawSumInput.Text) > CurrentClient.Holdings[i].FinalAmount)
                            {
                                MessageBox.Show("На Вашій скарбничці менше коштів." + Environment.NewLine + "Будь ласка, введіть коректну суму.");
                            }
                            else if (Convert.ToInt32(WithdrawSumInput.Text) == CurrentClient.Holdings[i].CalcSum(DateTime.Now))
                            {
                                MessageBox.Show("Ви зняли всю суму зі скарбнички. Її буде видалено.");
                                CurrentClient.Holdings.Remove(CurrentClient.Holdings[i]);
                                i--;
                            }
                            else
                            {
                                MessageBox.Show("Зі скарбнички " + count + " знято " + Convert.ToInt32(WithdrawSumInput.Text) + " грн.");
                                CurrentClient.Holdings[i].WithdrawMoney(Convert.ToInt32(WithdrawSumInput.Text), DateTime.Now);
                                PersonInfo.AppendText("Поточна сума на скарбничці " + count + ": " + CurrentClient.Holdings[i].FinalAmount + " грн." + Environment.NewLine);
                            }
                        }
                        count++;
                    }

                }

                if (!check)
                {
                    MessageBox.Show("Скарбнички під таким номером не існує, будь ласка, оберіть іншу.");
                }
                else
                {
                    WithdrawSumInput.Clear();
                }
            }

        }

        private void CodeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (clientData.Clients.Count != 0)
            {
                PersonInfo.AppendText("Перелік існуючих номерів акаунтів: " + Environment.NewLine);
                for (int i = 0; i < clientData.Clients.Count; i++)
                {
                    PersonInfo.AppendText(Convert.ToString(clientData.Clients[i].AccountNum) + Environment.NewLine);
                }
            }
        }

        private void RefrAccNums_Click(object sender, EventArgs e)
        {
            PersonInfo.Clear();
            if (clientData.Clients.Count != 0)
            {
                PersonInfo.AppendText("Перелік існуючих номерів акаунтів: " + Environment.NewLine);
                for (int i = 0; i < clientData.Clients.Count; i++)
                {
                    PersonInfo.AppendText(Convert.ToString(clientData.Clients[i].AccountNum) + Environment.NewLine);
                }
            }

        }

        private void DeleteMBox_Click(object sender, EventArgs e)
        {
            bool check = false;
            int count = 1;
            for (int i = 0; i < CurrentClient.Holdings.Count; i++)
            {
                if (CurrentClient.Holdings[i].DepositName == 2)
                {
                    if (WithdrawMBoxNum.Value == count)
                    {

                        
                            MessageBox.Show("Ви зняли всю суму зі скарбнички. Її буде видалено.");
                            CurrentClient.Holdings.Remove(CurrentClient.Holdings[i]);
                            i--;
                        
                    }
                    count++;
                }

            }

            if (!check)
            {
                MessageBox.Show("Скарбнички під таким номером не існує, будь ласка, оберіть іншу.");
            }
        }

        //private void SaveChanges_Click(object sender, EventArgs e)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fs, clientData.Clients);
        //    }
        //    MessageBox.Show("32");
        //}
    }
}
