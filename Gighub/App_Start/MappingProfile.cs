using AutoMapper;
using Gighub.Dtos;
using Gighub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gighub.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
        }
    }
}