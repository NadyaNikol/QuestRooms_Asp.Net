using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Repositories;
using WebApplication4.Utils;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //IRepository<QuestRoom> repository ;
        private readonly IUnitOfWork repository;


        public HomeController(IUnitOfWork context)
        {
            repository = context;
            // repository = new QuestRoomHandler();
            //repository = new CustomRepository();
        }

        public ActionResult Index()
        {
            List<QuestRoom> viewModel =repository.QuestRooms.GetAll();
            return View(viewModel);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            QuestRoom room = repository.QuestRooms.GetById(id);
            if (room != null) return View(room);
            else return new HttpNotFoundResult("Quest room doesn't exist");
        }
      
    }
}