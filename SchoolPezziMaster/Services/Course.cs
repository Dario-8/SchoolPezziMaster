using System.Collections.Generic;

namespace SchoolPezziMaster.Services
{
    public class Course
    {
        public int Id { get; set; }
        public List<Student> Students { get; set; }
    }
}
