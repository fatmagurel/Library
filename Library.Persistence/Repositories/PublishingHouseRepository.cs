using Library.Application.Common.Repositories;
using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Repositories
{
    public class PublishingHouseRepository : BaseRepository<PublishingHouse>, IPublishingHouseRepository
    {
        private readonly LibraryContext _libraryContext;
        public PublishingHouseRepository(LibraryContext libraryContext) : base(libraryContext)
        {
            _libraryContext = libraryContext;

        }
    }
}