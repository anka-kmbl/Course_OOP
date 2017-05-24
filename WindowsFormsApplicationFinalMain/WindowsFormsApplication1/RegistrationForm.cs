using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ClientModel;
using WindowsFormsApplication1.ClientModel.DepositModel;

namespace WindowsFormsApplication1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }



        
        private Person NewPerson { get; set; }
        

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(BYearInput.Text) > 1930 && Convert.ToInt32(BYearInput.Text) <= 2000 && Convert.ToInt32(BMonthInput.Text) <= 12 && Convert.ToInt32(BMonthInput.Text) >= 1 && Convert.ToInt32(BDayInput.Text) <= 31 && Convert.ToInt32(BDayInput.Text) >= 1)
                {
                    NewPerson = new Person(new Passport(SerialInput.Text, Convert.ToInt32(SerialNumInput.Text), SurnameInput.Text, NameInput.Text,
                   FNameInput.Text, new DateTime(Convert.ToInt32(BYearInput.Text), Convert.ToInt32(BMonthInput.Text), Convert.ToInt32(BDayInput.Text))), new List<Deposit> { });

                    MessageBox.Show("Номер вашого рахунку: " + NewPerson.AccountNum.ToString());
                    CallBackNewClient.callbackEventHandler(NewPerson);
                    this.Close();

                }
                else 
                {

                    MessageBox.Show("Введіть коректну дату народження!");
                }
            } 
            catch
            {
                MessageBox.Show("Перевірте коректність вводу.");
            }

            




        }

        private void SerialInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            
        }

        private void SerialNumInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void BYearInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void BMonthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void BDayInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void SurnameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void NameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void FNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
