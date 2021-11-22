using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já está cadastrado
            //Valida os dados
            //Insere o cliente
            //envia email de boas vindas
            var result = new CreateCustomerResponse{
                Id = Guid.NewGuid(),
                Name = "Jonas dos Santos",
                Email = "email@email.com.br",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}