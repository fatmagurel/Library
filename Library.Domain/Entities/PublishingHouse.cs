using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class PublishingHouse : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}
