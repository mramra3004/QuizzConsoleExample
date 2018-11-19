using System;
using System.ComponentModel.DataAnnotations.Schema;
using ProductManagement.ConsoleApplication.Data.Enum;
using ProductManagement.ConsoleApplication.Data.Interfaces;
using ProductManagement.ConsoleApplication.Infrastructure.SharedKernel;

namespace ProductManagement.ConsoleApplication.Data.Entities
{
    [Table("Exams")]
    public class Exam : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string ExamName { get; set; }
        public int Time { get; set; }
        public string Examiner { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}