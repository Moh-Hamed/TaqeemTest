using Barcode_Taqeem.BusinessLayer.Interface;
using Barcode_Taqeem.DAL_Data_Access_Layer_.Models;
using Barcode_Taqeem.DL_DomainLayer_;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Barcode_Taqeem.BusinessLayer
{
   public class EmployeeBusiness : IEmployeeBusiness
    {
        TaqeemDBTestContext db=new TaqeemDBTestContext();

        //public EmployeeBusiness(TaqeemDBTestContext _db)
        //{
        //    db = _db;
        //}
        public List<EmployeeDmainModel> GetAllEmployees()
        {
            // Define List here 
            //List<EmployeeDmainModel> list = new List<EmployeeDmainModel>();

            List<EmployeeDmainModel> list = db.Employees.Select(emp => new EmployeeDmainModel() 
            { Id = emp.Id, Name = emp.Name, Address = emp.Address,Phone=emp.Phone}).ToList();

            //list.Add(new EmployeeDmainModel() {Id=1,Name="Ahmed",Address="MNF"});
            //list.Add(new EmployeeDmainModel() {Id=2,Name="Zain",Address="MNF"});
            //list.Add(new EmployeeDmainModel() {Id=3,Name="farida",Address="MNF" });

            return list ;
         }

        public string GetEmployeeName(int Id)
        {
            return "Mido" + Id;
        }

    }
}
