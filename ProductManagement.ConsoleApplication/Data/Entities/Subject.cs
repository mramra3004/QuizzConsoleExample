using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ProductManagement.ConsoleApplication.Data.Enum;
using ProductManagement.ConsoleApplication.Data.Interfaces;
using ProductManagement.ConsoleApplication.Infrastructure.SharedKernel;

namespace ProductManagement.ConsoleApplication.Data.Entities
{
    [Table("Subjects")]
    public class Subject : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<SubjectChapterDetail> SubjectChapterDetails { set; get; }
    }
}