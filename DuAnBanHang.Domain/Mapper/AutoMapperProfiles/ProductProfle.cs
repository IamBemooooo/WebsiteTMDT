using AutoMapper;
using DuAnBanHang.Domain.DTO;
using DuAnBanHang.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnBanHang.Domain.Mapper.AutoMapperProfiles
{
    public class ProductProfle : Profile
    {
        public ProductProfle()
        {
            CreateMap<Products, ProductDTO>()
           .ForMember(des => des.NameType, opt => opt.MapFrom(src => src.ProductTypes.ProductsTypeName));
            ;
        }
    }
}
