using SQLite;
using System;

namespace SchoolFeesManager.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string StudentKey { get; set; } // Unique Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public string AcademicYear { get; set; }
        
        // Contact
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
        // Parent
        public string ParentName { get; set; }
        public string ParentPhone { get; set; }
        
        // Status
        public bool IsActive { get; set; } = true;

        [Ignore]
        public string FullName => $"{FirstName} {LastName}";
    }
}
