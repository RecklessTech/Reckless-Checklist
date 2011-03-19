using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecklessCheckList.Models
{
    public class Task
    {
        public Task() { }

        public Int32 Id { get; set; }

        public String Name { get; set; }

        public String Value { get; set; }
    }
}