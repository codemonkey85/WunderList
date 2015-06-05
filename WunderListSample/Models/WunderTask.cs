﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{
    public class WunderTask
    {
        public string Id { get; set; }
        public DateTime CreateAt { get; set; }
        //Refer to ListItem Id
        public string ListId { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

    }
}