using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.ClientModel;
using WindowsFormsApplication1.ClientModel.DepositModel;

namespace WindowsFormsApplication1
{
    [Serializable]
    class ClientDataBase
    {
        public ClientDataBase()
        {
            //Clients = new List<Person>
            //{
            //    new Person(new Passport("МТ",424045,"Максименко","Анна", "Ярославовна", new DateTime(1999,8,31)),
            //    new List<Deposit> { new MoneyBox(new DateTime(2017,4,17),1000), new DepositWithTerm(6, new DateTime(2017, 4, 17), 10000), new DepositWithTerm(12,new DateTime(2017,4,17),2000) }, 1234567),
            //    new Person(new Passport("МТ",278934,"Соль","Кощей", "Иванович", new DateTime(1999,7,3)),
            //    new List<Deposit> { new MoneyBox(new DateTime(2017,4,17),100), new DepositWithTerm(6,new DateTime(2017,4,17),10000) }, 1122334)



            //};
            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, Clients);
            //}
            Clients = new List<Person>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("DB.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    Clients = (List<Person>)formatter.Deserialize(fs);
                }
                catch
                {
                    Console.WriteLine("Is empty");
                }
            }
        }
        public List<Person> Clients { get; set; }

       
    }
}
