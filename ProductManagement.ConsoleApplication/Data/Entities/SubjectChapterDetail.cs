using System.ComponentModel.DataAnnotations.Schema;
using ProductManagement.ConsoleApplication.Infrastructure.SharedKernel;

namespace ProductManagement.ConsoleApplication.Data.Entities
{
    [Table("SubjectChapterDetails")]
    public class SubjectChapterDetail : DomainEntity<int>
    {
        public int SubjectId { get; set; }

        public int ChapterId { get; set; }

        [ForeignKey("SubjectId")] public virtual Subject Subject { get; set; }
        [ForeignKey("ChapterId")] public virtual Chapter Chapter { get; set; }
    }
}