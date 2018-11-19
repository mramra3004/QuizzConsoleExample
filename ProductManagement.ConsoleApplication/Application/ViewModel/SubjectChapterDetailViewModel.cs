using ProductManagement.ConsoleApplication.Data.Entities;

namespace ProductManagement.ConsoleApplication.Application.ViewModel
{
    public class SubjectChapterDetailViewModel
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int ChapterId { get; set; }
        public Subject Subject { get; set; }
        public Chapter Chapter { get; set; }
    }
}