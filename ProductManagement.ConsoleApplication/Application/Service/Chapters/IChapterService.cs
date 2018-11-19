using System.Collections.Generic;
using ProductManagement.ConsoleApplication.Application.ViewModel;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Utilities.Paging;

namespace ProductManagement.ConsoleApplication.Application.Service.Chapters
{
    public interface IChapterService
    {
        List<ChapterViewModel> GetAll();
        PagedResult<ChapterViewModel> GetAllPaging(string keyword, int page, int pageSize);
        ChapterViewModel Add(ChapterViewModel chapterViewModel);
        void Update(ChapterViewModel chapterViewModel);
        void Delete(int id);
        ChapterViewModel GetById(int id);
        void SaveChanges();
    }
}