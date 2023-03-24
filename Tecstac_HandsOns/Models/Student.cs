using System;

namespace Tecstac_HandsOns.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string Department { get; set; }
        public long PhoneNumber { get; set; }
    }
}