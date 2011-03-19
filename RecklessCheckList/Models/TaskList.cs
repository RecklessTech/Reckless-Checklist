using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecklessCheckList.Models
{
    public class TaskList
    {
        public TaskList() { }

        public List<Task> Tasks { get; set; }
    }
}