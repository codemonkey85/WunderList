using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{
    public class WunderListSubTask
    {
        public string Id { get; set; }
        public string TaskId { get; set; }
        public bool IsCompleted { get; set; }
        public string Title { get; set; }
    }
}