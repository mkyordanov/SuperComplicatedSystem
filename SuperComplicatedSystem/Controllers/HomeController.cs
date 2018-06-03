using Bytes2you.Validation;
using SuperComplicatedSystem.Services.Contracts;
using System.Web.Mvc;
using System;
using System.IO;
using System.Text;

namespace SuperComplicatedSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEquipmentService equipmentService;

        public HomeController(IEquipmentService equipmentService)
        {
            Guard.WhenArgument(equipmentService, "Equipment Service").IsNull().Throw();

            this.equipmentService = equipmentService;
        }
        public ActionResult Index()
        {
            var equipment = this.equipmentService.GetAll();
            return View(equipment);
        }
        [HttpGet]
        public ActionResult SaveData(string data)
        {
            var pcdata = data.Split(',');
            string path = string.Format(@"~\App_Data\{0}.csv", data[0]);
            var dataFile = System.Web.HttpContext.Current.Server.MapPath(path);
            var sb = new StringBuilder();
            foreach (var item in pcdata)
            {
                sb.AppendLine(item);
            }
            System.IO.File.Delete(dataFile);
            System.IO.File.AppendAllText(@dataFile, sb.ToString());

            return View();
        }
    }
}