using System;
using System.ComponentModel.DataAnnotations;

namespace LifeworthAPI.DTO.Account
{
    public class ResetPasswordRequestDTO
    {
        public ResetPasswordRequestDTO()
        {
        }
        [Required]
        public string EmployeeNo { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string PhoneNo { get; set; }
    }

    public class LoginRequestDTO
    {
        [Required]
        public string employeeNo { get; set; }
        [Required]
        public string PhoneNo { get; set; }
    }

    public class RequestToken
    {
        [Required]
        public string EmployeeNo { get; set; }
    }
}
