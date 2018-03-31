using AutoMapper;
using UMC.Model.Models;
using UMC.WApp.Models;

namespace TeduShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Shift, ShiftViewModel>();
            });
        }
    }
}