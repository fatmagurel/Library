using Library.Application.Common.Repositories;
using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.PostgreSQL.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly LibraryContext _libraryContext;
        public BookRepository(LibraryContext libraryContext) : base (libraryContext)
        {
            _libraryContext = libraryContext;

        }
    }
}
