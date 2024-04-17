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
    public class BillProfile : Profile
    {
        public BillProfile()
        {
            CreateMap<Bills, BillDTO>()
                .ForMember(x => x.BillCode, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.CustomerName, opt => opt.MapFrom(x => x.Users.FullName));
        }
    }
}
