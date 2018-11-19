using System;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Data.Enum;

namespace ProductManagement.ConsoleApplication.Application.ViewModel
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
        public int ScoreQuestion { get; set; }
        public int ExamId { get; set; }
        public int SubjectChapterDetailId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public SubjectChapterDetail SubjectChapterDetail { get; set; }
        public Exam Exam { get; set; }
    }
}