using System;
using System.Collections.Generic;
using System.Text;

namespace MobTasks.Domain
{
    public class Course
    {
        public Course()
        {
            Members = new List<Member>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Member> Members { get; set; }

        public List<Task> Tasks{ get; set; }

    }
}
