using System.Collections.Generic;

namespace Tecstac_HandsOns.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseId { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
    }
    public class Department
    {
        public List<string> CourseList { get; set; }
    }
}