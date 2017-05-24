using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ClientModel.DepositModel
{
    [Serializable]
     abstract class Deposit
    {
        
        public Deposit(DateTime startDate, double startAmount)
        {
            StartDate = startDate;
            StartAmount = startAmount;
            LastOperationDate = startDate;
            FinalAmount = startAmount;
        }
        public double Percent { get; set; }

        public int DepositTerm { get; set; }

       
        public double StartAmount { get; set; }

        public double FinalAmount { get; set; }

        public DateTime LastOperationDate { get; set; }
        public DateTime StartDate { get; set; }

        public int DepositName { get; set; }
        
        public virtual double CalcFinalSum(DateTime currentDate)
        {

            LastOperationDate = currentDate;
            return FinalAmount;
        }
        public virtual int CalcNumMonthLeft(DateTime currentDate)
        {
            int numPassed = CalcMonthNum(currentDate, StartDate);
            return DepositTerm - numPassed;
           
        }
        public virtual void WithdrawDeposit(DateTime currentDate)
        {
            LastOperationDate = currentDate;
        }

        public virtual void WithdrawMoney(double moneyAmount, DateTime currentDate)
        {
            LastOperationDate = currentDate;
            FinalAmount -= moneyAmount;
        }
        public virtual void PlusMoney(double moneyAmount, DateTime currentDate)
        {
            LastOperationDate = currentDate;
            FinalAmount += moneyAmount;
        }

        public virtual double CalcSum(DateTime currentDate)
        {
            LastOperationDate = currentDate;
            return FinalAmount;
        }

        
        public virtual int CalcMonthNum(DateTime currentDate, DateTime startPoint)
        {
            int monthNum = 0;
            if (currentDate.Year - startPoint.Year == 0)
            {
                monthNum = currentDate.Month - startPoint.Month;

            }
            else if (currentDate.Year - startPoint.Year == 1)
            {
                monthNum += currentDate.Month;
                monthNum += 12 - startPoint.Month;

            }
            else
            {
                monthNum += currentDate.Month;
                monthNum += 12 - startPoint.Month;
                monthNum += (currentDate.Year - startPoint.Year - 1) * 12;
            }

            if (currentDate.Day < startPoint.Day)
            {
                monthNum--;
            }

            return monthNum;
        }
    }
}
