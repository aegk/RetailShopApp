using MediatR;
using RetailShopApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Application.Commands
{
    public class LoginCommand : IRequest<AuthenticatedUser>
    {
    }
}
