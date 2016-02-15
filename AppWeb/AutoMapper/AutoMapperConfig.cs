using AutoMapper;

namespace AppWeb.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<Metier_Mvc>();
                x.AddProfile<Mvc_Metier>();
            });
        }

    }
}