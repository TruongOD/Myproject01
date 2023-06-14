using AutoMapper;

namespace Myproject01.Infrastructure.Dependencies
{
    public class AutoMapperInitiator
    {
        public static void Register(IServiceCollection service)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });

            var mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
