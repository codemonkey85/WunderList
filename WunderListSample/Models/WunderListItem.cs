using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{
    public class WunderListItem
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public string Owner_Type { get; set; }

        public string Owner_Id { get; set; }

        public string List_Type { get; set; }

        public WunderListType List_Type { get; set; }

        public string Revision { get; set; }

        public string Created_At{ get; set; }

    }
}