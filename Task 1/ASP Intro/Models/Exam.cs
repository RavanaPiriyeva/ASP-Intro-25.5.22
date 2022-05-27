using System;

namespace ASP_Intro.Models
{
    public class Exam
    {
        public Exam(int id, string name, DateTime dateTime)
        {
            this.Id = id;
            this.ExamName = name;
            this.Date = dateTime;
            
        }
        public int Id { get; set; }
        public string ExamName { get; set; }
        public DateTime Date { get; set; }

    }
}
