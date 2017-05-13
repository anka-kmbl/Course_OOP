using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.ClientModel.DepositModel
{
    [Serializable]
     class DepositWithTerm : Deposit
    {
        
        public DepositWithTerm(int depositTerm, DateTime startDate, double startAmount) : base(startDate, startAmount)
        {
            DepositTerm = depositTerm;
            StartAmount = startAmount;
            DepositName = 1;
            if(depositTerm == 6)
            {
                Percent = 0.05;
            } 
            else if(depositTerm == 12)
            {
                Percent = 0.08;
            } 
            else if(depositTerm == 24)
            {
                Percent = 0.12;
            }
        }


       
        public override int CalcNumMonthLeft(DateTime currentDate)
        {
            return base.CalcNumMonthLeft(currentDate);
        }
        public override void WithdrawDeposit(DateTime currentDate)
        {

            base.WithdrawDeposit(currentDate);
        }
        public override double CalcSum(DateTime currentDate)
        {
            
            FinalAmount = StartAmount * (1 + Percent * CalcMonthNum(currentDate, StartDate));
            return base.CalcSum(currentDate);
        }

        public override double CalcFinalSum(DateTime currentDate)
        {
            FinalAmount = StartAmount * (1 + Percent * DepositTerm);
            return base.CalcFinalSum(currentDate);
        }
    }
}
