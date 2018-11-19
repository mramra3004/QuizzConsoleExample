using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ProductManagement.ConsoleApplication.Application.Service.Chapters;
using ProductManagement.ConsoleApplication.Application.ViewModel;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Infrastructure.Interfaces;
using ProductManagement.ConsoleApplication.Utilities.Paging;

namespace ProductManagement.ConsoleApplication.Application.Service.Chapters
{
    public class ChapterService : IChapterService
    {
        private IRepository<Chapter, int> _chapterRepository;
        private IUnitOfWork _unitOfWork;

        public ChapterService(IRepository<Chapter, int> chapterRepository, IUnitOfWork unitOfWork)
        {
            _chapterRepository = chapterRepository;
            _unitOfWork = unitOfWork;
        }

        public List<ChapterViewModel> GetAll()
        {
            return _chapterRepository.FindAll().ProjectTo<ChapterViewModel>().ToList();
        }

        public PagedResult<ChapterViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _chapterRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            var paginationSet = new PagedResult<ChapterViewModel>()
            {
                Results = data.ProjectTo<ChapterViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public ChapterViewModel Add(ChapterViewModel chapterViewModel)
        {
            var chapter = Mapper.Map<ChapterViewModel, Chapter>(chapterViewModel);
            _chapterRepository.Add(chapter);
            return chapterViewModel;
        }

        public void Update(ChapterViewModel chapterViewModel)
        {
            var chapter = Mapper.Map<ChapterViewModel, Chapter>(chapterViewModel);
            _chapterRepository.Update(chapter);
        }

        public void Delete(int id)
        {
            _chapterRepository.Remove(id);
        }

        public ChapterViewModel GetById(int id)
        {
            return Mapper.Map<Chapter, ChapterViewModel>(_chapterRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}