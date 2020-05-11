using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MobTasks.Domain
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completed {get;set;}

        public Course Course{ get; set; }

        public int CourseId { get; set; }
    }
}
