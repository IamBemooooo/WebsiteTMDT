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
    public class CartDetailProfile : Profile
    {
        public CartDetailProfile()
        {
            CreateMap<CartDetails, CartDetailDTO>()
                .ForMember(x => x.price, otp => otp.MapFrom(x => x.Products.Price))
                .ForMember(x => x.image, otp => otp.MapFrom(x => x.Products.Images))
                .ForMember(x => x.productName, otp => otp.MapFrom(x => x.Products.NameProduct));

        }
    }
}
