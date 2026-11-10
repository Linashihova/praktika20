using System;

namespace ReportGeneration_Shihova.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdGroup { get; set; }
        public bool Expelled { get; set; }
        public DateTime DateExpelled { get; set; }
        public Student(int Id, string FirstName, string LastName, int IdGroup, bool Expelled, DateTime DateExpelled)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IdGroup = IdGroup;
            this.Expelled = Expelled;
            this.DateExpelled = DateExpelled;
        }
    }
}
