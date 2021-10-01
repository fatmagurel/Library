using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int BookId { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
