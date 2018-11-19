using System;
using System.Collections.Generic;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Data.Enum;

namespace ProductManagement.ConsoleApplication.Application.ViewModel
{
    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public ICollection<SubjectChapterDetail> SubjectChapterDetails { set; get; }
    }
}