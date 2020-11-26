using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GasModuleApi.Controllers;
using Gasmodule.BLL.Interface;
//using System.Web.Http;

namespace GasModule.Test
{
    [TestClass]
   public class AdminControllerTest
    {
        private ICompany company;

        public void AddComapanyuser()
        {
            //users users = new users();

            //AdminController controller = new AdminController(company);

            //var result = controller.AddCompanyUser(users);

        }
        public class users
        {
            public int UserId { get; set; }
        }
    }
}
