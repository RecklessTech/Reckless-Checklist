using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecklessCheckList.Models
{
    public class TaskResponse
    {
        public TaskResponse() { }

        public Boolean Completed { get; set; }

        public String OldStatus { get; set; }

        public String NewStatus { get; set; }
    }
}