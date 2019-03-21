using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Web;
using System.Net;
using System.IO;
using System.Web.Mvc;



namespace ConsumeAPI.Controllers
{
    public class ApiDataController : Controller
    {
        //
        // GET: /ApiData/

        public PartialViewResult Index(int Zip)
        {
            string resultant = " ";
            {
                string ApiURL = "http://localhost:56212/api/ValuesDealers/Get?Zip="+ Zip;
                WebRequest request = WebRequest.Create(ApiURL);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                resultant = reader.ReadLine();
                //while(str != null)  
                //{  
                //  Console.WriteLine(str);  
                //  str = reader.ReadLine();  
                //}  
            }
            return PartialView();
        }

    }
}



