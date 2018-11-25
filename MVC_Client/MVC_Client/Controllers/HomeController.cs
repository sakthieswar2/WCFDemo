using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_Client.Controllers
{
    public class HomeController : Controller
    {
        HelloService.Service1Client httpService = new HelloService.Service1Client("BasicHttpBinding_IService1");
        HelloService.Service1Client tcpService = new HelloService.Service1Client("NetTcpBinding_IService1");
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Greeting()
        {
            
            string Message = "sakthi";
            ViewBag.Message = httpService.SayHello(Message);

            return View("Index");
        }
        
        public ActionResult Program()
        {
            string Message = "sakthi";
            ViewBag.Message = tcpService.TodayProgram(Message);

            return View("Index");
        }
    }
}