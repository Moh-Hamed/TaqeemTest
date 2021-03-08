using Barcode_Taqeem.DL_DomainLayer_;
using System;
using System.Collections.Generic;
using System.Text;
//using Barcode_Taqeem.
namespace Barcode_Taqeem.BusinessLayer.Interface
{
    public interface IEmployeeBusiness
    {
        List<EmployeeDmainModel> GetAllEmployees();
        string GetEmployeeName(int Id);

    }
}
