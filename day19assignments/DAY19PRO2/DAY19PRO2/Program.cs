﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAY19PRO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("file:///E:/assignments/day19assignments/Employee.xml.txt");
            //  XmlNode node = doc.DocumentElement.SelectSingleNode("/employees/employee");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "Name")
                    {
                        Console.WriteLine(childNode.InnerText);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
