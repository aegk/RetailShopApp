using MediatR;
using RetailShopApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShopApp.Application.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthenticatedUser>
    {
        public Task<AuthenticatedUser> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
