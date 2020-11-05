using System;
namespace Exam.Models
{
    public interface IReport
    {
        int Id { get; set; }
        string Title { get; set; }
        string Status { get; set; }
        string Priority { get; set; }
        string Description { get; set; }
        DateTime TimeStamp { get; set; }
        string Owner { get; set; }
    }
}

