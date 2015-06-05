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

        public string OwnerType { get; set; }

        public string OwnerId { get; set; }

        public WunderListType ListType { get; set; }

        public string Revision { get; set; }

        public DateTime CreatedAt{ get; set; }

    }
}