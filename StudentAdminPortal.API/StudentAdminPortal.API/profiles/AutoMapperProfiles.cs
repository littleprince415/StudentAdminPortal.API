﻿using AutoMapper;
using StudentAdminPortal.API.Domain_Models;
using DataModels = StudentAdminPortal.API.DataModels;


namespace StudentAdminPortal.API.profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, 
                Student>().ReverseMap();
            CreateMap<DataModels.Gender, 
                Gender>().ReverseMap();
            CreateMap<DataModels.Address, 
                Address>().ReverseMap();        

        }
    }
}
