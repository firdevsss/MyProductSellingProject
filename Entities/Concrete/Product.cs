using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }

    }
}
