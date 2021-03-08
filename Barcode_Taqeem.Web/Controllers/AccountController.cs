using AutoMapper;
using Barcode_Taqeem.BusinessLayer;
using Barcode_Taqeem.BusinessLayer.Interface;
using Barcode_Taqeem.DL_DomainLayer_;
using Barcode_Taqeem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barcode_Taqeem.Web.Controllers
{
    public class AccountController : Controller
    {
        //IEmployeeBusiness empBusiness;
        //public AccountController(IEmployeeBusiness _empBusiness)
        //{
        //    empBusiness = _empBusiness;
        //}
        private readonly IMapper mapper;
        public AccountController(IMapper _mapper)
        {
            mapper = _mapper;
        }

        public IActionResult Index()
        {
            IEmployeeBusiness empBusiness = new EmployeeBusiness();

            ViewBag.empname = empBusiness.GetEmployeeName(1);

            var listEmp = empBusiness.GetAllEmployees();

            var empvm = mapper.Map<EmployeeViewModel>(listEmp);

            return View(empvm);
        }

        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, String Password)
        {


            return View();
        }

        // Change password
        [HttpGet]
        public IActionResult ChangePassword( )
        {


            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(string OldPassword, String NewPassword1, String NewPassword2)
        {


            return View();
        }

        // refisteration 
    }
}
