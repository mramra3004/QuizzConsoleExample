using System;
using ProductManagement.ConsoleApplication.Data.Enum;

namespace ProductManagement.ConsoleApplication.Application.ViewModel
{
    public class ChapterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}