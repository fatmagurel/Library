using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int Category { get; set; }
        public int PageCount { get; set; }
        public virtual Person Person { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual ICollection<PublishingHouse> PublishingHouses { get; set; }
    }
}
