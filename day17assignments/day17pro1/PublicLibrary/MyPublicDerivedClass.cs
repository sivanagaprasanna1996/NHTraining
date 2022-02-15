using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SivaLibrary;


namespace PublicLibrary
{
    public class MyPublicDerivedClass : MyBaseClass
    {
        public void MyPublicDerivedClassMethod()
        {
            a = 5;
            b = 10;
            c = 15;
            d = 20;
            e = 25;
       }
    }
   
    public class MyPublicLibraryOtherClass
    {
        public void MyPublicLoibraryOtherClass()
        {
            MyBaseClass mb = new MyBaseClass();

            mb.a = 5;
            mb.b = 10;
            mb.c = 15;
            mb.d = 20;
            mb.e = 25;

        }
    }
}
