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
    public class BillDetailProfile : Profile
    {
        public BillDetailProfile()
        {
            CreateMap<BillDetails, BillDetailDTO>()
                .ForMember(x => x.BillCode, opt => opt.MapFrom(x => x.Bills.Id))
                .ForMember(x => x.CustomerName, opt => opt.MapFrom(x => x.Bills.Users.FullName))
                .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.Products.NameProduct))
                .ForMember(x => x.price, opt => opt.MapFrom(x => x.Products.Price))
                .ForMember(x => x.VocherName, opt => opt.MapFrom(x => x.Bills.Vouchers.Select(x => x.VocherName).FirstOrDefault()));

        }
    }
}
