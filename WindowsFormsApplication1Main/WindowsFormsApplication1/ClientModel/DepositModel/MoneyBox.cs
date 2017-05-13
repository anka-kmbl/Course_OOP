using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ClientModel.DepositModel
{
    [Serializable]
     class MoneyBox : Deposit
    {

       
        public MoneyBox(DateTime startDate, double startAmount) : base(startDate, startAmount)
        {
            
            FinalAmount = startAmount;
            Percent = 0.01;
            
            DepositName = 2;
        }

        

        public override void WithdrawMoney(double moneyAmount, DateTime currentDate)
        {
            base.WithdrawMoney(moneyAmount, currentDate);
        }
        public override void PlusMoney(double moneyAmount, DateTime currentDate)
        {

            base.PlusMoney(moneyAmount, currentDate);
        }

        public override double CalcSum(DateTime currentDate)
        {
            
            FinalAmount =  FinalAmount * (1 + Percent * CalcMonthNum(currentDate, LastOperationDate));
            return base.CalcSum(currentDate);
        }


    }
}
