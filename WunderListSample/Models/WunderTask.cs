using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{

    public class WunderTask
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int  ID { get; set; }
        public DateTime CreateAt { get; set; }
        //Refer to ListItem Id
        public string ListId { get; set; }

        public string TaskId { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

    }
}