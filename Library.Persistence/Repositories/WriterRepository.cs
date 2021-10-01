using Library.Application.Common.Repositories;
using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Repositories
{
    public class WriterRepository : BaseRepository<Writer>, IWriterRepository
    {
        private readonly LibraryContext _libraryContext;
        public WriterRepository(LibraryContext libraryContext) : base(libraryContext)
        {
            _libraryContext = libraryContext;

        }
    }
}