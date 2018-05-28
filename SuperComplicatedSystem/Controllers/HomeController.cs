using Bytes2you.Validation;
using SuperComplicatedSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

    }
}