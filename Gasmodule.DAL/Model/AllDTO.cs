using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasmodule.DAL.Model
{
    [AttributeUsage(AttributeTargets.Property,
                Inherited = false,
                AllowMultiple = false)]
    internal sealed class OptionalAttribute : Attribute
    {
    }

        public partial class CompanyUser
        {
            [Key]
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Mobile { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int RoleId { get; set; }
            public DateTime CreatedOn { get; set; }
            public int CreatedBy { get; set; }
            public bool IsActive { get; set; }
            public bool IsDeleted { get; set; }
            public int loginCount { get; set; }

        }
           
        public class BusinessInfo
        {
      
            public int ID { get; set; }
            public int UserId { get; set; }
            public string LegalName { get; set; }
            public string BusinessName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string FaxNumber { get; set; }
            public string Email { get; set; }
            public string TaxID { get; set; }
            public string DateINCFormed { get; set; }
            public int CreatedBy { get; set; }
            public DateTime CreatedOn { get; set; }
            public int ModifiedBy { get; set; }
            public DateTime ModifiedOn { get; set; }
            public bool Active { get; set; }
            public bool IsDeleted { get; set; }
        }
        public partial class EmployeeDTO
        {

        }
        public partial class LicenseInfo
        {
        public int Id { get; set; }
        public string LicenseName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime ExpiresOn { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }

        public DateTime ModifiedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
    
    
 }
