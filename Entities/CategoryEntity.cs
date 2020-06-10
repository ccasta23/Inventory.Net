using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        [StringLength(10)]
        public string CategoryId { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }

        public ICollection<ProductEntity> Products;
    }
}
