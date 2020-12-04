using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Задание
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("autos.xml");
            foreach(XmlNode i in doc.DocumentElement)
            {
                Console.WriteLine("Номер модели в каталоге {0}", i.Attributes[0].Value);
                Console.WriteLine("Название модели: {0}", i["Model"].InnerText);
                Console.WriteLine("Год выхода: {0}", i["Year"].InnerText);
                Console.WriteLine("Цвет: {0}", i["Color"].InnerText);
                Console.WriteLine("Цена: {0}", i["Prise"].InnerText);
                Console.WriteLine("Максимальная скорость: {0}", i["MaxSpeed"].InnerText);
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
