using RetailShopApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Domain.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public Task<AuthenticatedUser> Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
