using AutoMapper;
using Barcode_Taqeem.DL_DomainLayer_;
using Barcode_Taqeem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barcode_Taqeem.Web.Infrastructure
{
    public class AutomapperWebProfile:Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<EmployeeDmainModel, EmployeeViewModel>() ;

            // Reverse Engineering 
           //CreateMap<EmployeeViewModel, EmployeeDmainModel>();
        }

        //public static void Run()
        //{
        //    AutoMapper.Mapper.Initialize();
        //}
    }
}
