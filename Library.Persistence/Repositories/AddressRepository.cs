using Library.Application.Common.Repositories;
using Library.Domain.Entities;
using Library.Persistence.PostgreSQL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.PostgreSQL.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly LibraryContext _libraryContext;
        public AddressRepository(LibraryContext libraryContext) : base(libraryContext)
        {
            _libraryContext = libraryContext;

        }
    }
}