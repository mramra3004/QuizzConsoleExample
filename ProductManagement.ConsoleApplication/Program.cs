using System;
using System.Linq;
using System.Text;
using AutoMapper;
using ProductManagement.ConsoleApplication.Application.AutoMapper;
using ProductManagement.ConsoleApplication.Application.Service.Chapters;
using ProductManagement.ConsoleApplication.Application.ViewModel;
using ProductManagement.ConsoleApplication.Data.EF;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Infrastructure.Interfaces;

namespace ProductManagement.ConsoleApplication
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var context = new AppDbContext())
            {
//                DbInitializer dbInitializer = new DbInitializer(context);
//                dbInitializer.Seed().Wait();
                Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile<DomainToViewModelMappingProfile>();
                    cfg.AddProfile<ViewModelToDomainMappingProfile>();
                });
                IRepository<Chapter, int> chapterRepository = new EFRepository<Chapter, int>(context);
                IUnitOfWork unitOfWork = new EFUnitOfWork(context);
                IChapterService chapterService = new ChapterService(chapterRepository, unitOfWork);
                var chapterViewModel = chapterService.GetAll();
                foreach (var item in chapterViewModel)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("------------------------------");
                var productViewModelPaging = chapterService.GetAllPaging("C", 3, 4);
                foreach (var item in productViewModelPaging.Results.OrderBy(x => x.Name))
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("------------------------------");
//                ChapterViewModel chapterViewModelTest = new ChapterViewModel() {Name = "Test"};
//                var test = chapterService.Add(chapterViewModelTest);
//                chapterService.SaveChanges();
//                Console.WriteLine(test.Name + " " + test.Id);
                Console.WriteLine("------------------------------");
                ChapterViewModel chapterViewModelTestUpdate = new ChapterViewModel()
                {
                    Id = 11,
                    Name = "TestUpdate"
                };
                chapterService.Update(chapterViewModelTestUpdate);
                chapterService.SaveChanges();
                foreach (var item in chapterService.GetAll())
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine(chapterService.GetById(11).Name);
                Console.WriteLine("------------------------------");
//                ChapterViewModel chapterViewModelTest = new ChapterViewModel() {Name = "Test1"};
//                var test = chapterService.Add(chapterViewModelTest);
//                chapterService.SaveChanges();
                Console.WriteLine("------------------------------");
//                chapterService.Delete(12);
//                chapterService.SaveChanges();
                foreach (var item in chapterService.GetAll())
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}