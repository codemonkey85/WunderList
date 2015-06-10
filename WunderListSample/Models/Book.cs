using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WunderListSample.Models
{
    public class Book
    {
        [Key,DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string BookName { get; set; }

        public string BookTaskId { get; set; }

        public bool IsCompleted { get; set; }

        public string BookConverUrl { get; set; }
       
        public DateTime? Create_Begin { get; set; }

        public DateTime? Create_End { get; set; }

    }
}