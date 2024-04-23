using AutoMapper;
using DuAnBanHang.Domain.DTO;
using DuAnBanHang.Domain.Models;

namespace DuAnBanHang.Domain.Mapper.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Users, UserDTO>()
                .ForMember(x => x.RoleName, opt => opt.MapFrom(des => des.Roles.RoleName));
        }
    }
}
