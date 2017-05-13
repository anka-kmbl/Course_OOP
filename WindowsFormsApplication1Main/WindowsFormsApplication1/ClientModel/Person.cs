using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.ClientModel.DepositModel;

namespace WindowsFormsApplication1.ClientModel
{
    [Serializable]
     class Person
    {
        
        public Person(Passport passportInfo,  List<Deposit> holdings)
        {
            var ran = new Random();
            AccountNum = ran.Next(1000000, 9999999);
           
            PassportInfo = passportInfo;
            Holdings = holdings;
        }

        public Person(Passport passportInfo, List<Deposit> holdings, int accNum)
        {

            PassportInfo = passportInfo;
            Holdings = holdings;
            AccountNum = accNum;
        }
        
        public int AccountNum { get; set; }
        public Passport PassportInfo { get; set; }
       
        public List<Deposit> Holdings { get; set; }
        public int Sum { get; set; }


    }

}
