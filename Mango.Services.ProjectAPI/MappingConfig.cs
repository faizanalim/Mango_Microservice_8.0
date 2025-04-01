using AutoMapper;
using Mango.Services.ProjectAPI.Models;
using Mango.Services.ProjectAPI.Models.Dto;

namespace Mango.Services.ProjectAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
