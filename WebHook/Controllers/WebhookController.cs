using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHook.Controllers
{
    public class WebhookController : Controller
    {
        //
        // GET: /Webhook/

        public ActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public JsonResult RunBatFile()
        {
            try
            {
                String command = @"E:\CodeDemo\Github\Webhook\pull.bat";
                Process process;
                var ProcessInfo = new ProcessStartInfo(command);

                 //ProcessInfo.CreateNoWindow = true;
             // ProcessInfo.UseShellExecute = false;
                 process = Process.Start(ProcessInfo);
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("Fail", JsonRequestBehavior.AllowGet);
            }
        }

    }
}
