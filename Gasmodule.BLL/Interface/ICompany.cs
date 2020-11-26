using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gasmodule.BLL.ViewModels;
namespace Gasmodule.BLL.Interface
{
    public interface ICompany
    {
        int AddUser(AllDTO.CompanyModel companyuser);
    }
}
