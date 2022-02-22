using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for MathematicesLibrary
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathematicesLibrary : System.Web.Services.WebService
    {

       
        [WebMethod]
        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

    }
}
