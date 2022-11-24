using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookReadingEventManagement2.Models
{
    public class CommentViewModel
    {
        public int CommentID { get; set; }
        public int EventID { get; set; }
        public string UserFullName { get; set; }
        public int UserID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Data { get; set; }
    }
}