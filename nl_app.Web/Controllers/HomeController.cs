using AutoMapper;
using nl_app.BLL.DTO;
using nl_app.BLL.Interfaces;
using nl_app.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nl_app.Web.Controllers
{
    public class HomeController : Controller
    {
        IOrderService orderService;
        public HomeController(IOrderService serv)
        {
            orderService = serv;
        }

        public ActionResult Index()
        {
            IEnumerable<PhoneDTO> phoneDtos = orderService.GetPhones();
            Mapper.Initialize(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>());
            var phones = Mapper.Map<IEnumerable<PhoneDTO>, List<PhoneViewModel>>(phoneDtos);
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
    }
}