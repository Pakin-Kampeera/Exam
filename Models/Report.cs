using System;
namespace Exam.Models
{
    public class Report : IReport
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Owner { get; set; }
    }
}

