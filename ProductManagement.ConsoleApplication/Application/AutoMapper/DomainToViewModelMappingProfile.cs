using AutoMapper;
using ProductManagement.ConsoleApplication.Application.ViewModel;
using ProductManagement.ConsoleApplication.Data.Entities;

namespace ProductManagement.ConsoleApplication.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Subject, SubjectViewModel>();
            CreateMap<Chapter, ChapterViewModel>();
        }
    }
}