using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
    }
}