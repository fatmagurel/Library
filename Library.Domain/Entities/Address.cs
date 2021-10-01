using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string District { get; set; }
        public string FullAddress { get; set; }
        public virtual Person Person { get; set; }

    }
}
