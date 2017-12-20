using AutoMapper;
using CafeTNT_Management.Models;
using CafeTNT_Management.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeTNT_Management
{
    public static class AutoMapper
    {
        public static void CreatMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserMasterDTO, UserMaster>();
            }); 
        }
        
    }
}