using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WunderListSample.Models;
namespace WunderListSample.ViewModel
{
    public class WunderlistItemViewModel
    {
        public WunderListItem WudnerListItem { get; set; }

        public List<WunderTask> WunderTasks { get; set; }
    }
}