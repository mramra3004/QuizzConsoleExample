using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Data.Enum;

namespace ProductManagement.ConsoleApplication.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _appDbContext;

        public DbInitializer(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Seed()
        {
            if (!_appDbContext.Chapters.Any())
            {
                List<Chapter> listChapter = new List<Chapter>();
                for (int i = 1; i <= 10; i++)
                {
                    Chapter chapter = new Chapter() {Name = "Chapter" + i, Status = Status.Active};
                    listChapter.Add(chapter);
                }

                _appDbContext.Chapters.AddRange(listChapter);
            }

            if (!_appDbContext.Subjects.Any())
            {
                List<Subject> listSubject = new List<Subject>()
                {
                    new Subject() {Name = "Mạng máy tính"},
                    new Subject() {Name = "Thông tin di động"},
                    new Subject() {Name = "Thông tin vô tuyến"},
                    new Subject() {Name = "Lập trình nâng cao"},
                    new Subject() {Name = "Cơ sở truyền số liệu"}
                };
                _appDbContext.Subjects.AddRange(listSubject);
            }

            if (!_appDbContext.SubjectChapterDetails.Any())
            {
                List<SubjectChapterDetail> listSubjectChapterDetails = new List<SubjectChapterDetail>();
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        SubjectChapterDetail subjectChapterDetail = new SubjectChapterDetail()
                            {SubjectId = i, ChapterId = j};
                        listSubjectChapterDetails.Add(subjectChapterDetail);
                    }
                }

                _appDbContext.SubjectChapterDetails.AddRange(listSubjectChapterDetails);
            }

            await this._appDbContext.SaveChangesAsync();
        }
    }
}