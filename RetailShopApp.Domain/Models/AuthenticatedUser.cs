using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Domain.Models
{
    public class AuthenticatedUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public int CustomerType { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Secret { get; set; }
         
    }
}
