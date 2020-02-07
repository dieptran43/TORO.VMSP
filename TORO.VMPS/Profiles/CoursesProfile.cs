using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TORO.VMPS.DAL;
using TORO.VMPS.DAL.Entities;
using TORO.VMPS.Models;

namespace TORO.VMPS.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CourseDto>();
            CreateMap<Models.CourseForCreationDto, Course>();
            CreateMap<Models.CourseForUpdateDto, Course>();
            CreateMap<Course, Models.CourseForUpdateDto>();
        }
    }
}
