using AutoMapper;

namespace PersonnelDirectory.Web.Models
{
    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Core.Person, ViewModels.Person>();
            Mapper.CreateMap<ViewModels.Person, Core.Person>();
        }
    }
}