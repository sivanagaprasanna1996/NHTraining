using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace day19pro1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter ID Number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            XmlDocument file = new XmlDocument();
            file.Load("file:///E:/assignments/day19assignments/Employee.xml.txt");


            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    bool ID = node2.Name == "ID";
                    bool isIndex = (ID == true ? Convert.ToInt32(node2.InnerText) : 0) == input;
                    if (ID && isIndex)
                    {
                        Console.WriteLine($"The Name of the ID is {node2.NextSibling.InnerText}.");
                    }
                }
            }
            Console.ReadLine();

            Console.ReadLine();


        }
    }
}

            

        
    

