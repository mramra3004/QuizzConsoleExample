using AutoMapper;
using ProductManagement.ConsoleApplication.Application.ViewModel;
using ProductManagement.ConsoleApplication.Data.Entities;

namespace ProductManagement.ConsoleApplication.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ChapterViewModel, Chapter>().ConstructUsing(c => new Chapter());
        }
    }
}