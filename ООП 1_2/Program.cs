using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1_2
{
    class Program
    {
        class Subscriber
        {
            internal int ID;
            public string Name;
            public string Family;
            public string Otcvhestvo;
            internal string Addres;
        }
        static void Main(string[] args)
        {
            Subscriber Subscriber = new Subscriber();
            Console.Write("Введите ID: ");
            Subscriber.ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите имя: ");
            Subscriber.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите фамилию: ");
            Subscriber.Family = Convert.ToString(Console.ReadLine());

            Console.Write("Введите отчество: ");
            Subscriber.Otcvhestvo = Convert.ToString(Console.ReadLine());

            Console.Write("Введите адрес: ");
            Subscriber.Addres = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Subscriber.ID + " " + Subscriber.Name + " " + Subscriber.Family + " " + Subscriber.Otcvhestvo + " " + Subscriber.Addres);
            Console.ReadLine();
        }
    }
}
