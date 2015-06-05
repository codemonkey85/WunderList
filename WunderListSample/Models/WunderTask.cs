using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{
    public class WunderTask
    {
        public string Id { get; set; }
        public string CreateDateTime { get; set; }

        //Refer to ListItem Id
        public string ListId { get; set; }

        public string Title { get; set; }
    }
}