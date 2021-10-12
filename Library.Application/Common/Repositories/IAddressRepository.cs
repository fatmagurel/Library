using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Common.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        public  IAddressQueryRepository Query { get; }
        public IAddressCommandRepository Command { get; }


    }

    public interface IAddressCommandRepository
    {
    }

    public interface IAddressQueryRepository
    {
    }

   
}
