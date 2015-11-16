using AutoMapper;
using PersonnelDirectory.Web2.Models.ViewModels;

namespace PersonnelDirectory.Web2.Models
{
    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Core.Person, Person>();
            Mapper.CreateMap<Person, Core.Person>();
        }
    }
}