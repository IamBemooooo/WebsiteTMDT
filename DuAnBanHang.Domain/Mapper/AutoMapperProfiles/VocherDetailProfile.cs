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
    public class VocherDetailProfile : Profile
    {
        public VocherDetailProfile()
        {
            CreateMap<VoucherDetails, VocherDetailDTO>()
                .ForMember(x => x.VocherType, opt => opt.MapFrom(x => x.Vouchers.VoucherTypes.VocherTypeName))
                .ForMember(x => x.VocherName, opt => opt.MapFrom(x => x.Vouchers.VocherName))
                .ForMember(x => x.TimeStart, opt => opt.MapFrom(x => x.Vouchers.TimeStart))
                .ForMember(x => x.TimeEnd, opt => opt.MapFrom(x => x.Vouchers.TimeEnd))
                .ForMember(x => x.NameProduct, opt => opt.MapFrom(x => x.Products.NameProduct));
        }
    }
}
