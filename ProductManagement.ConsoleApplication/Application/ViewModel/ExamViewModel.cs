using System;
using ProductManagement.ConsoleApplication.Data.Enum;

namespace ProductManagement.ConsoleApplication.Application.ViewModel
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        public string ExamName { get; set; }
        public int Time { get; set; }
        public string Examiner { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}