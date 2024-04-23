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
    public class SaleDetailProfile : Profile
    {
        public SaleDetailProfile()
        {
            CreateMap<SaleDetails, SaleDetailDTO>()
                .ForMember(x => x.SaleType, opt => opt.MapFrom(x => x.Sales.SaleTypes.SaleTypeName))
                .ForMember(x => x.SaleName, opt => opt.MapFrom(x => x.Sales.SaleName))
                .ForMember(x => x.TimeStart, opt => opt.MapFrom(x => x.Sales.TimeStart))
                .ForMember(x => x.TimeEnd, opt => opt.MapFrom(x => x.Sales.TimeEnd));
        }
    }
}
