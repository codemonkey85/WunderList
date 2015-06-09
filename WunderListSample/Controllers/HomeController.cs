using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WunderListSample.Models;
using Newtonsoft.Json;
using WunderListSample.DataBase;

namespace WunderListSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //GenerateDatabase();

            using (var db = new DbFactory())
            {
                var list = db.WunderListItems.ToList();
                foreach (var wunderlist in list) {
                    wunderlist.Title = wunderlist.Title;
                }

                return View(list);
            }
             
            }

        private void GenerateDatabase()
        {

            string filePath = Server.MapPath("~/File/data.txt");
            StreamReader reader = new StreamReader(filePath, System.Text.Encoding.Default);

            var d = JsonConvert.DeserializeObject<Rootobject>(reader.ReadToEnd());
            var listdata = d.data.lists;
            var taskdata = d.data.tasks;
            var subtaskdata = d.data.subtasks;

            try
            {
                using (var db = new DbFactory())
                {
                    foreach (var list in listdata)
                    {
                        WunderListItem wunderList = new WunderListItem();
                        wunderList.CreatedAt = list.created_at;
                        wunderList.ListType = WunderListType.List;
                        wunderList.Title = list.title;
                        wunderList.WunderListId = list.id.ToString();
                        db.WunderListItems.Add(wunderList);
                    }

                    foreach (var task in taskdata)
                    {
                        WunderTask wunderTask = new WunderTask();
                        wunderTask.CreateAt = task.created_at;
                        wunderTask.IsCompleted = task.completed;
                        wunderTask.ListId = task.list_id.ToString();
                        wunderTask.Title = task.title;
                        db.WunderTasks.Add(wunderTask);

                    }
                    foreach (var subtask in subtaskdata)
                    {
                        WunderListSubTask wunderSubTask = new WunderListSubTask();
                        wunderSubTask.IsCompleted = subtask.completed;
                        wunderSubTask.TaskId = subtask.task_id.ToString();
                        wunderSubTask.Title = subtask.title;
                        db.WunderListSubTasks.Add(wunderSubTask);
                    }
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        [HttpPost]
        public JsonResult GetTask() {
    
        }
    }
}