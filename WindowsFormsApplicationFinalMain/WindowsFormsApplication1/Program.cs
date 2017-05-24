using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ClientModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public static class CallBackNewClient
    {
        internal delegate void callbackEvent(Person person);
        internal static callbackEvent callbackEventHandler;

    }
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());

            ClientDataBase dataBase = new ClientDataBase();
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dataBase);

                
            }

            
            using (FileStream fs = new FileStream("clients.dat", FileMode.OpenOrCreate))
            {
                ClientDataBase data = (ClientDataBase)formatter.Deserialize(fs);
               
            }
        }
    }
}
