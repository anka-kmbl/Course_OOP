using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.ClientModel.DepositModel;

namespace WindowsFormsApplication1.ClientModel
{
    [Serializable]
    class Passport
    {
       
        public Passport(string serialLetters, int serialNum, string surname, string name, string fName, DateTime bDate)
        {
            SerialLetters = serialLetters;
            SerialNum = serialNum;
            Surname = surname;
            Name = name;
            FName = fName;
            BDate = bDate;

        }
        public string SerialLetters { get; set; }
        public int SerialNum { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public string FName { get; set; }

        public DateTime BDate { get; set; }
    }
}
