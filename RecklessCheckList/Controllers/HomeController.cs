using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecklessCheckList.Models;

namespace RecklessCheckList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TaskRepository repo = new TaskRepository();

            TaskList list = repo.GetTasks();
            return View(list);
        }

        public ActionResult ToggleTask(Int32 taskId)
        {
            TaskRepository repo = new TaskRepository();

            TaskResponse response = repo.ToggleTask(taskId);

            return Json(response);
        }

        

        public ActionResult About()
        {
            return View();
        }
    }
}
