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
using WunderListSample.ViewModel;

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
            string filePath = Server.MapPath("~/Db/WunderListJosn.txt");
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
                        wunderTask.TaskId = task.id.ToString();
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

        [HttpPost]
        public JsonResult GetTask() {
               DateTime dt = DateTime.Now;         
               using (var db = new DbFactory()) {
                   var task = db.WunderTasks.ToList();
                   task = task.Where(p => p.CreateAt.Month == dt.Month && p.ListId == "148182326").OrderByDescending(p => p.CreateAt).ToList();
                   return Json(task);
                }
            
        }

        [HttpPost]
        public JsonResult GetSubTask(string taskId)
        {
            using (var db = new DbFactory()) {
                var subTaskList = db.WunderListSubTasks.Where(p => p.TaskId == taskId).ToList();
                return Json(subTaskList);
            }

        }

        public ActionResult YearlyTask() {
            List<WunderlistItemViewModel> wvmList = new List<WunderlistItemViewModel>();
            DateTime dt = DateTime.Now;
            string currentYear = dt.Year.ToString();
            using (var db = new DbFactory()) {
                var yearList = db.WunderListItems.Where(p => p.Title.Contains(currentYear)).ToList();

                foreach (var list in yearList) {
                    WunderlistItemViewModel wvm = new WunderlistItemViewModel();
                    wvm.WudnerListItem = list;
                    wvm.WunderTasks = db.WunderTasks.Where(p => p.ListId == list.WunderListId).ToList();
                    wvmList.Add(wvm);
                }
               
                return View(wvmList);
            }

        }

        public ActionResult BookList() {
            return View();
        }
    }
}