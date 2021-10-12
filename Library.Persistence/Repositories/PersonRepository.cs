using Library.Application.Common.Repositories;
using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.PostgreSQL.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        private readonly LibraryContext _libraryContext;
        public PersonRepository(LibraryContext libraryContext) : base(libraryContext)
        {
            _libraryContext = libraryContext;

        }
    }
}
