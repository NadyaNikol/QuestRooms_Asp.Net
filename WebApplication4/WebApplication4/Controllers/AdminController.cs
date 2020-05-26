using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.ModelViews;
using WebApplication4.Repositories;
using WebApplication4.Utils;

namespace WebApplication4.Controllers
{
    public class AdminController : Controller
    {

        //IRepository<QuestRoom> QRRepository = null;
        //IRepository<Telephone> TelRepository = null;

        private readonly IUnitOfWork db;

        public AdminController (IUnitOfWork context)
        {
            db = context;
            // repository = new QuestRoomHandler();
            //QRRepository = new CustomRepository();
            //TelRepository = new TelephoneRepository();
        }


        public ActionResult Index()
        {
            return View(db.QuestRooms.GetAll());
        }

        [HttpGet]
        public ActionResult AddRoom()
        {

            //ViewBag.phones = new SelectList(db.Telephones.GetAll(), "Id", "Telephone");
            return View(/*new AddRoomViewModel()*/);
        }

        [HttpPost]
        public ActionResult AddRoom(AddRoomViewModel viewModel)
        {
            if (ModelState.IsValid && viewModel.File.ContentLength > 0)
            {
                string fileName = Path.GetFileName(viewModel.File.FileName);
                string path = Path.Combine(Server.MapPath("~/MyContent/Image"), fileName);
                viewModel.File.SaveAs(path);
                viewModel.Room.Logo = fileName;

                var numbersList = viewModel.Room.Telephones.ToList();

                numbersList.ForEach(number => db.Telephones.Add(number));

                db.QuestRooms.Add(viewModel.Room);
                db.Save();

                return RedirectToRoute(new { controller = "home", action = "details", id = viewModel.Room.Id });

            }

            //return View(viewModel.Room);
            return View("Index", viewModel.Room);
        }

        [HttpGet]
        public ActionResult UpdateRoom(int id)
        {
           
            var room = db.QuestRooms.GetById(id);

            if (room == null)
                return HttpNotFound();

            //SelectList tel = new SelectList(TelRepository.GetAll(), "Id", "Telephones", room.Id);
            //ViewBag.Tel = tel;

           // var vm = new AddRoomViewModel() { Room = room, Telephones = db.Telephones.GetAll().Where(t=>t.QuestRoomId==id).ToList() };
            var vm = new AddRoomViewModel() { Room = room };
            return View(vm);
        }

        [HttpPost]
        public ActionResult UpdateRoom(AddRoomViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var numbersList = vm.Room.Telephones.ToList();
                var questRoomId = vm.Room.Id;

                numbersList.ForEach(number => number.QuestRoomId = questRoomId);
                numbersList.ForEach(number => db.Telephones.Update(number));

                db.QuestRooms.Update(vm.Room);
                db.Save();

                return View("index", db.QuestRooms.GetAll());
            }
            return View(vm);
            //// repository.Update(viewModel.Room);
            //db.QuestRooms.Update(vm.Room);
            //return View("Index", db.Telephones.GetAll());
        }

        [HttpGet]
        public ActionResult DeleteRoom(int id)
        {
            QuestRoom r = db.QuestRooms.GetById(id);
            if (r == null)
                return HttpNotFound();

            return View("IndexRoom", r);

        }


        [HttpPost, ActionName("DeleteRoom")]
        public ActionResult DeleteRoom2(int id)
        {
            var fileName = db.QuestRooms.GetById(id).Logo;
            string fullPath = Request.MapPath("~/MyContent/Image" + fileName);

            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }

            db.QuestRooms.Delete(id);
            db.Save();

            return View("Index", db.QuestRooms.GetAll());
        }
    }
}