using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barcode_Taqeem.BusinessLayer;
using Barcode_Taqeem.BusinessLayer.Interface;

namespace Barcode_Taqeem.Web.Controllers
{
    public class TestController : Controller
    {
        //IEmployeeBusiness empBusiness;
        //public TestController(IEmployeeBusiness _empBusiness)
        //{
        //    empBusiness = _empBusiness;
        //}

        //public IActionResult Index()
        //{
        //    //IEmployeeBusiness empBusiness = new EmployeeBusiness();

        //    ViewBag.empname= empBusiness.GetEmployeeName(1);

        //   var listEmp= empBusiness.GetAllEmployees();

        //    return View(listEmp);
        //}

        // login
         
        public IActionResult Login()
        {
            

            return View( );
        }

        [HttpPost]
        public IActionResult Login(string username, String Password)
        {


            return View();
        }

        // forget password
        public IActionResult ChangePassword(string OldPassword, String Password)
        {


            return View();
        }

    }
}
