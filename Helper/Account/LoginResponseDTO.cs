using LifeworthAPI.Helper;
using System;
namespace LifewortAPI.DTO.Account
{
    public class LoginResponseDTO : Response
    {
        public LoginResponseDTO()
        {
        }

        public string token { get; set; }
        public string EmployeeNo { get; set; }
        public int id { get; set; }
        public string Gender { get; set; }
        public string Policy { get; set; }
        public string Name { get; set; }

        public string FullName { get; set; }
        public string image { get; set; }

        

        public string ID_Product { get; set; }
       // public object DateOfBrith { get; internal set; }
    }
}
