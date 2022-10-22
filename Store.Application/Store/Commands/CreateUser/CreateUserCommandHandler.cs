using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Store.Domain;
using BCrypt;
using Store.Application.Interfaces;

namespace Store.Application.Store.Commands.CreateUser
{
    public class CreateUserCommandHandler
        :IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IStoreDbContext _dbContext;

        public CreateUserCommandHandler(IStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateUserCommand request,CancellationToken cancellationToken)
        {

            var user = new User
            {
                UserId = Guid.NewGuid(),
                Username = request.Username,
                Email = request.Email, 
                Name = request.Name,
                LastName = request.LastName,
                HashPassord = BCrypt.Net.BCrypt.EnhancedHashPassword(request.Password)
            };

            await _dbContext.User.AddAsync(user, cancellationToken)

            return user.UserId;
        }


    }
}
