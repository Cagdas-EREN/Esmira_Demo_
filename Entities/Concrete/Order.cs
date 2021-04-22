using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int RepresentativeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }


    }
}
